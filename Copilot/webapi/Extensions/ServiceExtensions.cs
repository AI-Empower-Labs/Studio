// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;

using CopilotChat.Shared;
using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Services;
using CopilotChat.WebApi.Storage;
using CopilotChat.WebApi.Utilities;

using Marten;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Web;
using Microsoft.KernelMemory;
using Microsoft.KernelMemory.Diagnostics;

using Weasel.Core;

namespace CopilotChat.WebApi.Extensions;

/// <summary>
///     Extension methods for <see cref="IServiceCollection" />.
///     Add options and services for Chat Copilot.
/// </summary>
internal static class CopilotChatServiceExtensions
{
	/// <summary>
	///     Parse configuration into options.
	/// </summary>
	public static IServiceCollection AddOptions(this IServiceCollection services, ConfigurationManager configuration)
	{
		// General configuration
		AddOptionsLocal<ServiceOptions>(ServiceOptions.PropertyName);

		// Authentication configuration
		AddOptionsLocal<ChatAuthenticationOptions>(ChatAuthenticationOptions.PropertyName);

		// Chat prompt options
		AddOptionsLocal<PromptsOptions>(PromptsOptions.PropertyName);

		// AI Empower Labs Options
		AddOptionsLocal<AiEmpowerLabsOptions>(AiEmpowerLabsOptions.PropertyName);

		AddOptionsLocal<FrontendOptions>(FrontendOptions.PropertyName);

		return services;

		void AddOptionsLocal<TOptions>(string propertyName) where TOptions : class
		{
			services.AddOptions<TOptions>(configuration.GetSection(propertyName));
		}
	}

	private static void AddOptions<TOptions>(this IServiceCollection services, IConfigurationSection section)
		where TOptions : class
	{
		services.AddOptions<TOptions>()
			.Bind(section)
			.ValidateDataAnnotations()
			.ValidateOnStart()
			.PostConfigure(TrimStringProperties);
	}

	internal static IServiceCollection AddPlugins(this IServiceCollection services, IConfiguration configuration)
	{
		List<Plugin> plugins = configuration.GetSection("Plugins").Get<List<Plugin>>() ?? [];
		ILogger<Program> logger = services.BuildServiceProvider().GetRequiredService<ILogger<Program>>();
		logger.LogDebug("Found {Count} plugins", plugins.Count);

		// Validate the plugins
		Dictionary<string, Plugin> validatedPlugins = new();
		foreach (Plugin plugin in plugins)
		{
			if (validatedPlugins.ContainsKey(plugin.Name))
			{
				logger.LogWarning("Plugin '{Name}' is defined more than once. Skipping...", plugin.Name);
				continue;
			}

			Uri pluginManifestUrl = PluginUtils.GetPluginManifestUri(plugin.ManifestDomain);
			using HttpRequestMessage request = new(HttpMethod.Get, pluginManifestUrl);
			// Need to set the user agent to avoid 403s from some sites.
			request.Headers.Add("User-Agent", Telemetry.HttpUserAgent);
			try
			{
				logger.LogInformation("Adding plugin: {Name}", plugin.Name);
				using HttpClient httpClient = new();
				HttpResponseMessage response = httpClient.SendAsync(request).Result;
				if (!response.IsSuccessStatusCode)
				{
					throw new InvalidOperationException(
						$"Plugin '{plugin.Name}' at '{pluginManifestUrl}' returned status code '{response.StatusCode}'.");
				}

				validatedPlugins.Add(plugin.Name, plugin);
				logger.LogInformation("Added plugin: {Name}", plugin.Name);
			}
			catch (Exception ex) when (ex is InvalidOperationException or AggregateException)
			{
				logger.LogWarning(ex, "Plugin '{Name}' at {Url} responded with error. Skipping...", plugin.Name,
					pluginManifestUrl);
			}
			catch (Exception ex) when (ex is UriFormatException)
			{
				logger.LogWarning("Plugin '{Name}' at {Url} is not a valid URL. Skipping...", plugin.Name,
					pluginManifestUrl);
			}
		}

		// Add the plugins
		services.AddSingleton<IDictionary<string, Plugin>>(validatedPlugins);

		return services;
	}

	internal static IServiceCollection AddMaintenanceServices(this IServiceCollection services)
	{
		// Inject action stub
		services.AddSingleton<IReadOnlyList<IMaintenanceAction>>(
			_ => Array.Empty<IMaintenanceAction>());

		return services;
	}

	/// <summary>
	///     Add CORS settings.
	/// </summary>
	internal static IServiceCollection AddCorsPolicy(this IServiceCollection services, IConfiguration configuration)
	{
		string[] allowedOrigins = configuration.GetSection("AllowedOrigins").Get<string[]>() ?? [];
		if (allowedOrigins.Length > 0)
		{
			services.AddCors(options =>
			{
				options.AddDefaultPolicy(
					policy =>
					{
						policy.WithOrigins(allowedOrigins)
							.WithMethods("POST", "GET", "PUT", "DELETE", "PATCH")
							.AllowAnyHeader();
					});
			});
		}

		return services;
	}

