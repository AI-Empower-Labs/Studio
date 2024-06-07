// Copyright (c) Microsoft.All rights reserved.

using System.ComponentModel;
using System.Threading.Tasks;

using Microsoft.SemanticKernel;

namespace CopilotChat.WebApi.Plugins.Email;

// Suppress compiler warning that warns when a member is marked as static but does not access any 'static' data and could be made non-static.
#pragma warning disable CA1822

internal sealed class AuthorEmailPlanner
{
	[KernelFunction]
	[Description("Returns back the required steps necessary to author an email.")]
	[return: Description("The list of steps needed to author an email")]
	public async Task<string> GenerateRequiredStepsAsync(
		Kernel kernel,
		[Description("A 2-3 sentence description of what the email should be about")]
		string topic,
		[Description("A description of the recipients")]
		string recipients)
	{
		// Prompt the LLM to generate a list of steps to complete the task
		FunctionResult result = await kernel.InvokePromptAsync(
			$"""
			I'm going to write an email to {recipients} about {topic} on behalf of a user.
			Before I do that, can you succinctly recommend the top 3 steps I should take in a numbered list?
			I want to make sure I don't forget anything that would help my user's email sound more professional.
			Only send email when user explicitly says so!
			""",
			new()
			{
				{ "topic", topic },
				{ "recipients", recipients }
			});

		// Return the plan back to the agent
		return result.ToString();
	}
}
