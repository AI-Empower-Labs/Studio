// Copyright (c) Microsoft.All rights reserved.

using System;
using System.ComponentModel;
using System.Threading.Tasks;

using Microsoft.SemanticKernel;

namespace CopilotChat.WebApi.Plugins.Email;

// Suppress compiler warning that warns when a member is marked as static but does not access any 'static' data and could be made non-static.
#pragma warning disable CA1822

internal sealed class EmailPlugin
{
	[KernelFunction]
	[Description("Sends an email to a recipient.")]
	public Task SendEmail(
		Kernel kernel,
		[Description("Semicolon delimitated list of emails of the recipients")]
		string recipientEmails,
		[Description("The subject of the email")]
		string subject,
		[Description("The content of the email")]
		string body)
	{
		Console.WriteLine("Email sent!");
		Console.WriteLine(recipientEmails);
		Console.WriteLine(subject);
		Console.WriteLine(body);
		return Task.CompletedTask;
	}
}
