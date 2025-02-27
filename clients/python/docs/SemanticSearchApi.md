# openapi_client.SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**semantic_search_delete_document**](SemanticSearchApi.md#semantic_search_delete_document) | **DELETE** /api/semantic/{documentId} | 
[**semantic_search_delete_index**](SemanticSearchApi.md#semantic_search_delete_index) | **DELETE** /api/semantic/index/{name} | 
[**semantic_search_file_ingestion**](SemanticSearchApi.md#semantic_search_file_ingestion) | **POST** /api/ingest/file | Ingest a File into Semantic Search
[**semantic_search_ingestion_status**](SemanticSearchApi.md#semantic_search_ingestion_status) | **GET** /api/ingest/status | 
[**semantic_search_list**](SemanticSearchApi.md#semantic_search_list) | **POST** /api/semantic/list | 
[**semantic_search_query**](SemanticSearchApi.md#semantic_search_query) | **POST** /api/semantic/query | 
[**semantic_search_query_results_clustering**](SemanticSearchApi.md#semantic_search_query_results_clustering) | **POST** /api/semantic/query-results-clustering | 
[**semantic_search_rerank**](SemanticSearchApi.md#semantic_search_rerank) | **POST** /api/semantic/rerank | 
[**semantic_search_text_ingestion**](SemanticSearchApi.md#semantic_search_text_ingestion) | **POST** /api/ingest/text | Ingest Plain Text for Semantic Search
[**semantic_search_webpage_ingestion**](SemanticSearchApi.md#semantic_search_webpage_ingestion) | **POST** /api/ingest/webpage | 


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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_file_ingestion**
> IngestDocumentResponse semantic_search_file_ingestion(files, document_id=document_id, index=index, pipeline=pipeline, web_hook_url=web_hook_url, embedding_model=embedding_model, document_id2=document_id2, index2=index2, web_hook_url2=web_hook_url2, embedding_model_name=embedding_model_name, context=context, tags=tags, ingestion_pipeline=ingestion_pipeline, language_auto_detection=language_auto_detection, language=language)

Ingest a File into Semantic Search

Uploads and ingests a file document into the semantic search index. Supports optional configuration of index, ingestion pipeline, embedding model, and webhook for processing status.

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
    files = None # List[bytearray] | A collection of files to be ingested. Must contain at least one file.
    document_id = 'doc123' # str | A unique identifier for the document within the index. Documents with the same ID will be overwritten. (optional)
    index = 'my_custom_index' # str | The name of the index where the document will be ingested. Defaults to 'default' if not specified. (optional)
    pipeline = ['[\"step1\",\"step2\"]'] # List[str] | An array of ingestion pipeline step names. If not provided, server default steps will be used. (optional)
    web_hook_url = 'https://example.com/webhook' # str | A URL to receive a callback via webhook when the ingestion process is completed or fails. (optional)
    embedding_model = 'model_v2' # str | The embedding model to use during ingestion. If not specified, the server's default model will be applied. (optional)
    document_id2 = 'document_id_example' # str | Unique identifier for the document to ingest. (optional)
    index2 = 'index_example' # str | Optional index name where the document will be stored. (optional)
    web_hook_url2 = 'web_hook_url_example' # str | Optional webhook URL to notify upon completion. (optional)
    embedding_model_name = 'embedding_model_name_example' # str | Optional name of the embedding model to use during ingestion. (optional)
    context = None # Dict[str, str] | Optional key-value pairs for additional context or metadata. (optional)
    tags = None # Dict[str, List[str]] | A collection of tags associated with the document. Tags can be language-specific. (optional)
    ingestion_pipeline = ['ingestion_pipeline_example'] # List[str] | Optional list of ingestion pipeline steps. Allows custom processing. (optional)
    language_auto_detection = False # bool | Enable automatic language detection for document content. (optional) (default to False)
    language = 'language_example' # str | Force a specific language for full-text search. Use 'simple' for no language or leave empty. (optional)

    try:
        # Ingest a File into Semantic Search
        api_response = api_instance.semantic_search_file_ingestion(files, document_id=document_id, index=index, pipeline=pipeline, web_hook_url=web_hook_url, embedding_model=embedding_model, document_id2=document_id2, index2=index2, web_hook_url2=web_hook_url2, embedding_model_name=embedding_model_name, context=context, tags=tags, ingestion_pipeline=ingestion_pipeline, language_auto_detection=language_auto_detection, language=language)
        print("The response of SemanticSearchApi->semantic_search_file_ingestion:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_file_ingestion: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **List[bytearray]**| A collection of files to be ingested. Must contain at least one file. | 
 **document_id** | **str**| A unique identifier for the document within the index. Documents with the same ID will be overwritten. | [optional] 
 **index** | **str**| The name of the index where the document will be ingested. Defaults to &#39;default&#39; if not specified. | [optional] 
 **pipeline** | [**List[str]**](str.md)| An array of ingestion pipeline step names. If not provided, server default steps will be used. | [optional] 
 **web_hook_url** | **str**| A URL to receive a callback via webhook when the ingestion process is completed or fails. | [optional] 
 **embedding_model** | **str**| The embedding model to use during ingestion. If not specified, the server&#39;s default model will be applied. | [optional] 
 **document_id2** | **str**| Unique identifier for the document to ingest. | [optional] 
 **index2** | **str**| Optional index name where the document will be stored. | [optional] 
 **web_hook_url2** | **str**| Optional webhook URL to notify upon completion. | [optional] 
 **embedding_model_name** | **str**| Optional name of the embedding model to use during ingestion. | [optional] 
 **context** | [**Dict[str, str]**](Dict.md)| Optional key-value pairs for additional context or metadata. | [optional] 
 **tags** | [**Dict[str, List[str]]**](Dict.md)| A collection of tags associated with the document. Tags can be language-specific. | [optional] 
 **ingestion_pipeline** | [**List[str]**](str.md)| Optional list of ingestion pipeline steps. Allows custom processing. | [optional] 
 **language_auto_detection** | **bool**| Enable automatic language detection for document content. | [optional] [default to False]
 **language** | **str**| Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] 

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
**201** | Ingestion job successfully created. |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

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
**400** | Invalid request parameters or validation error. |  -  |
**404** | Not Found |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_query**
> QueryDocumentResponse semantic_search_query(query_document_request)

Performs semantic or hybrid search over previously ingested data.

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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_query_results_clustering**
> KMeansCluster semantic_search_query_results_clustering(semantic_search_query_results_clustering_request)

Perform k-means clustering over semantic search log entries

### Example


```python
import openapi_client
from openapi_client.models.k_means_cluster import KMeansCluster
from openapi_client.models.semantic_search_query_results_clustering_request import SemanticSearchQueryResultsClusteringRequest
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
    semantic_search_query_results_clustering_request = openapi_client.SemanticSearchQueryResultsClusteringRequest() # SemanticSearchQueryResultsClusteringRequest | 

    try:
        api_response = api_instance.semantic_search_query_results_clustering(semantic_search_query_results_clustering_request)
        print("The response of SemanticSearchApi->semantic_search_query_results_clustering:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling SemanticSearchApi->semantic_search_query_results_clustering: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semantic_search_query_results_clustering_request** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md)|  | 

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/csv, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_search_text_ingestion**
> IngestDocumentResponse semantic_search_text_ingestion(ingest_text_document_request)

Ingest Plain Text for Semantic Search

Ingests a plain text document into the semantic search index. This endpoint allows associating tags and specifying the target index for enhanced search capabilities.

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
        # Ingest Plain Text for Semantic Search
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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

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
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

