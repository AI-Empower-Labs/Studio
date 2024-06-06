// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     A repository for chat messages.
/// </summary>
public sealed class ChatMessageRepository(ICopilotChatMessageStorageContext storageContext) : CopilotChatMessageRepository(storageContext)
{
	/// <summary>
	///     Finds chat messages by chat id.
	/// </summary>
	/// <param name="chatId">The chat id.</param>
	/// <param name="skip">Number of messages to skip before starting to return messages.</param>
	/// <param name="count">The number of messages to return. -1 returns all messages.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of ChatMessages matching the given chatId sorted from most recent to oldest.</returns>
	public IAsyncEnumerable<CopilotChatMessage> FindByChatIdAsync(
		string chatId,
		int skip = 0,
		int count = -1,
		CancellationToken cancellationToken = default)
	{
		return QueryEntities(e => e.ChatId == chatId, skip, count, cancellationToken);
	}

	/// <summary>
	///     Finds the most recent chat message by chat id.
	/// </summary>
	/// <param name="chatId">The chat id.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>The most recent ChatMessage matching the given chatId.</returns>
	public async Task<CopilotChatMessage> FindLastByChatIdAsync(string chatId, CancellationToken cancellationToken)
	{
		IAsyncEnumerable<CopilotChatMessage> chatMessages = FindByChatIdAsync(chatId, 0, 1, cancellationToken);
		CopilotChatMessage? first = await chatMessages
			.OrderByDescending(e => e.Timestamp)
			.FirstOrDefaultAsync(cancellationToken: cancellationToken);
		return first ?? throw new KeyNotFoundException($"No messages found for chat '{chatId}'.");
	}
}
