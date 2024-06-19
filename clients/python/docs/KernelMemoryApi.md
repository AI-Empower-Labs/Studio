# openapi_client.KernelMemoryApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**download_get**](KernelMemoryApi.md#download_get) | **GET** /download | 
[**kernel_memory_ask**](KernelMemoryApi.md#kernel_memory_ask) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM
[**kernel_memory_delete**](KernelMemoryApi.md#kernel_memory_delete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index
[**kernel_memory_delete_index**](KernelMemoryApi.md#kernel_memory_delete_index) | **DELETE** /api/kernelmemory/indexes | Delete index
[**kernel_memory_get_index**](KernelMemoryApi.md#kernel_memory_get_index) | **GET** /api/kernelmemory/indexes | List indexes
[**kernel_memory_search**](KernelMemoryApi.md#kernel_memory_search) | **POST** /api/kernelmemory/search | Search for documents in specific index
[**kernel_memory_upload**](KernelMemoryApi.md#kernel_memory_upload) | **POST** /api/kernelmemory/upload | Upload file for ingestion
[**kernel_memory_upload_status**](KernelMemoryApi.md#kernel_memory_upload_status) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document


# **download_get**
> StreamableFileContent download_get(document_id, filename, index=index)



### Example


```python
import openapi_client
from openapi_client.models.streamable_file_content import StreamableFileContent
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
    api_instance = openapi_client.KernelMemoryApi(api_client)
    document_id = 'document_id_example' # str | 
    filename = 'filename_example' # str | 
    index = 'index_example' # str |  (optional)

    try:
        api_response = api_instance.download_get(document_id, filename, index=index)
        print("The response of KernelMemoryApi->download_get:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->download_get: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **document_id** | **str**|  | 
 **filename** | **str**|  | 
 **index** | **str**|  | [optional] 

### Return type

[**StreamableFileContent**](StreamableFileContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**404** | Not Found |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_ask**
> MemoryAnswer kernel_memory_ask(memory_query)

Query documents and forward result to LLM

### Example


```python
import openapi_client
from openapi_client.models.memory_answer import MemoryAnswer
from openapi_client.models.memory_query import MemoryQuery
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
    api_instance = openapi_client.KernelMemoryApi(api_client)
    memory_query = openapi_client.MemoryQuery() # MemoryQuery | 

    try:
        # Query documents and forward result to LLM
        api_response = api_instance.kernel_memory_ask(memory_query)
        print("The response of KernelMemoryApi->kernel_memory_ask:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_ask: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memory_query** | [**MemoryQuery**](MemoryQuery.md)|  | 

### Return type

[**MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_delete**
> DeleteAccepted kernel_memory_delete(document_id, index=index)

Delete document from specific index

### Example


```python
import openapi_client
from openapi_client.models.delete_accepted import DeleteAccepted
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
    api_instance = openapi_client.KernelMemoryApi(api_client)
    document_id = 'document_id_example' # str | 
    index = 'index_example' # str |  (optional)

    try:
        # Delete document from specific index
        api_response = api_instance.kernel_memory_delete(document_id, index=index)
        print("The response of KernelMemoryApi->kernel_memory_delete:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_delete: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **document_id** | **str**|  | 
 **index** | **str**|  | [optional] 

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**202** | Accepted |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_delete_index**
> DeleteAccepted kernel_memory_delete_index(index=index)

Delete index

### Example


```python
import openapi_client
from openapi_client.models.delete_accepted import DeleteAccepted
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
    api_instance = openapi_client.KernelMemoryApi(api_client)
    index = 'index_example' # str |  (optional)

    try:
        # Delete index
        api_response = api_instance.kernel_memory_delete_index(index=index)
        print("The response of KernelMemoryApi->kernel_memory_delete_index:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_delete_index: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **index** | **str**|  | [optional] 

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**202** | Accepted |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_get_index**
> IndexCollection kernel_memory_get_index()

List indexes

### Example


```python
import openapi_client
from openapi_client.models.index_collection import IndexCollection
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
    api_instance = openapi_client.KernelMemoryApi(api_client)

    try:
        # List indexes
        api_response = api_instance.kernel_memory_get_index()
        print("The response of KernelMemoryApi->kernel_memory_get_index:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_get_index: %s\n" % e)
```



### Parameters

This endpoint does not need any parameter.

### Return type

[**IndexCollection**](IndexCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_search**
> SearchResult kernel_memory_search(search_query)

Search for documents in specific index

### Example


```python
import openapi_client
from openapi_client.models.search_query import SearchQuery
from openapi_client.models.search_result import SearchResult
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
    api_instance = openapi_client.KernelMemoryApi(api_client)
    search_query = openapi_client.SearchQuery() # SearchQuery | 

    try:
        # Search for documents in specific index
        api_response = api_instance.kernel_memory_search(search_query)
        print("The response of KernelMemoryApi->kernel_memory_search:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_search: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search_query** | [**SearchQuery**](SearchQuery.md)|  | 

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_upload**
> UploadAccepted kernel_memory_upload()

Upload file for ingestion

### Example


```python
import openapi_client
from openapi_client.models.upload_accepted import UploadAccepted
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
    api_instance = openapi_client.KernelMemoryApi(api_client)

    try:
        # Upload file for ingestion
        api_response = api_instance.kernel_memory_upload()
        print("The response of KernelMemoryApi->kernel_memory_upload:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_upload: %s\n" % e)
```



### Parameters

This endpoint does not need any parameter.

### Return type

[**UploadAccepted**](UploadAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **kernel_memory_upload_status**
> DataPipelineStatus kernel_memory_upload_status(document_id, index=index)

Get ingestion status for specific document

### Example


```python
import openapi_client
from openapi_client.models.data_pipeline_status import DataPipelineStatus
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
    api_instance = openapi_client.KernelMemoryApi(api_client)
    document_id = 'document_id_example' # str | 
    index = 'index_example' # str |  (optional)

    try:
        # Get ingestion status for specific document
        api_response = api_instance.kernel_memory_upload_status(document_id, index=index)
        print("The response of KernelMemoryApi->kernel_memory_upload_status:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling KernelMemoryApi->kernel_memory_upload_status: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **document_id** | **str**|  | 
 **index** | **str**|  | [optional] 

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**429** | Too Many Requests |  -  |
**503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

