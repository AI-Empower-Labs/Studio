# SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**semanticSearchAsk**](SemanticSearchApi.md#semanticSearchAsk) | **POST** /api/semantic/ask |  |
| [**semanticSearchDeleteDocument**](SemanticSearchApi.md#semanticSearchDeleteDocument) | **DELETE** /api/semantic/{documentId} |  |
| [**semanticSearchDeleteIndex**](SemanticSearchApi.md#semanticSearchDeleteIndex) | **DELETE** /api/semantic/index |  |
| [**semanticSearchFileIngestion**](SemanticSearchApi.md#semanticSearchFileIngestion) | **POST** /api/semantic/ingest/file |  |
| [**semanticSearchIngestionStatus**](SemanticSearchApi.md#semanticSearchIngestionStatus) | **GET** /api/semantic/ingest/status |  |
| [**semanticSearchList**](SemanticSearchApi.md#semanticSearchList) | **POST** /api/semantic/list |  |
| [**semanticSearchQuery**](SemanticSearchApi.md#semanticSearchQuery) | **POST** /api/semantic/query |  |
| [**semanticSearchRerank**](SemanticSearchApi.md#semanticSearchRerank) | **POST** /api/semantic/rerank |  |
| [**semanticSearchTextIngestion**](SemanticSearchApi.md#semanticSearchTextIngestion) | **POST** /api/semantic/ingest/text |  |
| [**semanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticSearchWebpageIngestion) | **POST** /api/semantic/ingest/webpage |  |


<a id="semanticSearchAsk"></a>
# **semanticSearchAsk**
> AskDocumentResponse semanticSearchAsk(askDocumentRequest)



Ask questions over ingested documents

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
    AskDocumentRequest askDocumentRequest = new AskDocumentRequest(); // AskDocumentRequest | 
    try {
      AskDocumentResponse result = apiInstance.semanticSearchAsk(askDocumentRequest);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling SemanticSearchApi#semanticSearchAsk");
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
| **askDocumentRequest** | [**AskDocumentRequest**](AskDocumentRequest.md)|  | |

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

<a id="semanticSearchFileIngestion"></a>
# **semanticSearchFileIngestion**
> IngestDocumentResponse semanticSearchFileIngestion(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags)



Import file document into semantic search

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
    List<File> files = Arrays.asList(); // List<File> | The file object to ingest.
    String documentId = "documentId_example"; // String | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema.
    String index = "index_example"; // String | Optional value to specify with index the document should be ingested. Defaults to 'default'.
    List<String> pipeline = Arrays.asList(); // List<String> | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults.
    String webHookUrl = "webHookUrl_example"; // String | Url to use for webhook callback when operation finishes or fails.
    String embeddingModel = "embeddingModel_example"; // String | Embedding model to use in ingestion. Optional. Default to configured default.
    Map<String, Object> args = new HashMap(); // Map<String, Object> | 
    Map<String, Object> tags = new HashMap(); // Map<String, Object> | Tags to associate with ingestion
    try {
      IngestDocumentResponse result = apiInstance.semanticSearchFileIngestion(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags);
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
| **files** | **List&lt;File&gt;**| The file object to ingest. | |
| **documentId** | **String**| Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. | [optional] |
| **index** | **String**| Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;. | [optional] |
| **pipeline** | [**List&lt;String&gt;**](String.md)| Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] |
| **webHookUrl** | **String**| Url to use for webhook callback when operation finishes or fails. | [optional] |
| **embeddingModel** | **String**| Embedding model to use in ingestion. Optional. Default to configured default. | [optional] |
| **args** | [**Map&lt;String, Object&gt;**](Map.md)|  | [optional] |
| **tags** | [**Map&lt;String, Object&gt;**](Map.md)| Tags to associate with ingestion | [optional] |

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
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

<a id="semanticSearchQuery"></a>
# **semanticSearchQuery**
> QueryDocumentResponse semanticSearchQuery(queryDocumentRequest)



Query ingested documents using semantic search

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

<a id="semanticSearchTextIngestion"></a>
# **semanticSearchTextIngestion**
> IngestDocumentResponse semanticSearchTextIngestion(ingestTextDocumentRequest)



Import plain text into semantic search

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

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
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

