// Copyright (c) Microsoft. All rights reserved.

using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Web;

namespace CopilotChat.WebApi.Auth;

#pragma warning disable CS0618 // Type or member is obsolete

/// <summary>
///     Class implementing "authentication" that lets all requests pass through.
/// </summary>
public class PassThroughAuthenticationHandler(
    IOptionsMonitor<AuthenticationSchemeOptions> options,
    ILoggerFactory loggerFactory,
    UrlEncoder encoder,
    ISystemClock clock) : AuthenticationHandler<AuthenticationSchemeOptions>(options, loggerFactory, encoder, clock)
{
    public const string AuthenticationScheme = "PassThrough";
    private const string DefaultUserId = "c05c61eb-65e4-4223-915a-fe72b0c9ece1";
    private const string DefaultUserName = "Default User";

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        Logger.LogInformation("Allowing request to pass through");

        Claim userIdClaim = new(ClaimConstants.Sub, DefaultUserId);
        Claim nameClaim = new(ClaimConstants.Name, DefaultUserName);
        ClaimsIdentity identity = new([userIdClaim, nameClaim], AuthenticationScheme);
        ClaimsPrincipal principal = new(identity);
        AuthenticationTicket ticket = new(principal, Scheme.Name);

        return Task.FromResult(AuthenticateResult.Success(ticket));
    }

    /// <summary>
    ///     Returns true if the given user ID is the default user guest ID.
    /// </summary>
    public static bool IsDefaultUser(string userId)
    {
        return userId == DefaultUserId;
    }
}
