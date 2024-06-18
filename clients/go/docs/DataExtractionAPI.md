# \DataExtractionAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Embedding**](DataExtractionAPI.md#Embedding) | **Post** /api/extract/embed | Converts data to a numerical vector array
[**KeywordExtraction**](DataExtractionAPI.md#KeywordExtraction) | **Post** /api/extract/keywords | Performs keyword extraction on source text
[**NamedEntityRecognition**](DataExtractionAPI.md#NamedEntityRecognition) | **Post** /api/extract/entities | Extracts named entities from provided text
[**SemanticSimilarity**](DataExtractionAPI.md#SemanticSimilarity) | **Post** /api/extract/similarity | Generate semantic similarity queries from text
[**TokenCount**](DataExtractionAPI.md#TokenCount) | **Post** /api/extract/tokenCount | Count tokens in a text
[**Tokenize**](DataExtractionAPI.md#Tokenize) | **Post** /api/extract/tokenize | Converts data to a integer token array
[**TranscriptionSynchronous**](DataExtractionAPI.md#TranscriptionSynchronous) | **Post** /api/extract/transcription | Synchronous transcribe audio



## Embedding

> EmbeddingResponse Embedding(ctx).EmbeddingRequest(embeddingRequest).Execute()

Converts data to a numerical vector array



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
	embeddingRequest := *openapiclient.NewEmbeddingRequest() // EmbeddingRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.Embedding(context.Background()).EmbeddingRequest(embeddingRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.Embedding``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `Embedding`: EmbeddingResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.Embedding`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiEmbeddingRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **embeddingRequest** | [**EmbeddingRequest**](EmbeddingRequest.md) |  | 

### Return type

[**EmbeddingResponse**](EmbeddingResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## KeywordExtraction

> KeywordExtractionResponse KeywordExtraction(ctx).KeywordExtractionRequestBody(keywordExtractionRequestBody).Execute()

Performs keyword extraction on source text



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
	keywordExtractionRequestBody := *openapiclient.NewKeywordExtractionRequestBody("Text_example") // KeywordExtractionRequestBody | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.KeywordExtraction(context.Background()).KeywordExtractionRequestBody(keywordExtractionRequestBody).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.KeywordExtraction``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `KeywordExtraction`: KeywordExtractionResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.KeywordExtraction`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiKeywordExtractionRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keywordExtractionRequestBody** | [**KeywordExtractionRequestBody**](KeywordExtractionRequestBody.md) |  | 

### Return type

[**KeywordExtractionResponse**](KeywordExtractionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NamedEntityRecognition

> NamedEntityRecognitionResponse NamedEntityRecognition(ctx).NamedEntityRecognitionRequest(namedEntityRecognitionRequest).Execute()

Extracts named entities from provided text



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
	namedEntityRecognitionRequest := *openapiclient.NewNamedEntityRecognitionRequest("Text_example", []string{"Entities_example"}) // NamedEntityRecognitionRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.NamedEntityRecognition(context.Background()).NamedEntityRecognitionRequest(namedEntityRecognitionRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.NamedEntityRecognition``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `NamedEntityRecognition`: NamedEntityRecognitionResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.NamedEntityRecognition`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiNamedEntityRecognitionRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **namedEntityRecognitionRequest** | [**NamedEntityRecognitionRequest**](NamedEntityRecognitionRequest.md) |  | 

### Return type

[**NamedEntityRecognitionResponse**](NamedEntityRecognitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SemanticSimilarity

> SemanticSimilarityResponse SemanticSimilarity(ctx).SemanticSimilarityRequest(semanticSimilarityRequest).Execute()

Generate semantic similarity queries from text



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
	semanticSimilarityRequest := *openapiclient.NewSemanticSimilarityRequest() // SemanticSimilarityRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.SemanticSimilarity(context.Background()).SemanticSimilarityRequest(semanticSimilarityRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.SemanticSimilarity``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SemanticSimilarity`: SemanticSimilarityResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.SemanticSimilarity`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSemanticSimilarityRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semanticSimilarityRequest** | [**SemanticSimilarityRequest**](SemanticSimilarityRequest.md) |  | 

### Return type

[**SemanticSimilarityResponse**](SemanticSimilarityResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TokenCount

> TokenCountResponse TokenCount(ctx).TokenCountRequest(tokenCountRequest).Execute()

Count tokens in a text



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
	tokenCountRequest := *openapiclient.NewTokenCountRequest() // TokenCountRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.TokenCount(context.Background()).TokenCountRequest(tokenCountRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.TokenCount``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `TokenCount`: TokenCountResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.TokenCount`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiTokenCountRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenCountRequest** | [**TokenCountRequest**](TokenCountRequest.md) |  | 

### Return type

[**TokenCountResponse**](TokenCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Tokenize

> TokenizerResponse Tokenize(ctx).TokenizerRequest(tokenizerRequest).Execute()

Converts data to a integer token array



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
	tokenizerRequest := *openapiclient.NewTokenizerRequest() // TokenizerRequest | 

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.Tokenize(context.Background()).TokenizerRequest(tokenizerRequest).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.Tokenize``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `Tokenize`: TokenizerResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.Tokenize`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiTokenizeRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizerRequest** | [**TokenizerRequest**](TokenizerRequest.md) |  | 

### Return type

[**TokenizerResponse**](TokenizerResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TranscriptionSynchronous

> TranscriptionResponse TranscriptionSynchronous(ctx).Files(files).Model(model).Language(language).Prompt(prompt).Temperature(temperature).SplitOnWord(splitOnWord).LanguageDetection(languageDetection).NoiseReduction(noiseReduction).Execute()

Synchronous transcribe audio



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
	model := "model_example" // string | Model to use for transcription (Optional, default = Base) (optional)
	language := "language_example" // string | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) (optional)
	prompt := "prompt_example" // string | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional) (optional)
	temperature := float64(1.2) // float64 | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) (optional) (default to 0)
	splitOnWord := true // bool | Split into word segments. (optional, default is false) (optional) (default to false)
	languageDetection := true // bool | Enable transcription language detection (Optional. default is false) (optional) (default to false)
	noiseReduction := true // bool | Enable noise reduction from audio stream before transcription (Optional. default is false) (optional) (default to false)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.DataExtractionAPI.TranscriptionSynchronous(context.Background()).Files(files).Model(model).Language(language).Prompt(prompt).Temperature(temperature).SplitOnWord(splitOnWord).LanguageDetection(languageDetection).NoiseReduction(noiseReduction).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `DataExtractionAPI.TranscriptionSynchronous``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `TranscriptionSynchronous`: TranscriptionResponse
	fmt.Fprintf(os.Stdout, "Response from `DataExtractionAPI.TranscriptionSynchronous`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiTranscriptionSynchronousRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **[]*os.File** | The file object to ingest. | 
 **model** | **string** | Model to use for transcription (Optional, default &#x3D; Base) | 
 **language** | **string** | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | 
 **prompt** | **string** | An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | 
 **temperature** | **float64** | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [default to 0]
 **splitOnWord** | **bool** | Split into word segments. (optional, default is false) | [default to false]
 **languageDetection** | **bool** | Enable transcription language detection (Optional. default is false) | [default to false]
 **noiseReduction** | **bool** | Enable noise reduction from audio stream before transcription (Optional. default is false) | [default to false]

### Return type

[**TranscriptionResponse**](TranscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

