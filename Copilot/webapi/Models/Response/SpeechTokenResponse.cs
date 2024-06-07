// Copyright (c) Microsoft. All rights reserved.

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     Token Response is a simple wrapper around the token and region
/// </summary>
public sealed record SpeechTokenResponse
{
    public string? Token  { get; init; }
    public string? Region  { get; init; }
    public bool? IsSuccess  { get; init; }
}
