# \MiscellaneousAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLlmCacheEntry**](MiscellaneousAPI.md#DeleteLlmCacheEntry) | **Delete** /api/cache | 
[**GetConfiguration**](MiscellaneousAPI.md#GetConfiguration) | **Get** /info | 



## DeleteLlmCacheEntry

> DeleteLlmCacheEntry(ctx).CacheKey(cacheKey).Execute()





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
	cacheKey := "cacheKey_example" // string | The LLM cache key to remove (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	r, err := apiClient.MiscellaneousAPI.DeleteLlmCacheEntry(context.Background()).CacheKey(cacheKey).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `MiscellaneousAPI.DeleteLlmCacheEntry``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiDeleteLlmCacheEntryRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cacheKey** | **string** | The LLM cache key to remove | 

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


## GetConfiguration

> []map[string][]string GetConfiguration(ctx).Execute()





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
	resp, r, err := apiClient.MiscellaneousAPI.GetConfiguration(context.Background()).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `MiscellaneousAPI.GetConfiguration``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetConfiguration`: []map[string][]string
	fmt.Fprintf(os.Stdout, "Response from `MiscellaneousAPI.GetConfiguration`: %v\n", resp)
}
```

### Path Parameters

This endpoint does not need any parameter.

### Other Parameters

Other parameters are passed through a pointer to a apiGetConfigurationRequest struct via the builder pattern


### Return type

[**[]map[string][]string**](map.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

