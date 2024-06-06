// Copyright (c) Microsoft. All rights reserved.

using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Response;
using Xunit;

namespace ChatCopilotIntegrationTests;

public sealed class SpeechTokenTests : ChatCopilotIntegrationTest
{
    [Fact]
    public async Task GetSpeechToken()
    {
        await SetUpAuth();

        HttpResponseMessage response = await HttpClient.GetAsync("speechToken/");
        response.EnsureSuccessStatusCode();

        Stream contentStream = await response.Content.ReadAsStreamAsync();
        SpeechTokenResponse? speechTokenResponse =
            await JsonSerializer.DeserializeAsync<SpeechTokenResponse>(contentStream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        Assert.NotNull(speechTokenResponse);
        Assert.True((speechTokenResponse.IsSuccess == true && !string.IsNullOrEmpty(speechTokenResponse.Token)) ||
                    speechTokenResponse.IsSuccess == false);
    }
}
