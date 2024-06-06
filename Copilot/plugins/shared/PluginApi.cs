// Copyright (c) Microsoft. All rights reserved.

namespace Plugins.PluginShared;

/// <summary>
///     This class represents the plugin API specification.
/// </summary>
public sealed class PluginApi
{
    /// <summary>
    ///     The API specification
    /// </summary>
    public string Type { get; init; } = "openapi";

    /// <summary>
    ///     URL used to fetch the specification
    /// </summary>
    public string Url { get; init; } = string.Empty;
}
