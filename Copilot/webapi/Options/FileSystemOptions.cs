﻿// Copyright (c) Microsoft. All rights reserved.

using System.ComponentModel.DataAnnotations;

namespace CopilotChat.WebApi.Options;

/// <summary>
///     File system storage configuration.
/// </summary>
public sealed record FileSystemOptions
{
    /// <summary>
    ///     Gets or sets the file path for persistent file system storage.
    /// </summary>
    [Required]
    [NotEmptyOrWhitespace]
    public required string FilePath { get; set; }
}
