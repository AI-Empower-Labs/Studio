# \TranscriptionAPI

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranscriptionAsynchronous**](TranscriptionAPI.md#TranscriptionAsynchronous) | **Post** /api/transcribe/upload | Upload audio file for asynchronous transcription
[**TranscriptionGetById**](TranscriptionAPI.md#TranscriptionGetById) | **Get** /api/transcribe | Get transcription status and data



## TranscriptionAsynchronous

> TranscriptionAudioUploadResult TranscriptionAsynchronous(ctx).Files(files).Model(model).Language(language).Prompt(prompt).Temperature(temperature).WebHookUrl(webHookUrl).TranslateTo(translateTo).SplitOnWord(splitOnWord).LanguageDetection(languageDetection).EnableNoiseReduction(enableNoiseReduction).Execute()

Upload audio file for asynchronous transcription



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
	webHookUrl := "webHookUrl_example" // string | Url to call when transcription has completed or failed. (optional) (optional)
	translateTo := "translateTo_example" // string | The language to translate transcription into. Supplying the language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) (optional)
	splitOnWord := true // bool | Split into word segments. (optional, default is false) (optional) (default to false)
	languageDetection := true // bool | Enable transcription language detection (Optional. default is false) (optional) (default to false)
	enableNoiseReduction := true // bool | Enable noise reduction from audio stream before transcription (Optional. default is false) (optional) (default to false)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.TranscriptionAPI.TranscriptionAsynchronous(context.Background()).Files(files).Model(model).Language(language).Prompt(prompt).Temperature(temperature).WebHookUrl(webHookUrl).TranslateTo(translateTo).SplitOnWord(splitOnWord).LanguageDetection(languageDetection).EnableNoiseReduction(enableNoiseReduction).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `TranscriptionAPI.TranscriptionAsynchronous``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `TranscriptionAsynchronous`: TranscriptionAudioUploadResult
	fmt.Fprintf(os.Stdout, "Response from `TranscriptionAPI.TranscriptionAsynchronous`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiTranscriptionAsynchronousRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **[]*os.File** | The file object to ingest. | 
 **model** | **string** | Model to use for transcription (Optional, default &#x3D; Base) | 
 **language** | **string** | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | 
 **prompt** | **string** | An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | 
 **temperature** | **float64** | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [default to 0]
 **webHookUrl** | **string** | Url to call when transcription has completed or failed. (optional) | 
 **translateTo** | **string** | The language to translate transcription into. Supplying the language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | 
 **splitOnWord** | **bool** | Split into word segments. (optional, default is false) | [default to false]
 **languageDetection** | **bool** | Enable transcription language detection (Optional. default is false) | [default to false]
 **enableNoiseReduction** | **bool** | Enable noise reduction from audio stream before transcription (Optional. default is false) | [default to false]

### Return type

[**TranscriptionAudioUploadResult**](TranscriptionAudioUploadResult.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TranscriptionGetById

> TranscriptionGetById(ctx).Id(id).Execute()

Get transcription status and data



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
	r, err := apiClient.TranscriptionAPI.TranscriptionGetById(context.Background()).Id(id).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `TranscriptionAPI.TranscriptionGetById``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiTranscriptionGetByIdRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string** |  | 

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

