# StudioAiEmpowerLabs.DataExtractionApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiExtractThematicSimilarityClusterPost**](DataExtractionApi.md#apiExtractThematicSimilarityClusterPost) | **POST** /api/extract/thematic-similarity-cluster | Generate thematic similarity clusters using the K-Means algorithm
[**embedding**](DataExtractionApi.md#embedding) | **POST** /api/extract/embed | Converts data to a numerical vector array
[**keywordExtraction**](DataExtractionApi.md#keywordExtraction) | **POST** /api/extract/keywords | Performs keyword extraction on source text
[**namedEntityRecognition**](DataExtractionApi.md#namedEntityRecognition) | **POST** /api/extract/entities | Extracts named entities from provided text
[**semanticSimilarity**](DataExtractionApi.md#semanticSimilarity) | **POST** /api/extract/similarity | Generate semantic similarity queries from text
[**tokenCount**](DataExtractionApi.md#tokenCount) | **POST** /api/extract/tokenCount | Count tokens in a text
[**tokenize**](DataExtractionApi.md#tokenize) | **POST** /api/extract/tokenize | Converts data to a integer token array
[**transcriptionSynchronous**](DataExtractionApi.md#transcriptionSynchronous) | **POST** /api/extract/transcription | Synchronous transcribe audio



## apiExtractThematicSimilarityClusterPost

> KMeansCluster apiExtractThematicSimilarityClusterPost(apiExtractThematicSimilarityClusterPostRequest)

Generate thematic similarity clusters using the K-Means algorithm

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let apiExtractThematicSimilarityClusterPostRequest = new StudioAiEmpowerLabs.ApiExtractThematicSimilarityClusterPostRequest(); // ApiExtractThematicSimilarityClusterPostRequest | 
apiInstance.apiExtractThematicSimilarityClusterPost(apiExtractThematicSimilarityClusterPostRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiExtractThematicSimilarityClusterPostRequest** | [**ApiExtractThematicSimilarityClusterPostRequest**](ApiExtractThematicSimilarityClusterPostRequest.md)|  | 

### Return type

[**KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/csv, application/problem+json


## embedding

> EmbeddingResponse embedding(embeddingRequest)

Converts data to a numerical vector array

The embedding endpoint is a sophisticated API designed for transforming textual data into high-dimensional vectors, facilitating a wide array of natural language processing (NLP) tasks. This transformation process encodes the semantic properties and contextual meanings of the input text into a vector space, enabling machines to understand and process language in a manner analogous to human comprehension.  ## Core Features:  * Semantic Encoding: Leverages advanced machine learning models, particularly those based on transformer architectures, to capture the deep semantic and syntactic nuances of the input text. This ensures that similar words and phrases are positioned closely in the vector space, reflecting their semantic proximity. * High-Dimensional Representation: Transforms texts into vectors in a high-dimensional space, typically ranging from hundreds to thousands of dimensions. This rich representation captures a comprehensive spectrum of linguistic features and relationships. * Scalability: Engineered to handle a wide range of text sizes, from short tweets to extensive documents, without compromising on the accuracy of the vector representations.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let embeddingRequest = {"model":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]}; // EmbeddingRequest | 
apiInstance.embedding(embeddingRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **embeddingRequest** | [**EmbeddingRequest**](EmbeddingRequest.md)|  | 

### Return type

[**EmbeddingResponse**](EmbeddingResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## keywordExtraction

> KeywordExtractionResponse keywordExtraction(keywordExtractionRequestBody)

Performs keyword extraction on source text

This endpoint accepts a string of text and returns a list of key words or phrases that best describe the content of the text. This can be used for tagging, summarizing, indexing, or categorizing content.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let keywordExtractionRequestBody = {"text":"Hello world! Get in touch with AI Empower Labs from Malmö Sweden via www.AIEmpowerLabs.com or email info@AIEmpowerLabs.com"}; // KeywordExtractionRequestBody | 
apiInstance.keywordExtraction(keywordExtractionRequestBody, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keywordExtractionRequestBody** | [**KeywordExtractionRequestBody**](KeywordExtractionRequestBody.md)|  | 

### Return type

[**KeywordExtractionResponse**](KeywordExtractionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## namedEntityRecognition

> NamedEntityRecognitionResponse namedEntityRecognition(namedEntityRecognitionRequest)

Extracts named entities from provided text

This endpoint accepts a string of text and returns a list of identified entities classified into categories such as email, location, organisation, etc.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let namedEntityRecognitionRequest = {"text":"Hello world! Get in touch with AI Empower Labs from Malmö Sweden via www.AIEmpowerLabs.com or email info@AIEmpowerLabs.com","entities":["email","location","organisation","url"]}; // NamedEntityRecognitionRequest | 
apiInstance.namedEntityRecognition(namedEntityRecognitionRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **namedEntityRecognitionRequest** | [**NamedEntityRecognitionRequest**](NamedEntityRecognitionRequest.md)|  | 

### Return type

[**NamedEntityRecognitionResponse**](NamedEntityRecognitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## semanticSimilarity

> SemanticSimilarityResponse semanticSimilarity(semanticSimilarityRequest)

Generate semantic similarity queries from text

Upon receiving a user-defined query and a set of texts, the endpoint processes this information through its semantic analysis engine. This engine leverages state-of-the-art machine learning models, such as transformer-based architectures, to encode the texts and the query into high-dimensional vectors. By operating in this semantic space, it can accurately measure the distances between the query vector and each of the text vectors, reflecting how closely the meanings align.  Use Cases:  * Content Discovery: Helps users find articles, posts, or documents that are most relevant to their query.  * Customer Support: Automatically matches customer queries to the most relevant FAQs or support documents.  * Research and Study: Assists researchers in quickly finding academic papers or resources that are closely related to their field of inquiry.  By utilizing the semantic similarity endpoint, organizations and individuals can greatly enhance the efficiency and effectiveness of their information retrieval processes, ensuring that users are connected with the content most pertinent to their needs.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let semanticSimilarityRequest = {"query":"Machine learning is so easy","documents":["Deep learning is so straightforward","This is so difficult, like rocket science","I can't believe how much I struggled with this"],"model":"multilingual-e5-large"}; // SemanticSimilarityRequest | 
apiInstance.semanticSimilarity(semanticSimilarityRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semanticSimilarityRequest** | [**SemanticSimilarityRequest**](SemanticSimilarityRequest.md)|  | 

### Return type

[**SemanticSimilarityResponse**](SemanticSimilarityResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## tokenCount

> TokenCountResponse tokenCount(tokenCountRequest)

Count tokens in a text

The tokenCount endpoint designed for counting tokens in text data.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let tokenCountRequest = {"name":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]}; // TokenCountRequest | 
apiInstance.tokenCount(tokenCountRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenCountRequest** | [**TokenCountRequest**](TokenCountRequest.md)|  | 

### Return type

[**TokenCountResponse**](TokenCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## tokenize

> TokenizerResponse tokenize(tokenizerRequest)

Converts data to a integer token array

The tokenizer endpoint designed for transforming textual data into integer tokens.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let tokenizerRequest = {"name":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]}; // TokenizerRequest | 
apiInstance.tokenize(tokenizerRequest, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizerRequest** | [**TokenizerRequest**](TokenizerRequest.md)|  | 

### Return type

[**TokenizerResponse**](TokenizerResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## transcriptionSynchronous

> TranscriptionResponse transcriptionSynchronous(files, opts)

Synchronous transcribe audio

The audio transcription endpoint is a specialized web service designed to convert spoken words from audio or video files into written text. This technology relies on advanced speech recognition algorithms to accurately transcribe the content of audio or video recordings. The endpoint typically accepts files in various formats, such as MP3, WAV for audio, and MP4, AVI for video, among others. Users can upload their files directly to the service, which then processes the audio track to extract the spoken words.  The transcription process involves several steps, including noise reduction to improve audio clarity, speaker diarization to identify and differentiate between different speakers, and the actual speech-to-text conversion. The result is a detailed transcript that captures the spoken content, often including timestamps and speaker labels for easy reference.  This service is particularly useful for journalists, researchers, podcasters, and professionals who need to convert meetings, interviews, lectures, or presentations into written form for analysis, sharing, or archival purposes. The endpoint may offer additional features like language detection, support for multiple languages, and customization options to improve transcription accuracy based on specific vocabulary or industry terms.  To use the audio transcription endpoint, developers typically integrate it into applications via API calls. These calls specify the file to be transcribed and any additional parameters required by the service, such as language preference.   Upon completion, the service returns the transcription in a JSON text format, which can then be displayed, stored, or further processed according to the user&#39;s needs.

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.DataExtractionApi();
let files = ["null"]; // [File] | The file object to ingest.
let opts = {
  'model': "model_example", // String | Model to use for transcription (Optional, default = Base)
  'language': "language_example", // String | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional)
  'prompt': "prompt_example", // String | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional)
  'temperature': 0, // Number | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M)
  'splitOnWord': false, // Boolean | Split into word segments. (optional, default is false)
  'languageDetection': false, // Boolean | Enable transcription language detection (Optional. default is false)
  'enableNoiseReduction': false // Boolean | Enable noise reduction from audio stream before transcription (Optional. default is false)
};
apiInstance.transcriptionSynchronous(files, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **[File]**| The file object to ingest. | 
 **model** | **String**| Model to use for transcription (Optional, default &#x3D; Base) | [optional] 
 **language** | **String**| The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] 
 **prompt** | **String**| An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | [optional] 
 **temperature** | **Number**| The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [optional] [default to 0]
 **splitOnWord** | **Boolean**| Split into word segments. (optional, default is false) | [optional] [default to false]
 **languageDetection** | **Boolean**| Enable transcription language detection (Optional. default is false) | [optional] [default to false]
 **enableNoiseReduction** | **Boolean**| Enable noise reduction from audio stream before transcription (Optional. default is false) | [optional] [default to false]

### Return type

[**TranscriptionResponse**](TranscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json

