// Copyright (c) Microsoft. All rights reserved.

using System.Net.Http;
using System.Threading.Tasks;

using Xunit;

namespace ChatCopilotIntegrationTests;

public class StaticFiles : ChatCopilotIntegrationTest
{
	[Fact]
	public async Task GetStaticFiles()
	{
		HttpResponseMessage response = await HttpClient.GetAsync("index.html");
		response.EnsureSuccessStatusCode();
		Assert.True(response.Content.Headers.ContentLength > 1);

		response = await HttpClient.GetAsync("favicon.ico");
		response.EnsureSuccessStatusCode();
		Assert.True(response.Content.Headers.ContentLength > 1);
	}
}
