// Copyright (c) Microsoft. All rights reserved.

using System.Net.Http;
using System.Threading.Tasks;

using Xunit;

namespace ChatCopilotIntegrationTests;

/// <summary>
///     Class for testing the healthcheck endpoint
/// </summary>
public class HealthzTests : ChatCopilotIntegrationTest
{
    [Fact]
    public async Task HealthzSuccessfullyReturns()
    {
        HttpResponseMessage response = await HttpClient.GetAsync("healthz");

        response.EnsureSuccessStatusCode();
    }
}
