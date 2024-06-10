// Copyright (c) Microsoft. All rights reserved.

using System.ComponentModel.DataAnnotations;

namespace CopilotChat.WebApi.Options;

/// <summary>
///     Configuration options for authenticating to the service.
/// </summary>
public sealed class ChatAuthenticationOptions
{
    public enum AuthenticationType
    {
        None,
        AzureAd
    }

    public const string PropertyName = "Authentication";

    /// <summary>
    ///     Type of authentication.
    /// </summary>
    [Required]
    public AuthenticationType Type { get; init; } = AuthenticationType.None;

    /// <summary>
    ///     When <see cref="Type" /> is <see cref="AuthenticationType.AzureAd" />, these are the Azure AD options to use.
    /// </summary>
    [RequiredOnPropertyValue(nameof(Type), AuthenticationType.AzureAd)]
    public AzureAdOptions? AzureAd { get; init; }

    /// <summary>
    ///     Configuration options for Azure Active Directory (AAD) authorization.
    /// </summary>
#pragma warning disable CA1034
	public sealed record AzureAdOptions
#pragma warning restore CA1034
	{
        /// <summary>
        ///     AAD instance url, i.e., https://login.microsoftonline.com
        /// </summary>
        [Required]
        [NotEmptyOrWhitespace]
        public required string Instance { get; init; }

        /// <summary>
        ///     Tenant (directory) ID
        /// </summary>
        [Required]
        [NotEmptyOrWhitespace]
        public required string TenantId { get; init; }

        /// <summary>
        ///     Application (client) ID
        /// </summary>
        [Required]
        [NotEmptyOrWhitespace]
        public required string ClientId { get; init; }

        /// <summary>
        ///     Required scopes.
        /// </summary>
        [Required]
        public required string? Scopes { get; init; }
    }
}
