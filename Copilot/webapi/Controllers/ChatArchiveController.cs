// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Extensions;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Storage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Controllers;

[ApiController]
public sealed class ChatArchiveController(
    IKernelMemory memoryClient,
    ChatSessionRepository chatRepository,
    ChatMessageRepository chatMessageRepository,
    ChatArchiveEmbeddingConfig embeddingConfig,
    IOptions<PromptsOptions> promptOptions,
    ILogger<ChatArchiveController> logger) : ControllerBase
{
    /// <summary>
    ///     Download a chat archive.
    /// </summary>
    /// <param name="chatId">The ID of chat to be downloaded.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The serialized chat archive object of the chat id.</returns>
    [HttpGet]
    [Route("chats/{chatId:guid}/archive")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Policy = AuthPolicyName.RequireChatParticipant)]
    public async Task<ActionResult<ChatArchive?>> Download(Guid chatId,
        CancellationToken cancellationToken = default)
    {
        logger.LogDebug("Received call to download a chat archive");

        ChatArchive chatArchive = await CreateChatArchive(chatId, cancellationToken);

        return Ok(chatArchive);
    }

    /// <summary>
    ///     Prepare a chat archive.
    /// </summary>
    /// <param name="chatId">The chat id of the chat archive</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A ChatArchive object that represents the chat session.</returns>
    private async Task<ChatArchive> CreateChatArchive(Guid chatId, CancellationToken cancellationToken)
    {
        string chatIdString = chatId.ToString();
        ChatSession chat = await chatRepository.FindById(chatIdString, cancellationToken: cancellationToken);
        ChatArchive chatArchive = new()
        {
            // Get embedding configuration
            EmbeddingConfigurations = embeddingConfig,
            // get the chat title
            ChatTitle = chat.Title,

            // get the system description
            SystemDescription = chat.SafeSystemDescription,

            // get the chat history
            ChatHistory = await GetAllChatMessages(chatIdString).ToListAsync(cancellationToken: cancellationToken)
        };

        foreach (string memory in promptOptions.Value.MemoryMap.Keys)
        {
            chatArchive.Embeddings.Add(
                memory,
                await GetMemoryRecordsAndAppendToEmbeddings(chatIdString, memory, cancellationToken));
        }

        // get the document memory collection names (global scope)
        chatArchive.DocumentEmbeddings.Add(
            "GlobalDocuments",
            await GetMemoryRecordsAndAppendToEmbeddings(
                Guid.Empty.ToString(),
                promptOptions.Value.DocumentMemoryName,
                cancellationToken));

        // get the document memory collection names (user scope)
        chatArchive.DocumentEmbeddings.Add(
            "ChatDocuments",
            await GetMemoryRecordsAndAppendToEmbeddings(
                chatIdString,
                promptOptions.Value.DocumentMemoryName,
                cancellationToken));

        return chatArchive;
    }

    /// <summary>
    ///     Get memory from memory store and append the memory records to a given list.
    ///     It will update the memory collection name in the new list if the newCollectionName is provided.
    /// </summary>
    /// <param name="chatId"></param>
    /// <param name="memoryName">The current collection name. Used to query the memory storage.</param>
    /// <param name="cancellationToken"></param>
    private async Task<List<Citation>> GetMemoryRecordsAndAppendToEmbeddings(
        string chatId,
        string memoryName,
        CancellationToken cancellationToken)
    {
        List<Citation> collectionMemoryRecords;
        try
        {
            SearchResult result = await memoryClient.SearchMemory(
                promptOptions.Value.MemoryIndexName,
                "*", // dummy query since we don't care about relevance. An empty string will cause exception.
                -1, // no relevance required since the collection only has one entry
                chatId,
                memoryName,
                cancellationToken);

            collectionMemoryRecords = result.Results;
        }
        catch (Exception connectorException) when (!connectorException.IsCriticalException())
        {
            // A store exception might be thrown if the collection does not exist, depending on the memory store connector.
            logger.LogError(connectorException, "Cannot search collection {MemoryName}", memoryName);
            collectionMemoryRecords = [];
        }

        return collectionMemoryRecords;
    }

    /// <summary>
    ///     Get chat messages of a given chat id.
    /// </summary>
    /// <param name="chatId">The chat id</param>
    /// <returns>The list of chat messages in descending order of the timestamp</returns>
    private IAsyncEnumerable<CopilotChatMessage> GetAllChatMessages(string chatId)
    {
        return chatMessageRepository.FindByChatId(chatId);
    }
}
