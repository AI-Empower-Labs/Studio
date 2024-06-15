// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Security.Claims;

using Azure.Identity;

using Microsoft.AspNetCore.Http;
using Microsoft.Identity.Web;

namespace CopilotChat.WebApi.Auth;

/// <summary>
///     Class which provides validated security information for use in controllers.
/// </summary>
public sealed class AuthInfo(IHttpContextAccessor httpContextAccessor) : IAuthInfo
{
	private readonly Lazy<AuthData> _data = new(() =>
	{
		ClaimsPrincipal? user = httpContextAccessor.HttpContext?.User;
		if (user is null)
		{
			throw new InvalidOperationException("HttpContext must be present to inspect auth info.");
		}

		Claim? userIdClaim = user.FindFirst(ClaimConstants.Oid)
			?? user.FindFirst(ClaimConstants.ObjectId)
			?? user.FindFirst(ClaimConstants.Sub)
			?? user.FindFirst(ClaimConstants.NameIdentifierId);
		if (userIdClaim is null)
		{
			throw new CredentialUnavailableException("User Id was not present in the request token.");
		}

		Claim? tenantIdClaim = user.FindFirst(ClaimConstants.Tid)
			?? user.FindFirst(ClaimConstants.TenantId);
		Claim? userNameClaim = user.FindFirst(ClaimConstants.Name);
		if (userNameClaim is null)
		{
			throw new CredentialUnavailableException("User name was not present in the request token.");
		}

		Claim emailAddressClaim = user.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")
			?? new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "Unknown@AIEmpowerlabs.com");

		return new AuthData
		{
			UserId = tenantIdClaim is null
				? userIdClaim.Value
				: string.Join(".", userIdClaim.Value, tenantIdClaim.Value),
			UserName = userNameClaim.Value,
			EmailAddress = emailAddressClaim.Value
		};
	}, false);

	/// <summary>
	///     The authenticated user's unique ID.
	/// </summary>
	public string UserId => _data.Value.UserId;

	/// <summary>
	///     The authenticated user's name.
	/// </summary>
	public string Name => _data.Value.UserName;

	public string EmailAddress => _data.Value.EmailAddress;

	private record struct AuthData(string UserId, string UserName, string EmailAddress);
}
