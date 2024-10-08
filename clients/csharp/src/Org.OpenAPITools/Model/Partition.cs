/*
 * Studio - AI Empower Labs
 *
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Partition
    /// </summary>
    [DataContract(Name = "Partition")]
    public partial class Partition : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Partition" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="relevance">relevance.</param>
        /// <param name="partitionNumber">partitionNumber.</param>
        /// <param name="sectionNumber">sectionNumber.</param>
        /// <param name="lastUpdate">lastUpdate.</param>
        /// <param name="tags">tags.</param>
        public Partition(string text = default(string), float relevance = default(float), int partitionNumber = default(int), int sectionNumber = default(int), DateTime lastUpdate = default(DateTime), Dictionary<string, List<string>> tags = default(Dictionary<string, List<string>>))
        {
            this.Text = text;
            this.Relevance = relevance;
            this.PartitionNumber = partitionNumber;
            this.SectionNumber = sectionNumber;
            this.LastUpdate = lastUpdate;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Relevance
        /// </summary>
        [DataMember(Name = "relevance", EmitDefaultValue = false)]
        public float Relevance { get; set; }

        /// <summary>
        /// Gets or Sets PartitionNumber
        /// </summary>
        [DataMember(Name = "partitionNumber", EmitDefaultValue = false)]
        public int PartitionNumber { get; set; }

        /// <summary>
        /// Gets or Sets SectionNumber
        /// </summary>
        [DataMember(Name = "sectionNumber", EmitDefaultValue = false)]
        public int SectionNumber { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Partition {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Relevance: ").Append(Relevance).Append("\n");
            sb.Append("  PartitionNumber: ").Append(PartitionNumber).Append("\n");
            sb.Append("  SectionNumber: ").Append(SectionNumber).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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

}
