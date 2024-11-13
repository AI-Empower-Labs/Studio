using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using FluentEmail.Core;
using FluentEmail.Smtp;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using Plugins.EmailSend;
using Plugins.EmailSend.Models;
using Plugins.PluginShared;

using Scalar.AspNetCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets<Program>(true);
builder.Services.Configure<JsonSerializerOptions>(options => options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);
builder.Services.AddOpenApi(options =>
{
	options.AddDocumentTransformer((document, _, _) =>
	{
		document.Info.Title = "Copilot Email Sender using SMTP";
		document.Info.Description = "Copilot Email Sender using SMTP";
		document.Info.Version = "v1";
		return Task.CompletedTask;
	});
	options.AddOperationTransformer<DescriptionEnrichmentOpenApiSchemaTransformer>();
});

IConfigurationSection section = builder.Configuration.GetSection(nameof(PluginConfig));
builder.Services.Configure<PluginConfig>(section);
PluginConfig pluginConfig = section.Get<PluginConfig>()!;
Email.DefaultSender = new SmtpSender(new SmtpClient(pluginConfig.SmtpServer, pluginConfig.SmtpServerPort)
{
	Credentials = new NetworkCredential(pluginConfig.SmtpUserName, pluginConfig.SmtpPassword),
	EnableSsl = true
});
builder.Services.AddFluentEmail("not_used");

using WebApplication app = builder.Build();
app.MapOpenApi();
app.MapScalarApiReference();

app.MapGet("/.well-known/ai-plugin.json", PluginEndpoint.WellKnownAiPluginManifest).ExcludeFromDescription();
app.MapGet("/.well-known/icon", PluginEndpoint.Icon).ExcludeFromDescription();
app.MapGet("/get", (
			[FromServices] IOptions<PluginConfig> config,
			[FromQuery(Name = "recipientEmails"), Description("Semicolon delimited list of emails of the recipients")]
			string recipientEmails,
			[FromQuery(Name = "subject"), Description("The subject of the email")]
			string subject,
			[FromQuery(Name = "body"), Description("The content of the email")]
			string body,
			CancellationToken cancellationToken) =>
		PluginEndpoint.SendEmail(recipientEmails, subject, body, config.Value, cancellationToken))
	.WithName("Email")
	.WithDisplayName("Email")
	.WithTags("Email")
	.WithDescription("Endpoint to send an email to a recipient")
	.WithSummary("Sends an email to a recipient with recipient, subject and body")
	.Produces<string>(contentType: "text/plain");
app.Run();
