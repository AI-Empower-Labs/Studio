// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Text.Json.Serialization;

using CopilotChat.WebApi.Storage;

namespace CopilotChat.WebApi.Models.Storage;

/// <summary>
///     Type of the memory source.
/// </summary>
public enum MemorySourceType
{
	// A file source.
	File
}

/// <summary>
///     The external memory source.
/// </summary>
public sealed record MemorySource : IStorageEntity
{
	/// <summary>
	///     The Chat ID.
	/// </summary>
	[JsonPropertyName("chatId")]
	public required string ChatId { get; init; }

	/// <summary>
	///     The type of the source.
	/// </summary>
	[JsonConverter(typeof(JsonStringEnumConverter))]
	[JsonPropertyName("sourceType")]
	public required MemorySourceType SourceType { get; init; } = MemorySourceType.File;

	/// <summary>
	///     The name of the source.
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; init; } = string.Empty;

	/// <summary>
	///     The external link to the source.
	/// </summary>
	[JsonPropertyName("hyperlink")]
	public Uri? HyperLink { get; init; }

	/// <summary>
	///     The user ID of who shared the source.
	/// </summary>
	[JsonPropertyName("sharedBy")]
	public required string SharedBy { get; init; } = string.Empty;

	/// <summary>
	///     When the source is created in the bot.
	/// </summary>
	[JsonPropertyName("createdOn")]
	public DateTimeOffset CreatedOn { get; init; } = TimeProvider.System.GetUtcNow();

	/// <summary>
	///     The size of the source in bytes.
	/// </summary>
	[JsonPropertyName("size")]
	public required long Size { get; init; }

	/// <summary>
	///     The number of tokens in the source.
	/// </summary>
	[JsonPropertyName("tokens")]
	public long Tokens { get; init; } = 0;

	/// <summary>
	///     Source ID that is persistent and unique.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = Guid.NewGuid().ToString();

	/// <summary>
	///     The partition key for the source.
	/// </summary>
	[JsonIgnore]
	public string Partition => ChatId;
}
