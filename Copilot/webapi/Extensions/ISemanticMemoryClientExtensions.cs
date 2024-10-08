﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Extensions;

/// <summary>
///     Extension methods for <see cref="IKernelMemory" /> and service registration.
/// </summary>
internal static class SemanticMemoryClientExtensions
{
	private static readonly List<string> s_pipelineSteps =
	[
		"extract",
		"extract_audio",
		"sanitize",
		"partition",
		"gen_embeddings",
		"save_records"
	];

	/// <summary>
	///     Inject <see cref="IKernelMemory" />.
	/// </summary>
	public static void AddSemanticMemoryServices(this WebApplicationBuilder appBuilder)
	{
		appBuilder.Services
			.AddHttpClient("memoryClient")
			.AddStandardResilienceHandler();
		appBuilder.Services.AddSingleton(sp =>
		{
			IOptions<AiEmpowerLabsOptions> options = sp.GetRequiredService<IOptions<AiEmpowerLabsOptions>>();
			Uri uri = new(options.Value.Url);
			uri = new Uri(uri, "/api/kernelmemory");

			IHttpClientFactory httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
			HttpClient httpClient = httpClientFactory.CreateClient("memoryClient");

			IKernelMemory memory = new MemoryWebClient(
				uri.ToString(),
				httpClient,
				"not-needed");
			return memory;
		});
	}

	public static Task<SearchResult> SearchMemory(
		this IKernelMemory memoryClient,
		string indexName,
		string query,
		float relevanceThreshold,
		string? chatId,
		string? memoryName = null,
		CancellationToken cancellationToken = default)
	{
		return memoryClient
			.SearchMemory(indexName, query, relevanceThreshold, -1, chatId, memoryName, cancellationToken);
	}

	public static async Task<SearchResult> SearchMemory(
		this IKernelMemory memoryClient,
		string indexName,
		string query,
		float relevanceThreshold,
		int resultCount,
		string? chatId,
		string? memoryName = null,
		CancellationToken cancellationToken = default)
	{
		MemoryFilter filter = new();

		if (!string.IsNullOrEmpty(chatId))
		{
			filter.ByTag(MemoryTags.TagChatId, chatId);
		}

		if (!string.IsNullOrWhiteSpace(memoryName))
		{
			filter.ByTag(MemoryTags.TagMemory, memoryName);
		}

		SearchResult searchResult =
			await memoryClient.SearchAsync(
				query,
				indexName,
				filter,
				null,
				relevanceThreshold, // minRelevance param
				resultCount,
				null,
				cancellationToken);

		return searchResult;
	}

	public static async Task StoreDocumentAsync(
		this IKernelMemory memoryClient,
		string indexName,
		string documentId,
		string chatId,
		string memoryName,
		string fileName,
		Stream fileContent,
		CancellationToken cancellationToken = default)
	{
		DocumentUploadRequest uploadRequest =
			new()
			{
				DocumentId = documentId,
				Files = [new DocumentUploadRequest.UploadedFile(fileName, fileContent)],
				Index = indexName,
				Steps = s_pipelineSteps
			};

		uploadRequest.Tags.Add(MemoryTags.TagChatId, chatId);
		uploadRequest.Tags.Add(MemoryTags.TagMemory, memoryName);

		await memoryClient.ImportDocumentAsync(uploadRequest, cancellationToken: cancellationToken);
	}

	public static Task StoreMemory(
		this IKernelMemory memoryClient,
		string indexName,
		string chatId,
		string memoryName,
		string memory,
		CancellationToken cancellationToken = default)
	{
		return memoryClient.StoreMemory(indexName, chatId, memoryName, Guid.NewGuid().ToString(), memory, cancellationToken);
	}

	private static async Task StoreMemory(
		this IKernelMemory memoryClient,
		string indexName,
		string chatId,
		string memoryName,
		string memoryId,
		string memory,
		CancellationToken cancellationToken = default)
	{
		using MemoryStream stream = new();
		await using StreamWriter writer = new(stream);
		await writer.WriteAsync(memory);
		await writer.FlushAsync(cancellationToken);
		stream.Position = 0;

		DocumentUploadRequest uploadRequest = new()
		{
			DocumentId = memoryId,
			Index = indexName,
			Files = [new DocumentUploadRequest.UploadedFile("memory.txt", stream)],
			Steps = s_pipelineSteps
		};

		uploadRequest.Tags.Add(MemoryTags.TagChatId, chatId);
		uploadRequest.Tags.Add(MemoryTags.TagMemory, memoryName);

		await memoryClient.ImportDocumentAsync(uploadRequest, cancellationToken: cancellationToken);
	}

	public static async Task RemoveChatMemories(
		this IKernelMemory memoryClient,
		string indexName,
		string chatId,
		CancellationToken cancellationToken = default)
	{
		SearchResult memories = await memoryClient
			.SearchMemory(indexName, "*", 0.0F, chatId, cancellationToken: cancellationToken);
		string[] documentIds = memories.Results.Select(memory => memory.Link.Split('/').First()).Distinct().ToArray();
		Task[] tasks = documentIds
			.Select(documentId => memoryClient.DeleteDocumentAsync(documentId, indexName, cancellationToken)).ToArray();

		Task.WaitAll(tasks, cancellationToken);
	}
}
