// Copyright (c) Microsoft. All rights reserved.

using CopilotChat.WebApi.Models.Response;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopilotChat.WebApi.Controllers;

[ApiController]
public sealed class SpeechTokenController : ControllerBase
{
	/// <summary>
	///     Get an authorization token and region
	/// </summary>
	[Route("speechToken")]
	[HttpGet]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public ActionResult<SpeechTokenResponse> Get()
	{
		return new SpeechTokenResponse { IsSuccess = false };
	}
}
