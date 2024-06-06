// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Identity.Client;

namespace ImportDocument;

/// <summary>
///     This console app imports a list of files to Chat Copilot's WebAPI document memory store.
/// </summary>
public static class Program
{
	public static void Main(string[] args)
	{
		Config? config = Config.GetConfig();
		if (!Config.Validate(config))
		{
			Console.WriteLine("Error: Failed to read appsettings.json.");
			return;
		}

		Option<IEnumerable<FileInfo>> filesOption =
			new("--files", "The files to import to document memory store.")
			{
				IsRequired = true,
				AllowMultipleArgumentsPerToken = true
			};

		Option<Guid> chatCollectionOption = new(
			"--chat-id",
			description: "Save the extracted context to an isolated chat collection.",
			getDefaultValue: () => Guid.Empty
		);

		RootCommand rootCommand = new(
			"This console app imports files to Chat Copilot's WebAPI document memory store."
		)
		{
			filesOption,
			chatCollectionOption
		};

		rootCommand.SetHandler(async (files, chatCollectionId) =>
			{
				await ImportFilesAsync(files, config!, chatCollectionId);
			},
			filesOption,
			chatCollectionOption
		);

		rootCommand.Invoke(args);
	}

	/// <summary>
	///     Acquires a user account from Azure AD.
	/// </summary>
	/// <param name="config">The App configuration.</param>
	/// <param name="setAccessToken">Sets the access token to the first account found.</param>
	/// <returns>True if the user account was acquired.</returns>
	private static async Task<bool> AcquireTokenAsync(
		Config config,
		Action<string> setAccessToken)
	{
		Console.WriteLine("Attempting to authenticate user...");

		string webApiScope = $"api://{config.BackendClientId}/{config.Scopes}";
		string[] scopes = [webApiScope];
		try
		{
			IPublicClientApplication app = PublicClientApplicationBuilder.Create(config.ClientId)
				.WithRedirectUri(config.RedirectUri)
				.WithAuthority(config.Instance, config.TenantId)
				.Build();
			AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
			setAccessToken(result.AccessToken);
			return true;
		}
		catch (Exception ex) when (ex is MsalServiceException or MsalClientException)
		{
			Console.WriteLine($"Error: {ex.Message}");
			return false;
		}
	}

	/// <summary>
	///     Conditionally imports a list of files to the Document Store.
	/// </summary>
	/// <param name="files">A list of files to import.</param>
	/// <param name="config">Configuration.</param>
	/// <param name="chatCollectionId">Save the extracted context to an isolated chat collection.</param>
	private static async Task ImportFilesAsync(
		IEnumerable<FileInfo> files,
		Config config,
		Guid chatCollectionId)
	{
		IEnumerable<FileInfo> fileInfos = files as FileInfo[] ?? files.ToArray();
		foreach (FileInfo file in fileInfos)
		{
			if (!file.Exists)
			{
				Console.WriteLine($"File {file.FullName} does not exist.");
				return;
			}
		}

		string? accessToken = null;
		if (config.AuthenticationType == "AzureAd")
		{
			if (await AcquireTokenAsync(config, v => { accessToken = v; }) == false)
			{
				Console.WriteLine("Error: Failed to acquire access token.");
				return;
			}

			Console.WriteLine("Successfully acquired access token. Continuing...");
		}

		using MultipartFormDataContent formContent = new();
		List<StreamContent> filesContent = fileInfos
			.Select(file => new StreamContent(file.OpenRead()))
			.ToList();
		for (int i = 0; i < filesContent.Count; i++)
		{
			formContent.Add(filesContent[i], "formFiles", fileInfos.ElementAt(i).Name);
		}

		if (chatCollectionId != Guid.Empty)
		{
			Console.WriteLine($"Uploading and parsing file to chat {chatCollectionId}...");

			await UploadAsync(formContent, chatCollectionId);
		}
		else
		{
			Console.WriteLine("Uploading and parsing file to global collection...");

			await UploadAsync(formContent);
		}

		// Dispose of all the file streams.
		foreach (StreamContent fileContent in filesContent)
		{
			fileContent.Dispose();
		}

		return;

		async Task UploadAsync(MultipartFormDataContent multipartFormDataContent, Guid? chatId = null)
		{
			// Create a HttpClient instance and set the timeout to infinite since
			// large documents will take a while to parse.
			using HttpClientHandler clientHandler = new()
			{
				CheckCertificateRevocationList = true
			};
			using HttpClient httpClient = new(clientHandler)
			{
				Timeout = Timeout.InfiniteTimeSpan
			};

			if (config.AuthenticationType == "AzureAd")
			{
				// Add required properties to the request header.
				httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken!}");
			}

			string uriPath =
				chatId.HasValue ? $"chats/{chatId}/documents" : "documents";

			try
			{
				using HttpResponseMessage response = await httpClient.PostAsync(
					new Uri(new Uri(config.ServiceUri), uriPath),
					multipartFormDataContent);

				if (!response.IsSuccessStatusCode)
				{
					Console.WriteLine($"Error: {response.StatusCode} {response.ReasonPhrase}");
					Console.WriteLine(await response.Content.ReadAsStringAsync());
					return;
				}

				Console.WriteLine("Uploading and parsing successful.");
			}
			catch (HttpRequestException ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}
	}
}
