// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Storage;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
///     Controller for managing invitations and participants in a chat session.
///     This controller is responsible for:
///     1. Creating invitation links.
///     2. Accepting/rejecting invitation links.
///     3. Managing participants in a chat session.
/// </summary>
[ApiController]
public sealed class ChatParticipantController(
	ChatParticipantRepository chatParticipantRepository,
	ChatSessionRepository chatSessionRepository) : ControllerBase
{
	private const string UserJoinedClientCall = "UserJoined";

	/// <summary>
	///     Join the logged in user to a chat session given a chat ID.
	/// </summary>
	/// <param name="messageRelayHubContext">Message Hub that performs the real time relay service.</param>
	/// <param name="authInfo">The auth info for the current request.</param>
	/// <param name="chatId">The ID of the chat to join.</param>
	/// <param name="cancellationToken"></param>
	[HttpPost]
	[Route("chats/{chatId:guid}/participants")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status409Conflict)]
	public async Task<IActionResult> JoinChatAsync(
		[FromServices] IHubContext<MessageRelayHub> messageRelayHubContext,
		[FromServices] IAuthInfo authInfo,
		[FromRoute] Guid chatId,
		CancellationToken cancellationToken)
	{
		string userId = authInfo.UserId;

		// Make sure the chat session exists.
		if (!await chatSessionRepository.TryFindById(chatId.ToString(), cancellationToken: cancellationToken))
		{
			return BadRequest("Chat session does not exist.");
		}

		// Make sure the user is not already in the chat session.
		if (await chatParticipantRepository.IsUserInChatAsync(userId, chatId.ToString(), cancellationToken))
		{
			return Conflict("User is already in the chat session.");
		}

		ChatParticipant chatParticipant = new()
		{
			UserId = userId,
			ChatId = chatId.ToString()
		};
		await chatParticipantRepository.Create(chatParticipant, cancellationToken);

		// Broadcast the user joined event to all the connected clients.
		// Note that the client who initiated the request may not have joined the group.
		await messageRelayHubContext.Clients
			.Group(chatId.ToString())
			.SendAsync(UserJoinedClientCall, chatId, userId, cancellationToken: cancellationToken);

		return Ok(chatParticipant);
	}

	/// <summary>
	///     Get a list of chat participants that have the same chat id.
	/// </summary>
	/// <param name="chatId">The ID of the chat to get all the participants from.</param>
	/// <param name="cancellationToken"></param>
	[HttpGet]
	[Route("chats/{chatId:guid}/participants")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
	public async Task<IActionResult> GetAllParticipantsAsync(Guid chatId, CancellationToken cancellationToken)
	{
		// Make sure the chat session exists.
		if (!await chatSessionRepository.TryFindById(chatId.ToString(), cancellationToken: cancellationToken))
		{
			return NotFound("Chat session does not exist.");
		}

		IAsyncEnumerable<ChatParticipant> chatParticipants = chatParticipantRepository
			.FindByChatIdAsync(chatId.ToString(), cancellationToken);

		return Ok(chatParticipants);
	}
}
