# TranscriptionApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**transcriptionAsynchronous**](TranscriptionApi.md#transcriptionAsynchronous) | **POST** /api/transcribe/upload | Upload audio file for asynchronous transcription |
| [**transcriptionGetById**](TranscriptionApi.md#transcriptionGetById) | **GET** /api/transcribe | Get transcription status and data |


<a id="transcriptionAsynchronous"></a>
# **transcriptionAsynchronous**
> TranscriptionAudioUploadResult transcriptionAsynchronous(files, model, language, prompt, temperature, webHookUrl, translateTo, splitOnWord, languageDetection, enableNoiseReduction)

Upload audio file for asynchronous transcription

This service is designed to convert spoken words from audio or video files into written text, utilizing sophisticated speech recognition algorithms for accurate transcription. It offers a range of features that cater to various needs and use cases, making it particularly valuable for journalists, researchers, podcasters, and professionals dealing with meetings, interviews, lectures, or presentations.  ### Key features and capabilities include:  * Support for Various File Formats: Accepts a wide range of audio and video file formats, ensuring flexibility in file uploads. * Advanced Processing Steps: Incorporates noise reduction, speaker diarization, and speech-to-text conversion for clear and differentiated transcriptions. * Asynchronous Background Processing: Allows for non-blocking, efficient handling of transcription tasks, suitable for large files or batches of files. * Webhook Callback URL: Offers real-time updates on the transcription process via a provided webhook, enabling immediate reaction to task completion or failure. * /api/transcribe GET Endpoint: Provides an alternative for users to manually check the status of their transcription requests, allowing flexibility in monitoring. * Automatic Text Translation Feature: An optional service that translates the transcribed text into a specified target language, enhancing the utility for multi-lingual contexts. * Multi-File and Multi-Channel Support: Supports concurrent file uploads and accurate transcription of multi-channel recordings, ideal for complex audio environments. * The transcription output is meticulously formatted to clearly distinguish between channels and speakers, including timestamps and labels for easy navigation and reference. This structured approach ensures that even in challenging audio environments with multiple speakers or channels, the transcription service can provide clear, accurate, and useful text representations of the spoken content.  This service integrates into applications via API calls, offering developers a powerful tool to enhance their applications with audio-to-text conversion capabilities. The inclusion of features like language detection, support for multiple languages, and customization options for specific vocabulary or industry terms further extends its applicability across various domains and industries.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TranscriptionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    TranscriptionApi apiInstance = new TranscriptionApi(defaultClient);
    List<File> files = Arrays.asList(); // List<File> | The file object to ingest.
    String model = "tiny"; // String | Model to use for transcription (Optional, default = Base)
    String language = "language_example"; // String | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional)
    String prompt = "prompt_example"; // String | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional)
    Double temperature = 0D; // Double | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M)
    URI webHookUrl = new URI(); // URI | Url to call when transcription has completed or failed. (optional)
    String translateTo = "translateTo_example"; // String | The language to translate transcription into. Supplying the language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional)
    Boolean splitOnWord = false; // Boolean | Split into word segments. (optional, default is false)
    Boolean languageDetection = false; // Boolean | Enable transcription language detection (Optional. default is false)
    Boolean enableNoiseReduction = false; // Boolean | Enable noise reduction from audio stream before transcription (Optional. default is false)
    try {
      TranscriptionAudioUploadResult result = apiInstance.transcriptionAsynchronous(files, model, language, prompt, temperature, webHookUrl, translateTo, splitOnWord, languageDetection, enableNoiseReduction);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling TranscriptionApi#transcriptionAsynchronous");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **files** | **List&lt;File&gt;**| The file object to ingest. | |
| **model** | **String**| Model to use for transcription (Optional, default &#x3D; Base) | [optional] [enum: tiny, tiny.en, base, base.en, small, small.en, medium, medium.en, large_v1, large_v2, large_v3] |
| **language** | **String**| The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] |
| **prompt** | **String**| An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | [optional] |
| **temperature** | **Double**| The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [optional] [default to 0] |
| **webHookUrl** | **URI**| Url to call when transcription has completed or failed. (optional) | [optional] |
| **translateTo** | **String**| The language to translate transcription into. Supplying the language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] |
| **splitOnWord** | **Boolean**| Split into word segments. (optional, default is false) | [optional] [default to false] |
| **languageDetection** | **Boolean**| Enable transcription language detection (Optional. default is false) | [optional] [default to false] |
| **enableNoiseReduction** | **Boolean**| Enable noise reduction from audio stream before transcription (Optional. default is false) | [optional] [default to false] |

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
| **201** | Created |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

<a id="transcriptionGetById"></a>
# **transcriptionGetById**
> transcriptionGetById(id)

Get transcription status and data

The /api/transcribe GET endpoint is a crucial component of the audio transcription service, designed to offer users a way to check the status of their transcription requests. This endpoint caters to the needs of users who prefer polling to monitor their requests over relying on webhook callbacks for real-time updates. Here&#39;s a detailed description of its functionality and how it integrates within the service:  ### Purpose and Functionality The primary purpose of the /api/transcribe GET endpoint is to provide users with the ability to manually inquire about the current status of their audio or video file transcription tasks. This endpoint supports a polling mechanism, where users can send a GET request at their convenience to receive the latest update on their transcription process.  ### How It Works Request: To utilize this endpoint, users initiate a GET request, including a unique identifier for the transcription task as a parameter. This identifier is provided by the service when the transcription request is first submitted. Response: In response to the GET request, the endpoint returns data about the transcription task&#39;s status. The response indicate that the transcription is still processing, has been completed, or has failed.  ### Response Details The response from the /api/transcribe GET endpoint includes several pieces of information that are crucial for users to understand the status and outcome of their transcription requests:  Status: Indicates the current state of the transcription task (e.g., Queued, Completed, Failed). Completion Details: If the transcription is completed, the response include details the resulting transcript.  ### Use Cases This endpoint is particularly useful for scenarios where users need or prefer to periodically check the status of their requests rather than implement real-time update mechanisms via webhooks. It provides flexibility in handling transcription tasks, allowing users to:  ### Advantages The /api/transcribe GET endpoint offers several advantages, including simplicity in implementation, flexibility in usage, and the ability to integrate easily into various application workflows. It provides a straightforward method for users to remain informed about their transcription tasks without the need for complex callback systems, making it an essential feature for many applications and services requiring transcription capabilities.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TranscriptionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    TranscriptionApi apiInstance = new TranscriptionApi(defaultClient);
    UUID id = UUID.randomUUID(); // UUID | 
    try {
      apiInstance.transcriptionGetById(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling TranscriptionApi#transcriptionGetById");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | **UUID**|  | |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

