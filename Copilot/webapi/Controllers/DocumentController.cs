// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Extensions;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Models.Request;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Services;
using CopilotChat.WebApi.Storage;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
///     Controller for importing documents.
/// </summary>
/// <remarks>
///     This controller is responsible for contracts that are not possible to fulfill by kernel memory components.
/// </remarks>
[ApiController]
public sealed class DocumentController(
	ILogger<DocumentController> logger,
	IAuthInfo authInfo,
	IOptions<DocumentMemoryOptions> documentMemoryOptions,
	IOptions<PromptsOptions> promptOptions,
	ChatMemorySourceRepository sourceRepository,
	ChatMessageRepository messageRepository,
	ChatParticipantRepository participantRepository,
	DocumentTypeProvider documentTypeProvider) : ControllerBase
{
	private const string GlobalDocumentUploadedClientCall = "GlobalDocumentUploaded";
	private const string ReceiveMessageClientCall = "ReceiveMessage";

	/// <summary>
	///     Service API for importing a document.
	///     Documents imported through this route will be considered as global documents.
	/// </summary>
	[Route("documents")]
	[HttpPost]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public Task<IActionResult> DocumentImportAsync(
		[FromServices] IKernelMemory memoryClient,
		[FromServices] IHubContext<MessageRelayHub> messageRelayHubContext,
		[FromForm] DocumentImportForm documentImportForm,
		CancellationToken cancellationToken)
	{
		return DocumentImportAsync(
			memoryClient,
			messageRelayHubContext,
			DocumentScopes.Global,
			DocumentMemoryOptions.GlobalDocumentChatId,
			documentImportForm,
			cancellationToken
		);
	}

	/// <summary>
	///     Service API for importing a document.
	/// </summary>
	[Route("chats/{chatId}/documents")]
	[HttpPost]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public Task<IActionResult> DocumentImportAsync(
		[FromServices] IKernelMemory memoryClient,
		[FromServices] IHubContext<MessageRelayHub> messageRelayHubContext,
		[FromRoute] Guid chatId,
		[FromForm] DocumentImportForm documentImportForm,
		CancellationToken cancellationToken)
	{
		return DocumentImportAsync(
			memoryClient,
			messageRelayHubContext,
			DocumentScopes.Chat,
			chatId,
			documentImportForm,
			cancellationToken);
	}

	private async Task<IActionResult> DocumentImportAsync(
		IKernelMemory memoryClient,
		IHubContext<MessageRelayHub> messageRelayHubContext,
		DocumentScopes documentScope,
		Guid chatId,
		DocumentImportForm documentImportForm,
		CancellationToken cancellationToken)
	{
		try
		{
			await ValidateDocumentImportFormAsync(chatId, documentScope, documentImportForm, cancellationToken);
		}
		catch (ArgumentException ex)
		{
			return BadRequest(ex.Message);
		}

		logger.LogInformation("Importing {FormFiles} document(s)...", documentImportForm.FormFiles.Count());

		// Pre-create chat-message
		DocumentMessageContent documentMessageContent = new();

		IList<ImportResult> importResults =
			await ImportDocumentsAsync(memoryClient, chatId, documentImportForm, documentMessageContent, cancellationToken: cancellationToken);

		CopilotChatMessage? chatMessage = await TryCreateDocumentUploadMessage(chatId, documentMessageContent, cancellationToken: cancellationToken);

		if (chatMessage == null)
		{
			logger.LogWarning("Failed to create document upload message - {Content}",
				documentMessageContent.ToString());
			return BadRequest();
		}

		// Broadcast the document uploaded event to other users.
		if (documentScope == DocumentScopes.Chat)
		{
			// If chat message isn't created, it is still broadcast and visible in the documents tab.
			// The chat message won't, however, be displayed when the chat is freshly rendered.

			string userId = authInfo.UserId;
			await messageRelayHubContext.Clients
				.Group(chatId.ToString())
				.SendAsync(ReceiveMessageClientCall, chatId, userId, chatMessage, cancellationToken: cancellationToken);

			logger.LogInformation("Local upload chat message: {ChatMessage}", chatMessage.ToString());

			return Ok(chatMessage);
		}

		await messageRelayHubContext.Clients.All
			.SendAsync(
				GlobalDocumentUploadedClientCall,
				documentMessageContent.ToFormattedStringNamesOnly(),
				authInfo.Name,
				cancellationToken: cancellationToken);

		logger.LogInformation("Global upload chat message: {ChatMessage}", chatMessage.ToString());

		return Ok(chatMessage);
	}

	private async Task<IList<ImportResult>> ImportDocumentsAsync(
		IKernelMemory memoryClient,
		Guid chatId,
		DocumentImportForm documentImportForm,
		DocumentMessageContent messageContent,
		CancellationToken cancellationToken)
	{
		IEnumerable<ImportResult> importResults = new List<ImportResult>();

		await Task.WhenAll(
			documentImportForm.FormFiles.Select(
				async formFile =>
					await ImportDocumentAsync(formFile, memoryClient, chatId, cancellationToken: cancellationToken)
						.ContinueWith(
							task =>
							{
								ImportResult importResult = task.Result;

								messageContent.AddDocument(
									formFile.FileName,
									GetReadableByteString(formFile.Length),
									importResult.IsSuccessful);

								importResults = importResults.Append(importResult);
							},
							TaskScheduler.Default)));

		return importResults.ToArray();
	}

	private async Task<ImportResult> ImportDocumentAsync(
		IFormFile formFile,
		IKernelMemory memoryClient,
		Guid chatId,
		CancellationToken cancellationToken)
	{
		logger.LogInformation("Importing document {FileName}", formFile.FileName);

		// Create memory source
		MemorySource memorySource = new()
		{
			ChatId = chatId.ToString(),
			SourceType = MemorySourceType.File,
			Size = formFile.Length,
			Name = formFile.FileName,
			SharedBy = authInfo.UserId
		};

		if (!await TryUpsertMemorySourceAsync(memorySource, cancellationToken: cancellationToken))
		{
			logger.LogDebug("Failed to upsert memory source for file {FileName}", formFile.FileName);

			return ImportResult.Fail;
		}

		if (!await TryStoreMemoryAsyncLocal())
		{
			await TryRemoveMemoryAsync(memorySource, cancellationToken: cancellationToken);
		}

		return new ImportResult(memorySource.Id);

		async Task<bool> TryStoreMemoryAsyncLocal()
		{
			try
			{
				await using Stream stream = formFile.OpenReadStream();
				await memoryClient.StoreDocumentAsync(
					promptOptions.Value.MemoryIndexName,
					memorySource.Id,
					chatId.ToString(),
					promptOptions.Value.DocumentMemoryName,
					formFile.FileName,
					stream,
					cancellationToken: cancellationToken);

				return true;
			}
			catch (Exception ex) when (ex is not SystemException)
			{
				return false;
			}
		}
	}

	#region Private

	/// <summary>
	///     A class to store a document import results.
	/// </summary>
	private sealed class ImportResult
	{
		/// <summary>
		///     Create a new instance of the <see cref="ImportResult" /> class.
		/// </summary>
		/// <param name="collectionName">The name of the collection that the document is inserted to.</param>
		public ImportResult(string collectionName)
		{
			CollectionName = collectionName;
		}

		/// <summary>
		///     A boolean indicating whether the import is successful.
		/// </summary>
		public bool IsSuccessful => !string.IsNullOrWhiteSpace(CollectionName);

		/// <summary>
		///     The name of the collection that the document is inserted to.
		/// </summary>
		public string CollectionName { get; }

		/// <summary>
		///     Create a new instance of the <see cref="ImportResult" /> class representing a failed import.
		/// </summary>
		public static ImportResult Fail { get; } = new(string.Empty);
	}

	/// <summary>
	///     Validates the document import form.
	/// </summary>
	/// <param name="scope"></param>
	/// <param name="documentImportForm">The document import form.</param>
	/// <param name="chatId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException">Throws ArgumentException if validation fails.</exception>
	private async Task ValidateDocumentImportFormAsync(
		Guid chatId,
		DocumentScopes scope,
		DocumentImportForm documentImportForm,
		CancellationToken cancellationToken)
	{
		// Make sure the user has access to the chat session if the document is uploaded to a chat session.
		if (scope == DocumentScopes.Chat
			&& !await UserHasAccessToChatAsync(authInfo.UserId, chatId, cancellationToken))
		{
			throw new ArgumentException("User does not have access to the chat session.");
		}

		IEnumerable<IFormFile> formFiles = documentImportForm.FormFiles;

		IEnumerable<IFormFile> enumerable = formFiles as IFormFile[] ?? formFiles.ToArray();
		if (!enumerable.Any())
		{
			throw new ArgumentException("No files were uploaded.");
		}

		if (enumerable.Count() > documentMemoryOptions.Value.FileCountLimit)
		{
			throw new ArgumentException(
				$"Too many files uploaded. Max file count is {documentMemoryOptions.Value.FileCountLimit}.");
		}

		// Loop through the uploaded files and validate them before importing.
		foreach (IFormFile formFile in enumerable)
		{
			if (formFile.Length == 0)
			{
				throw new ArgumentException($"File {formFile.FileName} is empty.");
			}

			if (formFile.Length > documentMemoryOptions.Value.FileSizeLimit)
			{
				throw new ArgumentException($"File {formFile.FileName} size exceeds the limit.");
			}

			// Make sure the file type is supported.
			string fileType = Path.GetExtension(formFile.FileName);
			if (!documentTypeProvider.IsSupported(fileType))
			{
				throw new ArgumentException($"Unsupported file type: {fileType}");
			}
		}
	}

	/// <summary>
	///     Validates the document import form.
	/// </summary>
	/// <param name="documentStatusForm">The document import form.</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException">Throws ArgumentException if validation fails.</exception>
	private async Task ValidateDocumentStatusFormAsync(DocumentStatusForm documentStatusForm, CancellationToken cancellationToken)
	{
		// Make sure the user has access to the chat session if the document is uploaded to a chat session.
		if (documentStatusForm.DocumentScope == DocumentScopes.Chat
			&& !await UserHasAccessToChatAsync(documentStatusForm.UserId, documentStatusForm.ChatId, cancellationToken))
		{
			throw new ArgumentException("User does not have access to the chat session.");
		}

		IEnumerable<string> fileReferences = documentStatusForm.FileReferences;

		IEnumerable<string> references = fileReferences as string[] ?? fileReferences.ToArray();
		if (!references.Any())
		{
			throw new ArgumentException("No files identified.");
		}

		if (references.Count() > documentMemoryOptions.Value.FileCountLimit)
		{
			throw new ArgumentException(
				$"Too many files requested. Max file count is {documentMemoryOptions.Value.FileCountLimit}.");
		}

		// Loop through the uploaded files and validate them before importing.
		foreach (string fileReference in references)
		{
			if (string.IsNullOrWhiteSpace(fileReference))
			{
				throw new ArgumentException($"File {fileReference} is empty.");
			}
		}
	}

	/// <summary>
	///     Try to upsert a memory source.
	/// </summary>
	/// <param name="memorySource">The memory source to be uploaded</param>
	/// <param name="cancellationToken"></param>
	/// <returns>True if upsert is successful. False otherwise.</returns>
	private async Task<bool> TryUpsertMemorySourceAsync(MemorySource memorySource, CancellationToken cancellationToken)
	{
		try
		{
			await sourceRepository.Upsert(memorySource, cancellationToken: cancellationToken);
			return true;
		}
		catch (Exception ex) when (ex is not SystemException)
		{
			return false;
		}
	}

	/// <summary>
	///     Try to upsert a memory source.
	/// </summary>
	/// <param name="memorySource">The memory source to be uploaded</param>
	/// <param name="cancellationToken"></param>
	/// <returns>True if upsert is successful. False otherwise.</returns>
	private async Task TryRemoveMemoryAsync(MemorySource memorySource, CancellationToken cancellationToken)
	{
		try
		{
			await sourceRepository.Delete(memorySource, cancellationToken: cancellationToken);
		}
		catch (Exception ex) when (ex is ArgumentOutOfRangeException)
		{
		}
	}

	/// <summary>
	///     Try to upsert a memory source.
	/// </summary>
	/// <param name="memorySource">The memory source to be uploaded</param>
	/// <param name="cancellationToken"></param>
	/// <returns>True if upsert is successful. False otherwise.</returns>
	private async Task<bool> TryStoreMemoryAsync(MemorySource memorySource, CancellationToken cancellationToken)
	{
		try
		{
			await sourceRepository.Upsert(memorySource, cancellationToken: cancellationToken);
			return true;
		}
		catch (Exception ex) when (ex is ArgumentOutOfRangeException)
		{
			return false;
		}
	}

	/// <summary>
	///     Try to create a chat message that represents document upload.
	/// </summary>
	/// <param name="chatId">The target chat-id</param>
	/// <param name="messageContent">The document message content</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A ChatMessage object if successful, null otherwise</returns>
	private async Task<CopilotChatMessage?> TryCreateDocumentUploadMessage(
		Guid chatId,
		DocumentMessageContent messageContent,
		CancellationToken cancellationToken)
	{
		CopilotChatMessage chatMessage = CopilotChatMessage.CreateDocumentMessage(
			authInfo.UserId,
			authInfo.Name, // User name
			chatId.ToString(),
			messageContent);

		try
		{
			await messageRepository.Create(chatMessage, cancellationToken: cancellationToken);
			return chatMessage;
		}
		catch (Exception ex) when (ex is ArgumentOutOfRangeException)
		{
			return null;
		}
	}

	/// <summary>
	///     Converts a `long` byte count to a human-readable string.
	/// </summary>
	/// <param name="bytes">Byte count</param>
	/// <returns>Human-readable string of bytes</returns>
	private static string GetReadableByteString(long bytes)
	{
		string[] sizes = ["B", "KB", "MB", "GB", "TB"];
		int i;
		double dblsBytes = bytes;
		for (i = 0; i < sizes.Length && bytes >= 1024; i++, bytes /= 1024)
		{
			dblsBytes = bytes / 1024.0;
		}

		return string.Format(CultureInfo.InvariantCulture, "{0:0.#}{1}", dblsBytes, sizes[i]);
	}

	/// <summary>
	///     Check if the user has access to the chat session.
	/// </summary>
	/// <param name="userId">The user ID.</param>
	/// <param name="chatId">The chat session ID.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A boolean indicating whether the user has access to the chat session.</returns>
	private async Task<bool> UserHasAccessToChatAsync(string userId, Guid chatId, CancellationToken cancellationToken)
	{
		return await participantRepository.IsUserInChatAsync(userId, chatId.ToString(), cancellationToken);
	}

	#endregion
}
