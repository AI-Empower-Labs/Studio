# \SemanticSearchAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SemanticSearchAsk**](SemanticSearchAPI.md#SemanticSearchAsk) | **Post** /api/semantic/ask | 
[**SemanticSearchDeleteDocument**](SemanticSearchAPI.md#SemanticSearchDeleteDocument) | **Delete** /api/semantic/{documentId} | 
[**SemanticSearchDeleteIndex**](SemanticSearchAPI.md#SemanticSearchDeleteIndex) | **Delete** /api/semantic/index | 
[**SemanticSearchFileIngestion**](SemanticSearchAPI.md#SemanticSearchFileIngestion) | **Post** /api/semantic/ingest/file | 
[**SemanticSearchIngestionStatus**](SemanticSearchAPI.md#SemanticSearchIngestionStatus) | **Get** /api/semantic/ingest/status | 
[**SemanticSearchList**](SemanticSearchAPI.md#SemanticSearchList) | **Post** /api/semantic/list | 
[**SemanticSearchQuery**](SemanticSearchAPI.md#SemanticSearchQuery) | **Post** /api/semantic/query | 
[**SemanticSearchRerank**](SemanticSearchAPI.md#SemanticSearchRerank) | **Post** /api/semantic/rerank | 
[**SemanticSearchTextIngestion**](SemanticSearchAPI.md#SemanticSearchTextIngestion) | **Post** /api/semantic/ingest/text | 
[**SemanticSearchWebpageIngestion**](SemanticSearchAPI.md#SemanticSearchWebpageIngestion) | **Post** /api/semantic/ingest/webpage | 
[**SemanticSearchWordcloud**](SemanticSearchAPI.md#SemanticSearchWordcloud) | **Post** /api/semantic/wordcloud | 



## SemanticSearchAsk

> AskDocumentResponse SemanticSearchAsk(ctx).AskDocumentRequest(askDocumentRequest).Execute()





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
	askDocumentRequest := *openapiclient.NewAskDocumentRequest() // AskDocumentRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchAsk(context.Background()).AskDocumentRequest(askDocumentRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchAsk``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchAsk`: AskDocumentResponse
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchAsk`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchAskRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **askDocumentRequest** | [**AskDocumentRequest**](AskDocumentRequest.md) |  | 

### Return type

[**AskDocumentResponse**](AskDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


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

> IngestDocumentResponse SemanticSearchFileIngestion(ctx).Files(files).DocumentId(documentId).Index(index).Pipeline(pipeline).WebHookUrl(webHookUrl).EmbeddingModel(embeddingModel).Tags(tags).Execute()





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
	files := []*os.File{"TODO"} // []*os.File | The file object to ingest.
	documentId := "documentId_example" // string | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. (optional)
	index := "index_example" // string | Optional value to specify with index the document should be ingested. Defaults to 'default'. (optional)
	pipeline := []string{"Inner_example"} // []string | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. (optional)
	webHookUrl := "webHookUrl_example" // string | Url to use for webhook callback when operation finishes or fails. (optional)
	embeddingModel := "embeddingModel_example" // string | Embedding model to use in ingestion. Optional. Default to configured default. (optional)
	tags := map[string]interface{}{"key": interface{}(123)} // map[string]interface{} | Tags to associate with ingestion (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchFileIngestion(context.Background()).Files(files).DocumentId(documentId).Index(index).Pipeline(pipeline).WebHookUrl(webHookUrl).EmbeddingModel(embeddingModel).Tags(tags).Execute()
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
 **files** | **[]*os.File** | The file object to ingest. | 
 **documentId** | **string** | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. | 
 **index** | **string** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39;. | 
 **pipeline** | **[]string** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | 
 **webHookUrl** | **string** | Url to use for webhook callback when operation finishes or fails. | 
 **embeddingModel** | **string** | Embedding model to use in ingestion. Optional. Default to configured default. | 
 **tags** | **map[string]interface{}** | Tags to associate with ingestion | 

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
	ingestTextDocumentRequest := *openapiclient.NewIngestTextDocumentRequest("DocumentId_example", "Text_example") // IngestTextDocumentRequest | 

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
	ingestWebPageDocumentRequest := *openapiclient.NewIngestWebPageDocumentRequest("DocumentId_example", "Url_example") // IngestWebPageDocumentRequest | 

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


## SemanticSearchWordcloud

> string SemanticSearchWordcloud(ctx).WordCloudDocumentRequest(wordCloudDocumentRequest).Execute()





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
	wordCloudDocumentRequest := *openapiclient.NewWordCloudDocumentRequest() // WordCloudDocumentRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SemanticSearchAPI.SemanticSearchWordcloud(context.Background()).WordCloudDocumentRequest(wordCloudDocumentRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SemanticSearchAPI.SemanticSearchWordcloud``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSearchWordcloud`: string
	fmt.Fprintf(os.Stdout, "Response from `SemanticSearchAPI.SemanticSearchWordcloud`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSearchWordcloudRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wordCloudDocumentRequest** | [**WordCloudDocumentRequest**](WordCloudDocumentRequest.md) |  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: image/png, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

