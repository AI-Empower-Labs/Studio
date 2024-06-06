// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Text.Json.Serialization;

using CopilotChat.WebApi.Storage;

namespace CopilotChat.WebApi.Models.Storage;

/// <summary>
///     A chat participant is a user that is part of a chat.
///     A user can be part of multiple chats, thus a user can have multiple chat participants.
/// </summary>
public sealed record ChatParticipant : IStorageEntity
{
	/// <summary>
	///     User ID that is persistent and unique.
	/// </summary>
	public required string UserId { get; init; }

	/// <summary>
	///     Chat ID that this participant belongs to.
	/// </summary>
	public required string ChatId { get; init; }

	/// <summary>
	///     Participant ID that is persistent and unique.
	/// </summary>
	public string Id { get; init; } = Guid.NewGuid().ToString();

	/// <summary>
	///     The partition key for the source.
	/// </summary>
	[JsonIgnore]
	public string Partition => UserId;
}
