# SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
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
> IngestDocumentResponse semanticSearchFileIngestion(documentId2, files, documentId, index, pipeline, webHookUrl, embeddingModel, index2, webHookUrl2, embeddingModelName, context, tags, ingestionPipeline, languageAutoDetection, language)

Ingest a File into Semantic Search

Uploads and ingests a file document into the semantic search index. Supports optional configuration of index, ingestion pipeline, embedding model, and webhook for processing status.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SemanticSearchApi()
val documentId2 : kotlin.String = documentId_example // kotlin.String | Unique identifier for the document to ingest.
val files : kotlin.collections.List<java.io.File> = /path/to/file.txt // kotlin.collections.List<java.io.File> | A collection of files to be ingested. Must contain at least one file.
val documentId : kotlin.String = doc123 // kotlin.String | A unique identifier for the document within the index. Documents with the same ID will be overwritten.
val index : kotlin.String = my_custom_index // kotlin.String | The name of the index where the document will be ingested. Defaults to 'default' if not specified.
val pipeline : kotlin.collections.List<kotlin.String> = ["step1","step2"] // kotlin.collections.List<kotlin.String> | An array of ingestion pipeline step names. If not provided, server default steps will be used.
val webHookUrl : java.net.URI = https://example.com/webhook // java.net.URI | A URL to receive a callback via webhook when the ingestion process is completed or fails.
val embeddingModel : kotlin.String = model_v2 // kotlin.String | The embedding model to use during ingestion. If not specified, the server's default model will be applied.
val index2 : kotlin.String = index_example // kotlin.String | Optional index name where the document will be stored.
val webHookUrl2 : java.net.URI = webHookUrl_example // java.net.URI | Optional webhook URL to notify upon completion.
val embeddingModelName : kotlin.String = embeddingModelName_example // kotlin.String | Optional name of the embedding model to use during ingestion.
val context : kotlin.collections.Map<kotlin.String, kotlin.String> =  // kotlin.collections.Map<kotlin.String, kotlin.String> | Optional key-value pairs for additional context or metadata.
val tags : kotlin.collections.Map<kotlin.String, kotlin.collections.List<kotlin.String>> =  // kotlin.collections.Map<kotlin.String, kotlin.collections.List<kotlin.String>> | A collection of tags associated with the document. Tags can be language-specific.
val ingestionPipeline : kotlin.collections.List<kotlin.String> =  // kotlin.collections.List<kotlin.String> | Optional list of ingestion pipeline steps. Allows custom processing.
val languageAutoDetection : kotlin.Boolean = true // kotlin.Boolean | Enable automatic language detection for document content.
val language : kotlin.String = language_example // kotlin.String | Force a specific language for full-text search. Use 'simple' for no language or leave empty.
try {
    val result : IngestDocumentResponse = apiInstance.semanticSearchFileIngestion(documentId2, files, documentId, index, pipeline, webHookUrl, embeddingModel, index2, webHookUrl2, embeddingModelName, context, tags, ingestionPipeline, languageAutoDetection, language)
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
| **documentId2** | **kotlin.String**| Unique identifier for the document to ingest. | |
| **files** | **kotlin.collections.List&lt;java.io.File&gt;**| A collection of files to be ingested. Must contain at least one file. | |
| **documentId** | **kotlin.String**| A unique identifier for the document within the index. Documents with the same ID will be overwritten. | [optional] |
| **index** | **kotlin.String**| The name of the index where the document will be ingested. Defaults to &#39;default&#39; if not specified. | [optional] |
| **pipeline** | [**kotlin.collections.List&lt;kotlin.String&gt;**](kotlin.String.md)| An array of ingestion pipeline step names. If not provided, server default steps will be used. | [optional] |
| **webHookUrl** | **java.net.URI**| A URL to receive a callback via webhook when the ingestion process is completed or fails. | [optional] |
| **embeddingModel** | **kotlin.String**| The embedding model to use during ingestion. If not specified, the server&#39;s default model will be applied. | [optional] |
| **index2** | **kotlin.String**| Optional index name where the document will be stored. | [optional] |
| **webHookUrl2** | **java.net.URI**| Optional webhook URL to notify upon completion. | [optional] |
| **embeddingModelName** | **kotlin.String**| Optional name of the embedding model to use during ingestion. | [optional] |
| **context** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.String&gt;**](kotlin.collections.Map.md)| Optional key-value pairs for additional context or metadata. | [optional] |
| **tags** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;**](kotlin.collections.Map.md)| A collection of tags associated with the document. Tags can be language-specific. | [optional] |
| **ingestionPipeline** | [**kotlin.collections.List&lt;kotlin.String&gt;**](kotlin.String.md)| Optional list of ingestion pipeline steps. Allows custom processing. | [optional] |
| **languageAutoDetection** | **kotlin.Boolean**| Enable automatic language detection for document content. | [optional] [default to false] |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **language** | **kotlin.String**| Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] [enum: arabic, armenian, basque, catalan, danish, dutch, english, finnish, french, german, greek, hindi, hungarian, indonesian, irish, italian, lithuanian, nepali, norwegian, portuguese, romanian, russian, serbian, spanish, swedish, tamil, turkish, yiddish, simple] |

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



Performs semantic or hybrid search over previously ingested data.

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

Ingest Plain Text for Semantic Search

Ingests a plain text document into the semantic search index. This endpoint allows associating tags and specifying the target index for enhanced search capabilities.

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

