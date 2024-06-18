# LanguageApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**languageDetection**](LanguageApi.md#languageDetection) | **GET** /api/language/detect | Detects language of a text |
| [**languageGetLanguageList**](LanguageApi.md#languageGetLanguageList) | **GET** /api/language | List of supported languages for translation |
| [**languageTranslate**](LanguageApi.md#languageTranslate) | **POST** /api/language/translate | Translation of text from one language to another |


<a id="languageDetection"></a>
# **languageDetection**
> DetectLanguageResponse languageDetection(text)

Detects language of a text

Accepts text input and returns information about the language in which the text is written.  The response from the endpoint includes the detected language represented by a language code (e.g., EN for English, ES for Spanish) and may also provide a confidence score indicating the likelihood that the detected language is correct. This type of endpoint is useful for applications requiring automatic language recognition, such as content localization, multilingual support systems, and global data analysis tools.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LanguageApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    LanguageApi apiInstance = new LanguageApi(defaultClient);
    String text = "text_example"; // String | 
    try {
      DetectLanguageResponse result = apiInstance.languageDetection(text);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LanguageApi#languageDetection");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **text** | **String**|  | |

### Return type

[**DetectLanguageResponse**](DetectLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

<a id="languageGetLanguageList"></a>
# **languageGetLanguageList**
> GetLanguageResponse languageGetLanguageList()

List of supported languages for translation

Returns a list of supported languages, and translation targets

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LanguageApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    LanguageApi apiInstance = new LanguageApi(defaultClient);
    try {
      GetLanguageResponse result = apiInstance.languageGetLanguageList();
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LanguageApi#languageGetLanguageList");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetLanguageResponse**](GetLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

<a id="languageTranslate"></a>
# **languageTranslate**
> TranslateResponse languageTranslate(translate)

Translation of text from one language to another

This endpoint provides a simplified interface for text translation, making it accessible for various applications, including web and mobile apps that require multilingual support.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LanguageApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    LanguageApi apiInstance = new LanguageApi(defaultClient);
    Translate translate = new Translate(); // Translate | 
    try {
      TranslateResponse result = apiInstance.languageTranslate(translate);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling LanguageApi#languageTranslate");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **translate** | [**Translate**](Translate.md)|  | |

### Return type

[**TranslateResponse**](TranslateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

