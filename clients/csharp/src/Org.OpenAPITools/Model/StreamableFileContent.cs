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
    /// StreamableFileContent
    /// </summary>
    public partial class StreamableFileContent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamableFileContent" /> class.
        /// </summary>
        /// <param name="fileName">fileName</param>
        /// <param name="fileSize">fileSize</param>
        /// <param name="fileType">fileType</param>
        /// <param name="lastWrite">lastWrite</param>
        [JsonConstructor]
        internal StreamableFileContent(Option<string?> fileName = default, Option<long?> fileSize = default, Option<string?> fileType = default, Option<DateTime?> lastWrite = default)
        {
            FileNameOption = fileName;
            FileSizeOption = fileSize;
            FileTypeOption = fileType;
            LastWriteOption = lastWrite;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of FileName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FileNameOption { get; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [JsonPropertyName("fileName")]
        public string? FileName { get { return this.FileNameOption; } }

        /// <summary>
        /// Used to track the state of FileSize
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> FileSizeOption { get; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [JsonPropertyName("fileSize")]
        public long? FileSize { get { return this.FileSizeOption; } }

        /// <summary>
        /// Used to track the state of FileType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FileTypeOption { get; }

        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [JsonPropertyName("fileType")]
        public string? FileType { get { return this.FileTypeOption; } }

        /// <summary>
        /// Used to track the state of LastWrite
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastWriteOption { get; }

        /// <summary>
        /// Gets or Sets LastWrite
        /// </summary>
        [JsonPropertyName("lastWrite")]
        public DateTime? LastWrite { get { return this.LastWriteOption; } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StreamableFileContent {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  LastWrite: ").Append(LastWrite).Append("\n");
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
    /// A Json converter for type <see cref="StreamableFileContent" />
    /// </summary>
    public class StreamableFileContentJsonConverter : JsonConverter<StreamableFileContent>
    {
        /// <summary>
        /// The format to use to serialize LastWrite
        /// </summary>
        public static string LastWriteFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="StreamableFileContent" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override StreamableFileContent Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> fileName = default;
            Option<long?> fileSize = default;
            Option<string?> fileType = default;
            Option<DateTime?> lastWrite = default;

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
                        case "fileName":
                            fileName = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "fileSize":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fileSize = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "fileType":
                            fileType = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "lastWrite":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastWrite = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (fileSize.IsSet && fileSize.Value == null)
                throw new ArgumentNullException(nameof(fileSize), "Property is not nullable for class StreamableFileContent.");

            if (lastWrite.IsSet && lastWrite.Value == null)
                throw new ArgumentNullException(nameof(lastWrite), "Property is not nullable for class StreamableFileContent.");

            return new StreamableFileContent(fileName, fileSize, fileType, lastWrite);
        }

        /// <summary>
        /// Serializes a <see cref="StreamableFileContent" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="streamableFileContent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, StreamableFileContent streamableFileContent, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, streamableFileContent, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="StreamableFileContent" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="streamableFileContent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, StreamableFileContent streamableFileContent, JsonSerializerOptions jsonSerializerOptions)
        {
            if (streamableFileContent.FileNameOption.IsSet)
                if (streamableFileContent.FileNameOption.Value != null)
                    writer.WriteString("fileName", streamableFileContent.FileName);
                else
                    writer.WriteNull("fileName");

            if (streamableFileContent.FileSizeOption.IsSet)
                writer.WriteNumber("fileSize", streamableFileContent.FileSizeOption.Value!.Value);

            if (streamableFileContent.FileTypeOption.IsSet)
                if (streamableFileContent.FileTypeOption.Value != null)
                    writer.WriteString("fileType", streamableFileContent.FileType);
                else
                    writer.WriteNull("fileType");

            if (streamableFileContent.LastWriteOption.IsSet)
                writer.WriteString("lastWrite", streamableFileContent.LastWriteOption.Value!.Value.ToString(LastWriteFormat));
        }
    }
}
