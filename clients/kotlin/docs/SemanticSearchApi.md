# SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**semanticSearchAsk**](SemanticSearchApi.md#semanticSearchAsk) | **POST** /api/semantic/ask |  |
| [**semanticSearchDeleteDocument**](SemanticSearchApi.md#semanticSearchDeleteDocument) | **DELETE** /api/semantic/{documentId} |  |
| [**semanticSearchDeleteIndex**](SemanticSearchApi.md#semanticSearchDeleteIndex) | **DELETE** /api/semantic/index |  |
| [**semanticSearchFileIngestion**](SemanticSearchApi.md#semanticSearchFileIngestion) | **POST** /api/ingest/file |  |
| [**semanticSearchIngestionStatus**](SemanticSearchApi.md#semanticSearchIngestionStatus) | **GET** /api/ingest/status |  |
| [**semanticSearchList**](SemanticSearchApi.md#semanticSearchList) | **POST** /api/semantic/list |  |
| [**semanticSearchQuery**](SemanticSearchApi.md#semanticSearchQuery) | **POST** /api/semantic/query |  |
| [**semanticSearchQueryResultsClustering**](SemanticSearchApi.md#semanticSearchQueryResultsClustering) | **POST** /api/semantic/query-results-clustering |  |
| [**semanticSearchRerank**](SemanticSearchApi.md#semanticSearchRerank) | **POST** /api/semantic/rerank |  |
| [**semanticSearchTextIngestion**](SemanticSearchApi.md#semanticSearchTextIngestion) | **POST** /api/ingest/text |  |
| [**semanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticSearchWebpageIngestion) | **POST** /api/ingest/webpage |  |


<a id="semanticSearchAsk"></a>
# **semanticSearchAsk**
> AskDocumentResponse semanticSearchAsk(askDocumentRequest)



Ask questions over ingested documents

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val askDocumentRequest : AskDocumentRequest = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8} // AskDocumentRequest | 
try {
    val result : AskDocumentResponse = apiInstance.semanticSearchAsk(askDocumentRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchAsk")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchAsk")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **askDocumentRequest** | [**AskDocumentRequest**](AskDocumentRequest.md)|  | |

### Return type

[**AskDocumentResponse**](AskDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchDeleteDocument"></a>
# **semanticSearchDeleteDocument**
> semanticSearchDeleteDocument(documentId, index)



Delete specific document by id

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val documentId : kotlin.String = documentId_example // kotlin.String | 
val index : kotlin.String = index_example // kotlin.String | 
try {
    apiInstance.semanticSearchDeleteDocument(documentId, index)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchDeleteDocument")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchDeleteDocument")
    e.printStackTrace()
}
```

### Parameters
| **documentId** | **kotlin.String**|  | |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **index** | **kotlin.String**|  | |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

<a id="semanticSearchDeleteIndex"></a>
# **semanticSearchDeleteIndex**
> semanticSearchDeleteIndex(name)



Delete specific index by name

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val name : kotlin.String = name_example // kotlin.String | 
try {
    apiInstance.semanticSearchDeleteIndex(name)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchDeleteIndex")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchDeleteIndex")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **name** | **kotlin.String**|  | |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

<a id="semanticSearchFileIngestion"></a>
# **semanticSearchFileIngestion**
> IngestDocumentResponse semanticSearchFileIngestion(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags)



Import file document into semantic search

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val files : kotlin.collections.List<java.io.File> = /path/to/file.txt // kotlin.collections.List<java.io.File> | The file object to ingest.
val documentId : kotlin.String = documentId_example // kotlin.String | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema.
val index : kotlin.String = index_example // kotlin.String | Optional value to specify with index the document should be ingested. Defaults to 'default'.
val pipeline : kotlin.collections.List<kotlin.String> =  // kotlin.collections.List<kotlin.String> | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults.
val webHookUrl : kotlin.String = webHookUrl_example // kotlin.String | Url to use for webhook callback when operation finishes or fails.
val embeddingModel : kotlin.String = embeddingModel_example // kotlin.String | Embedding model to use in ingestion. Optional. Default to configured default.
val args : kotlin.collections.Map<kotlin.String, kotlin.Any> = Object // kotlin.collections.Map<kotlin.String, kotlin.Any> | 
val tags : kotlin.collections.Map<kotlin.String, kotlin.Any> = Object // kotlin.collections.Map<kotlin.String, kotlin.Any> | Tags to associate with ingestion
try {
    val result : IngestDocumentResponse = apiInstance.semanticSearchFileIngestion(files, documentId, index, pipeline, webHookUrl, embeddingModel, args, tags)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchFileIngestion")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchFileIngestion")
    e.printStackTrace()
}
```

### Parameters
| **files** | **kotlin.collections.List&lt;java.io.File&gt;**| The file object to ingest. | |
| **documentId** | **kotlin.String**| Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. | [optional] |
| **index** | **kotlin.String**| Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;. | [optional] |
| **pipeline** | [**kotlin.collections.List&lt;kotlin.String&gt;**](kotlin.String.md)| Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] |
| **webHookUrl** | **kotlin.String**| Url to use for webhook callback when operation finishes or fails. | [optional] |
| **embeddingModel** | **kotlin.String**| Embedding model to use in ingestion. Optional. Default to configured default. | [optional] |
| **args** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.Any&gt;**](kotlin.collections.Map.md)|  | [optional] |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **tags** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.Any&gt;**](kotlin.collections.Map.md)| Tags to associate with ingestion | [optional] |

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchIngestionStatus"></a>
# **semanticSearchIngestionStatus**
> DataPipelineStatus semanticSearchIngestionStatus(id)



Get queue status for ingestion job

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | 
try {
    val result : DataPipelineStatus = apiInstance.semanticSearchIngestionStatus(id)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchIngestionStatus")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchIngestionStatus")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **java.util.UUID**|  | |

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchList"></a>
# **semanticSearchList**
> ListDocumentResponse semanticSearchList(listDocumentParameters)



List - and filter - for ingested documents

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val listDocumentParameters : ListDocumentParameters = {"index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"withEmbeddings":false,"limit":10} // ListDocumentParameters | 
try {
    val result : ListDocumentResponse = apiInstance.semanticSearchList(listDocumentParameters)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchList")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **listDocumentParameters** | [**ListDocumentParameters**](ListDocumentParameters.md)|  | |

### Return type

[**ListDocumentResponse**](ListDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchQuery"></a>
# **semanticSearchQuery**
> QueryDocumentResponse semanticSearchQuery(queryDocumentRequest)



Query ingested documents using semantic search

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val queryDocumentRequest : QueryDocumentRequest = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8,"limit":10} // QueryDocumentRequest | 
try {
    val result : QueryDocumentResponse = apiInstance.semanticSearchQuery(queryDocumentRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchQuery")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchQuery")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **queryDocumentRequest** | [**QueryDocumentRequest**](QueryDocumentRequest.md)|  | |

### Return type

[**QueryDocumentResponse**](QueryDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchQueryResultsClustering"></a>
# **semanticSearchQueryResultsClustering**
> KMeansCluster semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest)



Perform k-means clustering over semantic search log entries

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val semanticSearchQueryResultsClusteringRequest : SemanticSearchQueryResultsClusteringRequest =  // SemanticSearchQueryResultsClusteringRequest | 
try {
    val result : KMeansCluster = apiInstance.semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchQueryResultsClustering")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchQueryResultsClustering")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **semanticSearchQueryResultsClusteringRequest** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md)|  | |

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchRerank"></a>
# **semanticSearchRerank**
> ReRankDocumentsResponse semanticSearchRerank(reRankDocumentsRequest)



Rerank documents

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val reRankDocumentsRequest : ReRankDocumentsRequest = {"query":"What is the capital of the United States?","documents":["Carson City is the capital city of the American state of Nevada. At the  2010 United States Census, Carson City had a population of 55,274.","The Commonwealth of the Northern Mariana Islands is a group of islands in the Pacific Ocean that are a political division controlled by the United States. Its capital is Saipan.","Charlotte Amalie is the capital and largest city of the United States Virgin Islands. It has about 20,000 people. The city is on the island of Saint Thomas.","Washington, D.C. (also known as simply Washington or D.C., and officially as the District of Columbia) is the capital of the United States. It is a federal district. ","Capital punishment (the death penalty) has existed in the United States since before the United States was a country. As of 2017, capital punishment is legal in 30 of the 50 states.","North Dakota is a state in the United States. 672,591 people lived in North Dakota in the year 2010. The capital and seat of government is Bismarck."],"limit":10} // ReRankDocumentsRequest | 
try {
    val result : ReRankDocumentsResponse = apiInstance.semanticSearchRerank(reRankDocumentsRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchRerank")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchRerank")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **reRankDocumentsRequest** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md)|  | |

### Return type

[**ReRankDocumentsResponse**](ReRankDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchTextIngestion"></a>
# **semanticSearchTextIngestion**
> IngestDocumentResponse semanticSearchTextIngestion(ingestTextDocumentRequest)



Import plain text into semantic search

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val ingestTextDocumentRequest : IngestTextDocumentRequest = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Great":[],"AI":[],"Software":["true"]},"text":"Hello world"} // IngestTextDocumentRequest | 
try {
    val result : IngestDocumentResponse = apiInstance.semanticSearchTextIngestion(ingestTextDocumentRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchTextIngestion")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchTextIngestion")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ingestTextDocumentRequest** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md)|  | |

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSearchWebpageIngestion"></a>
# **semanticSearchWebpageIngestion**
> IngestDocumentResponse semanticSearchWebpageIngestion(ingestWebPageDocumentRequest)



Import web page text into semantic search

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val ingestWebPageDocumentRequest : IngestWebPageDocumentRequest = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Software":["true"]},"url":"https://www.aiempowerlabs.com"} // IngestWebPageDocumentRequest | 
try {
    val result : IngestDocumentResponse = apiInstance.semanticSearchWebpageIngestion(ingestWebPageDocumentRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling SemanticSearchApi#semanticSearchWebpageIngestion")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SemanticSearchApi#semanticSearchWebpageIngestion")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **ingestWebPageDocumentRequest** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md)|  | |

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

