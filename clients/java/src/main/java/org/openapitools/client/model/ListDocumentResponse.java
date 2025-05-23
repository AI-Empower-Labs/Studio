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

import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

import org.openapitools.client.JSON;

/**
 * ListDocumentResponse
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-02-27T12:37:37.320941922Z[Etc/UTC]", comments = "Generator version: 7.12.0-SNAPSHOT")
public class ListDocumentResponse {
  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  @javax.annotation.Nullable
  private String id;

  public static final String SERIALIZED_NAME_VECTOR = "vector";
  @SerializedName(SERIALIZED_NAME_VECTOR)
  @javax.annotation.Nullable
  private Object vector;

  public static final String SERIALIZED_NAME_TAGS = "tags";
  @SerializedName(SERIALIZED_NAME_TAGS)
  @javax.annotation.Nullable
  private Map<String, List<String>> tags = new HashMap<>();

  public static final String SERIALIZED_NAME_PAYLOAD = "payload";
  @SerializedName(SERIALIZED_NAME_PAYLOAD)
  @javax.annotation.Nullable
  private Map<String, Object> payload;

  public ListDocumentResponse() {
  }

  public ListDocumentResponse id(@javax.annotation.Nullable String id) {
    this.id = id;
    return this;
  }

  /**
   * Unique record ID
   * @return id
   */
  @javax.annotation.Nullable
  public String getId() {
    return id;
  }

  public void setId(@javax.annotation.Nullable String id) {
    this.id = id;
  }


  public ListDocumentResponse vector(@javax.annotation.Nullable Object vector) {
    this.vector = vector;
    return this;
  }

  /**
   * Embedding vector
   * @return vector
   */
  @javax.annotation.Nullable
  public Object getVector() {
    return vector;
  }

  public void setVector(@javax.annotation.Nullable Object vector) {
    this.vector = vector;
  }


  public ListDocumentResponse tags(@javax.annotation.Nullable Map<String, List<String>> tags) {
    this.tags = tags;
    return this;
  }

  public ListDocumentResponse putTagsItem(String key, List<String> tagsItem) {
    if (this.tags == null) {
      this.tags = new HashMap<>();
    }
    this.tags.put(key, tagsItem);
    return this;
  }

  /**
   * Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc.
   * @return tags
   */
  @javax.annotation.Nullable
  public Map<String, List<String>> getTags() {
    return tags;
  }

  public void setTags(@javax.annotation.Nullable Map<String, List<String>> tags) {
    this.tags = tags;
  }


  public ListDocumentResponse payload(@javax.annotation.Nullable Map<String, Object> payload) {
    this.payload = payload;
    return this;
  }

  public ListDocumentResponse putPayloadItem(String key, Object payloadItem) {
    if (this.payload == null) {
      this.payload = new HashMap<>();
    }
    this.payload.put(key, payloadItem);
    return this;
  }

  /**
   * Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc.
   * @return payload
   */
  @javax.annotation.Nullable
  public Map<String, Object> getPayload() {
    return payload;
  }

  public void setPayload(@javax.annotation.Nullable Map<String, Object> payload) {
    this.payload = payload;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ListDocumentResponse listDocumentResponse = (ListDocumentResponse) o;
    return Objects.equals(this.id, listDocumentResponse.id) &&
        Objects.equals(this.vector, listDocumentResponse.vector) &&
        Objects.equals(this.tags, listDocumentResponse.tags) &&
        Objects.equals(this.payload, listDocumentResponse.payload);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && Objects.deepEquals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, vector, tags, payload);
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
    sb.append("class ListDocumentResponse {\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    vector: ").append(toIndentedString(vector)).append("\n");
    sb.append("    tags: ").append(toIndentedString(tags)).append("\n");
    sb.append("    payload: ").append(toIndentedString(payload)).append("\n");
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
    openapiFields.add("id");
    openapiFields.add("vector");
    openapiFields.add("tags");
    openapiFields.add("payload");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

  /**
   * Validates the JSON Element and throws an exception if issues found
   *
   * @param jsonElement JSON Element
   * @throws IOException if the JSON Element is invalid with respect to ListDocumentResponse
   */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!ListDocumentResponse.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in ListDocumentResponse is not found in the empty JSON string", ListDocumentResponse.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!ListDocumentResponse.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `ListDocumentResponse` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if ((jsonObj.get("id") != null && !jsonObj.get("id").isJsonNull()) && !jsonObj.get("id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!ListDocumentResponse.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'ListDocumentResponse' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<ListDocumentResponse> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(ListDocumentResponse.class));

       return (TypeAdapter<T>) new TypeAdapter<ListDocumentResponse>() {
           @Override
           public void write(JsonWriter out, ListDocumentResponse value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public ListDocumentResponse read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

  /**
   * Create an instance of ListDocumentResponse given an JSON string
   *
   * @param jsonString JSON string
   * @return An instance of ListDocumentResponse
   * @throws IOException if the JSON string is invalid with respect to ListDocumentResponse
   */
  public static ListDocumentResponse fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, ListDocumentResponse.class);
  }

  /**
   * Convert an instance of ListDocumentResponse to an JSON string
   *
   * @return JSON string
   */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

