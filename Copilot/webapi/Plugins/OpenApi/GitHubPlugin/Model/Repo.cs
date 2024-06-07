// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Plugins.OpenApi.GitHubPlugin.Model;

/// <summary>
///     Represents a GitHub Repo.
/// </summary>
public sealed record Repo
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Repo" />.
    /// </summary>
    /// <param name="name">The name of the repository, e.g. "dotnet/runtime".</param>
    /// <param name="fullName">The full name of the repository, e.g. "Microsoft/dotnet/runtime".</param>
    public Repo(string name, string fullName)
    {
        Name = name;
        FullName = fullName;
    }

    /// <summary>
    ///     Gets or sets the name of the repo
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     Gets or sets the full name of the repo
    /// </summary>
    [JsonPropertyName("full_name")]
    public string FullName { get; init; }
}
