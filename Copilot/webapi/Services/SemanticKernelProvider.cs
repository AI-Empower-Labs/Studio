// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Options;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.TextGeneration;

namespace CopilotChat.WebApi.Services;

#pragma warning disable SKEXP0001
#pragma warning disable SKEXP0010
#pragma warning disable CA2000
#pragma warning disable SKEXP0070

/// <summary>
///     Extension methods for registering Semantic Kernel related services.
/// </summary>
internal sealed class SemanticKernelProvider(IOptions<AiEmpowerLabsOptions> options)
{
	private readonly IKernelBuilder _builderChat = InitializeCompletionKernel(options);

	/// <summary>
	///     Produce semantic-kernel with only completion services for chat.
	/// </summary>
	public Kernel GetCompletionKernel()
	{
		lock (_builderChat)
		{
			return _builderChat.Build();
		}
	}

	private static IKernelBuilder InitializeCompletionKernel(IOptions<AiEmpowerLabsOptions> options)
	{
		IKernelBuilder builder = Kernel.CreateBuilder();
		builder.Services.AddLogging();
		Func<IServiceProvider, object?, OpenAIChatCompletionService> factory = (sp, _) =>
		{
			Uri chatCompletionUri = new(options.Value.Url);
			chatCompletionUri = new Uri(chatCompletionUri, "/api/openai/v1/chat/completions");

			HttpClientHandler httpMessageHandler = new();
			RewriterHandler rewriterHandler = new(httpMessageHandler, sp.GetRequiredService<ILogger<RewriterHandler>>());

			return new(options.Value.LlmModelName,
				chatCompletionUri,
				"NoKey",
				null,
				new HttpClient(rewriterHandler),
				sp.GetService<ILoggerFactory>());
		};
		builder.Services.AddKeyedSingleton<IChatCompletionService>(null, factory);
		builder.Services.AddKeyedSingleton<ITextGenerationService>(null, factory);

		return builder;
	}
}

/// <summary>
/// Extract data_sources property from request and convert it to metadata property
/// </summary>
/// <param name="httpMessageHandler"></param>
/// <param name="logger"></param>
internal sealed class RewriterHandler(
	HttpMessageHandler httpMessageHandler,
	ILogger<RewriterHandler> logger) : DelegatingHandler(httpMessageHandler)
{
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (request.Content is null)
		{
			return await base.SendAsync(request, cancellationToken);
		}

		string requestBodyString = await request.Content.ReadAsStringAsync(cancellationToken);
		Dictionary<string, JsonElement>? requestBody = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(requestBodyString);
		if (requestBody is not null
			&& requestBody.Remove("data_sources", out JsonElement dataSourcesJsonElement))
		{
			JsonElement[]? dataSourcesArray = dataSourcesJsonElement.Deserialize<JsonElement[]>();
			if (dataSourcesArray is not null && dataSourcesArray.Length == 1)
			{
				Dictionary<string, JsonNode>? firstItemDataSources = dataSourcesArray[0].Deserialize<Dictionary<string, JsonNode>>();
				if (firstItemDataSources is not null)
				{
					JsonObject doc = new();
					foreach (KeyValuePair<string, JsonNode> pair in firstItemDataSources)
					{
						doc[pair.Key] = pair.Value;
					}

					requestBody.Add("metadata", doc.Deserialize<JsonElement>());
					using JsonContent requestContent = JsonContent.Create(requestBody);
					request.Content = requestContent;
					return await base.SendAsync(request, cancellationToken);
				}
			}
		}

		logger.LogError("Could not extract langfuse metadata");

		return await base.SendAsync(request, cancellationToken);
	}
}
