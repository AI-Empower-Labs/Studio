// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace Plugins.PluginShared;

/// <summary>
///     This class represents the OpenAI plugin manifest:
///     https://platform.openai.com/docs/plugins/getting-started/plugin-manifest
/// </summary>
public sealed class PluginManifest
{
	/// <summary>
	///     Manifest schema version
	/// </summary>
	[JsonPropertyName("schema_version")]
	public string SchemaVersion { get; init; } = "v1";

	/// <summary>
	///     The name of the plugin that the model will use
	/// </summary>
	[JsonPropertyName("name_for_model")]
	public string NameForModel { get; init; } = string.Empty;

	/// <summary>
	///     Human-readable name of the plugin
	/// </summary>
	[JsonPropertyName("name_for_human")]
	public string NameForHuman { get; init; } = string.Empty;

	/// <summary>
	///     Description of the plugin that the model will use
	/// </summary>
	[JsonPropertyName("description_for_model")]
	public string DescriptionForModel { get; init; } = string.Empty;

	/// <summary>
	///     Human-readable description of the plugin
	/// </summary>
	[JsonPropertyName("description_for_human")]
	public string DescriptionForHuman { get; init; } = string.Empty;

	/// <summary>
	///     The authentication schema
	/// </summary>
	public PluginAuth Auth { get; init; } = new();

	/// <summary>
	///     The API specification
	/// </summary>
	public PluginApi Api { get; init; } = new();

	/// <summary>
	///     URL used to fetch the logo
	/// </summary>
	[JsonPropertyName("logo_url")]
	public string LogoUrl { get; init; } = string.Empty;

	/// <summary>
	///     Email contact for safety/moderation, support and deactivation
	/// </summary>
	[JsonPropertyName("contact_email")]
	public string ContactEmail { get; init; } = string.Empty;

	/// <summary>
	///     Redirect URL for users to get more information about the plugin
	/// </summary>
	[JsonPropertyName("legal_info_url")]
	public string LegalInfoUrl { get; init; } = string.Empty;

	/// <summary>
	///     "Bearer" or "Basic"
	/// </summary>
	public string HttpAuthorizationType { get; init; } = string.Empty;
}
