// <auto-generated>
/*
 * Studio - AI Empower Labs
 *
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ListDocumentResponse
    /// </summary>
    public partial class ListDocumentResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentResponse" /> class.
        /// </summary>
        /// <param name="id">Unique record ID</param>
        /// <param name="vector">Embedding vector</param>
        /// <param name="tags">Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc.</param>
        /// <param name="payload">Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc.</param>
        [JsonConstructor]
        public ListDocumentResponse(Option<string?> id = default, Option<Object?> vector = default, Option<Dictionary<string, List<string>>?> tags = default, Option<Dictionary<string, Object>?> payload = default)
        {
            IdOption = id;
            VectorOption = vector;
            TagsOption = tags;
            PayloadOption = payload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdOption { get; private set; }

        /// <summary>
        /// Unique record ID
        /// </summary>
        /// <value>Unique record ID</value>
        [JsonPropertyName("id")]
        public string? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Vector
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> VectorOption { get; private set; }

        /// <summary>
        /// Embedding vector
        /// </summary>
        /// <value>Embedding vector</value>
        [JsonPropertyName("vector")]
        public Object? Vector { get { return this.VectorOption; } set { this.VectorOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tags
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, List<string>>?> TagsOption { get; private set; }

        /// <summary>
        /// Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc.
        /// </summary>
        /// <value>Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc.</value>
        [JsonPropertyName("tags")]
        public Dictionary<string, List<string>>? Tags { get { return this.TagsOption; } set { this.TagsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Payload
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, Object>?> PayloadOption { get; private set; }

        /// <summary>
        /// Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc.
        /// </summary>
        /// <value>Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc.</value>
        [JsonPropertyName("payload")]
        public Dictionary<string, Object>? Payload { get { return this.PayloadOption; } set { this.PayloadOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListDocumentResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Vector: ").Append(Vector).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ListDocumentResponse" />
    /// </summary>
    public class ListDocumentResponseJsonConverter : JsonConverter<ListDocumentResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ListDocumentResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ListDocumentResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<Object?> vector = default;
            Option<Dictionary<string, List<string>>?> tags = default;
            Option<Dictionary<string, Object>?> payload = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "vector":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vector = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "tags":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tags = new Option<Dictionary<string, List<string>>?>(JsonSerializer.Deserialize<Dictionary<string, List<string>>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "payload":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                payload = new Option<Dictionary<string, Object>?>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (vector.IsSet && vector.Value == null)
                throw new ArgumentNullException(nameof(vector), "Property is not nullable for class ListDocumentResponse.");

            if (tags.IsSet && tags.Value == null)
                throw new ArgumentNullException(nameof(tags), "Property is not nullable for class ListDocumentResponse.");

            return new ListDocumentResponse(id, vector, tags, payload);
        }

        /// <summary>
        /// Serializes a <see cref="ListDocumentResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listDocumentResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ListDocumentResponse listDocumentResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, listDocumentResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ListDocumentResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listDocumentResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ListDocumentResponse listDocumentResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (listDocumentResponse.VectorOption.IsSet && listDocumentResponse.Vector == null)
                throw new ArgumentNullException(nameof(listDocumentResponse.Vector), "Property is required for class ListDocumentResponse.");

            if (listDocumentResponse.TagsOption.IsSet && listDocumentResponse.Tags == null)
                throw new ArgumentNullException(nameof(listDocumentResponse.Tags), "Property is required for class ListDocumentResponse.");

            if (listDocumentResponse.IdOption.IsSet)
                if (listDocumentResponse.IdOption.Value != null)
                    writer.WriteString("id", listDocumentResponse.Id);
                else
                    writer.WriteNull("id");

            if (listDocumentResponse.VectorOption.IsSet)
            {
                writer.WritePropertyName("vector");
                JsonSerializer.Serialize(writer, listDocumentResponse.Vector, jsonSerializerOptions);
            }
            if (listDocumentResponse.TagsOption.IsSet)
            {
                writer.WritePropertyName("tags");
                JsonSerializer.Serialize(writer, listDocumentResponse.Tags, jsonSerializerOptions);
            }
            if (listDocumentResponse.PayloadOption.IsSet)
                if (listDocumentResponse.PayloadOption.Value != null)
                {
                    writer.WritePropertyName("payload");
                    JsonSerializer.Serialize(writer, listDocumentResponse.Payload, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("payload");
        }
    }
}