	/// <summary>
	///     Add persistent chat store services.
	/// </summary>
	public static IServiceCollection AddPersistentChatStore(this IServiceCollection services, IConfiguration configuration)
	{
		string? postgresConnectionString = configuration.GetConnectionString("postgres");

		if (!string.IsNullOrEmpty(postgresConnectionString))
		{
			services
				.AddMarten(options =>
				{
					options.Connection(postgresConnectionString);
					options.UseSystemTextJsonForSerialization(enumStorage: EnumStorage.AsString);
				})
				.UseLightweightSessions();
			services.AddSingleton<IStorageContext<ChatSession>, PostgresContext<ChatSession>>();
			services.AddSingleton<IStorageContext<MemorySource>, PostgresContext<MemorySource>>();
			services.AddSingleton<IStorageContext<ChatParticipant>, PostgresContext<ChatParticipant>>();
			services.AddSingleton<ICopilotChatMessageStorageContext, PostgresCopilotChatMessageContext>();
		}
		else
		{
			services.AddSingleton<IStorageContext<ChatSession>, VolatileContext<ChatSession>>();
			services.AddSingleton<IStorageContext<MemorySource>, VolatileContext<MemorySource>>();
			services.AddSingleton<IStorageContext<ChatParticipant>, VolatileContext<ChatParticipant>>();
			services.AddSingleton<ICopilotChatMessageStorageContext, VolatileCopilotChatMessageContext>();
		}

		services.AddSingleton<ChatSessionRepository>();
		services.AddSingleton<ChatMessageRepository>();
		services.AddSingleton<ChatMemorySourceRepository>();
		services.AddSingleton<ChatParticipantRepository>();

		return services;
	}

	/// <summary>
	///     Add authorization services
	/// </summary>
	public static IServiceCollection AddChatCopilotAuthorization(this IServiceCollection services)
	{
		return services.AddScoped<IAuthorizationHandler, ChatParticipantAuthorizationHandler>()
			.AddAuthorizationCore(options =>
			{
				options.DefaultPolicy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser()
					.Build();
				options.AddPolicy(AuthPolicyName.RequireChatParticipant, builder =>
				{
					builder.RequireAuthenticatedUser()
						.AddRequirements(new ChatParticipantRequirement());
				});
			});
	}

	/// <summary>
	///     Add authentication services
	/// </summary>
	public static IServiceCollection AddChatCopilotAuthentication(this IServiceCollection services,
		IConfiguration configuration)
	{
		services.AddScoped<IAuthInfo, AuthInfo>();
		ChatAuthenticationOptions config = services.BuildServiceProvider()
			.GetRequiredService<IOptions<ChatAuthenticationOptions>>().Value;
		switch (config.Type)
		{
			case ChatAuthenticationOptions.AuthenticationType.AzureAd:
				services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
					.AddMicrosoftIdentityWebApi(
						configuration.GetSection($"{ChatAuthenticationOptions.PropertyName}:AzureAd"));
				break;

			case ChatAuthenticationOptions.AuthenticationType.None:
				services.AddAuthentication(PassThroughAuthenticationHandler.AuthenticationScheme)
					.AddScheme<AuthenticationSchemeOptions, PassThroughAuthenticationHandler>(
						PassThroughAuthenticationHandler.AuthenticationScheme,
						null);
				break;

			default:
				throw new InvalidOperationException($"Invalid authentication type '{config.Type}'.");
		}

		return services;
	}

	/// <summary>
	///     Trim all string properties, recursively.
	/// </summary>
	private static void TrimStringProperties<T>(T options) where T : class
	{
		Queue<object> targets = new();
		targets.Enqueue(options);

		while (targets.Count > 0)
		{
			object target = targets.Dequeue();
			Type targetType = target.GetType();
			foreach (PropertyInfo property in targetType.GetProperties())
			{
				// Skip enumerations
				if (property.PropertyType.IsEnum)
				{
					continue;
				}

				// Skip index properties
				if (property.GetIndexParameters().Length == 0)
				{
					continue;
				}

				// Property is a built-in type, readable, and writable.
				if (property.PropertyType.Namespace == "System" &&
					property is { CanRead: true, CanWrite: true })
				{
					// Property is a non-null string.
					if (property.PropertyType == typeof(string) &&
						property.GetValue(target) is not null)
					{
						property.SetValue(target, property.GetValue(target)!.ToString()!.Trim());
					}
				}
				else
				{
					// Property is a non-built-in and non-enum type - queue it for processing.
					if (property.GetValue(target) is not null)
					{
						targets.Enqueue(property.GetValue(target)!);
					}
				}
			}
		}
	}
}
