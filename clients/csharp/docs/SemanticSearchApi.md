# Org.OpenAPITools.Api.SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SemanticSearchAsk**](SemanticSearchApi.md#semanticsearchask) | **POST** /api/semantic/ask |  |
| [**SemanticSearchDeleteDocument**](SemanticSearchApi.md#semanticsearchdeletedocument) | **DELETE** /api/semantic/{documentId} |  |
| [**SemanticSearchDeleteIndex**](SemanticSearchApi.md#semanticsearchdeleteindex) | **DELETE** /api/semantic/index |  |
| [**SemanticSearchFileIngestion**](SemanticSearchApi.md#semanticsearchfileingestion) | **POST** /api/ingest/file |  |
| [**SemanticSearchIngestionStatus**](SemanticSearchApi.md#semanticsearchingestionstatus) | **GET** /api/ingest/status |  |
| [**SemanticSearchList**](SemanticSearchApi.md#semanticsearchlist) | **POST** /api/semantic/list |  |
| [**SemanticSearchQuery**](SemanticSearchApi.md#semanticsearchquery) | **POST** /api/semantic/query |  |
| [**SemanticSearchQueryResultsClustering**](SemanticSearchApi.md#semanticsearchqueryresultsclustering) | **POST** /api/semantic/query-results-clustering |  |
| [**SemanticSearchRerank**](SemanticSearchApi.md#semanticsearchrerank) | **POST** /api/semantic/rerank |  |
| [**SemanticSearchTextIngestion**](SemanticSearchApi.md#semanticsearchtextingestion) | **POST** /api/ingest/text |  |
| [**SemanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticsearchwebpageingestion) | **POST** /api/ingest/webpage |  |

<a id="semanticsearchask"></a>
# **SemanticSearchAsk**
> AskDocumentResponse SemanticSearchAsk (AskDocumentRequest askDocumentRequest)



Ask questions over ingested documents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSearchAskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new SemanticSearchApi(config);
            var askDocumentRequest = new AskDocumentRequest(); // AskDocumentRequest | 

            try
            {
                AskDocumentResponse result = apiInstance.SemanticSearchAsk(askDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchAsk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSearchAskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AskDocumentResponse> response = apiInstance.SemanticSearchAskWithHttpInfo(askDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SemanticSearchApi.SemanticSearchAskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **askDocumentRequest** | [**AskDocumentRequest**](AskDocumentRequest.md) |  |  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="semanticsearchfileingestion"></a>
# **SemanticSearchFileIngestion**
> IngestDocumentResponse SemanticSearchFileIngestion (List<System.IO.Stream> files, string? documentId = null, string? index = null, List<string>? pipeline = null, string? webHookUrl = null, string? embeddingModel = null, Dictionary<string, Object>? args = null, Dictionary<string, Object>? tags = null)



Import file document into semantic search

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
            var files = new List<System.IO.Stream>(); // List<System.IO.Stream> | The file object to ingest.
            var documentId = "documentId_example";  // string? | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. (optional) 
            var index = "index_example";  // string? | Optional value to specify with index the document should be ingested. Defaults to 'default'. (optional) 
            var pipeline = new List<string>?(); // List<string>? | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. (optional) 
            var webHookUrl = "webHookUrl_example";  // string? | Url to use for webhook callback when operation finishes or fails. (optional) 
            var embeddingModel = "embeddingModel_example";  // string? | Embedding model to use in ingestion. Optional. Default to configured default. (optional) 
            var args = new Dictionary<string, Object>?(); // Dictionary<string, Object>? |  (optional) 
            var tags = new Dictionary<string, Object>?(); // Dictionary<string, Object>? | Tags to associate with ingestion (optional) 

            try
            {
                IngestDocumentResponse result = apiInstance.SemanticSearchFileIngestion(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags);
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
    ApiResponse<IngestDocumentResponse> response = apiInstance.SemanticSearchFileIngestionWithHttpInfo(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags);
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
| **files** | **List&lt;System.IO.Stream&gt;** | The file object to ingest. |  |
| **documentId** | **string?** | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. | [optional]  |
| **index** | **string?** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;. | [optional]  |
| **pipeline** | [**List&lt;string&gt;?**](string.md) | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional]  |
| **webHookUrl** | **string?** | Url to use for webhook callback when operation finishes or fails. | [optional]  |
| **embeddingModel** | **string?** | Embedding model to use in ingestion. Optional. Default to configured default. | [optional]  |
| **args** | [**Dictionary&lt;string, Object&gt;?**](Dictionary.md) |  | [optional]  |
| **tags** | [**Dictionary&lt;string, Object&gt;?**](Dictionary.md) | Tags to associate with ingestion | [optional]  |

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
| **201** | Created ingestion job |  -  |
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="semanticsearchquery"></a>
# **SemanticSearchQuery**
> QueryDocumentResponse SemanticSearchQuery (QueryDocumentRequest queryDocumentRequest)



Query ingested documents using semantic search

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="semanticsearchtextingestion"></a>
# **SemanticSearchTextIngestion**
> IngestDocumentResponse SemanticSearchTextIngestion (IngestTextDocumentRequest ingestTextDocumentRequest)



Import plain text into semantic search

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

