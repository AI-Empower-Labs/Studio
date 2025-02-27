# openapi_client.MiscellaneousApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete_llm_cache_entry**](MiscellaneousApi.md#delete_llm_cache_entry) | **DELETE** /api/cache | 
[**get_configuration**](MiscellaneousApi.md#get_configuration) | **GET** /info | 


# **delete_llm_cache_entry**
> delete_llm_cache_entry(key=key)

Delete LLM cache entry

### Example


```python
import openapi_client
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
    api_instance = openapi_client.MiscellaneousApi(api_client)
    key = 'key_example' # str | The LLM cache key to remove (optional)

    try:
        api_instance.delete_llm_cache_entry(key=key)
    except Exception as e:
        print("Exception when calling MiscellaneousApi->delete_llm_cache_entry: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **str**| The LLM cache key to remove | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK - Cache was deleted |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_configuration**
> List[Dict[str, List[str]]] get_configuration()

Get configuration information

### Example


```python
import openapi_client
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
    api_instance = openapi_client.MiscellaneousApi(api_client)

    try:
        api_response = api_instance.get_configuration()
        print("The response of MiscellaneousApi->get_configuration:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling MiscellaneousApi->get_configuration: %s\n" % e)
```



### Parameters

This endpoint does not need any parameter.

### Return type

**List[Dict[str, List[str]]]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Current configuration |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

