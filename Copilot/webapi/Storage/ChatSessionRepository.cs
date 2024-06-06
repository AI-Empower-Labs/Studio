// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Threading;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     A repository for chat sessions.
/// </summary>
public class ChatSessionRepository(IStorageContext<ChatSession> storageContext)
	: Repository<ChatSession>(storageContext)
{
	private readonly IStorageContext<ChatSession> _storageContext = storageContext;

	/// <summary>
	///     Retrieves all chat sessions.
	/// </summary>
	/// <returns>A list of ChatMessages.</returns>
	public IAsyncEnumerable<ChatSession> GetAllChatsAsync(CancellationToken cancellationToken)
	{
		return _storageContext.QueryEntitiesAsync(_ => true, cancellationToken);
	}
}
