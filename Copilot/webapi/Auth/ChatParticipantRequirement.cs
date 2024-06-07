﻿// Copyright (c) Microsoft. All rights reserved.

using Microsoft.AspNetCore.Authorization;

namespace CopilotChat.WebApi.Auth;

/// <summary>
///     Used to require the chat to be owned by the authenticated user.
/// </summary>
public sealed class ChatParticipantRequirement : IAuthorizationRequirement;
