// Copyright (c) Microsoft. All rights reserved.

using System;

namespace CopilotChat.WebApi.Options;

/// <summary>
///     Option for a single plugin.
/// </summary>
public sealed record Plugin
{
    /// <summary>
    ///     The name of the plugin.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    ///     The url of the plugin.
    /// </summary>
    public required Uri ManifestDomain { get; init; } = new("http://localhost");

    /// <summary>
    ///     The key of the plugin.
    /// </summary>
    public  required string Key { get; init; }
}
