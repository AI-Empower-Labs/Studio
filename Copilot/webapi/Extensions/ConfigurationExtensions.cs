// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace CopilotChat.WebApi.Extensions;

internal static class ConfigExtensions
{
    /// <summary>
    ///     Build the configuration for the service.
    /// </summary>
    public static IHostBuilder AddConfiguration(this IHostBuilder host)
    {
        string? environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        host.ConfigureAppConfiguration((_, configBuilder) =>
        {
            configBuilder.AddJsonFile(
                "appsettings.json",
                false,
                true);

            configBuilder.AddJsonFile(
                $"appsettings.{environment}.json",
                true,
                true);

            configBuilder.AddEnvironmentVariables();

            configBuilder.AddUserSecrets(
                Assembly.GetExecutingAssembly(),
                true,
                true);
        });

        return host;
    }
}
