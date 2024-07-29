// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Azure.AI.OpenAI;

using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Plugins.Utils;
using CopilotChat.WebApi.Storage;

using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

using CopilotChatMessage = CopilotChat.WebApi.Models.Storage.CopilotChatMessage;

namespace CopilotChat.WebApi.Plugins.Chat;

#pragma warning disable SKEXP0070
#pragma warning disable SKEXP0010

/// <summary>
///     ChatPlugin offers a more coherent chat experience by using memories
///     to extract conversation history and user intentions.
/// </summary>
public sealed class ChatPlugin(
	Kernel kernel,
	IKernelMemory memoryClient,
	ChatMessageRepository chatMessageRepository,
	ChatSessionRepository chatSessionRepository,
	IHubContext<MessageRelayHub> messageRelayHubContext,
	IOptions<PromptsOptions> promptOptions,
	ILogger logger)
{
	/// <summary>
	/// Tags used for Langfuse metadata in chat requests.
	/// </summary>
	private static readonly string[] s_langFuseTags = ["AI Empower Labs", "Copilot"];
	private static readonly string[] s_langFuseTagsWithIntent = [..s_langFuseTags, "Intent"];

	/// <summary>
	///     Settings containing prompt texts.
	/// </summary>
	private readonly PromptsOptions _promptOptions = promptOptions.Value.Copy();

	/// <summary>
	///     A kernel memory retriever instance to query semantic memories.
	/// </summary>
	private readonly SemanticMemoryRetriever _semanticMemoryRetriever = new(promptOptions, chatSessionRepository, memoryClient);

	/// <summary>
	///     Method that wraps GetAllowedChatHistoryAsync to get allotted history messages as one string.
	///     GetAllowedChatHistoryAsync optionally updates a ChatHistory object with the allotted messages,
	///     but the ChatHistory type is not supported when calling from a rendered prompt, so this wrapper bypasses the
	///     chatHistory parameter.
	/// </summary>
	/// <param name="tokenLimit"></param>
	/// <param name="chatId"></param>
	[KernelFunction]
	[Description("Extract chat history")]
	public Task<string> ExtractChatHistory(
		[Description("Chat ID to extract history from")]
		string chatId,
		[Description("Maximum number of tokens")]
		int tokenLimit)
	{
		return GetAllowedChatHistory(chatId, tokenLimit);
	}

	/// <summary>
	///     Extract chat history within token limit as a formatted string and optionally update the ChatHistory object with the
	///     allotted messages
	/// </summary>
	/// <param name="chatId">Chat ID to extract history from.</param>
	/// <param name="tokenLimit">Maximum number of tokens.</param>
	/// <param name="chatHistory">Optional ChatHistory object tracking allotted messages.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>Chat history as a string.</returns>
	private async Task<string> GetAllowedChatHistory(
		string chatId,
		int tokenLimit,
		ChatHistory? chatHistory = null,
		CancellationToken cancellationToken = default)
	{
		IAsyncEnumerable<CopilotChatMessage> sortedMessages = chatMessageRepository
			.FindByChatId(chatId, 0, 100, cancellationToken);

		ChatHistory allottedChatHistory = [];
		int remainingToken = tokenLimit;
		string historyText = string.Empty;

		await foreach (CopilotChatMessage chatMessage in sortedMessages)
		{
			string formattedMessage = chatMessage.ToFormattedString();

			if (chatMessage.Type == CopilotChatMessage.ChatMessageType.Document)
			{
				continue;
			}

			AuthorRole promptRole = chatMessage.AuthorRole == CopilotChatMessage.AuthorRoles.Bot
				? AuthorRole.System
				: AuthorRole.User;
			int tokenCount = chatHistory is not null
				? TokenUtils.GetContextMessageTokenCount(promptRole, formattedMessage)
				: TokenUtils.TokenCount(formattedMessage);

			if (remainingToken - tokenCount >= 0)
			{
				historyText = $"{formattedMessage}\n{historyText}";
				if (chatMessage.AuthorRole == CopilotChatMessage.AuthorRoles.Bot)
				{
					// Message doesn't have to be formatted for bot. This helps with asserting a natural language response from the LLM (no date or author preamble).
					allottedChatHistory.AddAssistantMessage(chatMessage.Content.Trim());
				}
				else
				{
					// Omit user name if Auth is disabled.
					string userMessage = PassThroughAuthenticationHandler.IsDefaultUser(chatMessage.UserId)
						? $"[{chatMessage.Timestamp.ToString("G", CultureInfo.CurrentCulture)}] {chatMessage.Content}"
						: formattedMessage;
					allottedChatHistory.AddUserMessage(userMessage.Trim());
				}

				remainingToken -= tokenCount;
			}
			else
			{
				break;
			}
		}

		chatHistory?.AddRange(allottedChatHistory.Reverse());

		return $"Chat history:\n{historyText.Trim()}";
	}

	/// <summary>
	///     This is the entry point for getting a chat response. It manages the token limit, saves
	///     messages to memory, and fills in the necessary context variables for completing the
	///     prompt that will be rendered by the template engine.
	/// </summary>
	/// <param name="context"></param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="message"></param>
	/// <param name="userId"></param>
	/// <param name="userName"></param>
	/// <param name="chatId"></param>
	/// <param name="messageType"></param>
	[KernelFunction]
	[Description("Get chat response")]
	public async Task<KernelArguments> Chat(
		[Description("The new message")] string message,
		[Description("Unique and persistent identifier for the user")]
		string userId,
		[Description("Name of the user")] string userName,
		[Description("Unique and persistent identifier for the chat")]
		string chatId,
		[Description("Type of the message")] string messageType,
		KernelArguments context,
		CancellationToken cancellationToken = default)
	{
		// Set the system description in the prompt options
		await SetSystemDescription(chatId, cancellationToken);

		// Save this new message to memory such that subsequent chat responses can use it
		await UpdateBotResponseStatusOnClient(chatId, "Saving user message to chat history",
			cancellationToken);
		CopilotChatMessage newUserMessage =
			await SaveNewMessage(message, userId, userName, chatId, messageType, cancellationToken);

		// Clone the context to avoid modifying the original context variables.
		KernelArguments chatContext = new(context);
		chatContext["knowledgeCutoff"] = _promptOptions.KnowledgeCutoffDate;

		CopilotChatMessage chatMessage =
			await GetChatResponse(chatId, userId, chatContext, newUserMessage, cancellationToken);
		context["input"] = chatMessage.Content;

		if (chatMessage.TokenUsage is not null)
		{
			context["tokenUsage"] = JsonSerializer.Serialize(chatMessage.TokenUsage);
		}
		else
		{
			logger.LogWarning(
				"ChatPlugin.ChatAsync token usage unknown. Ensure token management has been implemented correctly");
		}

		return context;
	}

	/// <summary>
	///     Generate the necessary chat context to create a prompt then invoke the model to get a response.
	/// </summary>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="chatContext">The KernelArguments.</param>
	/// <param name="userMessage">ChatMessage object representing new user message.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The created chat message containing the model-generated response.</returns>
	private async Task<CopilotChatMessage> GetChatResponse(
		string chatId,
		string userId,
		KernelArguments chatContext,
		CopilotChatMessage userMessage,
		CancellationToken cancellationToken)
	{
		// Render system instruction components and create the meta-prompt template
		string systemInstructions = await AsyncUtils.SafeInvokeAsync(
			() => RenderSystemInstructions(chatId, chatContext, cancellationToken),
			nameof(RenderSystemInstructions));
		ChatHistory metaPrompt = new(systemInstructions);

		// Bypass audience extraction if Auth is disabled
		string audience = string.Empty;
		if (!PassThroughAuthenticationHandler.IsDefaultUser(userId))
		{
			// Get the audience
			await UpdateBotResponseStatusOnClient(chatId, "Extracting audience", cancellationToken);
			audience = await AsyncUtils.SafeInvokeAsync(
				() => GetAudience(chatContext, chatId, userId, cancellationToken), nameof(GetAudience));
			metaPrompt.AddSystemMessage(audience);
		}

		// Extract user intent from the conversation history.
		await UpdateBotResponseStatusOnClient(chatId, "Extracting user intent", cancellationToken);
		string userIntent = await AsyncUtils.SafeInvokeAsync(
			() => GetUserIntent(chatContext, chatId, userId, cancellationToken), nameof(GetUserIntent));
		metaPrompt.AddSystemMessage(userIntent);

		// Calculate max amount of tokens to use for memories
		int maxRequestTokenBudget = GetMaxRequestTokenBudget();
		// Calculate tokens used so far: system instructions, audience extraction and user intent
		int tokensUsed = TokenUtils.GetContextMessagesTokenCount(metaPrompt);
		int chatMemoryTokenBudget = maxRequestTokenBudget
			- tokensUsed
			- TokenUtils.GetContextMessageTokenCount(AuthorRole.User,
				userMessage.ToFormattedString());
		chatMemoryTokenBudget = (int)(chatMemoryTokenBudget * _promptOptions.MemoriesResponseContextWeight);

		// Query relevant semantic and document memories
		await UpdateBotResponseStatusOnClient(chatId, "Extracting semantic and document memories",
			cancellationToken);
		(string memoryText, IDictionary<string, CitationSource> citationMap) =
			await _semanticMemoryRetriever.QueryMemories(userIntent, chatId, chatMemoryTokenBudget);
		if (!string.IsNullOrWhiteSpace(memoryText))
		{
			metaPrompt.AddSystemMessage(memoryText);
			tokensUsed += TokenUtils.GetContextMessageTokenCount(AuthorRole.System, memoryText);
		}

		// Add as many chat history messages to meta-prompt as the token budget will allow
		await UpdateBotResponseStatusOnClient(chatId, "Extracting chat history", cancellationToken);
		string allowedChatHistory = await GetAllowedChatHistory(chatId, maxRequestTokenBudget - tokensUsed, metaPrompt, cancellationToken);

		// Store token usage of prompt template
		chatContext[TokenUtils.GetFunctionKey("SystemMetaPrompt")] = TokenUtils.GetContextMessagesTokenCount(metaPrompt)
			.ToString(CultureInfo.CurrentCulture);

		// Stream the response to the client
		BotResponsePrompt promptView = new()
		{
			SystemPersona = systemInstructions,
			Audience = audience,
			UserIntent = userIntent,
			ChatMemories = memoryText,
			ChatHistory = allowedChatHistory,
			MetaPromptTemplate = metaPrompt
		};

		return await HandleBotResponse(chatId, userId, chatContext, promptView, citationMap.Values.AsEnumerable(), cancellationToken);
	}

	/// <summary>
	///     Helper function to render system instruction components.
	/// </summary>
	/// <param name="chatId">The chat ID</param>
	/// <param name="context">The KernelArguments.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task<string> RenderSystemInstructions(string chatId, KernelArguments context,
		CancellationToken cancellationToken)
	{
		// Render system instruction components
		await UpdateBotResponseStatusOnClient(chatId, "Initializing prompt", cancellationToken);

		KernelPromptTemplateFactory promptTemplateFactory = new();
		IPromptTemplate promptTemplate =
			promptTemplateFactory.Create(new PromptTemplateConfig(_promptOptions.SystemPersona));
		return await promptTemplate.RenderAsync(kernel, context, cancellationToken);
	}

	/// <summary>
	///     Helper function to handle final steps of bot response generation, including streaming to client,
	///     generating semantic text memory, calculating final token usages, and saving to chat history.
	/// </summary>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="chatContext">Chat context.</param>
	/// <param name="promptView">The prompt view.</param>
	/// <param name="citations">Citation sources.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task<CopilotChatMessage> HandleBotResponse(
		string chatId,
		string userId,
		KernelArguments chatContext,
		BotResponsePrompt promptView,
		IEnumerable<CitationSource>? citations,
		CancellationToken cancellationToken)
	{
		// Get bot response and stream to client
		await UpdateBotResponseStatusOnClient(chatId, "Generating bot response", cancellationToken);
		CopilotChatMessage chatMessage = await AsyncUtils.SafeInvokeAsync(
			() => StreamResponseToClient(chatId, userId, promptView, cancellationToken, citations),
			nameof(StreamResponseToClient));

		// Save the message into chat history
		await UpdateBotResponseStatusOnClient(chatId, "Saving message to chat history", cancellationToken);
		await chatMessageRepository.Upsert(chatMessage, cancellationToken);

		// Extract semantic chat memory
		await UpdateBotResponseStatusOnClient(chatId, "Generating semantic chat memory", cancellationToken);
		await AsyncUtils.SafeInvokeAsync(
			() => SemanticChatMemoryExtractor.ExtractSemanticChatMemory(
				chatId,
				memoryClient,
				kernel,
				chatContext,
				_promptOptions,
				logger,
				cancellationToken), nameof(SemanticChatMemoryExtractor.ExtractSemanticChatMemory));

		// Calculate total token usage for dependency functions and prompt template
		await UpdateBotResponseStatusOnClient(chatId, "Saving token usage", cancellationToken);
		chatMessage = chatMessage with
		{
			TokenUsage = GetTokenUsages(chatContext, chatMessage.Content)
		};

		// Update the message on client and in chat history with final completion token usage
		await UpdateMessageOnClient(chatMessage, cancellationToken);
		await chatMessageRepository.Upsert(chatMessage, cancellationToken);

		return chatMessage;
	}

	/// <summary>
	///     Extract the list of participants from the conversation history.
	///     Note that only those who have spoken will be included.
	/// </summary>
	/// <param name="context">Kernel context variables.</param>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task<string> GetAudience(
		KernelArguments context,
		string chatId,
		string userId,
		CancellationToken cancellationToken)
	{
		// Clone the context to avoid modifying the original context variables
		KernelArguments audienceContext = new(context);
		int historyTokenBudget =
			_promptOptions.CompletionTokenLimit -
			_promptOptions.ResponseTokenLimit -
			TokenUtils.TokenCount(string.Join("\n\n", [
					_promptOptions.SystemAudience,
					_promptOptions.SystemAudienceContinuation
				])
			);

		audienceContext["tokenLimit"] = historyTokenBudget.ToString(new NumberFormatInfo());

		KernelFunction completionFunction = kernel.CreateFunctionFromPrompt(
			_promptOptions.SystemAudienceExtraction,
			CreateIntentCompletionSettings(chatId, userId),
			"SystemAudienceExtraction",
			"Extract audience");

		FunctionResult result = await completionFunction.InvokeAsync(kernel, audienceContext, cancellationToken);

		// Get token usage from ChatCompletion result and add to original context
		string? tokenUsage = TokenUtils.GetFunctionTokenUsage(result, logger);
		if (tokenUsage is not null)
		{
			context[TokenUtils.GetFunctionKey("SystemAudienceExtraction")] = tokenUsage;
		}
		else
		{
			logger.LogError("Unable to determine token usage for audienceExtraction");
		}

		return $"List of participants: {result}";
	}

	/// <summary>
	///     Extract user intent from the conversation history.
	/// </summary>
	/// <param name="context">Kernel context.</param>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task<string> GetUserIntent(
		KernelArguments context,
		string chatId,
		string userId,
		CancellationToken cancellationToken)
	{
		// Clone the context to avoid modifying the original context variables
		KernelArguments intentContext = new(context);

		int tokenBudget =
			_promptOptions.CompletionTokenLimit -
			_promptOptions.ResponseTokenLimit -
			TokenUtils.TokenCount(string.Join("\n", [
					_promptOptions.SystemPersona,
					_promptOptions.SystemIntent,
					_promptOptions.SystemIntentContinuation
				])
			);

		intentContext["tokenLimit"] = tokenBudget.ToString(new NumberFormatInfo());
		intentContext["knowledgeCutoff"] = _promptOptions.KnowledgeCutoffDate;

		KernelFunction completionFunction = kernel.CreateFunctionFromPrompt(
			_promptOptions.SystemIntentExtraction,
			CreateIntentCompletionSettings(chatId, userId),
			"UserIntentExtraction",
			"Extract user intent");

		FunctionResult result = await completionFunction.InvokeAsync(kernel, intentContext, cancellationToken);

		// Get token usage from ChatCompletion result and add to original context
		string? tokenUsage = TokenUtils.GetFunctionTokenUsage(result, logger);
		if (tokenUsage is not null)
		{
			context[TokenUtils.GetFunctionKey("SystemIntentExtraction")] = tokenUsage;
		}
		else
		{
			logger.LogError("Unable to determine token usage for userIntentExtraction");
		}

		return $"User intent: {result}";
	}

	/// <summary>
	///     Save a new message to the chat history.
	/// </summary>
	/// <param name="message">The message</param>
	/// <param name="userId">The user ID</param>
	/// <param name="userName"></param>
	/// <param name="chatId">The chat ID</param>
	/// <param name="type">Type of the message</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task<CopilotChatMessage> SaveNewMessage(
		string message,
		string userId,
		string userName,
		string chatId,
		string type,
		CancellationToken cancellationToken)
	{
		// Make sure the chat exists.
		if (!await chatSessionRepository.TryFindById(chatId, cancellationToken: cancellationToken))
		{
			throw new ArgumentException("Chat session does not exist.");
		}

		CopilotChatMessage chatMessage = new()
		{
			UserId = userId,
			UserName = userName,
			ChatId = chatId,
			Content = message,
			AuthorRole = CopilotChatMessage.AuthorRoles.User,
			Prompt = string.Empty,
			Type = Enum.TryParse(type, out CopilotChatMessage.ChatMessageType typeAsEnum) &&
				Enum.IsDefined(typeAsEnum)
					? typeAsEnum
					: CopilotChatMessage.ChatMessageType.Message
		};

		await chatMessageRepository.Create(chatMessage, cancellationToken);
		return chatMessage;
	}

	/// <summary>
	///     Save a new response to the chat history.
	/// </summary>
	/// <param name="response">Response from the chat.</param>
	/// <param name="prompt">Prompt used to generate the response.</param>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="tokenUsage">Total token usage of response completion</param>
	/// <param name="citations">Citations for the message</param>
	/// <returns>The created chat message.</returns>
	private async Task<CopilotChatMessage> SaveNewResponse(
		string response,
		string prompt,
		string chatId,
		string userId,
		CancellationToken cancellationToken,
		Dictionary<string, int>? tokenUsage = null,
		IEnumerable<CitationSource>? citations = null)
	{
		// Make sure the chat exists.
		if (!await chatSessionRepository.TryFindById(chatId, cancellationToken: cancellationToken))
		{
			throw new ArgumentException("Chat session does not exist.");
		}

		// Save message to chat history
		CopilotChatMessage chatMessage = await CreateBotMessageOnClient(
			chatId,
			userId,
			prompt,
			response,
			cancellationToken,
			citations,
			tokenUsage
		);
		await chatMessageRepository.Upsert(chatMessage, cancellationToken);

		return chatMessage;
	}

	/// <summary>
	///     Updates previously saved response in the chat history.
	/// </summary>
	/// <param name="updatedResponse">Updated response from the chat.</param>
	/// <param name="messageId">The chat message ID.</param>
	/// <param name="chatId">The chat ID that's used as the partition Id.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task UpdateChatMessageContent(string updatedResponse, string messageId, string chatId,
		CancellationToken cancellationToken)
	{
		CopilotChatMessage? chatMessage = null;
		if (!await chatMessageRepository.TryFindById(messageId, chatId, v => chatMessage = v, cancellationToken))
		{
			throw new ArgumentException($"Chat message {messageId} does not exist.");
		}

		if (chatMessage is not null)
		{
			chatMessage = chatMessage with
			{
				Content = chatMessage.Content + updatedResponse
			};

			await chatMessageRepository.Upsert(chatMessage, cancellationToken);
		}
	}

	/// <summary>
	///     Create `OpenAIPromptExecutionSettings` for chat response. Parameters are read from the PromptSettings class.
	/// </summary>
	private OpenAIPromptExecutionSettings CreateChatRequestSettings(string chatId, string userId)
	{
		var x = new OpenAIPromptExecutionSettings
		{
			MaxTokens = _promptOptions.ResponseTokenLimit,
			Temperature = _promptOptions.ResponseTemperature,
			TopP = _promptOptions.ResponseTopP,
			FrequencyPenalty = _promptOptions.ResponseFrequencyPenalty,
			PresencePenalty = _promptOptions.ResponsePresencePenalty,
			ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions,
			AzureChatExtensionsOptions = new AzureChatExtensionsOptions
			{
				Extensions = { new LangfuseExtensionConfiguration(chatId, userId, s_langFuseTags) }
			}
		};

		return x;
	}

	/// <summary>
	///     Create `OpenAIPromptExecutionSettings` for intent response. Parameters are read from the PromptSettings class.
	/// </summary>
	private OpenAIPromptExecutionSettings CreateIntentCompletionSettings(string chatId, string userId)
	{
		return new OpenAIPromptExecutionSettings
		{
			MaxTokens = _promptOptions.ResponseTokenLimit,
			Temperature = _promptOptions.IntentTemperature,
			TopP = _promptOptions.IntentTopP,
			FrequencyPenalty = _promptOptions.IntentFrequencyPenalty,
			PresencePenalty = _promptOptions.IntentPresencePenalty,
			StopSequences = new[] { "] bot:" },
			AzureChatExtensionsOptions = new AzureChatExtensionsOptions
			{
				Extensions = { new LangfuseExtensionConfiguration(chatId, userId, s_langFuseTagsWithIntent) }
			}
		};
	}

	/// <summary>
	///     Calculate the maximum number of tokens that can be sent in a request
	/// </summary>
	private int GetMaxRequestTokenBudget()
	{
		// OpenAI inserts a message under the hood:
		// "content": "Assistant is a large language model.","role": "system"
		// This burns just under 20 tokens which need to be accounted for.
		const int extraOpenAiMessageTokens = 20;
		return _promptOptions.CompletionTokenLimit // Total token limit
			- extraOpenAiMessageTokens
			// Token count reserved for model to generate a response
			- _promptOptions.ResponseTokenLimit
			// Buffer for Tool Calls
			- _promptOptions.FunctionCallingTokenLimit;
	}

	/// <summary>
	///     Gets token usage totals for each semantic function if not undefined.
	/// </summary>
	/// <param name="kernelArguments">Context maintained during response generation.</param>
	/// <param name="content">String representing bot response. If null, response is still being generated or was hardcoded.</param>
	/// <returns>Dictionary containing function to token usage mapping for each total that's defined.</returns>
	private static Dictionary<string, int> GetTokenUsages(KernelArguments kernelArguments, string? content = null)
	{
		Dictionary<string, int> tokenUsageDict = new(StringComparer.OrdinalIgnoreCase);

		// Total token usage of each semantic function
		foreach (string function in TokenUtils.SemanticFunctions.Values)
		{
			if (kernelArguments.TryGetValue($"{function}TokenUsage", out object? tokenUsage)
				&& tokenUsage is string tokenUsageString)
			{
				tokenUsageDict.Add(function, int.Parse(tokenUsageString, CultureInfo.InvariantCulture));
			}
		}

		if (content is not null)
		{
			tokenUsageDict.Add(TokenUtils.SemanticFunctions["SystemCompletion"], TokenUtils.TokenCount(content));
		}

		return tokenUsageDict;
	}

	/// <summary>
	///     Stream the response to the client.
	/// </summary>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="prompt">Prompt used to generate the response</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="citations">Citations for the message</param>
	/// <returns>The created chat message</returns>
	private async Task<CopilotChatMessage> StreamResponseToClient(
		string chatId,
		string userId,
		BotResponsePrompt prompt,
		CancellationToken cancellationToken,
		IEnumerable<CitationSource>? citations = null)
	{
		// Create the stream
		IChatCompletionService chatCompletion = kernel.GetRequiredService<IChatCompletionService>();
		IAsyncEnumerable<StreamingChatMessageContent> stream =
			chatCompletion.GetStreamingChatMessageContentsAsync(
				prompt.MetaPromptTemplate,
				CreateChatRequestSettings(chatId, userId),
				kernel,
				cancellationToken);

		// Create message on client
		CopilotChatMessage chatMessage = await CreateBotMessageOnClient(
			chatId,
			userId,
			JsonSerializer.Serialize(prompt),
			string.Empty,
			cancellationToken,
			citations
		);

		// Stream the message to the client
		await foreach (StreamingChatMessageContent contentPiece in stream)
		{
			chatMessage = chatMessage with
			{
				Content = chatMessage.Content + contentPiece
			};
			await UpdateMessageOnClient(chatMessage, cancellationToken);
		}

		return chatMessage;
	}

	/// <summary>
	///     Create an empty message on the client to begin the response.
	/// </summary>
	/// <param name="chatId">The chat ID</param>
	/// <param name="userId">The user ID</param>
	/// <param name="prompt">Prompt used to generate the message</param>
	/// <param name="content">Content of the message</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="citations">Citations for the message</param>
	/// <param name="tokenUsage">Total token usage of response completion</param>
	/// <returns>The created chat message</returns>
	private async Task<CopilotChatMessage> CreateBotMessageOnClient(
		string chatId,
		string userId,
		string prompt,
		string content,
		CancellationToken cancellationToken,
		IEnumerable<CitationSource>? citations = null,
		Dictionary<string, int>? tokenUsage = null)
	{
		CopilotChatMessage chatMessage =
			CopilotChatMessage.CreateBotResponseMessage(chatId, content, prompt, citations, tokenUsage);
		await messageRelayHubContext.Clients.Group(chatId)
			.SendAsync("ReceiveMessage", chatId, userId, chatMessage, cancellationToken);
		return chatMessage;
	}

	/// <summary>
	///     Update the response on the client.
	/// </summary>
	/// <param name="message">The message</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task UpdateMessageOnClient(CopilotChatMessage message, CancellationToken cancellationToken)
	{
		await messageRelayHubContext.Clients.Group(message.ChatId)
			.SendAsync("ReceiveMessageUpdate", message, cancellationToken);
	}

	/// <summary>
	///     Update the status of the response on the client.
	/// </summary>
	/// <param name="chatId">The chat ID</param>
	/// <param name="status">Current status of the response</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	private async Task UpdateBotResponseStatusOnClient(
		string chatId,
		string status,
		CancellationToken cancellationToken)
	{
		await messageRelayHubContext.Clients.Group(chatId)
			.SendAsync("ReceiveBotResponseStatus", chatId, status, cancellationToken);
	}

	/// <summary>
	///     Set the system description in the prompt options.
	/// </summary>
	/// <param name="chatId">Id of the chat session</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <exception cref="ArgumentException">Throw if the chat session does not exist.</exception>
	private async Task SetSystemDescription(string chatId, CancellationToken cancellationToken)
	{
		ChatSession? chatSession = null;
		if (!await chatSessionRepository.TryFindById(chatId, callback: v => chatSession = v, cancellationToken: cancellationToken)
			|| chatSession is null)
		{
			throw new ArgumentException("Chat session does not exist.");
		}

		_promptOptions.SystemDescription = chatSession.SafeSystemDescription;
	}
}
