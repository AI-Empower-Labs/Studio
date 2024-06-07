// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CopilotChat.WebApi.Auth;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Models.Request;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Models.Storage;
using CopilotChat.WebApi.Options;
using CopilotChat.WebApi.Plugins.Chat;
using CopilotChat.WebApi.Storage;
using CopilotChat.WebApi.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Plugins.OpenApi;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
///     Controller responsible for handling chat messages and responses.
/// </summary>
[ApiController]
public sealed class ChatController(
    ILogger<ChatController> logger,
    IHttpClientFactory httpClientFactory,
    IOptions<ServiceOptions> serviceOptions,
    IDictionary<string, Plugin> plugins)
    : ControllerBase
{
    private const string ChatPluginName = nameof(ChatPlugin);
    private const string ChatFunctionName = "Chat";
    private const string GeneratingResponseClientCall = "ReceiveBotResponseStatus";
    private readonly ServiceOptions _serviceOptions = serviceOptions.Value;

    /// <summary>
    ///     Invokes the chat function to get a response from the bot.
    /// </summary>
    /// <param name="kernel">Semantic kernel obtained through dependency injection.</param>
    /// <param name="messageRelayHubContext">Message Hub that performs the real time relay service.</param>
    /// <param name="chatSessionRepository">Repository of chat sessions.</param>
    /// <param name="chatParticipantRepository">Repository of chat participants.</param>
    /// <param name="authInfo">Auth info for the current request.</param>
    /// <param name="ask">Prompt along with its parameters.</param>
    /// <param name="chatId">Chat ID.</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Results containing the response from the model.</returns>
    [Route("chats/{chatId:guid}/messages")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
    public async Task<IActionResult> ChatAsync(
        [FromServices] Kernel kernel,
        [FromServices] IHubContext<MessageRelayHub> messageRelayHubContext,
        [FromServices] ChatSessionRepository chatSessionRepository,
        [FromServices] ChatParticipantRepository chatParticipantRepository,
        [FromServices] IAuthInfo authInfo,
        [FromBody] Ask ask,
        [FromRoute] Guid chatId,
        CancellationToken cancellationToken)
    {
        logger.LogDebug("Chat message received");

        string chatIdString = chatId.ToString();

        // Put ask's variables in the context we will use.
        KernelArguments contextVariables = GetContextVariables(ask, authInfo, chatIdString);

        // Verify that the chat exists and that the user has access to it.
        ChatSession? chat = null;
        if (!await chatSessionRepository.TryFindById(chatIdString, callback: c => chat = c, cancellationToken: cancellationToken)
			|| chat is null)
        {
            return NotFound("Failed to find chat session for the chatId specified in variables.");
        }

        if (!await chatParticipantRepository.IsUserInChatAsync(authInfo.UserId, chatIdString, cancellationToken))
        {
            return Forbid("User does not have access to the chatId specified in variables.");
        }

        // Register plugins that have been enabled
        Dictionary<string, string> openApiPluginAuthHeaders = GetPluginAuthHeaders(HttpContext.Request.Headers);
        await RegisterFunctionsAsync(kernel, openApiPluginAuthHeaders, contextVariables);

        // Register hosted plugins that have been enabled
        await RegisterHostedFunctionsAsync(kernel, chat.EnabledPlugins);

        // Get the function to invoke
        KernelFunction chatFunction = kernel.Plugins.GetFunction(ChatPluginName, ChatFunctionName);

        // Run the function.
        FunctionResult? result;
        try
        {
            using CancellationTokenSource? cts = _serviceOptions.TimeoutLimitInS is not null
                // Create a cancellation token source with the timeout if specified
                ? new CancellationTokenSource(TimeSpan.FromSeconds((double)_serviceOptions.TimeoutLimitInS))
                : null;

            result = await kernel.InvokeAsync(chatFunction, contextVariables, cts?.Token ?? default);
        }
        catch (Exception ex)
        {
            if (ex is OperationCanceledException || ex.InnerException is OperationCanceledException)
            {
                // Log the timeout and return a 504 response
                logger.LogError("The {FunctionName} operation timed out", ChatFunctionName);
                return StatusCode(StatusCodes.Status504GatewayTimeout, $"The chat {ChatFunctionName} timed out.");
            }

            throw;
        }

        AskResult chatAskResult = new()
        {
            Value = result.ToString(),
            Variables = contextVariables.Select(v => new KeyValuePair<string, object?>(v.Key, v.Value))
        };

        // Broadcast AskResult to all users
        await messageRelayHubContext.Clients
	        .Group(chatIdString)
            .SendAsync(GeneratingResponseClientCall, chatIdString, null, cancellationToken: cancellationToken);

        return Ok(chatAskResult);
    }

    /// <summary>
    ///     Parse plugin auth values from request headers.
    /// </summary>
    private static Dictionary<string, string> GetPluginAuthHeaders(IHeaderDictionary headers)
    {
        // Create a regex to match the headers
        Regex regex = new("x-sk-copilot-(.*)-auth", RegexOptions.IgnoreCase);

        // Create a dictionary to store the matched headers and values
        Dictionary<string, string> authHeaders = new();

        // Loop through the request headers and add the matched ones to the dictionary
        foreach (KeyValuePair<string, StringValues> header in headers)
        {
            Match match = regex.Match(header.Key);
            if (match.Success)
            {
                // Use the first capture group as the key and the header value as the value
                authHeaders.Add(match.Groups[1].Value.ToUpperInvariant(), header.Value!);
            }
        }

        return authHeaders;
    }

    /// <summary>
    ///     Register functions with the kernel.
    /// </summary>
    private async Task RegisterFunctionsAsync(Kernel kernel, Dictionary<string, string> authHeaders,
        KernelArguments variables)
    {
        // Register authenticated functions with the kernel only if the request includes an auth header for the plugin.

        List<Task> tasks = new();

        // GitHub
        if (authHeaders.TryGetValue("GITHUB", out string? githubAuthHeader))
        {
            tasks.Add(RegisterGithubPluginAsync(kernel, githubAuthHeader));
        }

        // Jira
        if (authHeaders.TryGetValue("JIRA", out string? jiraAuthHeader))
        {
            tasks.Add(RegisterJiraPluginAsync(kernel, jiraAuthHeader, variables));
        }

        if (variables.TryGetValue("customPlugins", out object? customPluginsString))
        {
            tasks.AddRange(RegisterCustomPlugins(kernel, customPluginsString, authHeaders));
        }

        await Task.WhenAll(tasks);
    }

    private async Task RegisterGithubPluginAsync(Kernel kernel, string githubAuthHeader)
    {
        logger.LogInformation("Enabling GitHub plugin");
        BearerAuthenticationProvider authenticationProvider = new(() => Task.FromResult(githubAuthHeader));
        string pluginFullPath = GetPluginFullPath("OpenApi/GitHubPlugin/openapi.json");
        await kernel.ImportPluginFromOpenApiAsync(
            "GitHubPlugin",
            pluginFullPath,
            new OpenApiFunctionExecutionParameters
            {
                AuthCallback = authenticationProvider.AuthenticateRequestAsync
            });
    }

    private async Task RegisterJiraPluginAsync(Kernel kernel, string jiraAuthHeader, KernelArguments variables)
    {
        logger.LogInformation("Registering Jira plugin");
        BasicAuthenticationProvider authenticationProvider = new(() => Task.FromResult(jiraAuthHeader));
        bool hasServerUrlOverride = variables.TryGetValue("jira-server-url", out object? serverUrlOverride);

        await kernel.ImportPluginFromOpenApiAsync(
            "JiraPlugin",
            GetPluginFullPath("OpenApi/JiraPlugin/openapi.json"),
            new OpenApiFunctionExecutionParameters
            {
                AuthCallback = authenticationProvider.AuthenticateRequestAsync,
                ServerUrlOverride = hasServerUrlOverride ? new Uri(serverUrlOverride!.ToString()!) : null
            });
    }

    private IEnumerable<Task> RegisterCustomPlugins(Kernel kernel, object? customPluginsString,
        Dictionary<string, string> authHeaders)
    {
        CustomPlugin[]? customPlugins = JsonSerializer.Deserialize<CustomPlugin[]>(customPluginsString!.ToString()!);

        if (customPlugins is not null)
        {
            foreach (CustomPlugin plugin in customPlugins)
            {
                if (authHeaders.TryGetValue(plugin.AuthHeaderTag.ToUpperInvariant(), out string? pluginAuthValue))
                {
                    // Register the ChatGPT plugin with the kernel.
                    logger.LogInformation("Enabling {Name} plugin", plugin.NameForHuman);

                    // TODO: [Issue #44] Support other forms of auth. Currently, we only support user PAT or no auth.
                    bool requiresAuth = !plugin.AuthType.Equals("none", StringComparison.OrdinalIgnoreCase);

                    Task AuthCallback(HttpRequestMessage request, string _, OpenAIAuthenticationConfig __,
                        CancellationToken ___ = default)
                    {
                        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", pluginAuthValue);

                        return Task.CompletedTask;
                    }

                    yield return kernel.ImportPluginFromOpenAIAsync(
                        $"{plugin.NameForModel}Plugin",
                        PluginUtils.GetPluginManifestUri(plugin.ManifestDomain),
                        new OpenAIFunctionExecutionParameters
                        {
                            HttpClient = httpClientFactory.CreateClient(),
                            IgnoreNonCompliantErrors = true,
                            AuthCallback = requiresAuth ? AuthCallback : null
                        });
                }
            }
        }
        else
        {
            logger.LogDebug("Failed to deserialize custom plugin details: {Plugin}", customPluginsString);
        }
    }

    private async Task RegisterHostedFunctionsAsync(Kernel kernel, HashSet<string> enabledPlugins)
    {
        foreach (string enabledPlugin in enabledPlugins)
        {
            if (plugins.TryGetValue(enabledPlugin, out Plugin? plugin))
            {
                logger.LogDebug("Enabling hosted plugin {Plugin}", plugin.Name);

                Task AuthCallback(HttpRequestMessage request, string _, OpenAIAuthenticationConfig __,
                    CancellationToken ___ = default)
                {
                    request.Headers.Add("X-Functions-Key", plugin.Key);

                    return Task.CompletedTask;
                }

                // Register the ChatGPT plugin with the kernel.
                await kernel.ImportPluginFromOpenAIAsync(
                    PluginUtils.SanitizePluginName(plugin.Name),
                    PluginUtils.GetPluginManifestUri(plugin.ManifestDomain),
                    new OpenAIFunctionExecutionParameters
                    {
                        HttpClient = httpClientFactory.CreateClient(),
                        IgnoreNonCompliantErrors = true,
                        AuthCallback = AuthCallback
                    });
            }
            else
            {
                logger.LogWarning("Failed to find plugin {Plugin}", enabledPlugin);
            }
        }
    }

    private static KernelArguments GetContextVariables(Ask ask, IAuthInfo authInfo, string chatId)
    {
        const string userIdKey = "userId";
        const string userNameKey = "userName";
        const string chatIdKey = "chatId";
        const string messageKey = "message";

        KernelArguments contextVariables = new();
        foreach (KeyValuePair<string, string> variable in ask.Variables)
        {
            contextVariables[variable.Key] = variable.Value;
        }

        contextVariables[userIdKey] = authInfo.UserId;
        contextVariables[userNameKey] = authInfo.Name;
        contextVariables[chatIdKey] = chatId;
        contextVariables[messageKey] = ask.Input;

        return contextVariables;
    }

    private static string GetPluginFullPath(string pluginPath)
    {
        return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "Plugins", pluginPath);
    }
}

