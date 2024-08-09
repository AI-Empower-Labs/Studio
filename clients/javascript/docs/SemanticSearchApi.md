# StudioAiEmpowerLabs.SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**semanticSearchAsk**](SemanticSearchApi.md#semanticSearchAsk) | **POST** /api/semantic/ask | 
[**semanticSearchDeleteDocument**](SemanticSearchApi.md#semanticSearchDeleteDocument) | **DELETE** /api/semantic/{documentId} | 
[**semanticSearchDeleteIndex**](SemanticSearchApi.md#semanticSearchDeleteIndex) | **DELETE** /api/semantic/index | 
[**semanticSearchFileIngestion**](SemanticSearchApi.md#semanticSearchFileIngestion) | **POST** /api/semantic/ingest/file | 
[**semanticSearchIngestionStatus**](SemanticSearchApi.md#semanticSearchIngestionStatus) | **GET** /api/semantic/ingest/status | 
[**semanticSearchList**](SemanticSearchApi.md#semanticSearchList) | **POST** /api/semantic/list | 
[**semanticSearchQuery**](SemanticSearchApi.md#semanticSearchQuery) | **POST** /api/semantic/query | 
[**semanticSearchQueryResultsClustering**](SemanticSearchApi.md#semanticSearchQueryResultsClustering) | **POST** /api/semantic/query-results-clustering | 
[**semanticSearchRerank**](SemanticSearchApi.md#semanticSearchRerank) | **POST** /api/semantic/rerank | 
[**semanticSearchTextIngestion**](SemanticSearchApi.md#semanticSearchTextIngestion) | **POST** /api/semantic/ingest/text | 
[**semanticSearchWebpageIngestion**](SemanticSearchApi.md#semanticSearchWebpageIngestion) | **POST** /api/semantic/ingest/webpage | 



## semanticSearchAsk

> AskDocumentResponse semanticSearchAsk(askDocumentRequest)



Ask questions over ingested documents

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let askDocumentRequest = {"query":"Find invoice totals","index":"Studio","filter":[{"documentId":["SomeUniqueId"],"tags":{"A":[]}}],"minRelevance":0.8}; // AskDocumentRequest | 
apiInstance.semanticSearchAsk(askDocumentRequest, (error, data, response) => {
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
 **askDocumentRequest** | [**AskDocumentRequest**](AskDocumentRequest.md)|  | 

### Return type

[**AskDocumentResponse**](AskDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


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

> IngestDocumentResponse semanticSearchFileIngestion(files, opts)



Import file document into semantic search

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.SemanticSearchApi();
let files = ["null"]; // [File] | The file object to ingest.
let opts = {
  'documentId': "documentId_example", // String | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema.
  'index': "index_example", // String | Optional value to specify with index the document should be ingested. Defaults to 'default'.
  'pipeline': ["null"], // [String] | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults.
  'webHookUrl': "webHookUrl_example", // String | Url to use for webhook callback when operation finishes or fails.
  'embeddingModel': "embeddingModel_example", // String | Embedding model to use in ingestion. Optional. Default to configured default.
  'args': {key: null}, // {String: Object} | 
  'tags': {key: null} // {String: Object} | Tags to associate with ingestion
};
apiInstance.semanticSearchFileIngestion(files, opts, (error, data, response) => {
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
 **files** | **[File]**| The file object to ingest. | 
 **documentId** | **String**| Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. | [optional] 
 **index** | **String**| Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;. | [optional] 
 **pipeline** | [**[String]**](String.md)| Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
 **webHookUrl** | **String**| Url to use for webhook callback when operation finishes or fails. | [optional] 
 **embeddingModel** | **String**| Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 
 **args** | [**{String: Object}**](Object.md)|  | [optional] 
 **tags** | [**{String: Object}**](Object.md)| Tags to associate with ingestion | [optional] 

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



Query ingested documents using semantic search

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



Import plain text into semantic search

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

