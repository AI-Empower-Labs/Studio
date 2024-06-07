// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CopilotChat.WebApi.Options;

namespace CopilotChat.WebApi.Models.Request;

public sealed record Ask
{
    [Required] [NotEmptyOrWhitespace] public string Input { get; init; } = string.Empty;

    public IEnumerable<KeyValuePair<string, string>> Variables { get; init; } = [];
}
