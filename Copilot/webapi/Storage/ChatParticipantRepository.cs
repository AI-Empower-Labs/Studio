// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     A repository for chat sessions.
/// </summary>
public sealed class ChatParticipantRepository(IStorageContext<ChatParticipant> storageContext)
	: Repository<ChatParticipant>(storageContext)
{
	private readonly IStorageContext<ChatParticipant> _storageContext = storageContext;

	/// <summary>
	///     Finds chat participants by user id.
	///     A user can be part of multiple chats, thus a user can have multiple chat participants.
	/// </summary>
	/// <param name="userId">The user id.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of chat participants of the same user id in different chat sessions.</returns>
	public IAsyncEnumerable<ChatParticipant> FindByUserIdAsync(string userId, CancellationToken cancellationToken)
	{
		return _storageContext.QueryEntitiesAsync(e => e.UserId == userId, cancellationToken);
	}

	/// <summary>
	///     Finds chat participants by chat id.
	/// </summary>
	/// <param name="chatId">The chat id.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of chat participants in the same chat sessions.</returns>
	public IAsyncEnumerable<ChatParticipant> FindByChatIdAsync(string chatId, CancellationToken cancellationToken)
	{
		return _storageContext.QueryEntitiesAsync(e => e.ChatId == chatId, cancellationToken);
	}


	/// <summary>
	///     Checks if a user is in a chat session.
	/// </summary>
	/// <param name="userId">The user id.</param>
	/// <param name="chatId">The chat id.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>True if the user is in the chat session, false otherwise.</returns>
	public async Task<bool> IsUserInChatAsync(string userId, string chatId, CancellationToken cancellationToken)
	{
		IAsyncEnumerable<ChatParticipant> users = _storageContext
			.QueryEntitiesAsync(e => e.UserId == userId && e.ChatId == chatId, cancellationToken);
		return await users.AnyAsync(cancellationToken: cancellationToken);
	}
}
