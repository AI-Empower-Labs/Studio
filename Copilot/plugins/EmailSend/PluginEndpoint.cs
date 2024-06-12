using System.IO;
using System.Threading;
using System.Threading.Tasks;

using FluentEmail.Core;
using FluentEmail.Core.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

using Plugins.EmailSend.Models;
using Plugins.PluginShared;

using Uri = System.Uri;

namespace Plugins.EmailSend;

/// <summary>
///     Plugin endpoints
/// </summary>
public sealed class PluginEndpoint
{
	/// <summary>
	///     Gets the plugin manifest.
	/// </summary>
	/// <returns>The manifest in Json</returns>
	public static IResult WellKnownAiPluginManifest(HttpContext httpContext)
	{
		HttpRequest req = httpContext.Request;
		Uri reqUrl = new(req.GetDisplayUrl());
		PluginManifest pluginManifest = new()
		{
			NameForModel = "EmailSender",
			NameForHuman = "EmailSender",
			DescriptionForModel = "Send an email with recipient, subject and body",
			DescriptionForHuman = "Send an email with recipient, subject and body",
			ContactEmail = "support@aiempowerlabs.com",
			Auth = new PluginAuth
			{
				Type = "none"
			},
			Api = new PluginApi
			{
				Type = "openapi",
				Url = $"{reqUrl.Scheme}://{reqUrl.Host}:{reqUrl.Port}/swagger/v1/swagger.json"
			},
			LogoUrl = $"{reqUrl.Scheme}://{reqUrl.Host}:{reqUrl.Port}/.well-known/icon"
		};

		return Results.Ok(pluginManifest);
	}

	/// <summary>
	///     Gets the plugin's icon.
	/// </summary>
	/// <returns>The icon.</returns>
	public static IResult Icon()
	{
		if (!File.Exists("./Icons/smtp.png"))
		{
			return Results.NotFound();
		}

#pragma warning disable CA2000
		FileStream stream = File.OpenRead("./Icons/smtp.png");
		return Results.Stream(stream, "image/png");
	}

	/// <summary>
	///     Search the web for the given query.
	/// </summary>
	/// <returns>A string representing the search result.</returns>
	public static async Task<IResult> SendEmail(
		string recipientEmails,
		string subject,
		string body,
		PluginConfig config,
		CancellationToken cancellationToken)
	{
		SendResponse email = await Email
			.From(config.SenderEmail, config.SenderName)
			.To(recipientEmails)
			.Subject(subject)
			.Body(body)
			.SendAsync(cancellationToken);

		return email.Successful
			? Results.Text("Email is sent.")
			: Results.Text("Email failed to send because: {0}.", string.Join(',', email.ErrorMessages));
	}
}
