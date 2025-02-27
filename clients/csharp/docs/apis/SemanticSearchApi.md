# Org.OpenAPITools.Api.SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SemanticSearchDeleteDocument**](SemanticSearchApi.md#semanticsearchdeletedocument) | **DELETE** /api/semantic/{documentId} |  |
| [**SemanticSearchDeleteIndex**](SemanticSearchApi.md#semanticsearchdeleteindex) | **DELETE** /api/semantic/index/{name} |  |
| [**SemanticSearchFileIngestion**](SemanticSearchApi.md#semanticsearchfileingestion) | **POST** /api/ingest/file | Ingest a File into Semantic Search |
| [**SemanticSearchIngestionStatus**](SemanticSearchApi.md#semanticsearchingestionstatus) | **GET** /api/ingest/status |  |
| [**SemanticSearchList**](SemanticSearchApi.md#semanticsearchlist) | **POST** /api/semantic/list |  |
| [**SemanticSearchQuery**](SemanticSearchApi.md#semanticsearchquery) | **POST** /api/semantic/query |  |
| [**SemanticSearchQueryResultsClustering**](SemanticSearchApi.md#semanticsearchqueryresultsclustering) | **POST** /api/semantic/query-results-clustering |  |
| [**SemanticSearchRerank**](SemanticSearchApi.md#semanticsearchrerank) | **POST** /api/semantic/rerank |  |
| [**SemanticSearchTextIngestion**](SemanticSearchApi.md#semanticsearchtextingestion) | **POST** /api/ingest/text | Ingest Plain Text for Semantic Search |
| [**SemanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticsearchwebpageingestion) | **POST** /api/ingest/webpage |  |

<a id="semanticsearchdeletedocument"></a>
# **SemanticSearchDeleteDocument**
> void SemanticSearchDeleteDocument (string documentId, string index)



Delete specific document by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchDeleteDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var documentId = "documentId_example";  // string | 
            var index = "index_example";  // string | 

            try
            {
                apiInstance.SemanticSearchDeleteDocument(documentId, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchDeleteDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchDeleteDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SemanticSearchDeleteDocumentWithHttpInfo(documentId, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchDeleteDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** |  |  |
| **index** | **string** |  |  |

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
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchdeleteindex"></a>
# **SemanticSearchDeleteIndex**
> void SemanticSearchDeleteIndex (string name)



Delete specific index by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchDeleteIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var name = "name_example";  // string | 

            try
            {
                apiInstance.SemanticSearchDeleteIndex(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchDeleteIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchDeleteIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SemanticSearchDeleteIndexWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchDeleteIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchfileingestion"></a>
# **SemanticSearchFileIngestion**
> IngestDocumentResponse SemanticSearchFileIngestion (string documentId2, List<System.IO.Stream> files, string documentId = null, string index = null, List<string> pipeline = null, string webHookUrl = null, string embeddingModel = null, string index2 = null, string webHookUrl2 = null, string embeddingModelName = null, Dictionary<string, string> context = null, Dictionary<string, List<string>> tags = null, List<string> ingestionPipeline = null, bool languageAutoDetection = null, string language = null)

Ingest a File into Semantic Search

Uploads and ingests a file document into the semantic search index. Supports optional configuration of index, ingestion pipeline, embedding model, and webhook for processing status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchFileIngestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var documentId2 = "documentId_example";  // string | Unique identifier for the document to ingest.
            var files = new List<System.IO.Stream>(); // List<System.IO.Stream> | A collection of files to be ingested. Must contain at least one file.
            var documentId = doc123;  // string | A unique identifier for the document within the index. Documents with the same ID will be overwritten. (optional) 
            var index = my_custom_index;  // string | The name of the index where the document will be ingested. Defaults to 'default' if not specified. (optional) 
            var pipeline = new List<string>(); // List<string> | An array of ingestion pipeline step names. If not provided, server default steps will be used. (optional) 
            var webHookUrl = https://example.com/webhook;  // string | A URL to receive a callback via webhook when the ingestion process is completed or fails. (optional) 
            var embeddingModel = model_v2;  // string | The embedding model to use during ingestion. If not specified, the server's default model will be applied. (optional) 
            var index2 = "index_example";  // string | Optional index name where the document will be stored. (optional) 
            var webHookUrl2 = "webHookUrl_example";  // string | Optional webhook URL to notify upon completion. (optional) 
            var embeddingModelName = "embeddingModelName_example";  // string | Optional name of the embedding model to use during ingestion. (optional) 
            var context = new Dictionary<string, string>(); // Dictionary<string, string> | Optional key-value pairs for additional context or metadata. (optional) 
            var tags = new Dictionary<string, List<string>>(); // Dictionary<string, List<string>> | A collection of tags associated with the document. Tags can be language-specific. (optional) 
            var ingestionPipeline = new List<string>(); // List<string> | Optional list of ingestion pipeline steps. Allows custom processing. (optional) 
            var languageAutoDetection = false;  // bool | Enable automatic language detection for document content. (optional)  (default to false)
            var language = "arabic";  // string | Force a specific language for full-text search. Use 'simple' for no language or leave empty. (optional) 

            try
            {
                // Ingest a File into Semantic Search
                IngestDocumentResponse result = apiInstance.SemanticSearchFileIngestion(documentId2, files, documentId, index, pipeline, webHookUrl, embeddingModel, index2, webHookUrl2, embeddingModelName, context, tags, ingestionPipeline, languageAutoDetection, language);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchFileIngestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchFileIngestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ingest a File into Semantic Search
    ApiResponse<IngestDocumentResponse> response = apiInstance.SemanticSearchFileIngestionWithHttpInfo(documentId2, files, documentId, index, pipeline, webHookUrl, embeddingModel, index2, webHookUrl2, embeddingModelName, context, tags, ingestionPipeline, languageAutoDetection, language);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchFileIngestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId2** | **string** | Unique identifier for the document to ingest. |  |
| **files** | **List&lt;System.IO.Stream&gt;** | A collection of files to be ingested. Must contain at least one file. |  |
| **documentId** | **string** | A unique identifier for the document within the index. Documents with the same ID will be overwritten. | [optional]  |
| **index** | **string** | The name of the index where the document will be ingested. Defaults to &#39;default&#39; if not specified. | [optional]  |
| **pipeline** | [**List&lt;string&gt;**](string.md) | An array of ingestion pipeline step names. If not provided, server default steps will be used. | [optional]  |
| **webHookUrl** | **string** | A URL to receive a callback via webhook when the ingestion process is completed or fails. | [optional]  |
| **embeddingModel** | **string** | The embedding model to use during ingestion. If not specified, the server&#39;s default model will be applied. | [optional]  |
| **index2** | **string** | Optional index name where the document will be stored. | [optional]  |
| **webHookUrl2** | **string** | Optional webhook URL to notify upon completion. | [optional]  |
| **embeddingModelName** | **string** | Optional name of the embedding model to use during ingestion. | [optional]  |
| **context** | [**Dictionary&lt;string, string&gt;**](Dictionary.md) | Optional key-value pairs for additional context or metadata. | [optional]  |
| **tags** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Dictionary.md) | A collection of tags associated with the document. Tags can be language-specific. | [optional]  |
| **ingestionPipeline** | [**List&lt;string&gt;**](string.md) | Optional list of ingestion pipeline steps. Allows custom processing. | [optional]  |
| **languageAutoDetection** | **bool** | Enable automatic language detection for document content. | [optional] [default to false] |
| **language** | **string** | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional]  |

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
| **201** | Ingestion job successfully created. |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchingestionstatus"></a>
# **SemanticSearchIngestionStatus**
> DataPipelineStatus SemanticSearchIngestionStatus (Guid id)



Get queue status for ingestion job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchIngestionStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                DataPipelineStatus result = apiInstance.SemanticSearchIngestionStatus(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchIngestionStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchIngestionStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataPipelineStatus> response = apiInstance.SemanticSearchIngestionStatusWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchIngestionStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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
| **200** | Created ingestion job |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **404** | Not Found |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchlist"></a>
# **SemanticSearchList**
> ListDocumentResponse SemanticSearchList (ListDocumentParameters listDocumentParameters)



List - and filter - for ingested documents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var listDocumentParameters = new ListDocumentParameters(); // ListDocumentParameters | 

            try
            {
                ListDocumentResponse result = apiInstance.SemanticSearchList(listDocumentParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListDocumentResponse> response = apiInstance.SemanticSearchListWithHttpInfo(listDocumentParameters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listDocumentParameters** | [**ListDocumentParameters**](ListDocumentParameters.md) |  |  |

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
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchquery"></a>
# **SemanticSearchQuery**
> QueryDocumentResponse SemanticSearchQuery (QueryDocumentRequest queryDocumentRequest)



Performs semantic or hybrid search over previously ingested data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var queryDocumentRequest = new QueryDocumentRequest(); // QueryDocumentRequest | 

            try
            {
                QueryDocumentResponse result = apiInstance.SemanticSearchQuery(queryDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QueryDocumentResponse> response = apiInstance.SemanticSearchQueryWithHttpInfo(queryDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryDocumentRequest** | [**QueryDocumentRequest**](QueryDocumentRequest.md) |  |  |

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
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchqueryresultsclustering"></a>
# **SemanticSearchQueryResultsClustering**
> KMeansCluster SemanticSearchQueryResultsClustering (SemanticSearchQueryResultsClusteringRequest semanticSearchQueryResultsClusteringRequest)



Perform k-means clustering over semantic search log entries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchQueryResultsClusteringExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var semanticSearchQueryResultsClusteringRequest = new SemanticSearchQueryResultsClusteringRequest(); // SemanticSearchQueryResultsClusteringRequest | 

            try
            {
                KMeansCluster result = apiInstance.SemanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchQueryResultsClustering: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchQueryResultsClusteringWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<KMeansCluster> response = apiInstance.SemanticSearchQueryResultsClusteringWithHttpInfo(semanticSearchQueryResultsClusteringRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchQueryResultsClusteringWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **semanticSearchQueryResultsClusteringRequest** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md) |  |  |

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
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchrerank"></a>
# **SemanticSearchRerank**
> ReRankDocumentsResponse SemanticSearchRerank (ReRankDocumentsRequest reRankDocumentsRequest)



Rerank documents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchRerankExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var reRankDocumentsRequest = new ReRankDocumentsRequest(); // ReRankDocumentsRequest | 

            try
            {
                ReRankDocumentsResponse result = apiInstance.SemanticSearchRerank(reRankDocumentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchRerank: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchRerankWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReRankDocumentsResponse> response = apiInstance.SemanticSearchRerankWithHttpInfo(reRankDocumentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchRerankWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reRankDocumentsRequest** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md) |  |  |

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
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchtextingestion"></a>
# **SemanticSearchTextIngestion**
> IngestDocumentResponse SemanticSearchTextIngestion (IngestTextDocumentRequest ingestTextDocumentRequest)

Ingest Plain Text for Semantic Search

Ingests a plain text document into the semantic search index. This endpoint allows associating tags and specifying the target index for enhanced search capabilities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchTextIngestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var ingestTextDocumentRequest = new IngestTextDocumentRequest(); // IngestTextDocumentRequest | 

            try
            {
                // Ingest Plain Text for Semantic Search
                IngestDocumentResponse result = apiInstance.SemanticSearchTextIngestion(ingestTextDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchTextIngestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchTextIngestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ingest Plain Text for Semantic Search
    ApiResponse<IngestDocumentResponse> response = apiInstance.SemanticSearchTextIngestionWithHttpInfo(ingestTextDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchTextIngestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingestTextDocumentRequest** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md) |  |  |

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
| **201** | Created ingestion job |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsearchwebpageingestion"></a>
# **SemanticSearchWebpageIngestion**
> IngestDocumentResponse SemanticSearchWebpageIngestion (IngestWebPageDocumentRequest ingestWebPageDocumentRequest)



Import web page text into semantic search

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchWebpageIngestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var ingestWebPageDocumentRequest = new IngestWebPageDocumentRequest(); // IngestWebPageDocumentRequest | 

            try
            {
                IngestDocumentResponse result = apiInstance.SemanticSearchWebpageIngestion(ingestWebPageDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchWebpageIngestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchWebpageIngestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IngestDocumentResponse> response = apiInstance.SemanticSearchWebpageIngestionWithHttpInfo(ingestWebPageDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchWebpageIngestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingestWebPageDocumentRequest** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md) |  |  |

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
| **201** | Created ingestion job |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

