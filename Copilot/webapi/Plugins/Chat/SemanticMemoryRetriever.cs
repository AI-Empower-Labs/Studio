// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CopilotChat.WebApi.Extensions;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Plugins.Utils;
using CopilotChat.WebApi.Storage;

using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Plugins.Chat;

/// <summary>
///     This class provides the functions to query kernel memory.
/// </summary>
public sealed class SemanticMemoryRetriever(
	IOptions<PromptsOptions> promptOptions,
	ChatSessionRepository chatSessionRepository,
	IKernelMemory memoryClient)
{
	private readonly List<string> _memoryNames =
	[
		promptOptions.Value.DocumentMemoryName,
		promptOptions.Value.LongTermMemoryName,
		promptOptions.Value.WorkingMemoryName
	];

	/// <summary>
	///     Query relevant memories based on the query.
	/// </summary>
	/// <returns>A string containing the relevant memories.</returns>
	public async Task<(string, IDictionary<string, CitationSource>)> QueryMemories(
		[Description("Query to match.")] string query,
		[Description("Chat ID to query history from")]
		string chatId,
		[Description("Maximum number of tokens")]
		int tokenLimit)
	{
		ChatSession? chatSession = null;
		if (!await chatSessionRepository.TryFindById(chatId, callback: v => chatSession = v))
		{
			throw new ArgumentException($"Chat session {chatId} not found.");
		}

		int remainingToken = tokenLimit;

		// Search for relevant memories.
		List<(string IndexName, Citation Citation, Citation.Partition Memory)> relevantMemories = new();
		List<Task> tasks = _memoryNames
			.Select(memoryName => SearchMemoryAsync(memoryName))
			.ToList();

		// Global document memory.
		tasks.Add(SearchMemoryAsync(promptOptions.Value.DocumentMemoryName, true));
		tasks.Add(SearchAdditionalIndexMemory(promptOptions.Value));
		// Wait for all tasks to complete.
		await Task.WhenAll(tasks);

		StringBuilder builderMemory = new();
		IDictionary<string, CitationSource> citationMap =
			new Dictionary<string, CitationSource>(StringComparer.OrdinalIgnoreCase);

		if (relevantMemories.Count > 0)
		{
			(IDictionary<string, List<(string, CitationSource)>> memoryMap, citationMap) = ProcessMemories();

			// Format long term and working memories.
			string[] memoryNames = [..promptOptions.Value.MemoryMap.Keys, ..promptOptions.Value.AdditionalIndexesToSearch.Select(index => index.Name)];
			List<(string, CitationSource)>? memories;
			foreach (string memoryName in memoryNames)
			{
				if (memoryMap.TryGetValue(memoryName, out memories))
				{
					foreach ((string memoryContent, _) in memories)
					{
						if (builderMemory.Length == 0)
						{
							builderMemory.Append("Past memories (format: [memory type] <label>: <details>):\n");
						}

						string memoryText = $"[{memoryName}] {memoryContent}\n";
						builderMemory.Append(memoryText);
					}
				}
			}

			// Format document snippets.
			if (memoryMap.TryGetValue(promptOptions.Value.DocumentMemoryName, out memories) &&
				memories.Count != 0)
			{
				builderMemory.Append(
					"User has also shared some document snippets.\n" +
					"Quote the document link in square brackets at the end of each sentence that refers to the snippet in your response.\n");

				foreach ((string memoryContent, CitationSource citation) in memories)
				{
					string memoryText =
						$"Document name: {citation.SourceName}\nDocument link: {citation.Link}.\n[CONTENT START]\n{memoryContent}\n[CONTENT END]\n";
					builderMemory.Append(memoryText);
				}
			}
		}

		return (builderMemory.Length == 0 ? string.Empty : builderMemory.ToString(), citationMap);

		/// <summary>
		/// Search the memory for relevant memories by memory name.
		/// </summary>
		async Task SearchMemoryAsync(string memoryName, bool isGlobalMemory = false)
		{
			if (chatSession is null)
			{
				return;
			}

			SearchResult searchResult =
				await memoryClient.SearchMemory(
					promptOptions.Value.MemoryIndexName,
					query,
					CalculateRelevanceThreshold(memoryName, chatSession.MemoryBalance),
					isGlobalMemory ? DocumentMemoryOptions.GlobalDocumentChatId.ToString() : chatId,
					memoryName);

			foreach ((string memoryName, Citation c, Citation.Partition p) result in searchResult.Results.SelectMany(c =>
				c.Partitions.Select(p => (memoryName, c, p))))
			{
				relevantMemories.Add(result);
			}
		}

		async Task SearchAdditionalIndexMemory(PromptsOptions promptsOptions)
		{
			foreach (AdditionalIndex index in promptsOptions.AdditionalIndexesToSearch)
			{
				SearchResult searchResult = await memoryClient.SearchMemory(
					index.Name,
					query,
					index.RelevanceThreshold,
					null);

				foreach ((string memoryName, Citation c, Citation.Partition p) result in searchResult.Results.SelectMany(c =>
					c.Partitions.Select(p => (index.Name, c, p))))
				{
					relevantMemories.Add(result);
				}
			}
		}

		/// <summary>
		/// Process the relevant memories and return a map of memories with citations for each memory name.
		/// </summary>
		/// <returns>A map of memories for each memory name and a map of citations for documents.</returns>
		(IDictionary<string, List<(string, CitationSource)>>, IDictionary<string, CitationSource>) ProcessMemories()
		{
			Dictionary<string, List<(string, CitationSource)>> memoryMap = new(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, CitationSource> citationMap = new(StringComparer.OrdinalIgnoreCase);

			foreach ((string memoryName, Citation Citation, Citation.Partition Memory) result in relevantMemories
				.OrderByDescending(m => m.Memory.Relevance))
			{
				int tokenCount = TokenUtils.TokenCount(result.Memory.Text);
				if (remainingToken - tokenCount > 0)
				{
					string memoryName;
					if (result.Memory.Tags.TryGetValue(MemoryTags.TagMemory, out List<string?> tag)
						&& tag.Count > 0)
					{
						memoryName = tag.FirstOrDefault() ?? result.memoryName;
					}
					else
					{
						memoryName = result.memoryName;
					}

					CitationSource citationSource = CitationSource.FromSemanticMemoryCitation(
						result.Citation,
						result.Memory.Text,
						result.Memory.Relevance
					);

					bool additionalIndexMemory = promptOptions.Value.AdditionalIndexesToSearch
						.Any(index => index.Name.Equals(memoryName, StringComparison.Ordinal));
					if (_memoryNames.Contains(memoryName) || additionalIndexMemory)
					{
						if (!memoryMap.TryGetValue(memoryName, out List<(string, CitationSource)>? memories))
						{
							memories = new List<(string, CitationSource)>();
							memoryMap.Add(memoryName, memories);
						}

						memories.Add((result.Memory.Text, citationSource));
						remainingToken -= tokenCount;
					}

					// Only documents will have citations.
					if (memoryName == promptOptions.Value.DocumentMemoryName || additionalIndexMemory)
					{
						citationMap.TryAdd(result.Citation.Link, citationSource);
					}
				}
				else
				{
					break;
				}
			}

			return (memoryMap, citationMap);
		}
	}

	#region Private

	/// <summary>
	///     Calculates the relevance threshold for the memory.
	///     The relevance threshold is a function of the memory balance.
	///     The memory balance is a value between 0 and 1, where 0 means maximum focus on
	///     working term memory (by minimizing the relevance threshold for working memory
	///     and maximizing the relevance threshold for long term memory), and 1 means
	///     maximum focus on long term memory (by minimizing the relevance threshold for
	///     long term memory and maximizing the relevance threshold for working memory).
	///     The memory balance controls two 1st degree polynomials defined by the lower
	///     and upper bounds, one for long term memory and one for working memory.
	///     The relevance threshold is the value of the polynomial at the memory balance.
	/// </summary>
	/// <param name="memoryName">The name of the memory.</param>
	/// <param name="memoryBalance">The balance between long term memory and working term memory.</param>
	/// <returns></returns>
	/// <exception cref="ArgumentException">Thrown when the memory name is invalid.</exception>
	private float CalculateRelevanceThreshold(string memoryName, float memoryBalance)
	{
		float upper = promptOptions.Value.SemanticMemoryRelevanceUpper;
		float lower = promptOptions.Value.SemanticMemoryRelevanceLower;

		if (memoryBalance < 0.0 || memoryBalance > 1.0)
		{
			throw new ArgumentException($"Invalid memory balance: {memoryBalance}");
		}

		if (memoryName == promptOptions.Value.LongTermMemoryName)
		{
			return ((lower - upper) * memoryBalance) + upper;
		}

		if (memoryName == promptOptions.Value.WorkingMemoryName)
		{
			return ((upper - lower) * memoryBalance) + lower;
		}

		if (memoryName == promptOptions.Value.DocumentMemoryName)
		{
			return promptOptions.Value.DocumentMemoryMinRelevance;
		}

		throw new ArgumentException($"Invalid memory name: {memoryName}");
	}

	# endregion
}
