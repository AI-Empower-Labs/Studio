// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace Plugins.PluginShared;

/// <summary>
///     This class represents the OpenAI plugin authentication schema.
/// </summary>
public sealed class PluginAuth
{
    /// <summary>
    ///     The authentication schema
    ///     Supported values: none, service_http, user_http
    /// </summary>
    public string Type { get; init; } = "none";

    /// <summary>
    ///     Manifest schema version
    /// </summary>
    [JsonPropertyName("authorization_type")]
    public string AuthorizationType { get; } = "bearer";

    /// <summary>
    ///     Tokens for API key authentication
    /// </summary>
    [JsonPropertyName("verification_tokens")]
    public VerificationTokens Tokens { get; init; } = new();

    /// <summary>
    ///     Tokens for API key authentication
    /// </summary>
    public class VerificationTokens
    {
        /// <summary>
        ///     The API key
        /// </summary>
        public string OpenAi { get; init; } = string.Empty;
    }
}
