// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
///     Controller responsible for returning information on the service.
/// </summary>
[ApiController]
public sealed class ServiceInfoController(
    IOptions<ChatAuthenticationOptions> chatAuthenticationOptions,
    IOptions<FrontendOptions> frontendOptions,
    IDictionary<string, Plugin> availablePlugins) : ControllerBase
{
    private readonly IEnumerable<Plugin> _availablePlugins = SanitizePlugins(availablePlugins);

    /// <summary>
    ///     Return information on running service.
    /// </summary>
    [Route("info")]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetServiceInfo()
    {
        ServiceInfoResponse response = new()
        {
            MemoryStore = new MemoryStoreInfoResponse
            {
                Types = Enum.GetNames<MemoryStoreType>(),
                SelectedType = MemoryStoreType.Database.ToString()
            },
            AvailablePlugins = _availablePlugins,
            Version = GetAssemblyFileVersion()
        };

        return Ok(response);
    }

    /// <summary>
    ///     Return the auth config to be used by the frontend client to access this service.
    /// </summary>
    [Route("authConfig")]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [AllowAnonymous]
    public IActionResult GetAuthConfig()
    {
        string authorityUriString = string.Empty;
        if (!string.IsNullOrEmpty(chatAuthenticationOptions.Value.AzureAd?.Instance) &&
            !string.IsNullOrEmpty(chatAuthenticationOptions.Value.AzureAd?.TenantId))
        {
            Uri authorityUri = new(chatAuthenticationOptions.Value.AzureAd!.Instance);
            authorityUri = new Uri(authorityUri, chatAuthenticationOptions.Value.AzureAd!.TenantId);
            authorityUriString = authorityUri.ToString();
        }

        FrontendAuthConfig config = new()
        {
            AuthType = chatAuthenticationOptions.Value.Type.ToString(),
            AadAuthority = authorityUriString,
            AadClientId = frontendOptions.Value.AadClientId,
            AadApiScope =
                $"api://{chatAuthenticationOptions.Value.AzureAd?.ClientId}/{chatAuthenticationOptions.Value.AzureAd?.Scopes}"
        };

        return Ok(config);
    }

    private static string GetAssemblyFileVersion()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);

        return fileVersion.FileVersion ?? string.Empty;
    }

    /// <summary>
    ///     Sanitize the plugins to only return the name and url.
    /// </summary>
    /// <param name="plugins">The plugins to sanitize.</param>
    /// <returns></returns>
    private static IEnumerable<Plugin> SanitizePlugins(IDictionary<string, Plugin> plugins)
    {
        return plugins.Select(p => new Plugin
        {
            Name = p.Value.Name,
            ManifestDomain = p.Value.ManifestDomain,
            Key = p.Value.Name
        });
    }
}
