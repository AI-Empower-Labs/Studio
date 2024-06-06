// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;
using CopilotChat.WebApi.Options;

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     Configuration to be used by the frontend client to this service.
/// </summary>
public sealed record FrontendAuthConfig
{
    /// <summary>
    ///     Type of auth to use.
    /// </summary>
    [JsonPropertyName("authType")]
    public string AuthType  { get; init; } = ChatAuthenticationOptions.AuthenticationType.None.ToString();

    /// <summary>
    ///     Azure Active Directory authority to use.
    /// </summary>
    [JsonPropertyName("aadAuthority")]
    public string AadAuthority  { get; init; } = string.Empty;

    /// <summary>
    ///     Azure Active Directory client ID the frontend is to use.
    /// </summary>
    [JsonPropertyName("aadClientId")]
    public string AadClientId  { get; init; } = string.Empty;

    /// <summary>
    ///     Azure Active Directory scope the frontend should request.
    /// </summary>
    [JsonPropertyName("aadApiScope")]
    public string AadApiScope  { get; init; } = string.Empty;
}
