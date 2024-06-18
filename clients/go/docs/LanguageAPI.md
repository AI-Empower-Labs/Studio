# \LanguageAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LanguageDetection**](LanguageAPI.md#LanguageDetection) | **Get** /api/language/detect | Detects language of a text
[**LanguageGetLanguageList**](LanguageAPI.md#LanguageGetLanguageList) | **Get** /api/language | List of supported languages for translation
[**LanguageTranslate**](LanguageAPI.md#LanguageTranslate) | **Post** /api/language/translate | Translation of text from one language to another



## LanguageDetection

> DetectLanguageResponse LanguageDetection(ctx).Text(text).Execute()

Detects language of a text



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
	text := "text_example" // string | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.LanguageAPI.LanguageDetection(context.Background()).Text(text).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `LanguageAPI.LanguageDetection``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `LanguageDetection`: DetectLanguageResponse
	fmt.Fprintf(os.Stdout, "Response from `LanguageAPI.LanguageDetection`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiLanguageDetectionRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string** |  | 

### Return type

[**DetectLanguageResponse**](DetectLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LanguageGetLanguageList

> GetLanguageResponse LanguageGetLanguageList(ctx).Execute()

List of supported languages for translation



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
	resp, r, err := apiClient.LanguageAPI.LanguageGetLanguageList(context.Background()).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `LanguageAPI.LanguageGetLanguageList``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `LanguageGetLanguageList`: GetLanguageResponse
	fmt.Fprintf(os.Stdout, "Response from `LanguageAPI.LanguageGetLanguageList`: %v\n", resp)
}
```

### Path Parameters

This endpoint does not need any parameter.

### Other Parameters

Other parameters are passed through a pointer to a apiLanguageGetLanguageListRequest struct via the builder pattern


### Return type

[**GetLanguageResponse**](GetLanguageResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LanguageTranslate

> TranslateResponse LanguageTranslate(ctx).Translate(translate).Execute()

Translation of text from one language to another



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
	translate := *openapiclient.NewTranslate() // Translate | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.LanguageAPI.LanguageTranslate(context.Background()).Translate(translate).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `LanguageAPI.LanguageTranslate``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `LanguageTranslate`: TranslateResponse
	fmt.Fprintf(os.Stdout, "Response from `LanguageAPI.LanguageTranslate`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiLanguageTranslateRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **translate** | [**Translate**](Translate.md) |  | 

### Return type

[**TranslateResponse**](TranslateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

