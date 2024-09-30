// Copyright (c) Microsoft. All rights reserved.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Extensions;
using CopilotChat.WebApi.Options;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.TextGeneration;

using OpenAI;

namespace CopilotChat.WebApi.Services;

#pragma warning disable SKEXP0001
#pragma warning disable SKEXP0010
#pragma warning disable CA2000
#pragma warning disable SKEXP0070

/// <summary>
///     Extension methods for registering Semantic Kernel related services.
/// </summary>
public sealed class SemanticKernelProvider(
	IOptions<AiEmpowerLabsOptions> options,
	IServiceProvider sp,
	IEnumerable<SemanticKernelExtensions.RegisterFunctionsWithKernel> registerFunctionsWithKernel)
{
	public Kernel KernelBuilderFactory()
	{
		IKernelBuilder builder = Kernel.CreateBuilder();
		builder.Services.AddLogging();
		Func<IServiceProvider, object?, OpenAIChatCompletionService> factory = (serviceProvider, _) =>
		{
			Uri chatCompletionUri = new(options.Value.Url);
			chatCompletionUri = new Uri(chatCompletionUri, "/api/openai/v1/chat/completions");
			OpenAIClientOptions clientOptions = new();

			clientOptions.AddPolicy(new UriRewriterPipelineTransport(chatCompletionUri), PipelinePosition.BeforeTransport);
			// Uncomment to include request tracking with langfuse
			//clientOptions.AddPolicy(new CoPilotModifyingPipelineTransport(userId, chatId, tags), PipelinePosition.BeforeTransport);

			OpenAIClient h = new("NoKey", clientOptions);
			return new(options.Value.LlmModelName, h, serviceProvider.GetService<ILoggerFactory>());
		};
		builder.Services.AddKeyedSingleton<IChatCompletionService>(null, factory);
		builder.Services.AddKeyedSingleton<ITextGenerationService>(null, factory);
		Kernel kernel = builder.Build();

		foreach (SemanticKernelExtensions.RegisterFunctionsWithKernel functionsWithKernel in registerFunctionsWithKernel)
		{
			functionsWithKernel.Invoke(sp, kernel);
		}

		return kernel;
	}

	/// <summary>
	/// Add properties to chat completion requests, so that logging can occur in middleware.
	/// </summary>
	internal sealed class CoPilotModifyingPipelineTransport(string userId, string sessionId, string[] tags) : PipelinePolicy
	{
		public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
		{
			if (message.Request.Content is not null)
			{
				using MemoryStream stream = new();
				message.Request.Content.WriteTo(stream);
				stream.Seek(0, SeekOrigin.Begin);
				Dictionary<string, JsonElement>? requestBody = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(stream);
				if (requestBody is not null)
				{
					requestBody.Add("session_id", JsonDocument.Parse($"\"{sessionId}\"").RootElement);
					requestBody.Add("user_id", JsonDocument.Parse($"\"{userId}\"").RootElement);
					requestBody.Add("tags", JsonDocument.Parse(JsonSerializer.Serialize(tags)).RootElement);
					message.Request.Content = new DictionaryDataBinaryContent(requestBody);
				}
			}

			if (currentIndex < pipeline.Count - 1)
			{
				pipeline[currentIndex + 1].Process(message, pipeline, currentIndex + 1);
			}
		}

		public override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
		{
			if (message.Request.Content is not null)
			{
				using MemoryStream stream = new();
				await message.Request.Content.WriteToAsync(stream);
				stream.Seek(0, SeekOrigin.Begin);
				Dictionary<string, JsonElement>? requestBody = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(stream);
				if (requestBody is not null)
				{
					requestBody.Add("extra_body", JsonDocument.Parse(
						$$"""
						{
							"session_id": "{{sessionId}}",
							"user_id": "{{userId}}",
							"tags": {{JsonSerializer.Serialize(tags)}}
						}
						""").RootElement);
					message.Request.Content = new DictionaryDataBinaryContent(requestBody);
				}
			}

			if (currentIndex < pipeline.Count - 1)
			{
				await pipeline[currentIndex + 1].ProcessAsync(message, pipeline, currentIndex + 1);
			}
		}

		private sealed class DictionaryDataBinaryContent(Dictionary<string, JsonElement> dictionary) : System.ClientModel.BinaryContent
		{
			private readonly byte[] _bytes = JsonSerializer.SerializeToUtf8Bytes(dictionary);

			public override bool TryComputeLength(out long length)
			{
				length = _bytes.Length;
				return true;
			}

			public override void WriteTo(Stream stream, CancellationToken cancellation = default)
			{
				stream.Write(_bytes, 0, _bytes.Length);
			}

			public override async Task WriteToAsync(Stream stream, CancellationToken cancellation = default)
			{
				await stream.WriteAsync(_bytes, cancellation).ConfigureAwait(false);
			}

			public override void Dispose()
			{
			}
		}
	}

	/// <summary>
	/// Overwrite chat completion endpoint
	/// </summary>
	/// <param name="chatCompletionUri"></param>
	internal sealed class UriRewriterPipelineTransport(Uri chatCompletionUri) : PipelinePolicy
	{
		public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
		{
			message.Request.Uri = chatCompletionUri;
			if (currentIndex < pipeline.Count - 1)
			{
				pipeline[currentIndex + 1].Process(message, pipeline, currentIndex + 1);
			}
		}

		public override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
		{
			message.Request.Uri = chatCompletionUri;
			if (currentIndex < pipeline.Count - 1)
			{
				await pipeline[currentIndex + 1].ProcessAsync(message, pipeline, currentIndex + 1);
			}
		}
	}
}
