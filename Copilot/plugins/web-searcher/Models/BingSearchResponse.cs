// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace Plugins.WebSearcher.Models;

/// <summary>
///     Defines a webpage that is relevant to the query.
/// </summary>
internal sealed class WebPage
{
	/// <summary>
	///     The name of the webpage.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	///     The URL to the webpage.
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	///     A snippet of text from the webpage that describes its contents.
	/// </summary>
	[JsonPropertyName("snippet")]
	public string Snippet { get; set; } = string.Empty;
}

/// <summary>
///     Defines a list of relevant webpage links.
/// </summary>
internal sealed record WebPages
{
	/// <summary>
	///     A list of webpages that are relevant to the query.
	/// </summary>
	[JsonPropertyName("value")]
	public required WebPage[] Value { get; init; }
}

/// <summary>
///     The Bing's top-level object for search requests that succeed.
/// </summary>
internal sealed record BingSearchResponse
{
	/// <summary>
	///     A list of webpages that are relevant to the search query.
	/// </summary>
	[JsonPropertyName("webPages")]
	public required WebPages WebPages { get; init; }
}
