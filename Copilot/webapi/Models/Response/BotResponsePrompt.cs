// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     The final prompt sent to generate bot response.
/// </summary>
public sealed record BotResponsePrompt
{
	/// <summary>
	///     The system persona of the chat, includes SystemDescription and SystemResponse components from PromptsOptions.cs.
	/// </summary>
	[JsonPropertyName("systemPersona")]
	public required string SystemPersona { get; init; }

	/// <summary>
	///     Audience extracted from conversation history.
	/// </summary>
	[JsonPropertyName("audience")]
	public required string Audience { get; init; }

	/// <summary>
	///     User intent extracted from input and conversation history.
	/// </summary>
	[JsonPropertyName("userIntent")]
	public required string UserIntent { get; init; }

	/// <summary>
	///     Chat memories queried from the chat memory store if any, includes long term and working memory.
	/// </summary>
	[JsonPropertyName("chatMemories")]
	public required string ChatMemories { get; init; }

	/// <summary>
	///     Most recent messages from chat history.
	/// </summary>
	[JsonPropertyName("chatHistory")]
	public required string ChatHistory { get; init; }

	/// <summary>
	///     The collection of context messages associated with this chat completions request.
	///     See
	///     https://learn.microsoft.com/en-us/dotnet/api/azure.ai.openai.chatcompletionsoptions.messages?view=azure-dotnet-preview#azure-ai-openai-chatcompletionsoptions-messages.
	/// </summary>
	[JsonPropertyName("metaPromptTemplate")]
	[JsonConverter(typeof(ChatHistoryJsonConverter))]
	public required ChatHistory MetaPromptTemplate { get; init; }
}

internal sealed class ChatHistoryJsonConverter : JsonConverter<ChatHistory>
{
	public override ChatHistory? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		throw new NotImplementedException();
	}

	public override void Write(Utf8JsonWriter writer, ChatHistory value, JsonSerializerOptions options)
	{
		writer.WriteStartArray();
		foreach (ChatMessageContent content in value)
		{
			writer.WriteStartObject();

			writer.WriteString("Content", content.Content);
			writer.WritePropertyName("Role");
			JsonSerializer.Serialize(writer, content.Role);

			writer.WriteEndObject();
		}

		writer.WriteEndArray();
	}
}
