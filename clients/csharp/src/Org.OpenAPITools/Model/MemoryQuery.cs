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
    /// MemoryQuery
    /// </summary>
    public partial class MemoryQuery : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryQuery" /> class.
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="question">question</param>
        /// <param name="filters">filters</param>
        /// <param name="minRelevance">minRelevance</param>
        [JsonConstructor]
        public MemoryQuery(Option<string?> index = default, Option<string?> question = default, Option<List<Dictionary<string, List<string>>>?> filters = default, Option<double?> minRelevance = default)
        {
            IndexOption = index;
            QuestionOption = question;
            FiltersOption = filters;
            MinRelevanceOption = minRelevance;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Index
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IndexOption { get; private set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [JsonPropertyName("index")]
        public string? Index { get { return this.IndexOption; } set { this.IndexOption = new(value); } }

        /// <summary>
        /// Used to track the state of Question
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> QuestionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [JsonPropertyName("question")]
        public string? Question { get { return this.QuestionOption; } set { this.QuestionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Filters
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Dictionary<string, List<string>>>?> FiltersOption { get; private set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [JsonPropertyName("filters")]
        public List<Dictionary<string, List<string>>>? Filters { get { return this.FiltersOption; } set { this.FiltersOption = new(value); } }

        /// <summary>
        /// Used to track the state of MinRelevance
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> MinRelevanceOption { get; private set; }

        /// <summary>
        /// Gets or Sets MinRelevance
        /// </summary>
        [JsonPropertyName("minRelevance")]
        public double? MinRelevance { get { return this.MinRelevanceOption; } set { this.MinRelevanceOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemoryQuery {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  MinRelevance: ").Append(MinRelevance).Append("\n");
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
    /// A Json converter for type <see cref="MemoryQuery" />
    /// </summary>
    public class MemoryQueryJsonConverter : JsonConverter<MemoryQuery>
    {
        /// <summary>
        /// Deserializes json to <see cref="MemoryQuery" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MemoryQuery Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> index = default;
            Option<string?> question = default;
            Option<List<Dictionary<string, List<string>>>?> filters = default;
            Option<double?> minRelevance = default;

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
                        case "index":
                            index = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "question":
                            question = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "filters":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                filters = new Option<List<Dictionary<string, List<string>>>?>(JsonSerializer.Deserialize<List<Dictionary<string, List<string>>>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "minRelevance":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                minRelevance = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (minRelevance.IsSet && minRelevance.Value == null)
                throw new ArgumentNullException(nameof(minRelevance), "Property is not nullable for class MemoryQuery.");

            return new MemoryQuery(index, question, filters, minRelevance);
        }

        /// <summary>
        /// Serializes a <see cref="MemoryQuery" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="memoryQuery"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MemoryQuery memoryQuery, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, memoryQuery, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MemoryQuery" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="memoryQuery"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MemoryQuery memoryQuery, JsonSerializerOptions jsonSerializerOptions)
        {
            if (memoryQuery.IndexOption.IsSet)
                if (memoryQuery.IndexOption.Value != null)
                    writer.WriteString("index", memoryQuery.Index);
                else
                    writer.WriteNull("index");

            if (memoryQuery.QuestionOption.IsSet)
                if (memoryQuery.QuestionOption.Value != null)
                    writer.WriteString("question", memoryQuery.Question);
                else
                    writer.WriteNull("question");

            if (memoryQuery.FiltersOption.IsSet)
                if (memoryQuery.FiltersOption.Value != null)
                {
                    writer.WritePropertyName("filters");
                    JsonSerializer.Serialize(writer, memoryQuery.Filters, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("filters");
            if (memoryQuery.MinRelevanceOption.IsSet)
                writer.WriteNumber("minRelevance", memoryQuery.MinRelevanceOption.Value!.Value);
        }
    }
}
