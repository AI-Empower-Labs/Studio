// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Xunit;

namespace ChatCopilotIntegrationTests;

/// <summary>
///     Base class for Chat Copilot integration tests
/// </summary>
[Trait("Category", "Integration Tests")]
public abstract class ChatCopilotIntegrationTest : IDisposable
{
    private const string BaseUrlSettingName = "BaseServerUrl";
    protected const string ClientIdSettingName = "ClientID";
    protected const string AuthoritySettingName = "Authority";
    private const string UsernameSettingName = "TestUsername";
    private const string PasswordSettingName = "TestPassword";
    private const string ScopesSettingName = "Scopes";

    protected readonly HttpClient HttpClient;
    protected readonly IConfigurationRoot Configuration;

    protected ChatCopilotIntegrationTest()
    {
        // Load configuration
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("testsettings.json", false, true)
            .AddJsonFile("testsettings.development.json", true, true)
            .AddEnvironmentVariables()
            .AddUserSecrets<HealthzTests>()
            .Build();

        string? baseUrl = Configuration[BaseUrlSettingName];
        Assert.False(string.IsNullOrEmpty(baseUrl));
        Assert.True(baseUrl.EndsWith('/'));

        HttpClient = new HttpClient();
        HttpClient.BaseAddress = new Uri(baseUrl);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            HttpClient.Dispose();
        }
    }

    protected async Task SetUpAuth()
    {
        string accesstoken = await GetUserTokenByPassword();
        Assert.True(!string.IsNullOrEmpty(accesstoken));

        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accesstoken);
    }

    protected async Task<string> GetUserTokenByPassword()
    {
        IPublicClientApplication app = PublicClientApplicationBuilder.Create(Configuration[ClientIdSettingName])
            .WithAuthority(Configuration[AuthoritySettingName])
            .Build();

        string? scopeString = Configuration[ScopesSettingName];
        Assert.NotNull(scopeString);

        string[] scopes = scopeString.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        IEnumerable<IAccount>? accounts = await app.GetAccountsAsync();

        AuthenticationResult? result = null;

        if (accounts.Any())
        {
            result = await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault()).ExecuteAsync();
        }
        else
        {
            result = await app.AcquireTokenByUsernamePassword(scopes, Configuration[UsernameSettingName],
                Configuration[PasswordSettingName]).ExecuteAsync();
        }

        return result?.AccessToken ?? string.Empty;
    }
}
