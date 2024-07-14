// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Extensions;
using CopilotChat.WebApi.Models.Request;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Plugins.Utils;

using Microsoft.Extensions.Logging;
using Microsoft.KernelMemory;
using Microsoft.SemanticKernel;

namespace CopilotChat.WebApi.Plugins.Chat;

/// <summary>
///     Helper class to extract and create kernel memory from chat history.
/// </summary>
internal static class SemanticChatMemoryExtractor
{
	/// <summary>
	///     Extract and save kernel memory.
	/// </summary>
	/// <param name="chatId">The Chat ID.</param>
	/// <param name="memoryClient"></param>
	/// <param name="kernel">The semantic kernel.</param>
	/// <param name="kernelArguments">The Semantic Kernel context.</param>
	/// <param name="options">The prompts options.</param>
	/// <param name="logger">The logger.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	public static async Task ExtractSemanticChatMemory(
		string chatId,
		IKernelMemory memoryClient,
		Kernel kernel,
		KernelArguments kernelArguments,
		PromptsOptions options,
		ILogger logger,
		CancellationToken cancellationToken)
	{
		foreach (string memoryType in Enum.GetNames<SemanticMemoryType>())
		{
			try
			{
				if (!options.TryGetMemoryContainerName(memoryType, out string memoryName))
				{
					logger.LogInformation("Unable to extract kernel memory for invalid memory type {MemoryType}. Continuing...",
						memoryType);
					continue;
				}

				SemanticChatMemory semanticMemory = await ExtractCognitiveMemoryAsync(memoryType, memoryName, logger);
				foreach (SemanticChatMemoryItem item in semanticMemory.Items)
				{
					await CreateMemoryAsync(memoryName, item.ToFormattedString());
				}
			}
			catch (Exception ex) when (!ex.IsCriticalException())
			{
				// Skip kernel memory extraction for this item if it fails.
				// We cannot rely on the model to response with perfect Json each time.
				logger.LogInformation("Unable to extract kernel memory for {MemoryType}: {Message}. Continuing...", memoryType, ex.Message);
			}
		}

		/// <summary>
		/// Extracts the semantic chat memory from the chat session.
		/// </summary>
		async Task<SemanticChatMemory> ExtractCognitiveMemoryAsync(string memoryType, string memoryName, ILogger innerLogger)
		{
			if (!options.MemoryMap.TryGetValue(memoryName, out string? memoryPrompt))
			{
				throw new ArgumentException($"Memory name {memoryName} is not supported.");
			}

			// Token limit for chat history
			int tokenLimit = options.CompletionTokenLimit;
			int remainingToken =
				tokenLimit -
				options.ResponseTokenLimit -
				TokenUtils.TokenCount(memoryPrompt);

			KernelArguments memoryExtractionArguments = new(kernelArguments)
			{
				["tokenLimit"] = remainingToken.ToString(new NumberFormatInfo()),
				["memoryName"] = memoryName,
				["format"] = options.MemoryFormat,
				["knowledgeCutoff"] = options.KnowledgeCutoffDate
			};

			KernelFunction completionFunction = kernel.CreateFunctionFromPrompt(memoryPrompt);
			FunctionResult result = await completionFunction.InvokeAsync(
				kernel,
				memoryExtractionArguments,
				cancellationToken);

			// Get token usage from ChatCompletion result and add to context
			string? tokenUsage = TokenUtils.GetFunctionTokenUsage(result, innerLogger);
			if (tokenUsage is not null)
			{
				// Since there are multiple memory types, total token usage is calculated by cumulating the token usage of each memory type.
				kernelArguments[TokenUtils.GetFunctionKey($"SystemCognitive_{memoryType}")] = tokenUsage;
			}
			else
			{
				innerLogger.LogError("Unable to determine token usage for {MemoryType}", $"SystemCognitive_{memoryType}");
			}

			SemanticChatMemory memory = SemanticChatMemory.FromJson(result.ToString());

			return memory;
		}

		/// <summary>
		/// Create a memory item in the memory collection.
		/// If there is already a memory item that has a high similarity score with the new item, it will be skipped.
		/// </summary>
		async Task CreateMemoryAsync(string memoryName, string memory)
		{
			try
			{
				// Search if there is already a memory item that has a high similarity score with the new item.
				SearchResult searchResult =
					await memoryClient.SearchMemory(
						options.MemoryIndexName,
						memory,
						options.SemanticMemoryRelevanceUpper,
						1,
						chatId,
						memoryName,
						cancellationToken);

				if (searchResult.Results.Count == 0)
				{
					await memoryClient.StoreMemory(options.MemoryIndexName, chatId, memoryName, memory,
						cancellationToken);
				}
			}
			catch (Exception exception) when (!exception.IsCriticalException())
			{
				// A store exception might be thrown if the collection does not exist, depending on the memory store connector.
				logger.LogError(exception, "Unexpected failure searching {IndexName}", options.MemoryIndexName);
			}
		}
	}
}
