// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Embeddings;

namespace CopilotChat.WebApi.Services;

#pragma warning disable SKEXP0001
#pragma warning disable SKEXP0010
#pragma warning disable CA2000
#pragma warning disable SKEXP0070

/// <summary>
///     Extension methods for registering Semantic Kernel related services.
/// </summary>
internal sealed class SemanticKernelProvider
{
	private readonly IKernelBuilder _builderChat = InitializeCompletionKernel();

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

	private static IKernelBuilder InitializeCompletionKernel()
	{
		IKernelBuilder builder = Kernel.CreateBuilder();

		builder.Services.AddLogging();


		return builder;
	}
}

/// <summary>
/// Since Microsoft.SemanticKernel does not provide a direct way to set the address of the OpenAI server,
/// Therefore, you need to customize a DelegatingHandler and change the OpenAI server address to the Local-LLM-Server address.
/// </summary>
internal sealed class RequestUriReWriterHandler(Uri rewriteUri) : DelegatingHandler(new HttpClientHandler())
{
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		request.RequestUri = rewriteUri;
		HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
		return response;
	}
}
