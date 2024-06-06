// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;
using CopilotChat.WebApi.Models.Storage;

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     Response object definition to the 'chats' POST request.
///     This groups the initial bot message with the chat session
///     to avoid making two requests.
/// </summary>
public sealed record CreateChatResponse
{
    /// <summary>
    ///     The chat session that was created.
    /// </summary>
    [JsonPropertyName("chatSession")]
    public required ChatSession ChatSession  { get; init; }

    /// <summary>
    ///     Initial bot message.
    /// </summary>
    [JsonPropertyName("initialBotMessage")]
    public required CopilotChatMessage InitialBotMessage  { get; init; }
}
