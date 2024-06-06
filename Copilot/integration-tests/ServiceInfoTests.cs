// Copyright (c) Microsoft. All rights reserved.

using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Options;
using Xunit;

namespace ChatCopilotIntegrationTests;

public class ServiceInfoTests : ChatCopilotIntegrationTest
{
    [Fact]
    public async Task GetServiceInfo()
    {
        await SetUpAuth();

        HttpResponseMessage response = await HttpClient.GetAsync("info/");
        response.EnsureSuccessStatusCode();

        Stream contentStream = await response.Content.ReadAsStreamAsync();
        ServiceInfoResponse? objectFromResponse =
            await JsonSerializer.DeserializeAsync<ServiceInfoResponse>(contentStream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        Assert.NotNull(objectFromResponse);
        Assert.False(string.IsNullOrEmpty(objectFromResponse.MemoryStore.SelectedType));
        Assert.False(string.IsNullOrEmpty(objectFromResponse.Version));
    }

    [Fact]
    public async Task GetAuthConfig()
    {
        HttpResponseMessage response = await HttpClient.GetAsync("authConfig/");
        response.EnsureSuccessStatusCode();

        Stream contentStream = await response.Content.ReadAsStreamAsync();
        FrontendAuthConfig? objectFromResponse =
            await JsonSerializer.DeserializeAsync<FrontendAuthConfig>(contentStream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        Assert.NotNull(objectFromResponse);
        Assert.Equal(ChatAuthenticationOptions.AuthenticationType.AzureAd.ToString(), objectFromResponse.AuthType);
        Assert.Equal(Configuration[AuthoritySettingName], objectFromResponse.AadAuthority);
        Assert.Equal(Configuration[ClientIdSettingName], objectFromResponse.AadClientId);
        Assert.False(string.IsNullOrEmpty(objectFromResponse.AadApiScope));
    }
}
