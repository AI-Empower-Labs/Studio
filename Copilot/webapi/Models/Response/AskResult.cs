// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;

namespace CopilotChat.WebApi.Models.Response;

public sealed record AskResult
{
    public string Value { get; init; } = string.Empty;

    public IEnumerable<KeyValuePair<string, object?>>? Variables { get; init; } = [];
}
