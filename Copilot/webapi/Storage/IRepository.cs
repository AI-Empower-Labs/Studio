// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace CopilotChat.WebApi.Storage;

/// <summary>
///     Defines the basic CRUD operations for a repository.
/// </summary>
public interface IRepository<T> where T : IStorageEntity
{
	/// <summary>
	///     Creates a new entity in the repository.
	/// </summary>
	/// <param name="entity">An entity of type T.</param>
	/// <param name="cancellationToken"></param>
	Task Create(T entity, CancellationToken cancellationToken);

	/// <summary>
	///     Deletes an entity from the repository.
	/// </summary>
	/// <param name="entity">The entity to delete.</param>
	/// <param name="cancellationToken"></param>
	Task Delete(T entity, CancellationToken cancellationToken);

	/// <summary>
	///     Upserts an entity in the repository.
	/// </summary>
	/// <param name="entity">The entity to be upserted.</param>
	/// <param name="cancellationToken"></param>
	Task Upsert(T entity, CancellationToken cancellationToken);

	/// <summary>
	///     Finds an entity by its id.
	/// </summary>
	/// <param name="id">Id of the entity.</param>
	/// <param name="partition">Partition key value of the entity.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>An entity</returns>
	Task<T> FindById(string id, string partition, CancellationToken cancellationToken);

	/// <summary>
	///     Tries to find an entity by its id.
	/// </summary>
	/// <param name="id">Id of the entity.</param>
	/// <param name="partition">Partition key value of the entity.</param>
	/// <param name="callback">The entity delegate. Note async methods don't support ref or out parameters.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>True if the entity was found, false otherwise.</returns>
	Task<bool> TryFindById(string id, string partition, Action<T?> callback, CancellationToken cancellationToken);
}
