// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Net.Http;
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
			Uri uri = new(options.Value.Url);
			uri = new Uri(uri, "/api/openai/v1/chat/completions");
			return new(options.Value.LlmModelName,
				"NoKey",
				null,
				new HttpClient(new RequestUriReWriterHandler(uri)),
				sp.GetService<ILoggerFactory>());
		};
		builder.Services.AddKeyedSingleton<IChatCompletionService>(null, factory);
		builder.Services.AddKeyedSingleton<ITextGenerationService>(null, factory);

		return builder;
	}
}

/// <summary>
/// Since Microsoft.SemanticKernel does not provide a direct way to set the address of the OpenAI server,
/// Therefore, you need to customize a DelegatingHandler and change the OpenAI server address to the Local-LLM-Server address.
/// </summary>
internal sealed class RequestUriReWriterHandler(Uri rewriteUri) : DelegatingHandler(new HttpClientHandler())
{
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		request.RequestUri = rewriteUri;
		HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
		return response;
	}
}
