﻿// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace CopilotChat.WebApi.Plugins.OpenApi.JiraPlugin.Model;

/// <summary>
///     Represents an individual comment on an issue in jira.
/// </summary>
public class IndividualComments
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IndividualComments" /> class.
    /// </summary>
    /// <param name="body">The actual content of the comment.</param>
    /// <param name="author">Author of the comment.</param>
    public IndividualComments(string body, CommentAuthor author)
    {
        Body = body;
        Author = author;
    }

    /// <summary>
    ///     Gets or sets the body of the comment.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; }

    /// <summary>
    ///     Gets or sets the author name.
    /// </summary>
    [JsonPropertyName("author")]
    public CommentAuthor Author { get; set; }
}
