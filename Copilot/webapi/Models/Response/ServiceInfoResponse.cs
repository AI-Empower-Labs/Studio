// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Text.Json.Serialization;
using CopilotChat.WebApi.Options;

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     Information on running service.
/// </summary>
public sealed record ServiceInfoResponse
{
    /// <summary>
    ///     Configured memory store.
    /// </summary>
    [JsonPropertyName("memoryStore")]
    public MemoryStoreInfoResponse MemoryStore  { get; init; } = new();

    /// <summary>
    ///     All the available plugins.
    /// </summary>
    [JsonPropertyName("availablePlugins")]
    public IEnumerable<Plugin> AvailablePlugins  { get; init; } = [];

    /// <summary>
    ///     Version of this application.
    /// </summary>
    [JsonPropertyName("version")]
    public string Version  { get; init; } = string.Empty;
}

/// <summary>
///     Response to memoryStoreType request.
/// </summary>
public sealed class MemoryStoreInfoResponse
{
    /// <summary>
    ///     All the available memory store types.
    /// </summary>
    [JsonPropertyName("types")]
    public IEnumerable<string> Types  { get; init; } = [];

    /// <summary>
    ///     The selected memory store type.
    /// </summary>
    [JsonPropertyName("selectedType")]
    public string SelectedType  { get; init; } = string.Empty;
}
