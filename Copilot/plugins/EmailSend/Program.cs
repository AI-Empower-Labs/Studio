using System.Net;
using System.Net.Mail;
using System.Text.Json;
using System.Threading;

using FluentEmail.Core;
using FluentEmail.Smtp;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

using Plugins.EmailSend;
using Plugins.EmailSend.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets<Program>(true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo { Title = "Copilot Email Sender using SMTP", Version = "v1" });
});
builder.Services.Configure<JsonSerializerOptions>(options => options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);

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
app.UseSwagger();
app.MapGet("/.well-known/ai-plugin.json", PluginEndpoint.WellKnownAiPluginManifest).ExcludeFromDescription();
app.MapGet("/.well-known/icon", PluginEndpoint.Icon).ExcludeFromDescription();
app.MapGet("/get", (
			[FromServices] IOptions<PluginConfig> config,
			[FromQuery(Name = "recipientEmails")] string recipientEmails,
			[FromQuery(Name = "subject")] string subject,
			[FromQuery(Name = "body")] string body,
			CancellationToken cancellationToken) =>
		PluginEndpoint.SendEmail(recipientEmails, subject, body, config.Value, cancellationToken))
	.WithName("Email")
	.WithOpenApi(operation =>
	{
		operation.Summary = "Sends an email to a recipient with recipient, subject and body";
		operation.Description = "Endpoint to send an email to a recipient.";
		operation.Parameters[0].Description = "Semicolon delimited list of emails of the recipients.";
		operation.Parameters[1].Description = "The subject of the email.";
		operation.Parameters[2].Description = "The content of the email.";
		return operation;
	});
app.Run();
