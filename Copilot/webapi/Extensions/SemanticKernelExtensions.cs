// Copyright (c) Microsoft. All rights reserved.

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Plugins.Chat;
using CopilotChat.WebApi.Plugins.Email;
using CopilotChat.WebApi.Plugins.Personification;
using CopilotChat.WebApi.Services;
using CopilotChat.WebApi.Storage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.KernelMemory;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Plugins.Core;

namespace CopilotChat.WebApi.Extensions;

/// <summary>
///     Extension methods for registering Semantic Kernel related services.
/// </summary>
public static class SemanticKernelExtensions
{
    /// <summary>
    ///     Delegate to register functions with a Semantic Kernel
    /// </summary>
    public delegate Task RegisterFunctionsWithKernel(IServiceProvider sp, Kernel kernel);

    /// <summary>
    ///     Add Semantic Kernel services
    /// </summary>
    public static WebApplicationBuilder AddSemanticKernelServices(this WebApplicationBuilder builder)
    {
        builder.InitializeKernelProvider();

        builder.Services.AddSingleton<DocumentTypeProvider>();

        // Register plugins
        builder.Services.AddScoped<RegisterFunctionsWithKernel>(_ => RegisterChatCopilotFunctionsAsync);

        return builder;
    }

    /// <summary>
    ///     Register the chat plugin with the kernel.
    /// </summary>
	private static void RegisterChatPlugin(this Kernel kernel, IServiceProvider sp)
    {
        // Chat plugin
        kernel.ImportPluginFromObject(
            new ChatPlugin(
                kernel,
                sp.GetRequiredService<IKernelMemory>(),
                sp.GetRequiredService<ChatMessageRepository>(),
                sp.GetRequiredService<ChatSessionRepository>(),
                sp.GetRequiredService<IHubContext<MessageRelayHub>>(),
                sp.GetRequiredService<IOptions<PromptsOptions>>(),
                sp.GetRequiredService<ILogger<ChatPlugin>>()),
            nameof(ChatPlugin));
	}

    private static void InitializeKernelProvider(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<SemanticKernelProvider>();
    }

    /// <summary>
    ///     Register functions with the main kernel responsible for handling Chat Copilot requests.
    /// </summary>
    private static Task RegisterChatCopilotFunctionsAsync(IServiceProvider sp, Kernel kernel)
    {
        // Chat Copilot functions
        kernel.RegisterChatPlugin(sp);

		kernel.ImportPluginFromObject(new TimePlugin(), nameof(TimePlugin));
		kernel.ImportPluginFromObject(new PersonificationPlugin(sp), nameof(PersonificationPlugin));
		kernel.Plugins.AddFromType<AuthorEmailPlanner>();

        return Task.CompletedTask;
    }

    /// <summary>
    ///     Register plugins with a given kernel.
    /// </summary>
    private static Task RegisterPluginsAsync(IServiceProvider sp, Kernel kernel)
    {
        ILogger logger = kernel.LoggerFactory.CreateLogger(nameof(Kernel));

        // Semantic plugins
        ServiceOptions options = sp.GetRequiredService<IOptions<ServiceOptions>>().Value;
        if (!string.IsNullOrWhiteSpace(options.SemanticPluginsDirectory))
        {
            foreach (string subDir in Directory.GetDirectories(options.SemanticPluginsDirectory))
            {
                try
                {
                    kernel.ImportPluginFromPromptDirectory(options.SemanticPluginsDirectory, Path.GetFileName(subDir));
                }
                catch (KernelException ex)
                {
                    logger.LogError("Could not load plugin from {Directory}: {Message}", subDir, ex.Message);
                }
            }
        }

        // Native plugins
        if (!string.IsNullOrWhiteSpace(options.NativePluginsDirectory))
        {
            // Loop through all the files in the directory that have the .cs extension
            string[] pluginFiles = Directory.GetFiles(options.NativePluginsDirectory, "*.cs");
            foreach (string file in pluginFiles)
            {
                // Parse the name of the class from the file name (assuming it matches)
                string className = Path.GetFileNameWithoutExtension(file);

                // Get the type of the class from the current assembly
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type? classType = assembly.GetTypes().FirstOrDefault(t =>
                    t.Name.Contains(className, StringComparison.CurrentCultureIgnoreCase));

                // If the type is found, create an instance of the class using the default constructor
                if (classType is not null)
                {
                    try
                    {
                        object? plugin = Activator.CreateInstance(classType);
                        kernel.ImportPluginFromObject(plugin!, classType.Name);
                    }
                    catch (KernelException ex)
                    {
                        logger.LogError("Could not load plugin from file {File}: {Details}", file, ex.Message);
                    }
                }
                else
                {
                    logger.LogError(
                        "Class type not found. Make sure the class type matches exactly with the file name {FileName}",
                        className);
                }
            }
        }

        return Task.CompletedTask;
    }
}
