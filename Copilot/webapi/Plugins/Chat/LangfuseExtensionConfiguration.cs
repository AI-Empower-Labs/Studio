// Copyright (c) Microsoft.All rights reserved.

#pragma warning disable CS8644

using System.ClientModel.Primitives;
using System.Text.Json;

using Azure.AI.OpenAI;

namespace CopilotChat.WebApi.Plugins.Chat;

internal sealed class LangfuseExtensionConfiguration(
	string chatId,
	string userId,
	string[] tags) : AzureChatExtensionConfiguration, IJsonModel<AzureChatExtensionConfiguration>
{
	void IJsonModel<AzureChatExtensionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("session_id");
		writer.WriteStringValue(chatId);

		writer.WritePropertyName("user_id");
		writer.WriteStringValue(userId);

		writer.WritePropertyName("tags");
		JsonSerializer.Serialize(writer, tags);

		writer.WriteEndObject();
	}
}
