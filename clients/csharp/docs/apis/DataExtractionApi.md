# Org.OpenAPITools.Api.DataExtractionApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiExtractThematicSimilarityClusterPost**](DataExtractionApi.md#apiextractthematicsimilarityclusterpost) | **POST** /api/extract/thematic-similarity-cluster | Generate thematic similarity clusters using the K-Means algorithm |
| [**Embedding**](DataExtractionApi.md#embedding) | **POST** /api/extract/embed | Converts data to a numerical vector array |
| [**KeywordExtraction**](DataExtractionApi.md#keywordextraction) | **POST** /api/extract/keywords | Performs keyword extraction on source text |
| [**NamedEntityRecognition**](DataExtractionApi.md#namedentityrecognition) | **POST** /api/extract/entities | Extracts named entities from provided text |
| [**SemanticSimilarity**](DataExtractionApi.md#semanticsimilarity) | **POST** /api/extract/similarity | Generate semantic similarity queries from text |
| [**TokenCount**](DataExtractionApi.md#tokencount) | **POST** /api/extract/tokenCount | Count tokens in a text |
| [**Tokenize**](DataExtractionApi.md#tokenize) | **POST** /api/extract/tokenize | Converts data to a integer token array |
| [**TranscriptionSynchronous**](DataExtractionApi.md#transcriptionsynchronous) | **POST** /api/extract/transcription | Synchronous transcribe audio |

<a id="apiextractthematicsimilarityclusterpost"></a>
# **ApiExtractThematicSimilarityClusterPost**
> KMeansCluster ApiExtractThematicSimilarityClusterPost (ApiExtractThematicSimilarityClusterPostRequest apiExtractThematicSimilarityClusterPostRequest)

Generate thematic similarity clusters using the K-Means algorithm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiExtractThematicSimilarityClusterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var apiExtractThematicSimilarityClusterPostRequest = new ApiExtractThematicSimilarityClusterPostRequest(); // ApiExtractThematicSimilarityClusterPostRequest | 

            try
            {
                // Generate thematic similarity clusters using the K-Means algorithm
                KMeansCluster result = apiInstance.ApiExtractThematicSimilarityClusterPost(apiExtractThematicSimilarityClusterPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.ApiExtractThematicSimilarityClusterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiExtractThematicSimilarityClusterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate thematic similarity clusters using the K-Means algorithm
    ApiResponse<KMeansCluster> response = apiInstance.ApiExtractThematicSimilarityClusterPostWithHttpInfo(apiExtractThematicSimilarityClusterPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.ApiExtractThematicSimilarityClusterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiExtractThematicSimilarityClusterPostRequest** | [**ApiExtractThematicSimilarityClusterPostRequest**](ApiExtractThematicSimilarityClusterPostRequest.md) |  |  |

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/csv, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="embedding"></a>
# **Embedding**
> EmbeddingResponse Embedding (EmbeddingRequest embeddingRequest)

Converts data to a numerical vector array

The embedding endpoint is a sophisticated API designed for transforming textual data into high-dimensional vectors, facilitating a wide array of natural language processing (NLP) tasks. This transformation process encodes the semantic properties and contextual meanings of the input text into a vector space, enabling machines to understand and process language in a manner analogous to human comprehension.  ## Core Features:  * Semantic Encoding: Leverages advanced machine learning models, particularly those based on transformer architectures, to capture the deep semantic and syntactic nuances of the input text. This ensures that similar words and phrases are positioned closely in the vector space, reflecting their semantic proximity. * High-Dimensional Representation: Transforms texts into vectors in a high-dimensional space, typically ranging from hundreds to thousands of dimensions. This rich representation captures a comprehensive spectrum of linguistic features and relationships. * Scalability: Engineered to handle a wide range of text sizes, from short tweets to extensive documents, without compromising on the accuracy of the vector representations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmbeddingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var embeddingRequest = new EmbeddingRequest(); // EmbeddingRequest | 

            try
            {
                // Converts data to a numerical vector array
                EmbeddingResponse result = apiInstance.Embedding(embeddingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.Embedding: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmbeddingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Converts data to a numerical vector array
    ApiResponse<EmbeddingResponse> response = apiInstance.EmbeddingWithHttpInfo(embeddingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.EmbeddingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **embeddingRequest** | [**EmbeddingRequest**](EmbeddingRequest.md) |  |  |

### Return type

[**EmbeddingResponse**](EmbeddingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="keywordextraction"></a>
# **KeywordExtraction**
> KeywordExtractionResponse KeywordExtraction (KeywordExtractionRequestBody keywordExtractionRequestBody)

Performs keyword extraction on source text

This endpoint accepts a string of text and returns a list of key words or phrases that best describe the content of the text. This can be used for tagging, summarizing, indexing, or categorizing content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KeywordExtractionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var keywordExtractionRequestBody = new KeywordExtractionRequestBody(); // KeywordExtractionRequestBody | 

            try
            {
                // Performs keyword extraction on source text
                KeywordExtractionResponse result = apiInstance.KeywordExtraction(keywordExtractionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.KeywordExtraction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeywordExtractionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs keyword extraction on source text
    ApiResponse<KeywordExtractionResponse> response = apiInstance.KeywordExtractionWithHttpInfo(keywordExtractionRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.KeywordExtractionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keywordExtractionRequestBody** | [**KeywordExtractionRequestBody**](KeywordExtractionRequestBody.md) |  |  |

### Return type

[**KeywordExtractionResponse**](KeywordExtractionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="namedentityrecognition"></a>
# **NamedEntityRecognition**
> NamedEntityRecognitionResponse NamedEntityRecognition (NamedEntityRecognitionRequest namedEntityRecognitionRequest)

Extracts named entities from provided text

This endpoint accepts a string of text and returns a list of identified entities classified into categories such as email, location, organisation, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NamedEntityRecognitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var namedEntityRecognitionRequest = new NamedEntityRecognitionRequest(); // NamedEntityRecognitionRequest | 

            try
            {
                // Extracts named entities from provided text
                NamedEntityRecognitionResponse result = apiInstance.NamedEntityRecognition(namedEntityRecognitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.NamedEntityRecognition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NamedEntityRecognitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extracts named entities from provided text
    ApiResponse<NamedEntityRecognitionResponse> response = apiInstance.NamedEntityRecognitionWithHttpInfo(namedEntityRecognitionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.NamedEntityRecognitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **namedEntityRecognitionRequest** | [**NamedEntityRecognitionRequest**](NamedEntityRecognitionRequest.md) |  |  |

### Return type

[**NamedEntityRecognitionResponse**](NamedEntityRecognitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="semanticsimilarity"></a>
# **SemanticSimilarity**
> SemanticSimilarityResponse SemanticSimilarity (SemanticSimilarityRequest semanticSimilarityRequest)

Generate semantic similarity queries from text

Upon receiving a user-defined query and a set of texts, the endpoint processes this information through its semantic analysis engine. This engine leverages state-of-the-art machine learning models, such as transformer-based architectures, to encode the texts and the query into high-dimensional vectors. By operating in this semantic space, it can accurately measure the distances between the query vector and each of the text vectors, reflecting how closely the meanings align.  Use Cases:  * Content Discovery: Helps users find articles, posts, or documents that are most relevant to their query.  * Customer Support: Automatically matches customer queries to the most relevant FAQs or support documents.  * Research and Study: Assists researchers in quickly finding academic papers or resources that are closely related to their field of inquiry.  By utilizing the semantic similarity endpoint, organizations and individuals can greatly enhance the efficiency and effectiveness of their information retrieval processes, ensuring that users are connected with the content most pertinent to their needs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SemanticSimilarityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var semanticSimilarityRequest = new SemanticSimilarityRequest(); // SemanticSimilarityRequest | 

            try
            {
                // Generate semantic similarity queries from text
                SemanticSimilarityResponse result = apiInstance.SemanticSimilarity(semanticSimilarityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.SemanticSimilarity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SemanticSimilarityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate semantic similarity queries from text
    ApiResponse<SemanticSimilarityResponse> response = apiInstance.SemanticSimilarityWithHttpInfo(semanticSimilarityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.SemanticSimilarityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **semanticSimilarityRequest** | [**SemanticSimilarityRequest**](SemanticSimilarityRequest.md) |  |  |

### Return type

[**SemanticSimilarityResponse**](SemanticSimilarityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="tokencount"></a>
# **TokenCount**
> TokenCountResponse TokenCount (TokenCountRequest tokenCountRequest)

Count tokens in a text

The tokenCount endpoint designed for counting tokens in text data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TokenCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var tokenCountRequest = new TokenCountRequest(); // TokenCountRequest | 

            try
            {
                // Count tokens in a text
                TokenCountResponse result = apiInstance.TokenCount(tokenCountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.TokenCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokenCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Count tokens in a text
    ApiResponse<TokenCountResponse> response = apiInstance.TokenCountWithHttpInfo(tokenCountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.TokenCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenCountRequest** | [**TokenCountRequest**](TokenCountRequest.md) |  |  |

### Return type

[**TokenCountResponse**](TokenCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="tokenize"></a>
# **Tokenize**
> TokenizerResponse Tokenize (TokenizerRequest tokenizerRequest)

Converts data to a integer token array

The tokenizer endpoint designed for transforming textual data into integer tokens.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TokenizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var tokenizerRequest = new TokenizerRequest(); // TokenizerRequest | 

            try
            {
                // Converts data to a integer token array
                TokenizerResponse result = apiInstance.Tokenize(tokenizerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.Tokenize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TokenizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Converts data to a integer token array
    ApiResponse<TokenizerResponse> response = apiInstance.TokenizeWithHttpInfo(tokenizerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.TokenizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenizerRequest** | [**TokenizerRequest**](TokenizerRequest.md) |  |  |

### Return type

[**TokenizerResponse**](TokenizerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transcriptionsynchronous"></a>
# **TranscriptionSynchronous**
> TranscriptionResponse TranscriptionSynchronous (List<System.IO.Stream> files, string model = null, string language = null, string prompt = null, double temperature = null, bool splitOnWord = null, bool languageDetection = null, bool enableNoiseReduction = null)

Synchronous transcribe audio

The audio transcription endpoint is a specialized web service designed to convert spoken words from audio or video files into written text. This technology relies on advanced speech recognition algorithms to accurately transcribe the content of audio or video recordings. The endpoint typically accepts files in various formats, such as MP3, WAV for audio, and MP4, AVI for video, among others. Users can upload their files directly to the service, which then processes the audio track to extract the spoken words.  The transcription process involves several steps, including noise reduction to improve audio clarity, speaker diarization to identify and differentiate between different speakers, and the actual speech-to-text conversion. The result is a detailed transcript that captures the spoken content, often including timestamps and speaker labels for easy reference.  This service is particularly useful for journalists, researchers, podcasters, and professionals who need to convert meetings, interviews, lectures, or presentations into written form for analysis, sharing, or archival purposes. The endpoint may offer additional features like language detection, support for multiple languages, and customization options to improve transcription accuracy based on specific vocabulary or industry terms.  To use the audio transcription endpoint, developers typically integrate it into applications via API calls. These calls specify the file to be transcribed and any additional parameters required by the service, such as language preference.   Upon completion, the service returns the transcription in a JSON text format, which can then be displayed, stored, or further processed according to the user's needs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranscriptionSynchronousExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new DataExtractionApi(config);
            var files = new List<System.IO.Stream>(); // List<System.IO.Stream> | The file object to ingest.
            var model = "tiny";  // string | Model to use for transcription (Optional, default = Base) (optional) 
            var language = "language_example";  // string | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) (optional) 
            var prompt = "prompt_example";  // string | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional) (optional) 
            var temperature = 0D;  // double | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) (optional)  (default to 0D)
            var splitOnWord = false;  // bool | Split into word segments. (optional, default is false) (optional)  (default to false)
            var languageDetection = false;  // bool | Enable transcription language detection (Optional. default is false) (optional)  (default to false)
            var enableNoiseReduction = false;  // bool | Enable noise reduction from audio stream before transcription (Optional. default is false) (optional)  (default to false)

            try
            {
                // Synchronous transcribe audio
                TranscriptionResponse result = apiInstance.TranscriptionSynchronous(files, model, language, prompt, temperature, splitOnWord, languageDetection, enableNoiseReduction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractionApi.TranscriptionSynchronous: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranscriptionSynchronousWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Synchronous transcribe audio
    ApiResponse<TranscriptionResponse> response = apiInstance.TranscriptionSynchronousWithHttpInfo(files, model, language, prompt, temperature, splitOnWord, languageDetection, enableNoiseReduction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractionApi.TranscriptionSynchronousWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **files** | **List&lt;System.IO.Stream&gt;** | The file object to ingest. |  |
| **model** | **string** | Model to use for transcription (Optional, default &#x3D; Base) | [optional]  |
| **language** | **string** | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional]  |
| **prompt** | **string** | An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | [optional]  |
| **temperature** | **double** | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [optional] [default to 0D] |
| **splitOnWord** | **bool** | Split into word segments. (optional, default is false) | [optional] [default to false] |
| **languageDetection** | **bool** | Enable transcription language detection (Optional. default is false) | [optional] [default to false] |
| **enableNoiseReduction** | **bool** | Enable noise reduction from audio stream before transcription (Optional. default is false) | [optional] [default to false] |

### Return type

[**TranscriptionResponse**](TranscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

