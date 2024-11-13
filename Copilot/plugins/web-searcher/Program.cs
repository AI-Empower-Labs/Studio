// Copyright (c) Microsoft. All rights reserved.

using System.ComponentModel;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Plugins.PluginShared;
using Plugins.WebSearcher;
using Plugins.WebSearcher.Models;

using Scalar.AspNetCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets<Program>(true);
builder.Services.Configure<JsonSerializerOptions>(options => options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);
builder.Services.AddOpenApi(options =>
{
	options.AddDocumentTransformer((document, _, _) =>
	{
		document.Info.Title = "Copilot Email Sender using SMTP";
		document.Info.Description = "Copilot Email Sender using SMTP";
		document.Info.Version = "v1";
		return Task.CompletedTask;
	});
	options.AddOperationTransformer<DescriptionEnrichmentOpenApiSchemaTransformer>();
});
builder.Services.Configure<PluginConfig>(builder.Configuration.GetSection(nameof(PluginConfig)));
using WebApplication app = builder.Build();
app.MapOpenApi();
app.MapScalarApiReference();
app.MapGet("/.well-known/ai-plugin.json", PluginEndpoint.WellKnownAiPluginManifest).ExcludeFromDescription();
app.MapGet("/.well-known/icon", PluginEndpoint.Icon).ExcludeFromDescription();
app.MapGet("/get", (
			[FromServices] IOptions<PluginConfig> config,
			[FromServices] ILogger<PluginEndpoint> logger,
			HttpContext httpContext,
			[FromQuery(Name = "query"), Description("The search query string")]
			string query,
			[FromQuery(Name = "numResults"), Description("The number of results to return. Optional")]
			int numResults = 10,
			[FromQuery(Name = "site"), Description("The site to filter search results. Optional")]
			string? site = null,
			[FromQuery(Name = "offset"), Description("The offset for the results. Optional")]
			int? offset = 0,
			CancellationToken cancellationToken = default) =>
		PluginEndpoint.WebSearch(httpContext, query, numResults, offset ?? 0, site, config.Value, logger, cancellationToken))
	.WithName("Search")
	.WithDisplayName("Web Search")
	.WithTags("Search")
	.WithDescription("Endpoint to perform web search based on the provided query, with options for result count, site filtering, and offset")
	.WithSummary("Searches the web for the given query")
	.Produces<string>(contentType: "text/plain");
app.Run();
