// Copyright (c) Microsoft. All rights reserved.
using System.Threading.Tasks;
using Azure.Identity;
using CopilotChat.WebApi.Storage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CopilotChat.WebApi.Auth;

/// <summary>
///     Class implementing "authorization" that validates the user has access to a chat.
/// </summary>
public sealed class ChatParticipantAuthorizationHandler(
    IAuthInfo authInfo,
    ChatSessionRepository chatSessionRepository,
    ChatParticipantRepository chatParticipantRepository) : AuthorizationHandler<ChatParticipantRequirement, HttpContext>
{
    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        ChatParticipantRequirement requirement,
        HttpContext resource)
    {
        try
        {
            string? chatId = resource.GetRouteValue("chatId")?.ToString();
            if (chatId == null)
            {
                // delegate to downstream validation
                context.Succeed(requirement);
                return;
            }

            if (await chatSessionRepository.TryFindById(chatId))
            {
                // delegate to downstream validation
                context.Succeed(requirement);
                return;
            }

            bool isUserInChat = await chatParticipantRepository.IsUserInChatAsync(authInfo.UserId, chatId, resource.RequestAborted);
            if (!isUserInChat)
            {
                context.Fail(new AuthorizationFailureReason(this, "User does not have access to the requested chat."));
            }

            context.Succeed(requirement);
        }
        catch (CredentialUnavailableException ex)
        {
            context.Fail(new AuthorizationFailureReason(this, ex.Message));
        }
    }
}
