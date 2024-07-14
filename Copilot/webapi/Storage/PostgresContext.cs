// Copyright (c) Microsoft.All rights reserved.

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

using Marten;

namespace CopilotChat.WebApi.Storage;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;

/// <summary>
///     A storage context that stores entities in memory.
/// </summary>
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class PostgresContext<T>(IDocumentStore documentStore) : IStorageContext<T> where T : IStorageEntity
{
	/// <inheritdoc />
	public async IAsyncEnumerable<T> QueryEntitiesAsync(
		Expression<Func<T, bool>> predicate,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		await using IDocumentSession session = documentStore.LightweightSession();
		IAsyncEnumerable<T> asyncEnumerable = session
			.Query<T>()
			.Where(predicate)
			.ToAsyncEnumerable(token: cancellationToken);
		await foreach (T entity in asyncEnumerable)
		{
			yield return entity;
		}
	}

	/// <inheritdoc />
	public async Task Create(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity Id cannot be null or empty.");
		}

		await using IDocumentSession session = documentStore.LightweightSession();
		session.Store(entity);
		await session.SaveChangesAsync(cancellationToken);
	}

	/// <inheritdoc />
	public async Task Delete(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity Id cannot be null or empty.");
		}

		await using IDocumentSession session = documentStore.LightweightSession();
		session.Delete(entity);
		await session.SaveChangesAsync(cancellationToken);
	}

	/// <inheritdoc />
	public async Task<T> Read(string entityId, string partitionKey, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entityId))
		{
			throw new ArgumentOutOfRangeException(nameof(entityId), "Entity Id cannot be null or empty.");
		}

		await using IDocumentSession session = documentStore.LightweightSession();
		T? entity = await session.LoadAsync<T>(entityId, cancellationToken);
		if (entity is null)
		{
			throw new KeyNotFoundException($"Entity with id {entityId} not found.");
		}

		return entity;
	}

	/// <inheritdoc />
	public async Task Upsert(T entity, CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(entity.Id))
		{
			throw new ArgumentOutOfRangeException(nameof(entity), "Entity Id cannot be null or empty.");
		}

		await using IDocumentSession session = documentStore.LightweightSession();
		session.Store(entity);
		await session.SaveChangesAsync(cancellationToken);
	}

	private string GetDebuggerDisplay()
	{
		return ToString() ?? string.Empty;
	}
}

/// <summary>
/// Specialization of PostgresContext<T> for CopilotChatMessage.
/// </summary>
public sealed class PostgresCopilotChatMessageContext(IDocumentStore documentStore) : PostgresContext<CopilotChatMessage>(documentStore), ICopilotChatMessageStorageContext
{
	private readonly IDocumentStore _documentStore = documentStore;

	/// <inheritdoc />
	public async IAsyncEnumerable<CopilotChatMessage> QueryEntities(
		Expression<Func<CopilotChatMessage, bool>> predicate,
		int skip,
		int count,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		await using IDocumentSession session = _documentStore.LightweightSession();
		IAsyncEnumerable<CopilotChatMessage> asyncEnumerable = session
			.Query<CopilotChatMessage>()
			.Where(predicate)
			.OrderByDescending(m => m.Timestamp)
			.Skip(skip)
			.Take(count <= 0 ? int.MaxValue : count)
			.ToAsyncEnumerable(token: cancellationToken);
		await foreach (CopilotChatMessage copilotChatMessage in asyncEnumerable)
		{
			yield return copilotChatMessage;
		}
	}
}
