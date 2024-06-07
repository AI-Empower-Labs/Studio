// Copyright (c) Microsoft. All rights reserved.

using System.ComponentModel.DataAnnotations;

namespace CopilotChat.WebApi.Options;

/// <summary>
///     Configuration options for the Chat Copilot service.
/// </summary>
public sealed record ServiceOptions
{
    public const string PropertyName = "Service";

    /// <summary>
    ///     Timeout limit on requests to the service in seconds.
    /// </summary>
    [Range(0, int.MaxValue)]
    public double? TimeoutLimitInS { get; init; }

    /// <summary>
    ///     Configuration Key Vault URI
    /// </summary>
    [Url]
    public string? KeyVault { get; init; }

    /// <summary>
    ///     Local directory from which to load semantic plugins.
    /// </summary>
    public string? SemanticPluginsDirectory { get; init; }

    /// <summary>
    ///     Local directory from which to load native plugins.
    /// </summary>
    public string? NativePluginsDirectory { get; init; }

    /// <summary>
    ///     Setting indicating if the site is undergoing maintenance.
    /// </summary>
    public bool InMaintenance { get; init; }
}
