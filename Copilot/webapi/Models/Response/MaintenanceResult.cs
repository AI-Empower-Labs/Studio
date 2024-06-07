// Copyright (c) Microsoft. All rights reserved.

namespace CopilotChat.WebApi.Models.Response;

/// <summary>
///     Defines optional messaging for maintenance mode.
/// </summary>
public sealed record MaintenanceResult
{
    /// <summary>
    ///     The maintenance notification title.
    /// </summary>
    /// <remarks>
    ///     Will utilize default if not defined.
    /// </remarks>
    public string Title  { get; init; } = string.Empty;

    /// <summary>
    ///     The maintenance notification message.
    /// </summary>
    /// <remarks>
    ///     Will utilize default if not defined.
    /// </remarks>
    public string Message  { get; init; } = string.Empty;

    /// <summary>
    ///     The maintenance notification note.
    /// </summary>
    /// <remarks>
    ///     Will utilize default if not defined.
    /// </remarks>
    public string? Note  { get; init; }
}
