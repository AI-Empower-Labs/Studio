using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

using Microsoft.Extensions.Logging;

namespace LlmAutoTooling;

internal sealed class RequestUriReWriterHandler(
	Uri rewriteUri,
	ILogger<RequestUriReWriterHandler> logger,
	bool outputRequest,
	bool outputResponse) : DelegatingHandler(new HttpClientHandler())
{
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		if (request.Method == HttpMethod.Post
			&& request.RequestUri is not null
			&& request.RequestUri.ToString().Contains("completions", StringComparison.OrdinalIgnoreCase))
		{
			request.RequestUri = rewriteUri;
			request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "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");
		}

		if (request.Content is not null && outputRequest)
		{
			string content = await request.Content!.ReadAsStringAsync(cancellationToken);
			logger.LogDebug("{Method} {Uri} - {Json}", request.Method, request.RequestUri, ToJson(content));
		}

		HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

		if (outputResponse)
		{
			string responseText = await response.Content.ReadAsStringAsync(cancellationToken);
			logger.LogDebug("Response {Uri} - {Json}", request.RequestUri, ToJson(responseText));
		}

		return response;
	}

	private static string ToJson(string source)
	{
		try
		{
			Utf8JsonReader reader = new(Encoding.UTF8.GetBytes(source));
			if (JsonDocument.TryParseValue(ref reader, out JsonDocument? jsonDocument))
			{
				return JsonSerializer.Serialize(jsonDocument, new JsonSerializerOptions
				{
					WriteIndented = true
				});
			}
		}
		catch
		{
			// Ignore
		}

		return source;
	}
}
