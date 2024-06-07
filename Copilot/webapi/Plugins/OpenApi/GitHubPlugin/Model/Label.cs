// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Plugins.OpenApi.GitHubPlugin.Model;

/// <summary>
///     Represents a pull request label.
/// </summary>
public sealed record Label
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Label" /> class.
    /// </summary>
    /// <param name="id">The ID of the label.</param>
    /// <param name="name">The name of the label.</param>
    /// <param name="description">The description of the label.</param>
    public Label(long id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    /// <summary>
    ///     Gets or sets the ID of the label.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    ///     Gets or sets the name of the label.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     Gets or sets the description of the label.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; init; }
}
