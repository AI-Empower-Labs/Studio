// Copyright (c) Microsoft. All rights reserved.

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     Chat archive embedding configuration.
/// </summary>
public sealed record ChatArchiveEmbeddingConfig
{
    /// <summary>
    ///     The deployment or the model id.
    /// </summary>
    public string DeploymentOrModelId  { get; init; } = string.Empty;
}
