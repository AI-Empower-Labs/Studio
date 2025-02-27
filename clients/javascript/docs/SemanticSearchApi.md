# StudioAiEmpowerLabs.SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**semanticSearchDeleteDocument**](SemanticSearchApi.md#semanticSearchDeleteDocument) | **DELETE** /api/semantic/{documentId} | 
[**semanticSearchDeleteIndex**](SemanticSearchApi.md#semanticSearchDeleteIndex) | **DELETE** /api/semantic/index/{name} | 
[**semanticSearchFileIngestion**](SemanticSearchApi.md#semanticSearchFileIngestion) | **POST** /api/ingest/file | Ingest a File into Semantic Search
[**semanticSearchIngestionStatus**](SemanticSearchApi.md#semanticSearchIngestionStatus) | **GET** /api/ingest/status | 
[**semanticSearchList**](SemanticSearchApi.md#semanticSearchList) | **POST** /api/semantic/list | 
[**semanticSearchQuery**](SemanticSearchApi.md#semanticSearchQuery) | **POST** /api/semantic/query | 
[**semanticSearchQueryResultsClustering**](SemanticSearchApi.md#semanticSearchQueryResultsClustering) | **POST** /api/semantic/query-results-clustering | 
[**semanticSearchRerank**](SemanticSearchApi.md#semanticSearchRerank) | **POST** /api/semantic/rerank | 
[**semanticSearchTextIngestion**](SemanticSearchApi.md#semanticSearchTextIngestion) | **POST** /api/ingest/text | Ingest Plain Text for Semantic Search
[**semanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticSearchWebpageIngestion) | **POST** /api/ingest/webpage | 



## semanticSearchDeleteDocument

> semanticSearchDeleteDocument(documentId, index)



Delete specific document by id

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let documentId = "documentId_example"; // String | 
let index = "index_example"; // String | 
apiInstance.semanticSearchDeleteDocument(documentId, index, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **String**|  | 
 **index** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json


## semanticSearchDeleteIndex

> semanticSearchDeleteIndex(name)



Delete specific index by name

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let name = "name_example"; // String | 
apiInstance.semanticSearchDeleteIndex(name, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json


## semanticSearchFileIngestion

> IngestDocumentResponse semanticSearchFileIngestion(documentId2, files, opts)

Ingest a File into Semantic Search

Uploads and ingests a file document into the semantic search index. Supports optional configuration of index, ingestion pipeline, embedding model, and webhook for processing status.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let documentId2 = "documentId_example"; // String | Unique identifier for the document to ingest.
let files = ["null"]; // [File] | A collection of files to be ingested. Must contain at least one file.
let opts = {
  'documentId': "doc123", // String | A unique identifier for the document within the index. Documents with the same ID will be overwritten.
  'index': "my_custom_index", // String | The name of the index where the document will be ingested. Defaults to 'default' if not specified.
  'pipeline': ["null"], // [String] | An array of ingestion pipeline step names. If not provided, server default steps will be used.
  'webHookUrl': "https://example.com/webhook", // String | A URL to receive a callback via webhook when the ingestion process is completed or fails.
  'embeddingModel': "model_v2", // String | The embedding model to use during ingestion. If not specified, the server's default model will be applied.
  'index2': "index_example", // String | Optional index name where the document will be stored.
  'webHookUrl2': "webHookUrl_example", // String | Optional webhook URL to notify upon completion.
  'embeddingModelName': "embeddingModelName_example", // String | Optional name of the embedding model to use during ingestion.
  'context': {key: "null"}, // {String: String} | Optional key-value pairs for additional context or metadata.
  'tags': {key: null}, // {String: [String]} | A collection of tags associated with the document. Tags can be language-specific.
  'ingestionPipeline': ["null"], // [String] | Optional list of ingestion pipeline steps. Allows custom processing.
  'languageAutoDetection': false, // Boolean | Enable automatic language detection for document content.
  'language': "language_example" // String | Force a specific language for full-text search. Use 'simple' for no language or leave empty.
};
apiInstance.semanticSearchFileIngestion(documentId2, files, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId2** | **String**| Unique identifier for the document to ingest. | 
 **files** | **[File]**| A collection of files to be ingested. Must contain at least one file. | 
 **documentId** | **String**| A unique identifier for the document within the index. Documents with the same ID will be overwritten. | [optional] 
 **index** | **String**| The name of the index where the document will be ingested. Defaults to &#39;default&#39; if not specified. | [optional] 
 **pipeline** | [**[String]**](String.md)| An array of ingestion pipeline step names. If not provided, server default steps will be used. | [optional] 
 **webHookUrl** | **String**| A URL to receive a callback via webhook when the ingestion process is completed or fails. | [optional] 
 **embeddingModel** | **String**| The embedding model to use during ingestion. If not specified, the server&#39;s default model will be applied. | [optional] 
 **index2** | **String**| Optional index name where the document will be stored. | [optional] 
 **webHookUrl2** | **String**| Optional webhook URL to notify upon completion. | [optional] 
 **embeddingModelName** | **String**| Optional name of the embedding model to use during ingestion. | [optional] 
 **context** | [**{String: String}**](Object.md)| Optional key-value pairs for additional context or metadata. | [optional] 
 **tags** | [**{String: [String]}**](Object.md)| A collection of tags associated with the document. Tags can be language-specific. | [optional] 
 **ingestionPipeline** | [**[String]**](String.md)| Optional list of ingestion pipeline steps. Allows custom processing. | [optional] 
 **languageAutoDetection** | **Boolean**| Enable automatic language detection for document content. | [optional] [default to false]
 **language** | **String**| Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json


## semanticSearchIngestionStatus

> DataPipelineStatus semanticSearchIngestionStatus(id)



Get queue status for ingestion job

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let id = "id_example"; // String | 
apiInstance.semanticSearchIngestionStatus(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**|  | 

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json


## semanticSearchList

> ListDocumentResponse semanticSearchList(listDocumentParameters)



List - and filter - for ingested documents

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let listDocumentParameters = {"index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"withEmbeddings":false,"limit":10}; // ListDocumentParameters | 
apiInstance.semanticSearchList(listDocumentParameters, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listDocumentParameters** | [**ListDocumentParameters**](ListDocumentParameters.md)|  | 

### Return type

[**ListDocumentResponse**](ListDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## semanticSearchQuery

> QueryDocumentResponse semanticSearchQuery(queryDocumentRequest)



Performs semantic or hybrid search over previously ingested data.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let queryDocumentRequest = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8,"limit":10}; // QueryDocumentRequest | 
apiInstance.semanticSearchQuery(queryDocumentRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryDocumentRequest** | [**QueryDocumentRequest**](QueryDocumentRequest.md)|  | 

### Return type

[**QueryDocumentResponse**](QueryDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## semanticSearchQueryResultsClustering

> KMeansCluster semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest)



Perform k-means clustering over semantic search log entries

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let semanticSearchQueryResultsClusteringRequest = new StudioAiEmpowerLabs.SemanticSearchQueryResultsClusteringRequest(); // SemanticSearchQueryResultsClusteringRequest | 
apiInstance.semanticSearchQueryResultsClustering(semanticSearchQueryResultsClusteringRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semanticSearchQueryResultsClusteringRequest** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md)|  | 

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/csv, application/problem+json


## semanticSearchRerank

> ReRankDocumentsResponse semanticSearchRerank(reRankDocumentsRequest)



Rerank documents

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let reRankDocumentsRequest = {"query":"What is the capital of the United States?","documents":["Carson City is the capital city of the American state of Nevada. At the  2010 United States Census, Carson City had a population of 55,274.","The Commonwealth of the Northern Mariana Islands is a group of islands in the Pacific Ocean that are a political division controlled by the United States. Its capital is Saipan.","Charlotte Amalie is the capital and largest city of the United States Virgin Islands. It has about 20,000 people. The city is on the island of Saint Thomas.","Washington, D.C. (also known as simply Washington or D.C., and officially as the District of Columbia) is the capital of the United States. It is a federal district. ","Capital punishment (the death penalty) has existed in the United States since before the United States was a country. As of 2017, capital punishment is legal in 30 of the 50 states.","North Dakota is a state in the United States. 672,591 people lived in North Dakota in the year 2010. The capital and seat of government is Bismarck."],"limit":10}; // ReRankDocumentsRequest | 
apiInstance.semanticSearchRerank(reRankDocumentsRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reRankDocumentsRequest** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md)|  | 

### Return type

[**ReRankDocumentsResponse**](ReRankDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## semanticSearchTextIngestion

> IngestDocumentResponse semanticSearchTextIngestion(ingestTextDocumentRequest)

Ingest Plain Text for Semantic Search

Ingests a plain text document into the semantic search index. This endpoint allows associating tags and specifying the target index for enhanced search capabilities.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let ingestTextDocumentRequest = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Great":[],"AI":[],"Software":["true"]},"text":"Hello world"}; // IngestTextDocumentRequest | 
apiInstance.semanticSearchTextIngestion(ingestTextDocumentRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingestTextDocumentRequest** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md)|  | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## semanticSearchWebpageIngestion

> IngestDocumentResponse semanticSearchWebpageIngestion(ingestWebPageDocumentRequest)



Import web page text into semantic search

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let ingestWebPageDocumentRequest = {"documentId":"7e6ea7b1-ad67-4058-b043-dae5160ed245","index":"Studio","tags":{"Software":["true"]},"url":"https://www.aiempowerlabs.com"}; // IngestWebPageDocumentRequest | 
apiInstance.semanticSearchWebpageIngestion(ingestWebPageDocumentRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingestWebPageDocumentRequest** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md)|  | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

