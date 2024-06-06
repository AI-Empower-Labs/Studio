// Copyright (c) Microsoft. All rights reserved.

using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Models.Storage;

/// <summary>
///     Information about a citation source.
///     This is a replica of the <see cref="Citation" /> class in Kernel Memory.
///     Creating a replica here is to avoid taking a direct dependency on Kernel Memory in our data model.
/// </summary>
public sealed record CitationSource
{
    /// <summary>
    ///     Link of the citation.
    /// </summary>
    public required string Link { get; init; }

    /// <summary>
    ///     Type of source, e.g. PDF, Word, Chat, etc.
    /// </summary>
    public required string SourceContentType { get; init; }

    /// <summary>
    ///     Name of the source, e.g. file name.
    /// </summary>
    public required string SourceName { get; init; }

    /// <summary>
    ///     The snippet of the citation.
    /// </summary>
    public required string Snippet { get; init; }

    /// <summary>
    ///     Relevance score of the citation against the query.
    /// </summary>
    public required double RelevanceScore { get; init; }

    /// <summary>
    ///     Converts a <see cref="Citation" /> to a <see cref="CitationSource" />.
    /// </summary>
    public static CitationSource FromSemanticMemoryCitation(Citation citation, string snippet, double relevanceScore)
    {
        CitationSource citationSource = new()
        {
            Link = citation.Link,
            SourceContentType = citation.SourceContentType,
            SourceName = citation.SourceName,
            Snippet = snippet,
            RelevanceScore = relevanceScore
        };

        return citationSource;
    }
}
