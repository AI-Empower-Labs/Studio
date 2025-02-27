# openapi_client.TranscriptionApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transcription_asynchronous**](TranscriptionApi.md#transcription_asynchronous) | **POST** /api/transcribe/upload | Upload audio file for asynchronous transcription
[**transcription_get_by_id**](TranscriptionApi.md#transcription_get_by_id) | **GET** /api/transcribe | Get transcription status and data


# **transcription_asynchronous**
> TranscriptionAudioUploadResult transcription_asynchronous(files, model=model, language=language, prompt=prompt, temperature=temperature, web_hook_url=web_hook_url, translate_to=translate_to, split_on_word=split_on_word, language_detection=language_detection, enable_noise_reduction=enable_noise_reduction)

Upload audio file for asynchronous transcription

This service is designed to convert spoken words from audio or video files into written text, utilizing sophisticated speech recognition algorithms for accurate transcription. It offers a range of features that cater to various needs and use cases, making it particularly valuable for journalists, researchers, podcasters, and professionals dealing with meetings, interviews, lectures, or presentations.

### Key features and capabilities include:

* Support for Various File Formats: Accepts a wide range of audio and video file formats, ensuring flexibility in file uploads.
* Advanced Processing Steps: Incorporates noise reduction, speaker diarization, and speech-to-text conversion for clear and differentiated transcriptions.
* Asynchronous Background Processing: Allows for non-blocking, efficient handling of transcription tasks, suitable for large files or batches of files.
* Webhook Callback URL: Offers real-time updates on the transcription process via a provided webhook, enabling immediate reaction to task completion or failure.
* /api/transcribe GET Endpoint: Provides an alternative for users to manually check the status of their transcription requests, allowing flexibility in monitoring.
* Automatic Text Translation Feature: An optional service that translates the transcribed text into a specified target language, enhancing the utility for multi-lingual contexts.
* Multi-File and Multi-Channel Support: Supports concurrent file uploads and accurate transcription of multi-channel recordings, ideal for complex audio environments.
* The transcription output is meticulously formatted to clearly distinguish between channels and speakers, including timestamps and labels for easy navigation and reference. This structured approach ensures that even in challenging audio environments with multiple speakers or channels, the transcription service can provide clear, accurate, and useful text representations of the spoken content.

This service integrates into applications via API calls, offering developers a powerful tool to enhance their applications with audio-to-text conversion capabilities. The inclusion of features like language detection, support for multiple languages, and customization options for specific vocabulary or industry terms further extends its applicability across various domains and industries.

### Example


```python
import openapi_client
from openapi_client.models.transcription_audio_upload_result import TranscriptionAudioUploadResult
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://studio.aiempowerlabs.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://studio.aiempowerlabs.com"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.TranscriptionApi(api_client)
    files = None # List[bytearray] | The file object to ingest.
    model = 'model_example' # str | Model to use for transcription (Optional, default = Base) (optional)
    language = 'language_example' # str | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) (optional)
    prompt = 'prompt_example' # str | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional) (optional)
    temperature = 0 # float | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) (optional) (default to 0)
    web_hook_url = 'web_hook_url_example' # str | Url to call when transcription has completed or failed. (optional) (optional)
    translate_to = 'translate_to_example' # str | The language to translate transcription into. Supplying the language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) (optional)
    split_on_word = False # bool | Split into word segments. (optional, default is false) (optional) (default to False)
    language_detection = False # bool | Enable transcription language detection (Optional. default is false) (optional) (default to False)
    enable_noise_reduction = False # bool | Enable noise reduction from audio stream before transcription (Optional. default is false) (optional) (default to False)

    try:
        # Upload audio file for asynchronous transcription
        api_response = api_instance.transcription_asynchronous(files, model=model, language=language, prompt=prompt, temperature=temperature, web_hook_url=web_hook_url, translate_to=translate_to, split_on_word=split_on_word, language_detection=language_detection, enable_noise_reduction=enable_noise_reduction)
        print("The response of TranscriptionApi->transcription_asynchronous:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling TranscriptionApi->transcription_asynchronous: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **List[bytearray]**| The file object to ingest. | 
 **model** | **str**| Model to use for transcription (Optional, default &#x3D; Base) | [optional] 
 **language** | **str**| The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] 
 **prompt** | **str**| An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | [optional] 
 **temperature** | **float**| The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [optional] [default to 0]
 **web_hook_url** | **str**| Url to call when transcription has completed or failed. (optional) | [optional] 
 **translate_to** | **str**| The language to translate transcription into. Supplying the language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] 
 **split_on_word** | **bool**| Split into word segments. (optional, default is false) | [optional] [default to False]
 **language_detection** | **bool**| Enable transcription language detection (Optional. default is false) | [optional] [default to False]
 **enable_noise_reduction** | **bool**| Enable noise reduction from audio stream before transcription (Optional. default is false) | [optional] [default to False]

### Return type

[**TranscriptionAudioUploadResult**](TranscriptionAudioUploadResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
 - **Accept**: application/json, application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**201** | Created |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transcription_get_by_id**
> transcription_get_by_id(id)

Get transcription status and data

The /api/transcribe GET endpoint is a crucial component of the audio transcription service, designed to offer users a way to check the status of their transcription requests. This endpoint caters to the needs of users who prefer polling to monitor their requests over relying on webhook callbacks for real-time updates. Here's a detailed description of its functionality and how it integrates within the service:

### Purpose and Functionality
The primary purpose of the /api/transcribe GET endpoint is to provide users with the ability to manually inquire about the current status of their audio or video file transcription tasks. This endpoint supports a polling mechanism, where users can send a GET request at their convenience to receive the latest update on their transcription process.

### How It Works
Request: To utilize this endpoint, users initiate a GET request, including a unique identifier for the transcription task as a parameter. This identifier is provided by the service when the transcription request is first submitted.
Response: In response to the GET request, the endpoint returns data about the transcription task's status. The response indicate that the transcription is still processing, has been completed, or has failed.

### Response Details
The response from the /api/transcribe GET endpoint includes several pieces of information that are crucial for users to understand the status and outcome of their transcription requests:

Status: Indicates the current state of the transcription task (e.g., Queued, Completed, Failed).
Completion Details: If the transcription is completed, the response include details the resulting transcript.

### Use Cases
This endpoint is particularly useful for scenarios where users need or prefer to periodically check the status of their requests rather than implement real-time update mechanisms via webhooks. It provides flexibility in handling transcription tasks, allowing users to:

### Advantages
The /api/transcribe GET endpoint offers several advantages, including simplicity in implementation, flexibility in usage, and the ability to integrate easily into various application workflows. It provides a straightforward method for users to remain informed about their transcription tasks without the need for complex callback systems, making it an essential feature for many applications and services requiring transcription capabilities.

### Example


```python
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint

# Defining the host is optional and defaults to https://studio.aiempowerlabs.com
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://studio.aiempowerlabs.com"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.TranscriptionApi(api_client)
    id = 'id_example' # str | 

    try:
        # Get transcription status and data
        api_instance.transcription_get_by_id(id)
    except Exception as e:
        print("Exception when calling TranscriptionApi->transcription_get_by_id: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

