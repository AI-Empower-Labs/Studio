// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using CopilotChat.WebApi.Storage;

namespace CopilotChat.WebApi.Models.Storage;

/// <summary>
///     A chat session
/// </summary>
public sealed record ChatSession : IStorageEntity
{
	private const string CurrentVersion = "2.0";

	/// <summary>
	///     Title of the chat.
	/// </summary>
	public required string Title { get; init; }

	/// <summary>
	///     Timestamp of the chat creation.
	/// </summary>
	public DateTimeOffset CreatedOn { get; init; } = TimeProvider.System.GetUtcNow();

	/// <summary>
	///     System description of the chat that is used to generate responses.
	/// </summary>
	public required string SystemDescription { get; init; }

	/// <summary>
	///     Fixed system description with "TimeSkill" replaced by "TimePlugin"
	/// </summary>
	public string SafeSystemDescription =>
		SystemDescription.Replace("TimeSkill", "TimePlugin", StringComparison.OrdinalIgnoreCase);

	/// <summary>
	///     The balance between long term memory and working term memory.
	///     The higher this value, the more the system will rely on long term memory by lowering
	///     the relevance threshold of long term memory and increasing the threshold score of working memory.
	/// </summary>
	public float MemoryBalance { get; init; } = 0.5F;

	/// <summary>
	///     A list of enabled plugins.
	/// </summary>
	public HashSet<string> EnabledPlugins { get; set; } = [];

	/// <summary>
	///     Used to determine if the current chat requires upgrade.
	/// </summary>
	public string? Version { get; init; } = CurrentVersion;

	/// <summary>
	///     Chat ID that is persistent and unique.
	/// </summary>
	public string Id { get; init; } = Guid.NewGuid().ToString();

	/// <summary>
	///     The partition key for the session.
	/// </summary>
	[JsonIgnore]
	public string Partition => Id;
}
