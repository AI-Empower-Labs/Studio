// Copyright (c) Microsoft. All rights reserved.

using Microsoft.Extensions.Configuration;

namespace ImportDocument;

/// <summary>
///     Configuration for the app.
/// </summary>
public sealed record Config
{
	/// <summary>
	///     Client ID for the app as registered in Azure AD.
	/// </summary>
	public string AuthenticationType { get; init; } = "None";

	/// <summary>
	///     Client ID for the import document tool as registered in Azure AD.
	/// </summary>
	public string ClientId { get; init; } = string.Empty;

	/// <summary>
	///     Client ID for the backend web api as registered in Azure AD.
	/// </summary>
	public string BackendClientId { get; init; } = string.Empty;

	/// <summary>
	///     Tenant ID against which to authenticate users in Azure AD.
	/// </summary>
	public string TenantId { get; init; } = string.Empty;

	/// <summary>
	///     Azure AD cloud instance for authenticating users.
	/// </summary>
	public string Instance { get; init; } = string.Empty;

	/// <summary>
	///     Scopes that the client app requires to access the API.
	/// </summary>
	public string Scopes { get; init; } = string.Empty;

	/// <summary>
	///     Redirect URI for the app as registered in Azure AD.
	/// </summary>
	public string RedirectUri { get; init; } = string.Empty;

	/// <summary>
	///     Uri for the service that is running the chat.
	/// </summary>
	public string ServiceUri { get; init; } = string.Empty;

	/// <summary>
	///     Gets configuration from appsettings.json.
	/// </summary>
	/// <returns>An Config instance</returns>
	public static Config? GetConfig()
	{
		IConfigurationRoot config = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.Build();

		return config.GetRequiredSection("Config").Get<Config>();
	}

	/// <summary>
	///     Validates a Config object.
	/// </summary>
	/// <param name="config"></param>
	/// <returns>True is the config object is not null.</returns>
	public static bool Validate(Config? config)
	{
		return config is not null;
	}
}
