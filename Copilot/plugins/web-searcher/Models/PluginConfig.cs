﻿// Copyright (c) Microsoft. All rights reserved.

namespace Plugins.WebSearcher.Models;

/// <summary>
///     The plugin configuration.
/// </summary>
public sealed record PluginConfig
{
	/// <summary>
	///     The Bing API base URL.
	/// </summary>
	public string BingApiBaseUrl { get; init; } = "https://api.bing.microsoft.com/v7.0/search";

	/// <summary>
	///     The Bing API key.
	/// </summary>
	public string BingApiKey { get; init; } = string.Empty;
}
