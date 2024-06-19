# openapi_client.SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**semantic_search_ask**](SemanticSearchApi.md#semantic_search_ask) | **POST** /api/semantic/ask | 
[**semantic_search_delete_document**](SemanticSearchApi.md#semantic_search_delete_document) | **DELETE** /api/semantic/{documentId} | 
[**semantic_search_delete_index**](SemanticSearchApi.md#semantic_search_delete_index) | **DELETE** /api/semantic/index | 
[**semantic_search_file_ingestion**](SemanticSearchApi.md#semantic_search_file_ingestion) | **POST** /api/semantic/ingest/file | 
[**semantic_search_ingestion_status**](SemanticSearchApi.md#semantic_search_ingestion_status) | **GET** /api/semantic/ingest/status | 
[**semantic_search_list**](SemanticSearchApi.md#semantic_search_list) | **POST** /api/semantic/list | 
[**semantic_search_query**](SemanticSearchApi.md#semantic_search_query) | **POST** /api/semantic/query | 
[**semantic_search_rerank**](SemanticSearchApi.md#semantic_search_rerank) | **POST** /api/semantic/rerank | 
[**semantic_search_text_ingestion**](SemanticSearchApi.md#semantic_search_text_ingestion) | **POST** /api/semantic/ingest/text | 
[**semantic_search_webpage_ingestion**](SemanticSearchApi.md#semantic_search_webpage_ingestion) | **POST** /api/semantic/ingest/webpage | 


# **semantic_search_ask**
> AskDocumentResponse semantic_search_ask(ask_document_request)



Ask questions over ingested documents

### Example


```python
import openapi_client
from openapi_client.models.ask_document_request import AskDocumentRequest
from openapi_client.models.ask_document_response import AskDocumentResponse
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    ask_document_request = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8} # AskDocumentRequest | 

    try:
        api_response = api_instance.semantic_search_ask(ask_document_request)
        print("The response of SemanticSearchApi->semantic_search_ask:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_ask: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ask_document_request** | [**AskDocumentRequest**](AskDocumentRequest.md)|  | 

### Return type

[**AskDocumentResponse**](AskDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_delete_document**
> semantic_search_delete_document(document_id, index)



Delete specific document by id

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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    document_id = 'document_id_example' # str | 
    index = 'index_example' # str | 

    try:
        api_instance.semantic_search_delete_document(document_id, index)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_delete_document: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **document_id** | **str**|  | 
 **index** | **str**|  | 

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
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_delete_index**
> semantic_search_delete_index(name)



Delete specific index by name

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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    name = 'name_example' # str | 

    try:
        api_instance.semantic_search_delete_index(name)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_delete_index: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **str**|  | 

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
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_file_ingestion**
> IngestDocumentResponse semantic_search_file_ingestion(files, document_id=document_id, index=index, pipeline=pipeline, web_hook_url=web_hook_url, embedding_model=embedding_model, args=args, tags=tags)



Import file document into semantic search

### Example


```python
import openapi_client
from openapi_client.models.ingest_document_response import IngestDocumentResponse
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    files = None # List[bytearray] | The file object to ingest.
    document_id = 'document_id_example' # str | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. (optional)
    index = 'index_example' # str | Optional value to specify with index the document should be ingested. Defaults to 'default'. (optional)
    pipeline = ['pipeline_example'] # List[str] | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. (optional)
    web_hook_url = 'web_hook_url_example' # str | Url to use for webhook callback when operation finishes or fails. (optional)
    embedding_model = 'embedding_model_example' # str | Embedding model to use in ingestion. Optional. Default to configured default. (optional)
    args = None # Dict[str, Optional[object]] |  (optional)
    tags = None # Dict[str, object] | Tags to associate with ingestion (optional)

    try:
        api_response = api_instance.semantic_search_file_ingestion(files, document_id=document_id, index=index, pipeline=pipeline, web_hook_url=web_hook_url, embedding_model=embedding_model, args=args, tags=tags)
        print("The response of SemanticSearchApi->semantic_search_file_ingestion:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_file_ingestion: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **List[bytearray]**| The file object to ingest. | 
 **document_id** | **str**| Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. | [optional] 
 **index** | **str**| Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;. | [optional] 
 **pipeline** | [**List[str]**](str.md)| Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
 **web_hook_url** | **str**| Url to use for webhook callback when operation finishes or fails. | [optional] 
 **embedding_model** | **str**| Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 
 **args** | [**Dict[str, Optional[object]]**](Dict.md)|  | [optional] 
 **tags** | [**Dict[str, object]**](Dict.md)| Tags to associate with ingestion | [optional] 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**201** | Created ingestion job |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_ingestion_status**
> DataPipelineStatus semantic_search_ingestion_status(id)



Get queue status for ingestion job

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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    id = 'id_example' # str | 

    try:
        api_response = api_instance.semantic_search_ingestion_status(id)
        print("The response of SemanticSearchApi->semantic_search_ingestion_status:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_ingestion_status: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**|  | 

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
**200** | Created ingestion job |  -  |
**400** | Bad Request |  -  |
**404** | Not Found |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_list**
> ListDocumentResponse semantic_search_list(list_document_parameters)



List - and filter - for ingested documents

### Example


```python
import openapi_client
from openapi_client.models.list_document_parameters import ListDocumentParameters
from openapi_client.models.list_document_response import ListDocumentResponse
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    list_document_parameters = {"index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"withEmbeddings":false,"limit":10} # ListDocumentParameters | 

    try:
        api_response = api_instance.semantic_search_list(list_document_parameters)
        print("The response of SemanticSearchApi->semantic_search_list:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_list: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_document_parameters** | [**ListDocumentParameters**](ListDocumentParameters.md)|  | 

### Return type

[**ListDocumentResponse**](ListDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_query**
> QueryDocumentResponse semantic_search_query(query_document_request)



Query ingested documents using semantic search

### Example


```python
import openapi_client
from openapi_client.models.query_document_request import QueryDocumentRequest
from openapi_client.models.query_document_response import QueryDocumentResponse
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    query_document_request = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8,"limit":10} # QueryDocumentRequest | 

    try:
        api_response = api_instance.semantic_search_query(query_document_request)
        print("The response of SemanticSearchApi->semantic_search_query:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_query: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query_document_request** | [**QueryDocumentRequest**](QueryDocumentRequest.md)|  | 

### Return type

[**QueryDocumentResponse**](QueryDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_rerank**
> ReRankDocumentsResponse semantic_search_rerank(re_rank_documents_request)



Rerank documents

### Example


```python
import openapi_client
from openapi_client.models.re_rank_documents_request import ReRankDocumentsRequest
from openapi_client.models.re_rank_documents_response import ReRankDocumentsResponse
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    re_rank_documents_request = {"query":"What is the capital of the United States?","documents":["Carson City is the capital city of the American state of Nevada. At the  2010 United States Census, Carson City had a population of 55,274.","The Commonwealth of the Northern Mariana Islands is a group of islands in the Pacific Ocean that are a political division controlled by the United States. Its capital is Saipan.","Charlotte Amalie is the capital and largest city of the United States Virgin Islands. It has about 20,000 people. The city is on the island of Saint Thomas.","Washington, D.C. (also known as simply Washington or D.C., and officially as the District of Columbia) is the capital of the United States. It is a federal district. ","Capital punishment (the death penalty) has existed in the United States since before the United States was a country. As of 2017, capital punishment is legal in 30 of the 50 states.","North Dakota is a state in the United States. 672,591 people lived in North Dakota in the year 2010. The capital and seat of government is Bismarck."],"limit":10} # ReRankDocumentsRequest | 

    try:
        api_response = api_instance.semantic_search_rerank(re_rank_documents_request)
        print("The response of SemanticSearchApi->semantic_search_rerank:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_rerank: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **re_rank_documents_request** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md)|  | 

### Return type

[**ReRankDocumentsResponse**](ReRankDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_text_ingestion**
> IngestDocumentResponse semantic_search_text_ingestion(ingest_text_document_request)



Import plain text into semantic search

### Example


```python
import openapi_client
from openapi_client.models.ingest_document_response import IngestDocumentResponse
from openapi_client.models.ingest_text_document_request import IngestTextDocumentRequest
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    ingest_text_document_request = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Great":[],"AI":[],"Software":["true"]},"text":"Hello world"} # IngestTextDocumentRequest | 

    try:
        api_response = api_instance.semantic_search_text_ingestion(ingest_text_document_request)
        print("The response of SemanticSearchApi->semantic_search_text_ingestion:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_text_ingestion: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingest_text_document_request** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md)|  | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**201** | Created ingestion job |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_webpage_ingestion**
> IngestDocumentResponse semantic_search_webpage_ingestion(ingest_web_page_document_request)



Import web page text into semantic search

### Example


```python
import openapi_client
from openapi_client.models.ingest_document_response import IngestDocumentResponse
from openapi_client.models.ingest_web_page_document_request import IngestWebPageDocumentRequest
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
    api_instance = openapi_client.SemanticSearchApi(api_client)
    ingest_web_page_document_request = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Software":["true"]},"url":"https://www.aiempowerlabs.com"} # IngestWebPageDocumentRequest | 

    try:
        api_response = api_instance.semantic_search_webpage_ingestion(ingest_web_page_document_request)
        print("The response of SemanticSearchApi->semantic_search_webpage_ingestion:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_webpage_ingestion: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingest_web_page_document_request** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md)|  | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**201** | Created ingestion job |  -  |
**400** | Bad Request |  -  |
**429** | Too Many Requests |  -  |
**500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

