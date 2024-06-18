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
 * Represents a translation request with the source text, source language, and target language.
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-06-18T14:05:27.871542961Z[Etc/UTC]", comments = "Generator version: 7.7.0-SNAPSHOT")
public class Translate {
  public static final String SERIALIZED_NAME_TEXT = "text";
  @SerializedName(SERIALIZED_NAME_TEXT)
  private String text;

  /**
   * The language code of the input text.
   */
  @JsonAdapter(SourceEnum.Adapter.class)
  public enum SourceEnum {
    AUTO("auto"),
    
    AR("ar"),
    
    AZ("az"),
    
    BG("bg"),
    
    BN("bn"),
    
    CA("ca"),
    
    CS("cs"),
    
    DA("da"),
    
    DE("de"),
    
    EL("el"),
    
    EN("en"),
    
    EO("eo"),
    
    ES("es"),
    
    ET("et"),
    
    FA("fa"),
    
    FI("fi"),
    
    FR("fr"),
    
    GA("ga"),
    
    HE("he"),
    
    HI("hi"),
    
    HU("hu"),
    
    ID("id"),
    
    IT("it"),
    
    JA("ja"),
    
    KO("ko"),
    
    LT("lt"),
    
    LV("lv"),
    
    MS("ms"),
    
    NB("nb"),
    
    NL("nl"),
    
    PL("pl"),
    
    PT("pt"),
    
    RO("ro"),
    
    RU("ru"),
    
    SK("sk"),
    
    SL("sl"),
    
    SQ("sq"),
    
    SV("sv"),
    
    TH("th"),
    
    TL("tl"),
    
    TR("tr"),
    
    UK("uk"),
    
    ZH("zh"),
    
    ZT("zt");

    private String value;

    SourceEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static SourceEnum fromValue(String value) {
      for (SourceEnum b : SourceEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<SourceEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final SourceEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public SourceEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return SourceEnum.fromValue(value);
      }
    }

    public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      String value = jsonElement.getAsString();
      SourceEnum.fromValue(value);
    }
  }

  public static final String SERIALIZED_NAME_SOURCE = "source";
  @SerializedName(SERIALIZED_NAME_SOURCE)
  private SourceEnum source;

  /**
   * The language code of the desired output translation.
   */
  @JsonAdapter(TargetEnum.Adapter.class)
  public enum TargetEnum {
    AR("ar"),
    
    AZ("az"),
    
    BG("bg"),
    
    BN("bn"),
    
    CA("ca"),
    
    CS("cs"),
    
    DA("da"),
    
    DE("de"),
    
    EL("el"),
    
    EN("en"),
    
    EO("eo"),
    
    ES("es"),
    
    ET("et"),
    
    FA("fa"),
    
    FI("fi"),
    
    FR("fr"),
    
    GA("ga"),
    
    HE("he"),
    
    HI("hi"),
    
    HU("hu"),
    
    ID("id"),
    
    IT("it"),
    
    JA("ja"),
    
    KO("ko"),
    
    LT("lt"),
    
    LV("lv"),
    
    MS("ms"),
    
    NB("nb"),
    
    NL("nl"),
    
    PL("pl"),
    
    PT("pt"),
    
    RO("ro"),
    
    RU("ru"),
    
    SK("sk"),
    
    SL("sl"),
    
    SQ("sq"),
    
    SV("sv"),
    
    TH("th"),
    
    TL("tl"),
    
    TR("tr"),
    
    UK("uk"),
    
    ZH("zh"),
    
    ZT("zt");

    private String value;

    TargetEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static TargetEnum fromValue(String value) {
      for (TargetEnum b : TargetEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<TargetEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final TargetEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public TargetEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return TargetEnum.fromValue(value);
      }
    }

    public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      String value = jsonElement.getAsString();
      TargetEnum.fromValue(value);
    }
  }

  public static final String SERIALIZED_NAME_TARGET = "target";
  @SerializedName(SERIALIZED_NAME_TARGET)
  private TargetEnum target;

  public Translate() {
  }

  public Translate text(String text) {
    this.text = text;
    return this;
  }

   /**
   * The input text to be translated.
   * @return text
  **/
  @javax.annotation.Nullable
  public String getText() {
    return text;
  }

  public void setText(String text) {
    this.text = text;
  }


  public Translate source(SourceEnum source) {
    this.source = source;
    return this;
  }

   /**
   * The language code of the input text.
   * @return source
  **/
  @javax.annotation.Nullable
  public SourceEnum getSource() {
    return source;
  }

  public void setSource(SourceEnum source) {
    this.source = source;
  }


  public Translate target(TargetEnum target) {
    this.target = target;
    return this;
  }

   /**
   * The language code of the desired output translation.
   * @return target
  **/
  @javax.annotation.Nullable
  public TargetEnum getTarget() {
    return target;
  }

  public void setTarget(TargetEnum target) {
    this.target = target;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Translate translate = (Translate) o;
    return Objects.equals(this.text, translate.text) &&
        Objects.equals(this.source, translate.source) &&
        Objects.equals(this.target, translate.target);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && Objects.deepEquals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(text, source, target);
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
    sb.append("class Translate {\n");
    sb.append("    text: ").append(toIndentedString(text)).append("\n");
    sb.append("    source: ").append(toIndentedString(source)).append("\n");
    sb.append("    target: ").append(toIndentedString(target)).append("\n");
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
    openapiFields.add("text");
    openapiFields.add("source");
    openapiFields.add("target");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Element and throws an exception if issues found
  *
  * @param jsonElement JSON Element
  * @throws IOException if the JSON Element is invalid with respect to Translate
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!Translate.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in Translate is not found in the empty JSON string", Translate.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!Translate.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `Translate` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if ((jsonObj.get("text") != null && !jsonObj.get("text").isJsonNull()) && !jsonObj.get("text").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `text` to be a primitive type in the JSON string but got `%s`", jsonObj.get("text").toString()));
      }
      if ((jsonObj.get("source") != null && !jsonObj.get("source").isJsonNull()) && !jsonObj.get("source").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `source` to be a primitive type in the JSON string but got `%s`", jsonObj.get("source").toString()));
      }
      // validate the optional field `source`
      if (jsonObj.get("source") != null && !jsonObj.get("source").isJsonNull()) {
        SourceEnum.validateJsonElement(jsonObj.get("source"));
      }
      if ((jsonObj.get("target") != null && !jsonObj.get("target").isJsonNull()) && !jsonObj.get("target").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `target` to be a primitive type in the JSON string but got `%s`", jsonObj.get("target").toString()));
      }
      // validate the optional field `target`
      if (jsonObj.get("target") != null && !jsonObj.get("target").isJsonNull()) {
        TargetEnum.validateJsonElement(jsonObj.get("target"));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!Translate.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'Translate' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<Translate> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(Translate.class));

       return (TypeAdapter<T>) new TypeAdapter<Translate>() {
           @Override
           public void write(JsonWriter out, Translate value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public Translate read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of Translate given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of Translate
  * @throws IOException if the JSON string is invalid with respect to Translate
  */
  public static Translate fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, Translate.class);
  }

 /**
  * Convert an instance of Translate to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}
