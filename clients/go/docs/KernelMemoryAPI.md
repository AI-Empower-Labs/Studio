# \KernelMemoryAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KernelMemoryAsk**](KernelMemoryAPI.md#KernelMemoryAsk) | **Post** /api/kernelmemory/ask | Query documents and forward result to LLM
[**KernelMemoryDelete**](KernelMemoryAPI.md#KernelMemoryDelete) | **Delete** /api/kernelmemory/documents | Delete document from specific index
[**KernelMemoryDeleteIndex**](KernelMemoryAPI.md#KernelMemoryDeleteIndex) | **Delete** /api/kernelmemory/indexes | Delete index
[**KernelMemoryGetIndex**](KernelMemoryAPI.md#KernelMemoryGetIndex) | **Get** /api/kernelmemory/indexes | List indexes
[**KernelMemorySearch**](KernelMemoryAPI.md#KernelMemorySearch) | **Post** /api/kernelmemory/search | Search for documents in specific index
[**KernelMemoryUpload**](KernelMemoryAPI.md#KernelMemoryUpload) | **Post** /api/kernelmemory/upload | Upload file for ingestion
[**KernelMemoryUploadStatus**](KernelMemoryAPI.md#KernelMemoryUploadStatus) | **Get** /api/kernelmemory/upload-status | Get ingestion status for specific document



## KernelMemoryAsk

> MemoryAnswer KernelMemoryAsk(ctx).MemoryQuery(memoryQuery).Execute()

Query documents and forward result to LLM

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
	memoryQuery := *openapiclient.NewMemoryQuery() // MemoryQuery | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemoryAsk(context.Background()).MemoryQuery(memoryQuery).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemoryAsk``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemoryAsk`: MemoryAnswer
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemoryAsk`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemoryAskRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memoryQuery** | [**MemoryQuery**](MemoryQuery.md) |  | 

### Return type

[**MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KernelMemoryDelete

> DeleteAccepted KernelMemoryDelete(ctx).DocumentId(documentId).Index(index).Execute()

Delete document from specific index

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
	index := "index_example" // string |  (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemoryDelete(context.Background()).DocumentId(documentId).Index(index).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemoryDelete``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemoryDelete`: DeleteAccepted
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemoryDelete`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemoryDeleteRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string** |  | 
 **index** | **string** |  | 

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KernelMemoryDeleteIndex

> DeleteAccepted KernelMemoryDeleteIndex(ctx).Index(index).Execute()

Delete index

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
	index := "index_example" // string |  (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemoryDeleteIndex(context.Background()).Index(index).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemoryDeleteIndex``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemoryDeleteIndex`: DeleteAccepted
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemoryDeleteIndex`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemoryDeleteIndexRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **index** | **string** |  | 

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KernelMemoryGetIndex

> IndexCollection KernelMemoryGetIndex(ctx).Execute()

List indexes

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

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemoryGetIndex(context.Background()).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemoryGetIndex``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemoryGetIndex`: IndexCollection
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemoryGetIndex`: %v\n", resp)
}
```

### Path Parameters

This endpoint does not need any parameter.

### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemoryGetIndexRequest struct via the builder pattern


### Return type

[**IndexCollection**](IndexCollection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KernelMemorySearch

> SearchResult KernelMemorySearch(ctx).SearchQuery(searchQuery).Execute()

Search for documents in specific index

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
	searchQuery := *openapiclient.NewSearchQuery() // SearchQuery | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemorySearch(context.Background()).SearchQuery(searchQuery).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemorySearch``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemorySearch`: SearchResult
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemorySearch`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemorySearchRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchQuery** | [**SearchQuery**](SearchQuery.md) |  | 

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KernelMemoryUpload

> UploadAccepted KernelMemoryUpload(ctx).Execute()

Upload file for ingestion

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

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemoryUpload(context.Background()).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemoryUpload``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemoryUpload`: UploadAccepted
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemoryUpload`: %v\n", resp)
}
```

### Path Parameters

This endpoint does not need any parameter.

### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemoryUploadRequest struct via the builder pattern


### Return type

[**UploadAccepted**](UploadAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KernelMemoryUploadStatus

> DataPipelineStatus KernelMemoryUploadStatus(ctx).DocumentId(documentId).Index(index).Execute()

Get ingestion status for specific document

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
	index := "index_example" // string |  (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.KernelMemoryAPI.KernelMemoryUploadStatus(context.Background()).DocumentId(documentId).Index(index).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `KernelMemoryAPI.KernelMemoryUploadStatus``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KernelMemoryUploadStatus`: DataPipelineStatus
	fmt.Fprintf(os.Stdout, "Response from `KernelMemoryAPI.KernelMemoryUploadStatus`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiKernelMemoryUploadStatusRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string** |  | 
 **index** | **string** |  | 

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

