// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     A storage context that stores entities in memory.
/// </summary>
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class VolatileContext<T> : IStorageContext<T> where T : IStorageEntity
{
	/// <summary>
	///     Using a concurrent dictionary to store entities in memory.
	/// </summary>
#pragma warning disable CA1051
	protected readonly ConcurrentDictionary<string, T> Entities = new();
#pragma warning restore CA1051

	/// <inheritdoc />
	public IAsyncEnumerable<T> QueryEntitiesAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
	{
		Func<T, bool> compiledPredicate = predicate.Compile();
		return Entities.Values.Where(entity => compiledPredicate(entity)).ToAsyncEnumerable();
	}

	/// <inheritdoc />
	public Task Create(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity Id cannot be null or empty.");
		}

		Entities.TryAdd(entity.Id, entity);

		return Task.CompletedTask;
	}

	/// <inheritdoc />
	public Task Delete(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity Id cannot be null or empty.");
		}

		Entities.TryRemove(entity.Id, out _);

		return Task.CompletedTask;
	}

	/// <inheritdoc />
	public Task<T> Read(string entityId, string partitionKey, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entityId))
		{
			throw new ArgumentOutOfRangeException(nameof(entityId), "Entity Id cannot be null or empty.");
		}

		if (Entities.TryGetValue(entityId, out T? entity))
		{
			return Task.FromResult(entity);
		}

		throw new KeyNotFoundException($"Entity with id {entityId} not found.");
	}

	/// <inheritdoc />
	public Task Upsert(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity Id cannot be null or empty.");
		}

		Entities.AddOrUpdate(entity.Id, entity, (_, _) => entity);

		return Task.CompletedTask;
	}

	private string GetDebuggerDisplay()
	{
		return ToString() ?? string.Empty;
	}
}

/// <summary>
///     Specialization of VolatileContext<T> for CopilotChatMessage.
/// </summary>
public sealed class VolatileCopilotChatMessageContext : VolatileContext<CopilotChatMessage>, ICopilotChatMessageStorageContext
{
	/// <inheritdoc />
	public IAsyncEnumerable<CopilotChatMessage> QueryEntities(
		Expression<Func<CopilotChatMessage, bool>> predicate,
		int skip,
		int count,
		CancellationToken cancellationToken)
	{
		Func<CopilotChatMessage, bool> compiledPredicate = predicate.Compile();
		return Entities.Values
			.Where(message => compiledPredicate(message))
			.OrderByDescending(m => m.Timestamp)
			.Skip(skip)
			.Take(count)
			.ToAsyncEnumerable();
	}
}