/// <summary>
///     Retrieves authentication content (e.g. username/password, API key) via the provided delegate and
///     applies it to HTTP requests using the "basic" authentication scheme.
/// </summary>
public class BasicAuthenticationProvider
{
    private readonly Func<Task<string>> _credentialsDelegate;

    /// <summary>
    ///     Creates an instance of the <see cref="BasicAuthenticationProvider" /> class.
    /// </summary>
    /// <param name="credentialsDelegate">Delegate for retrieving credentials.</param>
    public BasicAuthenticationProvider(Func<Task<string>> credentialsDelegate)
    {
        _credentialsDelegate = credentialsDelegate;
    }

    /// <summary>
    ///     Applies the authentication content to the provided HTTP request message.
    /// </summary>
    /// <param name="request">The HTTP request message.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public async Task AuthenticateRequestAsync(HttpRequestMessage request,
        CancellationToken cancellationToken = default)
    {
        // Base64 encode
        string encodedContent =
            Convert.ToBase64String(Encoding.UTF8.GetBytes(await _credentialsDelegate().ConfigureAwait(false)));
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", encodedContent);
    }
}

/// <summary>
///     Retrieves a token via the provided delegate and applies it to HTTP requests using the
///     "bearer" authentication scheme.
/// </summary>
public class BearerAuthenticationProvider
{
    private readonly Func<Task<string>> _bearerTokenDelegate;

