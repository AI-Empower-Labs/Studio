// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Extensions;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Models.Request;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Plugins.Utils;
using CopilotChat.WebApi.Storage;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
///     Controller for chat history.
///     This controller is responsible for creating new chat sessions, retrieving chat sessions,
///     retrieving chat messages, and editing chat sessions.
/// </summary>
[ApiController]
public sealed class ChatHistoryController(
	ILogger<ChatHistoryController> logger,
	IKernelMemory memoryClient,
	ChatSessionRepository sessionRepository,
	ChatMessageRepository messageRepository,
	ChatParticipantRepository participantRepository,
	ChatMemorySourceRepository sourceRepository,
	IOptions<PromptsOptions> promptOptions,
	IAuthInfo authInfo) : ControllerBase
{
	private const string ChatEditedClientCall = "ChatEdited";
	private const string ChatDeletedClientCall = "ChatDeleted";
	private const string GetChatRoute = "GetChatRoute";

	/// <summary>
	///     Create a new chat session and populate the session with the initial bot message.
	/// </summary>
	/// <param name="chatParameters">Contains the title of the chat.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>The HTTP action result.</returns>
	[HttpPost]
	[Route("chats")]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> CreateChatSessionAsync(
		[FromBody] CreateChatParameters chatParameters,
		CancellationToken cancellationToken)
	{
		if (chatParameters.Title == null)
		{
			return BadRequest("Chat session parameters cannot be null.");
		}

		// Create a new chat session
		ChatSession newChat = new()
		{
			Title = chatParameters.Title,
			SystemDescription = promptOptions.Value.SystemDescription
		};
		await sessionRepository.Create(newChat, cancellationToken: cancellationToken);

		// Create initial bot message
		CopilotChatMessage chatMessage = CopilotChatMessage.CreateBotResponseMessage(
			newChat.Id,
			promptOptions.Value.InitialBotMessage,
			string.Empty, // The initial bot message doesn't need a prompt.
			null,
			TokenUtils.EmptyTokenUsages());
		await messageRepository.Create(chatMessage, cancellationToken: cancellationToken);

		// Add the user to the chat session
		ChatParticipant chatParticipant = new()
		{
			UserId = authInfo.UserId,
			ChatId = newChat.Id
		};
		await participantRepository.Create(chatParticipant, cancellationToken: cancellationToken);

		logger.LogDebug("Created chat session with id {Id}", newChat.Id);

		return CreatedAtRoute(GetChatRoute, new { chatId = newChat.Id },
			new CreateChatResponse
			{
				ChatSession = newChat,
				InitialBotMessage = chatMessage
			});
	}

	/// <summary>
	///     Get a chat session by id.
	/// </summary>
	/// <param name="chatId">The chat id.</param>
	[HttpGet]
	[Route("chats/{chatId:guid}", Name = GetChatRoute)]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
	public async Task<IActionResult> GetChatSessionByIdAsync(Guid chatId)
	{
		ChatSession? chat = null;
		if (await sessionRepository.TryFindById(chatId.ToString(), callback: v => chat = v))
		{
			return Ok(chat);
		}

		return NotFound($"No chat session found for chat id '{chatId}'.");
	}

	/// <summary>
	///     Get all chat sessions associated with the logged in user. Return an empty list if no chats are found.
	/// </summary>
	/// <returns>A list of chat sessions. An empty list if the user is not in any chat session.</returns>
	[HttpGet]
	[Route("chats")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<IActionResult> GetAllChatSessionsAsync(CancellationToken cancellationToken)
	{
		// Get all participants that belong to the user.
		// Then get all the chats from the list of participants.
		IAsyncEnumerable<ChatParticipant> chatParticipants = participantRepository
			.FindByUserIdAsync(authInfo.UserId, cancellationToken);

		List<ChatSession> chats = new();
		await foreach (ChatParticipant chatParticipant in chatParticipants)
		{
			ChatSession? chat = null;
			if (await sessionRepository.TryFindById(chatParticipant.ChatId, callback: v => chat = v, cancellationToken: cancellationToken))
			{
				chats.Add(chat!);
			}
			else
			{
				logger.LogDebug("Failed to find chat session with id {ChatId}", chatParticipant.ChatId);
			}
		}

		return Ok(chats);
	}

	/// <summary>
	///     Get chat messages for a chat session.
	///     Messages are returned ordered from most recent to oldest.
	/// </summary>
	/// <param name="chatId">The chat id.</param>
	/// <param name="skip">Number of messages to skip before starting to return messages.</param>
	/// <param name="count">The number of messages to return. -1 returns all messages.</param>
	/// <param name="cancellationToken"></param>
	[HttpGet]
	[Route("chats/{chatId:guid}/messages")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
	public async Task<IActionResult> GetChatMessagesAsync(
		[FromRoute] Guid chatId,
		[FromQuery] int skip = 0,
		[FromQuery] int count = -1,
		CancellationToken cancellationToken = default)
	{
		IAsyncEnumerable<CopilotChatMessage> chatMessages = messageRepository
			.FindByChatIdAsync(chatId.ToString(), skip, count, cancellationToken);
		if (!await chatMessages.AnyAsync(cancellationToken: cancellationToken))
		{
			return NotFound($"No messages found for chat id '{chatId}'.");
		}

		return Ok(chatMessages);
	}

	/// <summary>
	///     Edit a chat session.
	/// </summary>
	/// <param name="messageRelayHubContext"></param>
	/// <param name="chatParameters">Object that contains the parameters to edit the chat.</param>
	/// <param name="chatId"></param>
	/// <param name="cancellationToken"></param>
	[HttpPatch]
	[Route("chats/{chatId:guid}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
	public async Task<IActionResult> EditChatSessionAsync(
		[FromServices] IHubContext<MessageRelayHub> messageRelayHubContext,
		[FromBody] EditChatParameters chatParameters,
		[FromRoute] Guid chatId,
		CancellationToken cancellationToken)
	{
		ChatSession? chat = null;
		if (await sessionRepository.TryFindById(
			chatId.ToString(),
			callback: v => chat = v,
			cancellationToken: cancellationToken))
		{
			chat = chat! with
			{
				Title = chatParameters.Title ?? chat!.Title,
				SystemDescription = chatParameters.SystemDescription ?? chat!.SafeSystemDescription,
				MemoryBalance = chatParameters.MemoryBalance ?? chat!.MemoryBalance
			};

			await sessionRepository.Upsert(chat, cancellationToken: cancellationToken);
			await messageRelayHubContext.Clients
				.Group(chatId.ToString())
				.SendAsync(ChatEditedClientCall, chat, cancellationToken: cancellationToken);

			return Ok(chat);
		}

		return NotFound($"No chat session found for chat id '{chatId}'.");
	}

	/// <summary>
	///     Gets list of imported documents for a given chat.
	/// </summary>
	[Route("chats/{chatId:guid}/documents")]
	[HttpGet]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
	public async Task<ActionResult<IEnumerable<MemorySource>>> GetSourcesAsync(Guid chatId, CancellationToken cancellationToken)
	{
		logger.LogInformation("Get imported sources of chat session {ChatId}", chatId);

		if (await sessionRepository.TryFindById(chatId.ToString(), cancellationToken: cancellationToken))
		{
			IAsyncEnumerable<MemorySource> sources = sourceRepository
				.FindByChatIdAsync(chatId.ToString(), cancellationToken: cancellationToken);

			return Ok(sources);
		}

		return NotFound($"No chat session found for chat id '{chatId}'.");
	}

	/// <summary>
	///     Delete a chat session.
	/// </summary>
	/// <param name="messageRelayHubContext"></param>
	/// <param name="chatId">The chat id.</param>
	/// <param name="cancellationToken"></param>
	[HttpDelete]
	[Route("chats/{chatId:guid}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status403Forbidden)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status500InternalServerError)]
	[Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
	public async Task<IActionResult> DeleteChatSessionAsync(
		[FromServices] IHubContext<MessageRelayHub> messageRelayHubContext,
		Guid chatId,
		CancellationToken cancellationToken)
	{
		string chatIdString = chatId.ToString();
		ChatSession? chatToDelete;
		try
		{
			// Make sure the chat session exists
			chatToDelete = await sessionRepository.FindById(chatIdString, cancellationToken: cancellationToken);
		}
		catch (KeyNotFoundException)
		{
			return NotFound($"No chat session found for chat id '{chatId}'.");
		}

		// Delete any resources associated with the chat session.
		try
		{
			await DeleteChatResourcesAsync(chatIdString, cancellationToken);
		}
		catch (AggregateException)
		{
			return StatusCode(500, $"Failed to delete resources for chat id '{chatId}'.");
		}

		// Delete chat session and broadcast update to all participants.
		await sessionRepository.Delete(chatToDelete, cancellationToken: cancellationToken);
		await messageRelayHubContext.Clients
			.Group(chatIdString)
			.SendAsync(ChatDeletedClientCall, chatIdString, authInfo.UserId, cancellationToken);

		return NoContent();
	}

	/// <summary>
	///     Deletes all associated resources (messages, memories, participants) associated with a chat session.
	/// </summary>
	/// <param name="chatId">The chat id.</param>
	/// <param name="cancellationToken"></param>
	private async Task DeleteChatResourcesAsync(string chatId, CancellationToken cancellationToken)
	{
		List<Task> cleanupTasks = new();

		// Create and store the tasks for deleting all users tied to the chat.
		IAsyncEnumerable<ChatParticipant> participants = participantRepository.FindByChatIdAsync(chatId, cancellationToken);
		await foreach (ChatParticipant participant in participants)
		{
			cleanupTasks.Add(participantRepository.Delete(participant, cancellationToken: cancellationToken));
		}

		// Create and store the tasks for deleting chat messages.
		IAsyncEnumerable<CopilotChatMessage> messages = messageRepository.FindByChatIdAsync(chatId, cancellationToken: cancellationToken);
		await foreach (CopilotChatMessage message in messages)
		{
			cleanupTasks.Add(messageRepository.Delete(message, cancellationToken: cancellationToken));
		}

		// Create and store the tasks for deleting memory sources.
		IAsyncEnumerable<MemorySource> sources = sourceRepository.FindByChatIdAsync(chatId, false, cancellationToken);
		await foreach (MemorySource source in sources)
		{
			cleanupTasks.Add(sourceRepository.Delete(source, cancellationToken: cancellationToken));
		}

		// Create and store the tasks for deleting semantic memories.
		cleanupTasks.Add(memoryClient.RemoveChatMemoriesAsync(promptOptions.Value.MemoryIndexName, chatId,
			cancellationToken));

		// Create a task that represents the completion of all cleanupTasks
		Task aggregationTask = Task.WhenAll(cleanupTasks);
		try
		{
			// Await the completion of all tasks in parallel
			await aggregationTask;
		}
		catch (Exception ex)
		{
			// Handle any exceptions that occurred during the tasks
			if (aggregationTask.Exception?.InnerExceptions is not null &&
				aggregationTask.Exception.InnerExceptions.Count != 0)
			{
				foreach (Exception innerEx in aggregationTask.Exception.InnerExceptions)
				{
					logger.LogInformation("Failed to delete an entity of chat {ChatId}: {Message}", chatId, innerEx.Message);
				}

				throw aggregationTask.Exception;
			}

			throw new AggregateException($"Resource deletion failed for chat {chatId}.", ex);
		}
	}
}
