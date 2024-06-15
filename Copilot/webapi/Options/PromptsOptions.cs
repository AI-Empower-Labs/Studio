// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CopilotChat.WebApi.Models.Request;

namespace CopilotChat.WebApi.Options;

/// <summary>
///     Configuration options for the chat
/// </summary>
public sealed record PromptsOptions
{
    public const string PropertyName = "Prompts";

    /// <summary>
    ///     Token limit of the chat model.
    /// </summary>
    /// <remarks>https://platform.openai.com/docs/models/overview for token limits.</remarks>
    [Required]
    [Range(0, int.MaxValue)]
    public int CompletionTokenLimit { get; init; }

    /// <summary>
    ///     The token count left for the model to generate text after the prompt.
    /// </summary>
    [Required]
    [Range(0, int.MaxValue)]
    public int ResponseTokenLimit { get; init; }

    /// <summary>
    ///     The token count allowed for function calling responses.
    /// </summary>
    [Required]
    [Range(0, int.MaxValue)]
    public int FunctionCallingTokenLimit { get; init; }

    /// <summary>
    ///     Weight of memories in the contextual part of the final prompt.
    ///     Contextual prompt excludes all the system commands and user intent.
    /// </summary>
    internal double MemoriesResponseContextWeight { get; } = 0.6;

    /// <summary>
    ///     Upper bound of the relevancy score of a kernel memory to be included in the final prompt.
    ///     The actual relevancy score is determined by the memory balance.
    /// </summary>
    internal float SemanticMemoryRelevanceUpper { get; } = 0.9F;

    /// <summary>
    ///     Lower bound of the relevancy score of a kernel memory to be included in the final prompt.
    ///     The actual relevancy score is determined by the memory balance.
    /// </summary>
    internal float SemanticMemoryRelevanceLower { get; } = 0.6F;

    /// <summary>
    ///     Minimum relevance of a document memory to be included in the final prompt.
    ///     The higher the value, the answer will be more relevant to the user intent.
    /// </summary>
    internal float DocumentMemoryMinRelevance { get; } = 0.8F;

    // System
    [Required] [NotEmptyOrWhitespace] public string KnowledgeCutoffDate { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string InitialBotMessage { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string SystemDescription { get; set; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string SystemResponse { get; init; } = string.Empty;

    internal string[] SystemAudiencePromptComponents =>
    [
        SystemAudience,
        "{{ChatPlugin.ExtractChatHistory}}",
        SystemAudienceContinuation
    ];

    internal string SystemAudienceExtraction => string.Join("\n", SystemAudiencePromptComponents);

    internal string[] SystemIntentPromptComponents =>
    [
        SystemDescription,
        SystemIntent,
        "{{ChatPlugin.ExtractChatHistory}}",
        SystemIntentContinuation
    ];

    internal string SystemIntentExtraction => string.Join("\n", SystemIntentPromptComponents);

    // Intent extraction
    [Required] [NotEmptyOrWhitespace] public string SystemIntent { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string SystemIntentContinuation { get; init; } = string.Empty;

    // Audience extraction
    [Required] [NotEmptyOrWhitespace] public string SystemAudience { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string SystemAudienceContinuation { get; init; } = string.Empty;

    // Memory storage
    [Required] [NotEmptyOrWhitespace] public string MemoryIndexName { get; init; } = string.Empty;

    public ICollection<AdditionalIndex> AdditionalIndexesToSearch { get; init; } = [];

    // Document memory
    [Required] [NotEmptyOrWhitespace] public string DocumentMemoryName { get; init; } = string.Empty;

    // Memory extraction
    [Required] [NotEmptyOrWhitespace] public string SystemCognitive { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string MemoryFormat { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string MemoryAntiHallucination { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string MemoryContinuation { get; init; } = string.Empty;

    // Long-term memory
    [Required] [NotEmptyOrWhitespace] public string LongTermMemoryName { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string LongTermMemoryExtraction { get; init; } = string.Empty;

    internal string[] LongTermMemoryPromptComponents =>
    [
        SystemCognitive,
        $"{LongTermMemoryName} Description:\n{LongTermMemoryExtraction}",
        MemoryAntiHallucination,
        $"Chat Description:\n{SystemDescription}",
        "{{ChatPlugin.ExtractChatHistory}}",
        MemoryContinuation
    ];

    internal string LongTermMemory => string.Join("\n", LongTermMemoryPromptComponents);

    // Working memory
    [Required] [NotEmptyOrWhitespace] public string WorkingMemoryName { get; init; } = string.Empty;
    [Required] [NotEmptyOrWhitespace] public string WorkingMemoryExtraction { get; init; } = string.Empty;

    internal string[] WorkingMemoryPromptComponents =>
    [
        SystemCognitive,
        $"{WorkingMemoryName} Description:\n{WorkingMemoryExtraction}",
        MemoryAntiHallucination,
        $"Chat Description:\n{SystemDescription}",
        "{{ChatPlugin.ExtractChatHistory}}",
        MemoryContinuation
    ];

    internal string WorkingMemory => string.Join("\n", WorkingMemoryPromptComponents);

    // Memory map
    internal IDictionary<string, string> MemoryMap => new Dictionary<string, string>
    {
        { LongTermMemoryName, LongTermMemory },
        { WorkingMemoryName, WorkingMemory }
    };

    // Chat commands
    internal string[] SystemPersonaComponents =>
    [
        SystemDescription,
        SystemResponse
    ];

    internal string SystemPersona => string.Join("\n\n", SystemPersonaComponents);

    internal double ResponseTemperature { get; } = 0.7;
    internal double ResponseTopP { get; } = 1;
    internal double ResponsePresencePenalty { get; } = 0.5;
    internal double ResponseFrequencyPenalty { get; } = 0.5;

    internal double IntentTemperature { get; } = 0.7;
    internal double IntentTopP { get; } = 1;
    internal double IntentPresencePenalty { get; } = 0.5;
    internal double IntentFrequencyPenalty { get; } = 0.5;

    /// <summary>
    ///     Copy the options in case they need to be modified per chat.
    /// </summary>
    /// <returns>A shallow copy of the options.</returns>
    internal PromptsOptions Copy()
    {
        return (PromptsOptions)MemberwiseClone();
    }

    /// <summary>
    ///     Tries to retrieve the memoryContainerName associated with the specified memory type.
    /// </summary>
    internal bool TryGetMemoryContainerName(string memoryType, out string memoryContainerName)
    {
        memoryContainerName = string.Empty;
        if (!Enum.TryParse(memoryType, true, out SemanticMemoryType semanticMemoryType))
        {
            return false;
        }

        switch (semanticMemoryType)
        {
            case SemanticMemoryType.LongTermMemory:
                memoryContainerName = LongTermMemoryName;
                return true;

            case SemanticMemoryType.WorkingMemory:
                memoryContainerName = WorkingMemoryName;
                return true;

            default: return false;
        }
    }
}

public sealed record AdditionalIndex(
	[property: Required, NotEmptyOrWhitespace] string Name,
	[property: Required, Range(0f, 1f)] float RelevanceThreshold);
