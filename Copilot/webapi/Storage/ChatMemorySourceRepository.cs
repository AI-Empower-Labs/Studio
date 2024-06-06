// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Threading;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     A repository for chat messages.
/// </summary>
public class ChatMemorySourceRepository(IStorageContext<MemorySource> storageContext) : Repository<MemorySource>(storageContext)
{
	private readonly IStorageContext<MemorySource> _storageContext = storageContext;

	/// <summary>
	///     Finds chat memory sources by chat session id
	/// </summary>
	/// <param name="chatId">The chat session id.</param>
	/// <param name="includeGlobal">Flag specifying if global documents should be included in the response.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of memory sources.</returns>
	public IAsyncEnumerable<MemorySource> FindByChatIdAsync(string chatId, bool includeGlobal = true, CancellationToken cancellationToken = default)
	{
		return _storageContext
			.QueryEntitiesAsync(e => e.ChatId == chatId || (includeGlobal && e.ChatId == Guid.Empty.ToString()), cancellationToken);
	}

	/// <summary>
	///     Finds chat memory sources by name
	/// </summary>
	/// <param name="name">Name</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of memory sources with the given name.</returns>
	public IAsyncEnumerable<MemorySource> FindByNameAsync(string name, CancellationToken cancellationToken = default)
	{
		return _storageContext.QueryEntitiesAsync(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase), cancellationToken);
	}

	/// <summary>
	///     Retrieves all memory sources.
	/// </summary>
	/// <returns>A list of memory sources.</returns>
	public IAsyncEnumerable<MemorySource> GetAllAsync(CancellationToken cancellationToken = default)
	{
		return _storageContext.QueryEntitiesAsync(_ => true, cancellationToken);
	}
}
