// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

using CopilotChat.WebApi.Models.Request;
using CopilotChat.WebApi.Models.Response;
using Xunit;
using static CopilotChat.WebApi.Models.Storage.CopilotChatMessage;

namespace ChatCopilotIntegrationTests;

public class ChatTests : ChatCopilotIntegrationTest
{
    [Fact]
    public async Task ChatMessagePostSucceedsWithValidInput()
    {
        await SetUpAuth();

        // Create chat session
        CreateChatParameters createChatParams = new() { Title = nameof(ChatMessagePostSucceedsWithValidInput) };
        HttpResponseMessage response = await HttpClient.PostAsJsonAsync("chats", createChatParams);
        response.EnsureSuccessStatusCode();

        Stream contentStream = await response.Content.ReadAsStreamAsync();
        CreateChatResponse? createChatResponse =
            await JsonSerializer.DeserializeAsync<CreateChatResponse>(contentStream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        Assert.NotNull(createChatResponse);

        // Ask something to the bot
        Ask ask = new()
        {
            Input = "Who is Satya Nadella?",
            Variables = new KeyValuePair<string, string>[] { new("MessageType", ChatMessageType.Message.ToString()) }
        };
        response = await HttpClient.PostAsJsonAsync($"chats/{createChatResponse.ChatSession.Id}/messages", ask);
        response.EnsureSuccessStatusCode();

        contentStream = await response.Content.ReadAsStreamAsync();
        AskResult? askResult = await JsonSerializer.DeserializeAsync<AskResult>(contentStream,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        Assert.NotNull(askResult);
        Assert.False(string.IsNullOrEmpty(askResult.Value));


        // Clean up
        response = await HttpClient.DeleteAsync($"chats/{createChatResponse.ChatSession.Id}");
        response.EnsureSuccessStatusCode();
    }
}
