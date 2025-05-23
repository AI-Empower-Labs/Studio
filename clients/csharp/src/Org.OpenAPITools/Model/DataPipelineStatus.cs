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
    /// DataPipelineStatus
    /// </summary>
    public partial class DataPipelineStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPipelineStatus" /> class.
        /// </summary>
        /// <param name="completed">completed</param>
        /// <param name="failed">failed</param>
        /// <param name="empty">empty</param>
        /// <param name="index">index</param>
        /// <param name="documentId">documentId</param>
        /// <param name="tags">tags</param>
        /// <param name="creation">creation</param>
        /// <param name="lastUpdate">lastUpdate</param>
        /// <param name="steps">steps</param>
        /// <param name="remainingSteps">remainingSteps</param>
        /// <param name="completedSteps">completedSteps</param>
        [JsonConstructor]
        public DataPipelineStatus(Option<bool?> completed = default, Option<bool?> failed = default, Option<bool?> empty = default, Option<string?> index = default, Option<string?> documentId = default, Option<Dictionary<string, List<string>>?> tags = default, Option<DateTime?> creation = default, Option<DateTime?> lastUpdate = default, Option<List<string>?> steps = default, Option<List<string>?> remainingSteps = default, Option<List<string>?> completedSteps = default)
        {
            CompletedOption = completed;
            FailedOption = failed;
            EmptyOption = empty;
            IndexOption = index;
            DocumentIdOption = documentId;
            TagsOption = tags;
            CreationOption = creation;
            LastUpdateOption = lastUpdate;
            StepsOption = steps;
            RemainingStepsOption = remainingSteps;
            CompletedStepsOption = completedSteps;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Completed
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> CompletedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [JsonPropertyName("completed")]
        public bool? Completed { get { return this.CompletedOption; } set { this.CompletedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Failed
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> FailedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [JsonPropertyName("failed")]
        public bool? Failed { get { return this.FailedOption; } set { this.FailedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Empty
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EmptyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [JsonPropertyName("empty")]
        public bool? Empty { get { return this.EmptyOption; } set { this.EmptyOption = new(value); } }

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
        /// Used to track the state of DocumentId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DocumentIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get { return this.DocumentIdOption; } set { this.DocumentIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tags
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, List<string>>?> TagsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [JsonPropertyName("tags")]
        public Dictionary<string, List<string>>? Tags { get { return this.TagsOption; } set { this.TagsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Creation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Creation
        /// </summary>
        [JsonPropertyName("creation")]
        public DateTime? Creation { get { return this.CreationOption; } set { this.CreationOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [JsonPropertyName("last_update")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new(value); } }

        /// <summary>
        /// Used to track the state of Steps
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> StepsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [JsonPropertyName("steps")]
        public List<string>? Steps { get { return this.StepsOption; } set { this.StepsOption = new(value); } }

        /// <summary>
        /// Used to track the state of RemainingSteps
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> RemainingStepsOption { get; private set; }

        /// <summary>
        /// Gets or Sets RemainingSteps
        /// </summary>
        [JsonPropertyName("remaining_steps")]
        public List<string>? RemainingSteps { get { return this.RemainingStepsOption; } set { this.RemainingStepsOption = new(value); } }

        /// <summary>
        /// Used to track the state of CompletedSteps
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> CompletedStepsOption { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedSteps
        /// </summary>
        [JsonPropertyName("completed_steps")]
        public List<string>? CompletedSteps { get { return this.CompletedStepsOption; } set { this.CompletedStepsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataPipelineStatus {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Creation: ").Append(Creation).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  RemainingSteps: ").Append(RemainingSteps).Append("\n");
            sb.Append("  CompletedSteps: ").Append(CompletedSteps).Append("\n");
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
    /// A Json converter for type <see cref="DataPipelineStatus" />
    /// </summary>
    public class DataPipelineStatusJsonConverter : JsonConverter<DataPipelineStatus>
    {
        /// <summary>
        /// The format to use to serialize Creation
        /// </summary>
        public static string CreationFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="DataPipelineStatus" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DataPipelineStatus Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> completed = default;
            Option<bool?> failed = default;
            Option<bool?> empty = default;
            Option<string?> index = default;
            Option<string?> documentId = default;
            Option<Dictionary<string, List<string>>?> tags = default;
            Option<DateTime?> creation = default;
            Option<DateTime?> lastUpdate = default;
            Option<List<string>?> steps = default;
            Option<List<string>?> remainingSteps = default;
            Option<List<string>?> completedSteps = default;

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
                        case "completed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                completed = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "failed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                failed = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "empty":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                empty = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "index":
                            index = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "document_id":
                            documentId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "tags":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tags = new Option<Dictionary<string, List<string>>?>(JsonSerializer.Deserialize<Dictionary<string, List<string>>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "creation":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                creation = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "last_update":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastUpdate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "steps":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                steps = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "remaining_steps":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                remainingSteps = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "completed_steps":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                completedSteps = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (completed.IsSet && completed.Value == null)
                throw new ArgumentNullException(nameof(completed), "Property is not nullable for class DataPipelineStatus.");

            if (failed.IsSet && failed.Value == null)
                throw new ArgumentNullException(nameof(failed), "Property is not nullable for class DataPipelineStatus.");

            if (empty.IsSet && empty.Value == null)
                throw new ArgumentNullException(nameof(empty), "Property is not nullable for class DataPipelineStatus.");

            if (creation.IsSet && creation.Value == null)
                throw new ArgumentNullException(nameof(creation), "Property is not nullable for class DataPipelineStatus.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class DataPipelineStatus.");

            return new DataPipelineStatus(completed, failed, empty, index, documentId, tags, creation, lastUpdate, steps, remainingSteps, completedSteps);
        }

        /// <summary>
        /// Serializes a <see cref="DataPipelineStatus" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dataPipelineStatus"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DataPipelineStatus dataPipelineStatus, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dataPipelineStatus, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DataPipelineStatus" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dataPipelineStatus"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DataPipelineStatus dataPipelineStatus, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dataPipelineStatus.CompletedOption.IsSet)
                writer.WriteBoolean("completed", dataPipelineStatus.CompletedOption.Value!.Value);

            if (dataPipelineStatus.FailedOption.IsSet)
                writer.WriteBoolean("failed", dataPipelineStatus.FailedOption.Value!.Value);

            if (dataPipelineStatus.EmptyOption.IsSet)
                writer.WriteBoolean("empty", dataPipelineStatus.EmptyOption.Value!.Value);

            if (dataPipelineStatus.IndexOption.IsSet)
                if (dataPipelineStatus.IndexOption.Value != null)
                    writer.WriteString("index", dataPipelineStatus.Index);
                else
                    writer.WriteNull("index");

            if (dataPipelineStatus.DocumentIdOption.IsSet)
                if (dataPipelineStatus.DocumentIdOption.Value != null)
                    writer.WriteString("document_id", dataPipelineStatus.DocumentId);
                else
                    writer.WriteNull("document_id");

            if (dataPipelineStatus.TagsOption.IsSet)
                if (dataPipelineStatus.TagsOption.Value != null)
                {
                    writer.WritePropertyName("tags");
                    JsonSerializer.Serialize(writer, dataPipelineStatus.Tags, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("tags");
            if (dataPipelineStatus.CreationOption.IsSet)
                writer.WriteString("creation", dataPipelineStatus.CreationOption.Value!.Value.ToString(CreationFormat));

            if (dataPipelineStatus.LastUpdateOption.IsSet)
                writer.WriteString("last_update", dataPipelineStatus.LastUpdateOption.Value!.Value.ToString(LastUpdateFormat));

            if (dataPipelineStatus.StepsOption.IsSet)
                if (dataPipelineStatus.StepsOption.Value != null)
                {
                    writer.WritePropertyName("steps");
                    JsonSerializer.Serialize(writer, dataPipelineStatus.Steps, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("steps");
            if (dataPipelineStatus.RemainingStepsOption.IsSet)
                if (dataPipelineStatus.RemainingStepsOption.Value != null)
                {
                    writer.WritePropertyName("remaining_steps");
                    JsonSerializer.Serialize(writer, dataPipelineStatus.RemainingSteps, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("remaining_steps");
            if (dataPipelineStatus.CompletedStepsOption.IsSet)
                if (dataPipelineStatus.CompletedStepsOption.Value != null)
                {
                    writer.WritePropertyName("completed_steps");
                    JsonSerializer.Serialize(writer, dataPipelineStatus.CompletedSteps, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("completed_steps");
        }
    }
}
