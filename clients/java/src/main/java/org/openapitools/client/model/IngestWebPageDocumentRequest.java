/*
 * Studio - AI Empower Labs
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.openapitools.jackson.nullable.JsonNullable;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

import org.openapitools.client.JSON;

/**
 * IngestWebPageDocumentRequest
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-06-18T14:05:27.871542961Z[Etc/UTC]", comments = "Generator version: 7.7.0-SNAPSHOT")
public class IngestWebPageDocumentRequest {
  public static final String SERIALIZED_NAME_DOCUMENT_ID = "documentId";
  @SerializedName(SERIALIZED_NAME_DOCUMENT_ID)
  private String documentId;

  public static final String SERIALIZED_NAME_INDEX = "index";
  @SerializedName(SERIALIZED_NAME_INDEX)
  private String index;

  public static final String SERIALIZED_NAME_TAGS = "tags";
  @SerializedName(SERIALIZED_NAME_TAGS)
  private Map<String, List<String>> tags;

  public static final String SERIALIZED_NAME_URL = "url";
  @SerializedName(SERIALIZED_NAME_URL)
  private String url;

  public static final String SERIALIZED_NAME_PIPELINE = "pipeline";
  @SerializedName(SERIALIZED_NAME_PIPELINE)
  private List<String> pipeline;

  public static final String SERIALIZED_NAME_WEB_HOOK_URL = "webHookUrl";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_URL)
  private String webHookUrl;

  public static final String SERIALIZED_NAME_EMBEDDING_MODEL = "embeddingModel";
  @SerializedName(SERIALIZED_NAME_EMBEDDING_MODEL)
  private String embeddingModel;

  public IngestWebPageDocumentRequest() {
  }

  public IngestWebPageDocumentRequest documentId(String documentId) {
    this.documentId = documentId;
    return this;
  }

   /**
   * Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten
   * @return documentId
  **/
  @javax.annotation.Nonnull
  public String getDocumentId() {
    return documentId;
  }

  public void setDocumentId(String documentId) {
    this.documentId = documentId;
  }


  public IngestWebPageDocumentRequest index(String index) {
    this.index = index;
    return this;
  }

   /**
   * Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;
   * @return index
  **/
  @javax.annotation.Nullable
  public String getIndex() {
    return index;
  }

  public void setIndex(String index) {
    this.index = index;
  }


  public IngestWebPageDocumentRequest tags(Map<String, List<String>> tags) {
    this.tags = tags;
    return this;
  }

  public IngestWebPageDocumentRequest putTagsItem(String key, List<String> tagsItem) {
    if (this.tags == null) {
      this.tags = new HashMap<>();
    }
    this.tags.put(key, tagsItem);
    return this;
  }

   /**
   * Optionally add tags to ingestion
   * @return tags
  **/
  @javax.annotation.Nullable
  public Map<String, List<String>> getTags() {
    return tags;
  }

  public void setTags(Map<String, List<String>> tags) {
    this.tags = tags;
  }


  public IngestWebPageDocumentRequest url(String url) {
    this.url = url;
    return this;
  }

   /**
   * Web page to ingest
   * @return url
  **/
  @javax.annotation.Nonnull
  public String getUrl() {
    return url;
  }

  public void setUrl(String url) {
    this.url = url;
  }


  public IngestWebPageDocumentRequest pipeline(List<String> pipeline) {
    this.pipeline = pipeline;
    return this;
  }

  public IngestWebPageDocumentRequest addPipelineItem(String pipelineItem) {
    if (this.pipeline == null) {
      this.pipeline = new ArrayList<>();
    }
    this.pipeline.add(pipelineItem);
    return this;
  }

   /**
   * Optional value to specify ingestion pipeline steps. Defaults to server configured defaults.
   * @return pipeline
  **/
  @javax.annotation.Nullable
  public List<String> getPipeline() {
    return pipeline;
  }

  public void setPipeline(List<String> pipeline) {
    this.pipeline = pipeline;
  }


  public IngestWebPageDocumentRequest webHookUrl(String webHookUrl) {
    this.webHookUrl = webHookUrl;
    return this;
  }

   /**
   * Url to use for webhook callback when operation finishes or fails.
   * @return webHookUrl
  **/
  @javax.annotation.Nullable
  public String getWebHookUrl() {
    return webHookUrl;
  }

  public void setWebHookUrl(String webHookUrl) {
    this.webHookUrl = webHookUrl;
  }


  public IngestWebPageDocumentRequest embeddingModel(String embeddingModel) {
    this.embeddingModel = embeddingModel;
    return this;
  }

   /**
   * Embedding model to use in ingestion. Optional. Default to configured default.
   * @return embeddingModel
  **/
  @javax.annotation.Nullable
  public String getEmbeddingModel() {
    return embeddingModel;
  }

  public void setEmbeddingModel(String embeddingModel) {
    this.embeddingModel = embeddingModel;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    IngestWebPageDocumentRequest ingestWebPageDocumentRequest = (IngestWebPageDocumentRequest) o;
    return Objects.equals(this.documentId, ingestWebPageDocumentRequest.documentId) &&
        Objects.equals(this.index, ingestWebPageDocumentRequest.index) &&
        Objects.equals(this.tags, ingestWebPageDocumentRequest.tags) &&
        Objects.equals(this.url, ingestWebPageDocumentRequest.url) &&
        Objects.equals(this.pipeline, ingestWebPageDocumentRequest.pipeline) &&
        Objects.equals(this.webHookUrl, ingestWebPageDocumentRequest.webHookUrl) &&
        Objects.equals(this.embeddingModel, ingestWebPageDocumentRequest.embeddingModel);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && Objects.deepEquals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(documentId, index, tags, url, pipeline, webHookUrl, embeddingModel);
  }

  private static <T> int hashCodeNullable(JsonNullable<T> a) {
    if (a == null) {
      return 1;
    }
    return a.isPresent() ? Arrays.deepHashCode(new Object[]{a.get()}) : 31;
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class IngestWebPageDocumentRequest {\n");
    sb.append("    documentId: ").append(toIndentedString(documentId)).append("\n");
    sb.append("    index: ").append(toIndentedString(index)).append("\n");
    sb.append("    tags: ").append(toIndentedString(tags)).append("\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
    sb.append("    pipeline: ").append(toIndentedString(pipeline)).append("\n");
    sb.append("    webHookUrl: ").append(toIndentedString(webHookUrl)).append("\n");
    sb.append("    embeddingModel: ").append(toIndentedString(embeddingModel)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("documentId");
    openapiFields.add("index");
    openapiFields.add("tags");
    openapiFields.add("url");
    openapiFields.add("pipeline");
    openapiFields.add("webHookUrl");
    openapiFields.add("embeddingModel");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("documentId");
    openapiRequiredFields.add("url");
  }

 /**
  * Validates the JSON Element and throws an exception if issues found
  *
  * @param jsonElement JSON Element
  * @throws IOException if the JSON Element is invalid with respect to IngestWebPageDocumentRequest
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!IngestWebPageDocumentRequest.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in IngestWebPageDocumentRequest is not found in the empty JSON string", IngestWebPageDocumentRequest.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!IngestWebPageDocumentRequest.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `IngestWebPageDocumentRequest` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : IngestWebPageDocumentRequest.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (!jsonObj.get("documentId").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `documentId` to be a primitive type in the JSON string but got `%s`", jsonObj.get("documentId").toString()));
      }
      if ((jsonObj.get("index") != null && !jsonObj.get("index").isJsonNull()) && !jsonObj.get("index").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `index` to be a primitive type in the JSON string but got `%s`", jsonObj.get("index").toString()));
      }
      if (!jsonObj.get("url").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `url` to be a primitive type in the JSON string but got `%s`", jsonObj.get("url").toString()));
      }
      // ensure the optional json data is an array if present
      if (jsonObj.get("pipeline") != null && !jsonObj.get("pipeline").isJsonNull() && !jsonObj.get("pipeline").isJsonArray()) {
        throw new IllegalArgumentException(String.format("Expected the field `pipeline` to be an array in the JSON string but got `%s`", jsonObj.get("pipeline").toString()));
      }
      if ((jsonObj.get("webHookUrl") != null && !jsonObj.get("webHookUrl").isJsonNull()) && !jsonObj.get("webHookUrl").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `webHookUrl` to be a primitive type in the JSON string but got `%s`", jsonObj.get("webHookUrl").toString()));
      }
      if ((jsonObj.get("embeddingModel") != null && !jsonObj.get("embeddingModel").isJsonNull()) && !jsonObj.get("embeddingModel").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `embeddingModel` to be a primitive type in the JSON string but got `%s`", jsonObj.get("embeddingModel").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!IngestWebPageDocumentRequest.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'IngestWebPageDocumentRequest' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<IngestWebPageDocumentRequest> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(IngestWebPageDocumentRequest.class));

       return (TypeAdapter<T>) new TypeAdapter<IngestWebPageDocumentRequest>() {
           @Override
           public void write(JsonWriter out, IngestWebPageDocumentRequest value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public IngestWebPageDocumentRequest read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of IngestWebPageDocumentRequest given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of IngestWebPageDocumentRequest
  * @throws IOException if the JSON string is invalid with respect to IngestWebPageDocumentRequest
  */
  public static IngestWebPageDocumentRequest fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, IngestWebPageDocumentRequest.class);
  }

 /**
  * Convert an instance of IngestWebPageDocumentRequest to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}
