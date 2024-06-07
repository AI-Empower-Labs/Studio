// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     The data model of a chat archive.
/// </summary>
public sealed record ChatArchive
{
    /// <summary>
    ///     Schema information for the chat archive.
    /// </summary>
    public ChatArchiveSchemaInfo Schema { get; init; } = new();

    /// <summary>
    ///     The embedding configurations.
    /// </summary>
    public ChatArchiveEmbeddingConfig EmbeddingConfigurations { get; init; } = new();

    /// <summary>
    ///     Chat title.
    /// </summary>
    public string ChatTitle { get; init; } = string.Empty;

    /// <summary>
    ///     The system description of the chat that is used to generate responses.
    /// </summary>
    public string SystemDescription { get; init; } = string.Empty;

	/// <summary>
	///     The chat history. It contains all the messages in the conversation with the bot.
	/// </summary>
	public ICollection<CopilotChatMessage> ChatHistory { get; init; } = [];

    /// <summary>
    ///     Chat archive's embeddings.
    /// </summary>
    public Dictionary<string, List<Citation>> Embeddings { get; init; } = new();

    /// <summary>
    ///     The embeddings of uploaded documents in Chat Copilot. It represents the document memory which is accessible to all
    ///     chat sessions of a given user.
    /// </summary>
    public Dictionary<string, List<Citation>> DocumentEmbeddings { get; init; } = new();
}
