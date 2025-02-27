# \SemanticSearchAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SemanticSearchDeleteDocument**](SemanticSearchAPI.md#SemanticSearchDeleteDocument) | **Delete** /api/semantic/{documentId} | 
[**SemanticSearchDeleteIndex**](SemanticSearchAPI.md#SemanticSearchDeleteIndex) | **Delete** /api/semantic/index/{name} | 
[**SemanticSearchFileIngestion**](SemanticSearchAPI.md#SemanticSearchFileIngestion) | **Post** /api/ingest/file | Ingest a File into Semantic Search
[**SemanticSearchIngestionStatus**](SemanticSearchAPI.md#SemanticSearchIngestionStatus) | **Get** /api/ingest/status | 
[**SemanticSearchList**](SemanticSearchAPI.md#SemanticSearchList) | **Post** /api/semantic/list | 
[**SemanticSearchQuery**](SemanticSearchAPI.md#SemanticSearchQuery) | **Post** /api/semantic/query | 
[**SemanticSearchQueryResultsClustering**](SemanticSearchAPI.md#SemanticSearchQueryResultsClustering) | **Post** /api/semantic/query-results-clustering | 
[**SemanticSearchRerank**](SemanticSearchAPI.md#SemanticSearchRerank) | **Post** /api/semantic/rerank | 
[**SemanticSearchTextIngestion**](SemanticSearchAPI.md#SemanticSearchTextIngestion) | **Post** /api/ingest/text | Ingest Plain Text for Semantic Search
[**SemanticSearchWebpageIngestion**](SemanticSearchAPI.md#SemanticSearchWebpageIngestion) | **Post** /api/ingest/webpage | 



## SemanticSearchDeleteDocument

> SemanticSearchDeleteDocument(ctx, documentId).Index(index).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	documentId := "documentId_example" // string | 
	index := "index_example" // string | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	r, err := apiClient.SemanticSearchAPI.SemanticSearchDeleteDocument(context.Background(), documentId).Index(index).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchDeleteDocument``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
}
```

### Path Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**documentId** | **string** |  | 

### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchDeleteDocumentRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **index** | **string** |  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchDeleteIndex

> SemanticSearchDeleteIndex(ctx, name).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	name := "name_example" // string | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	r, err := apiClient.SemanticSearchAPI.SemanticSearchDeleteIndex(context.Background(), name).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchDeleteIndex``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
}
```

### Path Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**name** | **string** |  | 

### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchDeleteIndexRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchFileIngestion

> IngestDocumentResponse SemanticSearchFileIngestion(ctx).DocumentId2(documentId2).Files(files).DocumentId(documentId).Index(index).Pipeline(pipeline).WebHookUrl(webHookUrl).EmbeddingModel(embeddingModel).Index2(index2).WebHookUrl2(webHookUrl2).EmbeddingModelName(embeddingModelName).Context(context).Tags(tags).IngestionPipeline(ingestionPipeline).LanguageAutoDetection(languageAutoDetection).Language(language).Execute()

Ingest a File into Semantic Search



### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	documentId2 := "documentId_example" // string | Unique identifier for the document to ingest.
	files := []*os.File{"TODO"} // []*os.File | A collection of files to be ingested. Must contain at least one file.
	documentId := "doc123" // string | A unique identifier for the document within the index. Documents with the same ID will be overwritten. (optional)
	index := "my_custom_index" // string | The name of the index where the document will be ingested. Defaults to 'default' if not specified. (optional)
	pipeline := []string{"Inner_example"} // []string | An array of ingestion pipeline step names. If not provided, server default steps will be used. (optional)
	webHookUrl := "https://example.com/webhook" // string | A URL to receive a callback via webhook when the ingestion process is completed or fails. (optional)
	embeddingModel := "model_v2" // string | The embedding model to use during ingestion. If not specified, the server's default model will be applied. (optional)
	index2 := "index_example" // string | Optional index name where the document will be stored. (optional)
	webHookUrl2 := "webHookUrl_example" // string | Optional webhook URL to notify upon completion. (optional)
	embeddingModelName := "embeddingModelName_example" // string | Optional name of the embedding model to use during ingestion. (optional)
	context := map[string]string{"key": "Inner_example"} // map[string]string | Optional key-value pairs for additional context or metadata. (optional)
	tags := map[string][]string{"key": []string{"Inner_example"}} // map[string][]string | A collection of tags associated with the document. Tags can be language-specific. (optional)
	ingestionPipeline := []string{"Inner_example"} // []string | Optional list of ingestion pipeline steps. Allows custom processing. (optional)
	languageAutoDetection := true // bool | Enable automatic language detection for document content. (optional) (default to false)
	language := "language_example" // string | Force a specific language for full-text search. Use 'simple' for no language or leave empty. (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchFileIngestion(context.Background()).DocumentId2(documentId2).Files(files).DocumentId(documentId).Index(index).Pipeline(pipeline).WebHookUrl(webHookUrl).EmbeddingModel(embeddingModel).Index2(index2).WebHookUrl2(webHookUrl2).EmbeddingModelName(embeddingModelName).Context(context).Tags(tags).IngestionPipeline(ingestionPipeline).LanguageAutoDetection(languageAutoDetection).Language(language).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchFileIngestion``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchFileIngestion`: IngestDocumentResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchFileIngestion`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchFileIngestionRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId2** | **string** | Unique identifier for the document to ingest. | 
 **files** | **[]*os.File** | A collection of files to be ingested. Must contain at least one file. | 
 **documentId** | **string** | A unique identifier for the document within the index. Documents with the same ID will be overwritten. | 
 **index** | **string** | The name of the index where the document will be ingested. Defaults to &#39;default&#39; if not specified. | 
 **pipeline** | **[]string** | An array of ingestion pipeline step names. If not provided, server default steps will be used. | 
 **webHookUrl** | **string** | A URL to receive a callback via webhook when the ingestion process is completed or fails. | 
 **embeddingModel** | **string** | The embedding model to use during ingestion. If not specified, the server&#39;s default model will be applied. | 
 **index2** | **string** | Optional index name where the document will be stored. | 
 **webHookUrl2** | **string** | Optional webhook URL to notify upon completion. | 
 **embeddingModelName** | **string** | Optional name of the embedding model to use during ingestion. | 
 **context** | **map[string]string** | Optional key-value pairs for additional context or metadata. | 
 **tags** | **map[string][]string** | A collection of tags associated with the document. Tags can be language-specific. | 
 **ingestionPipeline** | **[]string** | Optional list of ingestion pipeline steps. Allows custom processing. | 
 **languageAutoDetection** | **bool** | Enable automatic language detection for document content. | [default to false]
 **language** | **string** | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchIngestionStatus

> DataPipelineStatus SemanticSearchIngestionStatus(ctx).Id(id).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	id := "38400000-8cf0-11bd-b23e-10b96e4ef00d" // string | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchIngestionStatus(context.Background()).Id(id).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchIngestionStatus``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchIngestionStatus`: DataPipelineStatus
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchIngestionStatus`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchIngestionStatusRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string** |  | 

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchList

> ListDocumentResponse SemanticSearchList(ctx).ListDocumentParameters(listDocumentParameters).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	listDocumentParameters := *openapiclient.NewListDocumentParameters() // ListDocumentParameters | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchList(context.Background()).ListDocumentParameters(listDocumentParameters).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchList``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchList`: ListDocumentResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchList`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchListRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listDocumentParameters** | [**ListDocumentParameters**](ListDocumentParameters.md) |  | 

### Return type

[**ListDocumentResponse**](ListDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchQuery

> QueryDocumentResponse SemanticSearchQuery(ctx).QueryDocumentRequest(queryDocumentRequest).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	queryDocumentRequest := *openapiclient.NewQueryDocumentRequest() // QueryDocumentRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchQuery(context.Background()).QueryDocumentRequest(queryDocumentRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchQuery``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchQuery`: QueryDocumentResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchQuery`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchQueryRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryDocumentRequest** | [**QueryDocumentRequest**](QueryDocumentRequest.md) |  | 

### Return type

[**QueryDocumentResponse**](QueryDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchQueryResultsClustering

> KMeansCluster SemanticSearchQueryResultsClustering(ctx).SemanticSearchQueryResultsClusteringRequest(semanticSearchQueryResultsClusteringRequest).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	semanticSearchQueryResultsClusteringRequest := *openapiclient.NewSemanticSearchQueryResultsClusteringRequest() // SemanticSearchQueryResultsClusteringRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchQueryResultsClustering(context.Background()).SemanticSearchQueryResultsClusteringRequest(semanticSearchQueryResultsClusteringRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchQueryResultsClustering``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchQueryResultsClustering`: KMeansCluster
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchQueryResultsClustering`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchQueryResultsClusteringRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semanticSearchQueryResultsClusteringRequest** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md) |  | 

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/csv, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchRerank

> ReRankDocumentsResponse SemanticSearchRerank(ctx).ReRankDocumentsRequest(reRankDocumentsRequest).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	reRankDocumentsRequest := *openapiclient.NewReRankDocumentsRequest() // ReRankDocumentsRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchRerank(context.Background()).ReRankDocumentsRequest(reRankDocumentsRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchRerank``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchRerank`: ReRankDocumentsResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchRerank`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchRerankRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reRankDocumentsRequest** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md) |  | 

### Return type

[**ReRankDocumentsResponse**](ReRankDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchTextIngestion

> IngestDocumentResponse SemanticSearchTextIngestion(ctx).IngestTextDocumentRequest(ingestTextDocumentRequest).Execute()

Ingest Plain Text for Semantic Search



### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	ingestTextDocumentRequest := *openapiclient.NewIngestTextDocumentRequest("Text_example", "20250225.103045.abcd1234efgh5678") // IngestTextDocumentRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchTextIngestion(context.Background()).IngestTextDocumentRequest(ingestTextDocumentRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchTextIngestion``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchTextIngestion`: IngestDocumentResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchTextIngestion`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchTextIngestionRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingestTextDocumentRequest** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md) |  | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSearchWebpageIngestion

> IngestDocumentResponse SemanticSearchWebpageIngestion(ctx).IngestWebPageDocumentRequest(ingestWebPageDocumentRequest).Execute()





### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/GIT_USER_ID/GIT_REPO_ID"
)

func main() {
	ingestWebPageDocumentRequest := *openapiclient.NewIngestWebPageDocumentRequest("Url_example", "20250225.103045.abcd1234efgh5678") // IngestWebPageDocumentRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchWebpageIngestion(context.Background()).IngestWebPageDocumentRequest(ingestWebPageDocumentRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchWebpageIngestion``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchWebpageIngestion`: IngestDocumentResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchWebpageIngestion`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchWebpageIngestionRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ingestWebPageDocumentRequest** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md) |  | 

### Return type

[**IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