    /// <summary>
    ///     Creates an instance of the <see cref="BearerAuthenticationProvider" /> class.
    /// </summary>
    /// <param name="bearerTokenDelegate">Delegate to retrieve the bearer token.</param>
    public BearerAuthenticationProvider(Func<Task<string>> bearerTokenDelegate)
    {
        _bearerTokenDelegate = bearerTokenDelegate;
    }

    /// <summary>
    ///     Applies the token to the provided HTTP request message.
    /// </summary>
    /// <param name="request">The HTTP request message.</param>
    /// <param name="cancellationToken"></param>
    public async Task AuthenticateRequestAsync(HttpRequestMessage request,
        CancellationToken cancellationToken = default)
    {
        string token = await _bearerTokenDelegate().ConfigureAwait(false);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    /// <summary>
    ///     Applies the token to the provided HTTP request message.
    /// </summary>
    /// <param name="request">The HTTP request message.</param>
    public async Task GraphClientAuthenticateRequestAsync(HttpRequestMessage request)
    {
        await AuthenticateRequestAsync(request);
    }

    /// <summary>
    ///     Applies the token to the provided HTTP request message.
    /// </summary>
    /// <param name="request">The HTTP request message.</param>
    /// <param name="cancellationToken"></param>
    public async Task OpenAiAuthenticateRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken = default)
    {
        await AuthenticateRequestAsync(request, cancellationToken);
    }
}
