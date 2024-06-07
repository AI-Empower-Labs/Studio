﻿// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Plugins.OpenApi.GitHubPlugin.Model;

/// <summary>
///     Represents a user on GitHub.
/// </summary>
public sealed record GitHubUser
{
    /// <summary>
    ///     Creates a new instance of the User class.
    /// </summary>
    /// <param name="name">The user's name.</param>
    /// <param name="email">The user's email address.</param>
    /// <param name="id">The user's numeric ID.</param>
    /// <param name="type">The user's type.</param>
    /// <param name="siteAdmin">Whether the user is a site admin.</param>
    public GitHubUser(string name, string email, int id, string type, bool siteAdmin)
    {
        Name = name;
        Email = email;
        Id = id;
        Type = type;
        SiteAdmin = siteAdmin;
    }

    /// <summary>
    ///     The user's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     The user's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; init; }

    /// <summary>
    ///     The user's numeric ID.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    ///     The user's type, e.g. User or Organization.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }

    /// <summary>
    ///     Whether the user is a site admin.
    /// </summary>
    [JsonPropertyName("site_admin")]
    public bool SiteAdmin { get; init; }
}
