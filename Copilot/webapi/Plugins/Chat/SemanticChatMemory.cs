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
		SemanticChatMemory? result = PowerParseJson<SemanticChatMemory>(json);
		return result ?? throw new ArgumentException("Failed to deserialize chat memory to json.");
	}

	/// <summary>
	/// Source: https://github.com/mehrandvd/SemanticValidation
	/// Parses <paramref name="text"/> to JSON in a more tolerant way suitable
	/// for OpenAI results.
	/// Sometimes even the prompt dictated to return a JSON, but OpenAI returns it
	/// with some additional characters like a heading and tailing ```, or even a starting ```json.
	/// This method tries its best to parse these texts to a JSON.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="text"></param>
	/// <returns></returns>
	public static T? PowerParseJson<T>(string text)
	{
		string trim = text.Trim(' ', '"', '\'', '`');

		int firstBrace = trim.IndexOfAny(['{', '[']);
		int lastBrace = trim.LastIndexOfAny(['}', ']']) + 1;

		string clear = trim[firstBrace..lastBrace];
		T? json = JsonSerializer.Deserialize<T>(clear, s_powerParseJsonSerializerOptions);

		return json;
	}

	private static readonly JsonSerializerOptions s_powerParseJsonSerializerOptions = new()
	{
		AllowTrailingCommas = true
	};
}
