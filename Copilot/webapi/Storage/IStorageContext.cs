// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     Defines the basic CRUD operations for a storage context.
/// </summary>
public interface IStorageContext<T> where T : IStorageEntity
{
	/// <summary>
	///     Query entities in the storage context.
	///     <param name="predicate">Predicate that needs to evaluate to true for a particular entryto be returned.</param>
	/// </summary>
	IAsyncEnumerable<T> QueryEntitiesAsync(
		Expression<Func<T, bool>> predicate,
		CancellationToken cancellationToken);

	/// <summary>
	///     Read an entity from the storage context by id.
	/// </summary>
	/// <param name="entityId">The entity id.</param>
	/// <param name="partitionKey">The entity partition</param>
	/// <param name="cancellationToken"></param>
	/// <returns>The entity.</returns>
	Task<T> Read(string entityId, string partitionKey, CancellationToken cancellationToken);

	/// <summary>
	///     Create an entity in the storage context.
	/// </summary>
	/// <param name="entity">The entity to be created in the context.</param>
	/// <param name="cancellationToken"></param>
	Task Create(T entity, CancellationToken cancellationToken);

	/// <summary>
	///     Upsert an entity in the storage context.
	/// </summary>
	/// <param name="entity">The entity to be upserted in the context.</param>
	/// <param name="cancellationToken"></param>
	Task Upsert(T entity, CancellationToken cancellationToken);

	/// <summary>
	///     Delete an entity from the storage context.
	/// </summary>
	/// <param name="entity">The entity to be deleted from the context.</param>
	/// <param name="cancellationToken"></param>
	Task Delete(T entity, CancellationToken cancellationToken);
}

/// <summary>
/// Specialization of IStorageContext<T> for CopilotChatMessage.
/// </summary>
public interface ICopilotChatMessageStorageContext : IStorageContext<CopilotChatMessage>
{
	/// <summary>
	///     Query entities in the storage context.
	/// </summary>
	/// <param name="predicate">Predicate that needs to evaluate to true for a particular entryto be returned.</param>
	/// <param name="skip">Number of messages to skip before starting to return messages.</param>
	/// <param name="count">The number of messages to return. -1 returns all messages.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of ChatMessages matching the given chatId sorted from most recent to oldest.</returns>
	IAsyncEnumerable<CopilotChatMessage> QueryEntities(
		Expression<Func<CopilotChatMessage, bool>> predicate,
		int skip = 0,
		int count = -1,
		CancellationToken cancellationToken = default);
}
