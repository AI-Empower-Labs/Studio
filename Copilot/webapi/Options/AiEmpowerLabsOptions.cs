// Copyright (c) Microsoft.All rights reserved.

using System.ComponentModel.DataAnnotations;

namespace CopilotChat.WebApi.Options;

public sealed record AiEmpowerLabsOptions
{
	public const string PropertyName = "AIEmpowerLabs";

	[Required, Url]
	public required string Url { get; init; }

	[Required, NotEmptyOrWhitespace]
	public required string LlmModelName { get; init; }

	public required bool EnableLangfuse { get; init; }
}
