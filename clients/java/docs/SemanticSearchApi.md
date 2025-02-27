# SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**semanticSearchDeleteDocument**](SemanticSearchApi.md#semanticSearchDeleteDocument) | **DELETE** /api/semantic/{documentId} |  |
| [**semanticSearchDeleteIndex**](SemanticSearchApi.md#semanticSearchDeleteIndex) | **DELETE** /api/semantic/index/{name} |  |
| [**semanticSearchFileIngestion**](SemanticSearchApi.md#semanticSearchFileIngestion) | **POST** /api/ingest/file | Ingest a File into Semantic Search |
| [**semanticSearchIngestionStatus**](SemanticSearchApi.md#semanticSearchIngestionStatus) | **GET** /api/ingest/status |  |
| [**semanticSearchList**](SemanticSearchApi.md#semanticSearchList) | **POST** /api/semantic/list |  |
| [**semanticSearchQuery**](SemanticSearchApi.md#semanticSearchQuery) | **POST** /api/semantic/query |  |
| [**semanticSearchQueryResultsClustering**](SemanticSearchApi.md#semanticSearchQueryResultsClustering) | **POST** /api/semantic/query-results-clustering |  |
| [**semanticSearchRerank**](SemanticSearchApi.md#semanticSearchRerank) | **POST** /api/semantic/rerank |  |
| [**semanticSearchTextIngestion**](SemanticSearchApi.md#semanticSearchTextIngestion) | **POST** /api/ingest/text | Ingest Plain Text for Semantic Search |
| [**semanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticSearchWebpageIngestion) | **POST** /api/ingest/webpage |  |


<a id="semanticSearchDeleteDocument"></a>
# **semanticSearchDeleteDocument**
> semanticSearchDeleteDocument(documentId, index)



Delete specific document by id

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    String documentId = "documentId_example"; // String | 
    String index = "index_example"; // String | 
    try {
      apiInstance.semanticSearchDeleteDocument(documentId, index);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchDeleteDocument");
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
| **documentId** | **String**|  | |
| **index** | **String**|  | |

### Return type

null (empty response body)

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

<a id="semanticSearchDeleteIndex"></a>
# **semanticSearchDeleteIndex**
> semanticSearchDeleteIndex(name)



Delete specific index by name

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    String name = "name_example"; // String | 
    try {
      apiInstance.semanticSearchDeleteIndex(name);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchDeleteIndex");
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
| **name** | **String**|  | |

### Return type

null (empty response body)

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

<a id="semanticSearchFileIngestion"></a>
# **semanticSearchFileIngestion**
> IngestDocumentResponse semanticSearchFileIngestion(documentId2, files, documentId, index, pipeline, webHookUrl, embeddingModel, index2, webHookUrl2, embeddingModelName, context, tags, ingestionPipeline, languageAutoDetection, language)

Ingest a File into Semantic Search

Uploads and ingests a file document into the semantic search index. Supports optional configuration of index, ingestion pipeline, embedding model, and webhook for processing status.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    String documentId2 = "documentId_example"; // String | Unique identifier for the document to ingest.
    List<File> files = Arrays.asList(); // List<File> | A collection of files to be ingested. Must contain at least one file.
    String documentId = "doc123"; // String | A unique identifier for the document within the index. Documents with the same ID will be overwritten.
    String index = "my_custom_index"; // String | The name of the index where the document will be ingested. Defaults to 'default' if not specified.
    List<String> pipeline = Arrays.asList(); // List<String> | An array of ingestion pipeline step names. If not provided, server default steps will be used.
    URI webHookUrl = new URI(); // URI | A URL to receive a callback via webhook when the ingestion process is completed or fails.
    String embeddingModel = "model_v2"; // String | The embedding model to use during ingestion. If not specified, the server's default model will be applied.
    String index2 = "index_example"; // String | Optional index name where the document will be stored.
    URI webHookUrl2 = new URI(); // URI | Optional webhook URL to notify upon completion.
    String embeddingModelName = "embeddingModelName_example"; // String | Optional name of the embedding model to use during ingestion.
    Map<String, String> context = new HashMap(); // Map<String, String> | Optional key-value pairs for additional context or metadata.
    Map<String, List<String>> tags = new HashMap(); // Map<String, List<String>> | A collection of tags associated with the document. Tags can be language-specific.
    List<String> ingestionPipeline = Arrays.asList(); // List<String> | Optional list of ingestion pipeline steps. Allows custom processing.
    Boolean languageAutoDetection = false; // Boolean | Enable automatic language detection for document content.
    String language = "arabic"; // String | Force a specific language for full-text search. Use 'simple' for no language or leave empty.
    try {
      IngestDocumentResponse result = apiInstance.semanticSearchFileIngestion(documentId2, files, documentId, index, pipeline, webHookUrl, embeddingModel, index2, webHookUrl2, embeddingModelName, context, tags, ingestionPipeline, languageAutoDetection, language);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchFileIngestion");
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
| **documentId2** | **String**| Unique identifier for the document to ingest. | |
| **files** | **List&lt;File&gt;**| A collection of files to be ingested. Must contain at least one file. | |
| **documentId** | **String**| A unique identifier for the document within the index. Documents with the same ID will be overwritten. | [optional] |
| **index** | **String**| The name of the index where the document will be ingested. Defaults to &#39;default&#39; if not specified. | [optional] |
| **pipeline** | [**List&lt;String&gt;**](String.md)| An array of ingestion pipeline step names. If not provided, server default steps will be used. | [optional] |
| **webHookUrl** | **URI**| A URL to receive a callback via webhook when the ingestion process is completed or fails. | [optional] |
| **embeddingModel** | **String**| The embedding model to use during ingestion. If not specified, the server&#39;s default model will be applied. | [optional] |
| **index2** | **String**| Optional index name where the document will be stored. | [optional] |
| **webHookUrl2** | **URI**| Optional webhook URL to notify upon completion. | [optional] |
| **embeddingModelName** | **String**| Optional name of the embedding model to use during ingestion. | [optional] |
| **context** | [**Map&lt;String, String&gt;**](Map.md)| Optional key-value pairs for additional context or metadata. | [optional] |
| **tags** | [**Map&lt;String, List&lt;String&gt;&gt;**](Map.md)| A collection of tags associated with the document. Tags can be language-specific. | [optional] |
| **ingestionPipeline** | [**List&lt;String&gt;**](String.md)| Optional list of ingestion pipeline steps. Allows custom processing. | [optional] |
| **languageAutoDetection** | **Boolean**| Enable automatic language detection for document content. | [optional] [default to false] |
| **language** | **String**| Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] [enum: arabic, armenian, basque, catalan, danish, dutch, english, finnish, french, german, greek, hindi, hungarian, indonesian, irish, italian, lithuanian, nepali, norwegian, portuguese, romanian, russian, serbian, spanish, swedish, tamil, turkish, yiddish, simple] |

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

<a id="semanticSearchIngestionStatus"></a>
# **semanticSearchIngestionStatus**
> DataPipelineStatus semanticSearchIngestionStatus(id)



Get queue status for ingestion job

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    UUID id = UUID.randomUUID(); // UUID | 
    try {
      DataPipelineStatus result = apiInstance.semanticSearchIngestionStatus(id);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchIngestionStatus");
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
| **id** | **UUID**|  | |

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

<a id="semanticSearchList"></a>
# **semanticSearchList**
> ListDocumentResponse semanticSearchList(listDocumentParameters)



List - and filter - for ingested documents

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    ListDocumentParameters listDocumentParameters = new ListDocumentParameters(); // ListDocumentParameters | 
    try {
      ListDocumentResponse result = apiInstance.semanticSearchList(listDocumentParameters);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchList");
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
| **listDocumentParameters** | [**ListDocumentParameters**](ListDocumentParameters.md)|  | |

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

<a id="semanticSearchQuery"></a>
# **semanticSearchQuery**
> QueryDocumentResponse semanticSearchQuery(queryDocumentRequest)



Performs semantic or hybrid search over previously ingested data.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    QueryDocumentRequest queryDocumentRequest = new QueryDocumentRequest(); // QueryDocumentRequest | 
    try {
      QueryDocumentResponse result = apiInstance.semanticSearchQuery(queryDocumentRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchQuery");
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
| **queryDocumentRequest** | [**QueryDocumentRequest**](QueryDocumentRequest.md)|  | |

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

<a id="semanticSearchQueryResultsClustering"></a>
# **semanticSearchQueryResultsClustering**
> KMeansCluster semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest)



Perform k-means clustering over semantic search log entries

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    SemanticSearchQueryResultsClusteringRequest semanticSearchQueryResultsClusteringRequest = new SemanticSearchQueryResultsClusteringRequest(); // SemanticSearchQueryResultsClusteringRequest | 
    try {
      KMeansCluster result = apiInstance.semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchQueryResultsClustering");
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
| **semanticSearchQueryResultsClusteringRequest** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md)|  | |

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

<a id="semanticSearchRerank"></a>
# **semanticSearchRerank**
> ReRankDocumentsResponse semanticSearchRerank(reRankDocumentsRequest)



Rerank documents

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    ReRankDocumentsRequest reRankDocumentsRequest = new ReRankDocumentsRequest(); // ReRankDocumentsRequest | 
    try {
      ReRankDocumentsResponse result = apiInstance.semanticSearchRerank(reRankDocumentsRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchRerank");
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
| **reRankDocumentsRequest** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md)|  | |

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

<a id="semanticSearchTextIngestion"></a>
# **semanticSearchTextIngestion**
> IngestDocumentResponse semanticSearchTextIngestion(ingestTextDocumentRequest)

Ingest Plain Text for Semantic Search

Ingests a plain text document into the semantic search index. This endpoint allows associating tags and specifying the target index for enhanced search capabilities.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    IngestTextDocumentRequest ingestTextDocumentRequest = new IngestTextDocumentRequest(); // IngestTextDocumentRequest | 
    try {
      IngestDocumentResponse result = apiInstance.semanticSearchTextIngestion(ingestTextDocumentRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchTextIngestion");
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
| **ingestTextDocumentRequest** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md)|  | |

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

<a id="semanticSearchWebpageIngestion"></a>
# **semanticSearchWebpageIngestion**
> IngestDocumentResponse semanticSearchWebpageIngestion(ingestWebPageDocumentRequest)



Import web page text into semantic search

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SemanticSearchApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    SemanticSearchApi apiInstance = new SemanticSearchApi(defaultClient);
    IngestWebPageDocumentRequest ingestWebPageDocumentRequest = new IngestWebPageDocumentRequest(); // IngestWebPageDocumentRequest | 
    try {
      IngestDocumentResponse result = apiInstance.semanticSearchWebpageIngestion(ingestWebPageDocumentRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchWebpageIngestion");
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
| **ingestWebPageDocumentRequest** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md)|  | |

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

