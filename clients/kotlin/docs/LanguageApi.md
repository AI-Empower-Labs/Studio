# LanguageApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**languageDetection**](LanguageApi.md#languageDetection) | **GET** /api/language/detect | Detects language of a text |
| [**languageGetLanguageList**](LanguageApi.md#languageGetLanguageList) | **GET** /api/language | List of supported languages for translation |
| [**languageTranslate**](LanguageApi.md#languageTranslate) | **POST** /api/language/translate | Translation of text from one language to another |


<a id="languageDetection"></a>
# **languageDetection**
> DetectLanguageResponse languageDetection(text)

Detects language of a text

Accepts text input and returns information about the language in which the text is written.  The response from the endpoint includes the detected language represented by a language code (e.g., EN for English, ES for Spanish) and may also provide a confidence score indicating the likelihood that the detected language is correct. This type of endpoint is useful for applications requiring automatic language recognition, such as content localization, multilingual support systems, and global data analysis tools.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LanguageApi()
val text : kotlin.String = text_example // kotlin.String | 
try {
    val result : DetectLanguageResponse = apiInstance.languageDetection(text)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling LanguageApi#languageDetection")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LanguageApi#languageDetection")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **text** | **kotlin.String**|  | |

### Return type

[**DetectLanguageResponse**](DetectLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

<a id="languageGetLanguageList"></a>
# **languageGetLanguageList**
> GetLanguageResponse languageGetLanguageList()

List of supported languages for translation

Returns a list of supported languages, and translation targets

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LanguageApi()
try {
    val result : GetLanguageResponse = apiInstance.languageGetLanguageList()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling LanguageApi#languageGetLanguageList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LanguageApi#languageGetLanguageList")
    e.printStackTrace()
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

<a id="languageTranslate"></a>
# **languageTranslate**
> TranslateResponse languageTranslate(translate)

Translation of text from one language to another

This endpoint provides a simplified interface for text translation, making it accessible for various applications, including web and mobile apps that require multilingual support.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LanguageApi()
val translate : Translate = {"text":"Hej verden","source":"auto","target":"en"} // Translate | 
try {
    val result : TranslateResponse = apiInstance.languageTranslate(translate)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling LanguageApi#languageTranslate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LanguageApi#languageTranslate")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **translate** | [**Translate**](Translate.md)|  | |

### Return type

[**TranslateResponse**](TranslateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

