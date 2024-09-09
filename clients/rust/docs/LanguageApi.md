# \LanguageApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**language_detection**](LanguageApi.md#language_detection) | **GET** /api/language/detect | Detects language of a text
[**language_get_language_list**](LanguageApi.md#language_get_language_list) | **GET** /api/language | List of supported languages for translation
[**language_translate**](LanguageApi.md#language_translate) | **POST** /api/language/translate | Translation of text from one language to another



## language_detection

> models::DetectLanguageResponse language_detection(text)
Detects language of a text

Accepts text input and returns information about the language in which the text is written.  The response from the endpoint includes the detected language represented by a language code (e.g., EN for English, ES for Spanish) and may also provide a confidence score indicating the likelihood that the detected language is correct. This type of endpoint is useful for applications requiring automatic language recognition, such as content localization, multilingual support systems, and global data analysis tools.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**text** | **String** |  | [required] |

### Return type

[**models::DetectLanguageResponse**](DetectLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## language_get_language_list

> models::GetLanguageResponse language_get_language_list()
List of supported languages for translation

Returns a list of supported languages, and translation targets

### Parameters

This endpoint does not need any parameter.

### Return type

[**models::GetLanguageResponse**](GetLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## language_translate

> models::TranslateResponse language_translate(translate)
Translation of text from one language to another

This endpoint provides a simplified interface for text translation, making it accessible for various applications, including web and mobile apps that require multilingual support.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**translate** | [**Translate**](Translate.md) |  | [required] |

### Return type

[**models::TranslateResponse**](TranslateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

