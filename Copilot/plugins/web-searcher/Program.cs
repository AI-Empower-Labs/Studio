// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Plugins.WebSearcher;
using Plugins.WebSearcher.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets<Program>(true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo {Title = "Copilot Web Search", Version = "v1" });
});
builder.Services.Configure<JsonSerializerOptions>(options => options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);
builder.Services.Configure<PluginConfig>(builder.Configuration.GetSection(nameof(PluginConfig)));
using WebApplication app = builder.Build();
app.UseSwagger();
app.MapGet("/.well-known/ai-plugin.json", PluginEndpoint.WellKnownAiPluginManifest).ExcludeFromDescription();
app.MapGet("/.well-known/icon", PluginEndpoint.Icon).ExcludeFromDescription();
app.MapGet("/get", (
			[FromServices] IOptions<PluginConfig> config,
			[FromServices] ILogger<PluginEndpoint> logger,
			HttpContext httpContext,
			[FromQuery(Name = "query")] string query,
			[FromQuery(Name = "numResults")] int numResults = 10,
			[FromQuery(Name = "site")] string? site = null,
			[FromQuery(Name = "offset")] int? offset = 0) =>
		PluginEndpoint.WebSearch(httpContext, query, numResults, offset ?? 0, site, config.Value, logger))
	.WithName("Search")
	.WithOpenApi(operation =>
	{
		operation.Summary = "Searches the web for the given query.";
		operation.Description = "Endpoint to perform web search based on the provided query, with options for result count, site filtering, and offset.";
		operation.Parameters[0].Description = "The search query string.";
		operation.Parameters[1].Description = "The number of results to return. Optional.";
		operation.Parameters[2].Description = "The site to filter search results. Optional.";
		operation.Parameters[3].Description = "The offset for the results. Optional.";
		return operation;
	});
app.Run();
