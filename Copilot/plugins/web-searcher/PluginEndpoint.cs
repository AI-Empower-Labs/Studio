// Copyright (c) Microsoft. All rights reserved.

using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;

using Plugins.PluginShared;
using Plugins.WebSearcher.Models;

using Uri = System.Uri;

namespace Plugins.WebSearcher;

/// <summary>
///     Plugin endpoints
/// </summary>
public sealed class PluginEndpoint
{
	/// <summary>
	///     Gets the plugin manifest.
	/// </summary>
	/// <returns>The manifest in Json</returns>
	public static IResult WellKnownAiPluginManifest(HttpContext httpContext)
	{
		HttpRequest req = httpContext.Request;
		Uri reqUrl = new(req.GetDisplayUrl());
		PluginManifest pluginManifest = new()
		{
			NameForModel = "WebSearcher",
			NameForHuman = "WebSearcher",
			DescriptionForModel = "Searches the web",
			DescriptionForHuman = "Searches the web",
			ContactEmail = "support@aiempowerlabs.com",
			Auth = new PluginAuth
			{
				Type = "none"
			},
			Api = new PluginApi
			{
				Type = "openapi",
				Url = $"{reqUrl.Scheme}://{reqUrl.Host}:{reqUrl.Port}/openapi/v1.json"
			},
			LogoUrl = $"{reqUrl.Scheme}://{reqUrl.Host}:{reqUrl.Port}/.well-known/icon"
		};

		return Results.Ok(pluginManifest);
	}

	/// <summary>
	///     Gets the plugin's icon.
	/// </summary>
	/// <returns>The icon.</returns>
	public static IResult Icon()
	{
		if (!File.Exists("./Icons/bing.png"))
		{
			return Results.NotFound();
		}

#pragma warning disable CA2000
		FileStream stream = File.OpenRead("./Icons/bing.png");
		return Results.Stream(stream, "image/png");
	}

	/// <summary>
	///     Search the web for the given query.
	/// </summary>
	/// <returns>A string representing the search result.</returns>
	public static async Task<IResult> WebSearch(
		HttpContext httpContext,
		string query,
		int numResults,
		int offset,
		string? site,
		PluginConfig config,
		ILogger<PluginEndpoint> logger,
		CancellationToken cancellationToken)
	{
		if (string.IsNullOrWhiteSpace(query))
		{
			return Results.BadRequest("Empty query");
		}

		if (numResults <= 0)
		{
			return Results.BadRequest("Invalid number of results");
		}

		if (string.IsNullOrWhiteSpace(site))
		{
			logger.LogDebug("Searching the web for '{Query}'", query);
		}
		else
		{
			logger.LogDebug("Searching the web for '{Query}' within '{Site}'", query, site);
		}

		using HttpClient httpClient = new();
		string queryString = $"?q={Uri.EscapeDataString(query)}";
		queryString += string.IsNullOrWhiteSpace(site) ? string.Empty : $"+site:{site}";
		queryString += $"&count={numResults}";
		queryString += $"&offset={offset}";

		Uri uri = new($"{config.BingApiBaseUrl}{queryString}");
		logger.LogDebug("Sending request to {Url}", uri);

		httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", config.BingApiKey);

		string bingResponse = await httpClient.GetStringAsync(uri, cancellationToken);

		logger.LogDebug("Search completed. Response: {BingResponse}", bingResponse);

		BingSearchResponse? data = JsonSerializer.Deserialize<BingSearchResponse>(bingResponse);
		WebPage[]? results = data?.WebPages.Value;

		string responseText = results == null
			? "No results found."
			: string.Join(",",
				results.Select(r =>
					$"[NAME]{r.Name}[END NAME] [URL]{r.Url}[END URL] [SNIPPET]{r.Snippet}[END SNIPPET]"));

		return Results.Text(responseText);
	}
}
