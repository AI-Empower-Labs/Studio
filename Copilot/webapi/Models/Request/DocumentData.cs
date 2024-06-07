// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Models.Request;

public sealed record DocumentData
{
    /// <summary>
    ///     Name of the uploaded document.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    ///     Size of the uploaded document in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public required string Size { get; init; }

    /// <summary>
    ///     Status of the uploaded document.
    ///     If true, the document is successfully uploaded. False otherwise.
    /// </summary>
    [JsonPropertyName("isUploaded")]
    public bool IsUploaded { get; init; }
}
