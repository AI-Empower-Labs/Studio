# openapi_client.LanguageApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**language_detection**](LanguageApi.md#language_detection) | **GET** /api/language/detect | Detects language of a text
[**language_get_language_list**](LanguageApi.md#language_get_language_list) | **GET** /api/language | List of supported languages for translation
[**language_translate**](LanguageApi.md#language_translate) | **POST** /api/language/translate | Translation of text from one language to another


# **language_detection**
> DetectLanguageResponse language_detection(text)

Detects language of a text

Accepts text input and returns information about the language in which the text is written.
 The response from the endpoint includes the detected language represented by a language code (e.g., EN for English, ES for Spanish) and may also provide a confidence score indicating the likelihood that the detected language is correct. This type of endpoint is useful for applications requiring automatic language recognition, such as content localization, multilingual support systems, and global data analysis tools.

### Example


```python
import openapi_client
from openapi_client.models.detect_language_response import DetectLanguageResponse
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://studio.aiempowerlabs.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://studio.aiempowerlabs.com"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.LanguageApi(api_client)
    text = 'text_example' # str | 

    try:
        # Detects language of a text
        api_response = api_instance.language_detection(text)
        print("The response of LanguageApi->language_detection:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling LanguageApi->language_detection: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **str**|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **language_get_language_list**
> GetLanguageResponse language_get_language_list()

List of supported languages for translation

Returns a list of supported languages, and translation targets

### Example


```python
import openapi_client
from openapi_client.models.get_language_response import GetLanguageResponse
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://studio.aiempowerlabs.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://studio.aiempowerlabs.com"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.LanguageApi(api_client)

    try:
        # List of supported languages for translation
        api_response = api_instance.language_get_language_list()
        print("The response of LanguageApi->language_get_language_list:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling LanguageApi->language_get_language_list: %s\n" % e)
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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **language_translate**
> TranslateResponse language_translate(translate)

Translation of text from one language to another

This endpoint provides a simplified interface for text translation, making it accessible for various applications, including web and mobile apps that require multilingual support.

### Example


```python
import openapi_client
from openapi_client.models.translate import Translate
from openapi_client.models.translate_response import TranslateResponse
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://studio.aiempowerlabs.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://studio.aiempowerlabs.com"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.LanguageApi(api_client)
    translate = {"text":"Hej verden","source":"auto","target":"en"} # Translate | 

    try:
        # Translation of text from one language to another
        api_response = api_instance.language_translate(translate)
        print("The response of LanguageApi->language_translate:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling LanguageApi->language_translate: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **translate** | [**Translate**](Translate.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

