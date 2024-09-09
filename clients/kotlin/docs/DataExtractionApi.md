# DataExtractionApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**apiExtractThematicSimilarityClusterPost**](DataExtractionApi.md#apiExtractThematicSimilarityClusterPost) | **POST** /api/extract/thematic-similarity-cluster | Generate thematic similarity clusters using the K-Means algorithm |
| [**embedding**](DataExtractionApi.md#embedding) | **POST** /api/extract/embed | Converts data to a numerical vector array |
| [**keywordExtraction**](DataExtractionApi.md#keywordExtraction) | **POST** /api/extract/keywords | Performs keyword extraction on source text |
| [**namedEntityRecognition**](DataExtractionApi.md#namedEntityRecognition) | **POST** /api/extract/entities | Extracts named entities from provided text |
| [**semanticSimilarity**](DataExtractionApi.md#semanticSimilarity) | **POST** /api/extract/similarity | Generate semantic similarity queries from text |
| [**tokenCount**](DataExtractionApi.md#tokenCount) | **POST** /api/extract/tokenCount | Count tokens in a text |
| [**tokenize**](DataExtractionApi.md#tokenize) | **POST** /api/extract/tokenize | Converts data to a integer token array |
| [**transcriptionSynchronous**](DataExtractionApi.md#transcriptionSynchronous) | **POST** /api/extract/transcription | Synchronous transcribe audio |


<a id="apiExtractThematicSimilarityClusterPost"></a>
# **apiExtractThematicSimilarityClusterPost**
> KMeansCluster apiExtractThematicSimilarityClusterPost(apiExtractThematicSimilarityClusterPostRequest)

Generate thematic similarity clusters using the K-Means algorithm

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val apiExtractThematicSimilarityClusterPostRequest : ApiExtractThematicSimilarityClusterPostRequest =  // ApiExtractThematicSimilarityClusterPostRequest | 
try {
    val result : KMeansCluster = apiInstance.apiExtractThematicSimilarityClusterPost(apiExtractThematicSimilarityClusterPostRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#apiExtractThematicSimilarityClusterPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#apiExtractThematicSimilarityClusterPost")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **apiExtractThematicSimilarityClusterPostRequest** | [**ApiExtractThematicSimilarityClusterPostRequest**](ApiExtractThematicSimilarityClusterPostRequest.md)|  | |

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="embedding"></a>
# **embedding**
> EmbeddingResponse embedding(embeddingRequest)

Converts data to a numerical vector array

The embedding endpoint is a sophisticated API designed for transforming textual data into high-dimensional vectors, facilitating a wide array of natural language processing (NLP) tasks. This transformation process encodes the semantic properties and contextual meanings of the input text into a vector space, enabling machines to understand and process language in a manner analogous to human comprehension.  ## Core Features:  * Semantic Encoding: Leverages advanced machine learning models, particularly those based on transformer architectures, to capture the deep semantic and syntactic nuances of the input text. This ensures that similar words and phrases are positioned closely in the vector space, reflecting their semantic proximity. * High-Dimensional Representation: Transforms texts into vectors in a high-dimensional space, typically ranging from hundreds to thousands of dimensions. This rich representation captures a comprehensive spectrum of linguistic features and relationships. * Scalability: Engineered to handle a wide range of text sizes, from short tweets to extensive documents, without compromising on the accuracy of the vector representations.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val embeddingRequest : EmbeddingRequest = {"model":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]} // EmbeddingRequest | 
try {
    val result : EmbeddingResponse = apiInstance.embedding(embeddingRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#embedding")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#embedding")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **embeddingRequest** | [**EmbeddingRequest**](EmbeddingRequest.md)|  | |

### Return type

[**EmbeddingResponse**](EmbeddingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="keywordExtraction"></a>
# **keywordExtraction**
> KeywordExtractionResponse keywordExtraction(keywordExtractionRequestBody)

Performs keyword extraction on source text

This endpoint accepts a string of text and returns a list of key words or phrases that best describe the content of the text. This can be used for tagging, summarizing, indexing, or categorizing content.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val keywordExtractionRequestBody : KeywordExtractionRequestBody = {"text":"Hello world! Get in touch with AI Empower Labs from Malmö Sweden via www.AIEmpowerLabs.com or email info@AIEmpowerLabs.com"} // KeywordExtractionRequestBody | 
try {
    val result : KeywordExtractionResponse = apiInstance.keywordExtraction(keywordExtractionRequestBody)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#keywordExtraction")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#keywordExtraction")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **keywordExtractionRequestBody** | [**KeywordExtractionRequestBody**](KeywordExtractionRequestBody.md)|  | |

### Return type

[**KeywordExtractionResponse**](KeywordExtractionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="namedEntityRecognition"></a>
# **namedEntityRecognition**
> NamedEntityRecognitionResponse namedEntityRecognition(namedEntityRecognitionRequest)

Extracts named entities from provided text

This endpoint accepts a string of text and returns a list of identified entities classified into categories such as email, location, organisation, etc.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val namedEntityRecognitionRequest : NamedEntityRecognitionRequest = {"text":"Hello world! Get in touch with AI Empower Labs from Malmö Sweden via www.AIEmpowerLabs.com or email info@AIEmpowerLabs.com","entities":["email","location","organisation","url"]} // NamedEntityRecognitionRequest | 
try {
    val result : NamedEntityRecognitionResponse = apiInstance.namedEntityRecognition(namedEntityRecognitionRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#namedEntityRecognition")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#namedEntityRecognition")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **namedEntityRecognitionRequest** | [**NamedEntityRecognitionRequest**](NamedEntityRecognitionRequest.md)|  | |

### Return type

[**NamedEntityRecognitionResponse**](NamedEntityRecognitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="semanticSimilarity"></a>
# **semanticSimilarity**
> SemanticSimilarityResponse semanticSimilarity(semanticSimilarityRequest)

Generate semantic similarity queries from text

Upon receiving a user-defined query and a set of texts, the endpoint processes this information through its semantic analysis engine. This engine leverages state-of-the-art machine learning models, such as transformer-based architectures, to encode the texts and the query into high-dimensional vectors. By operating in this semantic space, it can accurately measure the distances between the query vector and each of the text vectors, reflecting how closely the meanings align.  Use Cases:  * Content Discovery: Helps users find articles, posts, or documents that are most relevant to their query.  * Customer Support: Automatically matches customer queries to the most relevant FAQs or support documents.  * Research and Study: Assists researchers in quickly finding academic papers or resources that are closely related to their field of inquiry.  By utilizing the semantic similarity endpoint, organizations and individuals can greatly enhance the efficiency and effectiveness of their information retrieval processes, ensuring that users are connected with the content most pertinent to their needs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val semanticSimilarityRequest : SemanticSimilarityRequest = {"query":"Machine learning is so easy","documents":["Deep learning is so straightforward","This is so difficult, like rocket science","I can't believe how much I struggled with this"],"model":"multilingual-e5-large"} // SemanticSimilarityRequest | 
try {
    val result : SemanticSimilarityResponse = apiInstance.semanticSimilarity(semanticSimilarityRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#semanticSimilarity")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#semanticSimilarity")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **semanticSimilarityRequest** | [**SemanticSimilarityRequest**](SemanticSimilarityRequest.md)|  | |

### Return type

[**SemanticSimilarityResponse**](SemanticSimilarityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="tokenCount"></a>
# **tokenCount**
> TokenCountResponse tokenCount(tokenCountRequest)

Count tokens in a text

The tokenCount endpoint designed for counting tokens in text data.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val tokenCountRequest : TokenCountRequest = {"name":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]} // TokenCountRequest | 
try {
    val result : TokenCountResponse = apiInstance.tokenCount(tokenCountRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#tokenCount")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#tokenCount")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **tokenCountRequest** | [**TokenCountRequest**](TokenCountRequest.md)|  | |

### Return type

[**TokenCountResponse**](TokenCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="tokenize"></a>
# **tokenize**
> TokenizerResponse tokenize(tokenizerRequest)

Converts data to a integer token array

The tokenizer endpoint designed for transforming textual data into integer tokens.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val tokenizerRequest : TokenizerRequest = {"name":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]} // TokenizerRequest | 
try {
    val result : TokenizerResponse = apiInstance.tokenize(tokenizerRequest)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#tokenize")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#tokenize")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **tokenizerRequest** | [**TokenizerRequest**](TokenizerRequest.md)|  | |

### Return type

[**TokenizerResponse**](TokenizerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="transcriptionSynchronous"></a>
# **transcriptionSynchronous**
> TranscriptionResponse transcriptionSynchronous(files, model, language, prompt, temperature, splitOnWord, languageDetection, enableNoiseReduction)

Synchronous transcribe audio

The audio transcription endpoint is a specialized web service designed to convert spoken words from audio or video files into written text. This technology relies on advanced speech recognition algorithms to accurately transcribe the content of audio or video recordings. The endpoint typically accepts files in various formats, such as MP3, WAV for audio, and MP4, AVI for video, among others. Users can upload their files directly to the service, which then processes the audio track to extract the spoken words.  The transcription process involves several steps, including noise reduction to improve audio clarity, speaker diarization to identify and differentiate between different speakers, and the actual speech-to-text conversion. The result is a detailed transcript that captures the spoken content, often including timestamps and speaker labels for easy reference.  This service is particularly useful for journalists, researchers, podcasters, and professionals who need to convert meetings, interviews, lectures, or presentations into written form for analysis, sharing, or archival purposes. The endpoint may offer additional features like language detection, support for multiple languages, and customization options to improve transcription accuracy based on specific vocabulary or industry terms.  To use the audio transcription endpoint, developers typically integrate it into applications via API calls. These calls specify the file to be transcribed and any additional parameters required by the service, such as language preference.   Upon completion, the service returns the transcription in a JSON text format, which can then be displayed, stored, or further processed according to the user&#39;s needs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DataExtractionApi()
val files : kotlin.collections.List<java.io.File> = /path/to/file.txt // kotlin.collections.List<java.io.File> | The file object to ingest.
val model : kotlin.String = model_example // kotlin.String | Model to use for transcription (Optional, default = Base)
val language : kotlin.String = language_example // kotlin.String | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional)
val prompt : kotlin.String = prompt_example // kotlin.String | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional)
val temperature : kotlin.Double = 1.2 // kotlin.Double | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M)
val splitOnWord : kotlin.Boolean = true // kotlin.Boolean | Split into word segments. (optional, default is false)
val languageDetection : kotlin.Boolean = true // kotlin.Boolean | Enable transcription language detection (Optional. default is false)
val enableNoiseReduction : kotlin.Boolean = true // kotlin.Boolean | Enable noise reduction from audio stream before transcription (Optional. default is false)
try {
    val result : TranscriptionResponse = apiInstance.transcriptionSynchronous(files, model, language, prompt, temperature, splitOnWord, languageDetection, enableNoiseReduction)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling DataExtractionApi#transcriptionSynchronous")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DataExtractionApi#transcriptionSynchronous")
    e.printStackTrace()
}
```

### Parameters
| **files** | **kotlin.collections.List&lt;java.io.File&gt;**| The file object to ingest. | |
| **model** | **kotlin.String**| Model to use for transcription (Optional, default &#x3D; Base) | [optional] [enum: tiny, tiny.en, base, base.en, small, small.en, medium, medium.en, large_v1, large_v2, large_v3] |
| **language** | **kotlin.String**| The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] |
| **prompt** | **kotlin.String**| An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | [optional] |
| **temperature** | **kotlin.Double**| The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [optional] [default to 0.0] |
| **splitOnWord** | **kotlin.Boolean**| Split into word segments. (optional, default is false) | [optional] [default to false] |
| **languageDetection** | **kotlin.Boolean**| Enable transcription language detection (Optional. default is false) | [optional] [default to false] |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **enableNoiseReduction** | **kotlin.Boolean**| Enable noise reduction from audio stream before transcription (Optional. default is false) | [optional] [default to false] |

### Return type

[**TranscriptionResponse**](TranscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/problem+json

