﻿// Copyright (c) Microsoft. All rights reserved.

namespace CopilotChat.WebApi.Storage;

public interface IStorageEntity
{
	/// <summary>
	///     Unique ID of the entity.
	/// </summary>
	string Id { get; init; }

	/// <summary>
	///     Partition key value.
	/// </summary>
	string Partition { get; }
}
