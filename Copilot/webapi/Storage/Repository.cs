// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     Defines the basic CRUD operations for a repository.
/// </summary>
public class Repository<T>(IStorageContext<T> storageContext) : IRepository<T> where T : IStorageEntity
{
	/// <inheritdoc />
	public Task Create(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity ID cannot be null or empty.");
		}

		return storageContext.Create(entity, cancellationToken);
	}

	/// <inheritdoc />
	public Task Delete(T entity, CancellationToken cancellationToken)
	{
		return storageContext.Delete(entity, cancellationToken);
	}

	/// <inheritdoc />
	public Task<T> FindById(string id, string? partition = null, CancellationToken cancellationToken = default)
	{
		return storageContext.Read(id, partition ?? id, cancellationToken);
	}

	/// <inheritdoc />
	public async Task<bool> TryFindById(string id, string? partition = null, Action<T?>? callback = null, CancellationToken cancellationToken = default)
	{
		try
		{
			T found = await FindById(id, partition ?? id, cancellationToken);
			callback?.Invoke(found);
			return true;
		}
		catch (Exception ex) when (ex is ArgumentOutOfRangeException or KeyNotFoundException)
		{
			return false;
		}
	}

	/// <inheritdoc />
	public Task Upsert(T entity, CancellationToken cancellationToken)
	{
		return storageContext.Upsert(entity, cancellationToken);
	}
}

/// <summary>
///     Specialization of Repository<T> for CopilotChatMessage.
/// </summary>
public class CopilotChatMessageRepository(ICopilotChatMessageStorageContext storageContext)
	: Repository<CopilotChatMessage>(storageContext)
{
	/// <summary>
	///     Finds chat messages matching a predicate.
	/// </summary>
	/// <param name="predicate">Predicate that needs to evaluate to true for a particular entryto be returned.</param>
	/// <param name="skip">Number of messages to skip before starting to return messages.</param>
	/// <param name="count">The number of messages to return. -1 returns all messages.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of ChatMessages matching the given chatId sorted from most recent to oldest.</returns>
	protected IAsyncEnumerable<CopilotChatMessage> QueryEntities(
		Expression<Func<CopilotChatMessage, bool>> predicate,
		int skip = 0,
		int count = -1,
		CancellationToken cancellationToken = default)
	{
		return storageContext.QueryEntities(predicate, skip, count, cancellationToken);
	}
}
