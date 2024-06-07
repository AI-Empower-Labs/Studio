// Copyright (c) Microsoft. All rights reserved.

namespace CopilotChat.WebApi.Options;

/// <summary>
///     Configuration options to be relayed to the frontend.
/// </summary>
public sealed record FrontendOptions
{
    public const string PropertyName = "Frontend";

    /// <summary>
    ///     Client ID for the frontend
    /// </summary>
    public required string AadClientId { get; init; }
}
