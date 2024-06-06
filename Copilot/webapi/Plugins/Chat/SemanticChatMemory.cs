// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Plugins.Chat;

/// <summary>
///     A collection of semantic chat memory.
/// </summary>
public sealed record SemanticChatMemory
{
	/// <summary>
	///     The chat memory items.
	/// </summary>
	[JsonPropertyName("items")]
	public ICollection<SemanticChatMemoryItem> Items { get; } = [];

	/// <summary>
	///     Create and add a chat memory item.
	/// </summary>
	/// <param name="label">Label for the chat memory item.</param>
	/// <param name="details">Details for the chat memory item.</param>
	public void AddItem(string label, string details)
	{
		Items.Add(new SemanticChatMemoryItem
		{
			Label = label,
			Details = details
		});
	}

	/// <summary>
	///     Serialize the chat memory to a Json string.
	/// </summary>
	/// <returns>A Json string representing the chat memory.</returns>
	public override string ToString()
	{
		return JsonSerializer.Serialize(this);
	}

	/// <summary>
	///     Create a semantic chat memory from a Json string.
	/// </summary>
	/// <param name="json">Json string to deserialize.</param>
	/// <returns>A semantic chat memory.</returns>
	public static SemanticChatMemory FromJson(string json)
	{
		SemanticChatMemory? result = JsonSerializer.Deserialize<SemanticChatMemory>(json);
		return result ?? throw new ArgumentException("Failed to deserialize chat memory to json.");
	}
}
