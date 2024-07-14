// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Plugins.Chat;

/// <summary>
///     A single entry in the chat memory.
/// </summary>
public sealed record SemanticChatMemoryItem
{
	/// <summary>
	///     Label for the chat memory item.
	/// </summary>
	[JsonPropertyName("label")]
	public required string Label { get; init; }

	/// <summary>
	///     Details for the chat memory item.
	/// </summary>
	[JsonPropertyName("details")]
	public required string Details { get; init; }

	/// <summary>
	///     Format the chat memory item as a string.
	/// </summary>
	/// <returns>A formatted string representing the item.</returns>
	public string ToFormattedString()
	{
		return $"{Label}: {Details.Trim()}";
	}
}
