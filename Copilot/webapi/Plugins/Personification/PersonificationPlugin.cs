using System;
using System.ComponentModel;

using CopilotChat.WebApi.Auth;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;

namespace CopilotChat.WebApi.Plugins.Personification;

/// <summary>
/// PersonificationPlugin provides username and email for current user.
/// </summary>
internal sealed class PersonificationPlugin(IServiceProvider serviceProvider)
{
	/// <summary>
	/// Get the name of the authenticated user
	/// </summary>
	/// <returns>The name if the authenticated user</returns>
	[KernelFunction, Description("Get the name of the authenticated user.")]
	public string CurrentName()
	{
		IAuthInfo authInfo = serviceProvider.GetRequiredService<IAuthInfo>();
		return authInfo.Name;
	}

	/// <summary>
	/// Get the email address of the authenticated user
	/// </summary>
	/// <returns>The name if the authenticated user</returns>
	[KernelFunction, Description("Get the email address of the authenticated user.")]
	public string EmailAddress()
	{
		IAuthInfo authInfo = serviceProvider.GetRequiredService<IAuthInfo>();
		return authInfo.EmailAddress;
	}
}
