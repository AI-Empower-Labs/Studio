# openapi_client.DataExtractionApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_extract_thematic_similarity_cluster_post**](DataExtractionApi.md#api_extract_thematic_similarity_cluster_post) | **POST** /api/extract/thematic-similarity-cluster | Generate thematic similarity clusters using the K-Means algorithm
[**embedding**](DataExtractionApi.md#embedding) | **POST** /api/extract/embed | Converts data to a numerical vector array
[**keyword_extraction**](DataExtractionApi.md#keyword_extraction) | **POST** /api/extract/keywords | Performs keyword extraction on source text
[**named_entity_recognition**](DataExtractionApi.md#named_entity_recognition) | **POST** /api/extract/entities | Extracts named entities from provided text
[**semantic_similarity**](DataExtractionApi.md#semantic_similarity) | **POST** /api/extract/similarity | Generate semantic similarity queries from text
[**token_count**](DataExtractionApi.md#token_count) | **POST** /api/extract/tokenCount | Count tokens in a text
[**tokenize**](DataExtractionApi.md#tokenize) | **POST** /api/extract/tokenize | Converts data to a integer token array
[**transcription_synchronous**](DataExtractionApi.md#transcription_synchronous) | **POST** /api/extract/transcription | Synchronous transcribe audio


# **api_extract_thematic_similarity_cluster_post**
> KMeansCluster api_extract_thematic_similarity_cluster_post(api_extract_thematic_similarity_cluster_post_request)

Generate thematic similarity clusters using the K-Means algorithm

### Example


```python
import openapi_client
from openapi_client.models.api_extract_thematic_similarity_cluster_post_request import ApiExtractThematicSimilarityClusterPostRequest
from openapi_client.models.k_means_cluster import KMeansCluster
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    api_extract_thematic_similarity_cluster_post_request = openapi_client.ApiExtractThematicSimilarityClusterPostRequest() # ApiExtractThematicSimilarityClusterPostRequest | 

    try:
        # Generate thematic similarity clusters using the K-Means algorithm
        api_response = api_instance.api_extract_thematic_similarity_cluster_post(api_extract_thematic_similarity_cluster_post_request)
        print("The response of DataExtractionApi->api_extract_thematic_similarity_cluster_post:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->api_extract_thematic_similarity_cluster_post: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **api_extract_thematic_similarity_cluster_post_request** | [**ApiExtractThematicSimilarityClusterPostRequest**](ApiExtractThematicSimilarityClusterPostRequest.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **embedding**
> EmbeddingResponse embedding(embedding_request)

Converts data to a numerical vector array

The embedding endpoint is a sophisticated API designed for transforming textual data into high-dimensional vectors, facilitating a wide array of natural language processing (NLP) tasks. This transformation process encodes the semantic properties and contextual meanings of the input text into a vector space, enabling machines to understand and process language in a manner analogous to human comprehension.

## Core Features:

* Semantic Encoding: Leverages advanced machine learning models, particularly those based on transformer architectures, to capture the deep semantic and syntactic nuances of the input text. This ensures that similar words and phrases are positioned closely in the vector space, reflecting their semantic proximity.
* High-Dimensional Representation: Transforms texts into vectors in a high-dimensional space, typically ranging from hundreds to thousands of dimensions. This rich representation captures a comprehensive spectrum of linguistic features and relationships.
* Scalability: Engineered to handle a wide range of text sizes, from short tweets to extensive documents, without compromising on the accuracy of the vector representations.

### Example


```python
import openapi_client
from openapi_client.models.embedding_request import EmbeddingRequest
from openapi_client.models.embedding_response import EmbeddingResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    embedding_request = {"model":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]} # EmbeddingRequest | 

    try:
        # Converts data to a numerical vector array
        api_response = api_instance.embedding(embedding_request)
        print("The response of DataExtractionApi->embedding:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->embedding: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **embedding_request** | [**EmbeddingRequest**](EmbeddingRequest.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **keyword_extraction**
> KeywordExtractionResponse keyword_extraction(keyword_extraction_request_body)

Performs keyword extraction on source text

This endpoint accepts a string of text and returns a list of key words or phrases that best describe the content of the text. This can be used for tagging, summarizing, indexing, or categorizing content.

### Example


```python
import openapi_client
from openapi_client.models.keyword_extraction_request_body import KeywordExtractionRequestBody
from openapi_client.models.keyword_extraction_response import KeywordExtractionResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    keyword_extraction_request_body = {"text":"Hello world! Get in touch with AI Empower Labs from Malmö Sweden via www.AIEmpowerLabs.com or email info@AIEmpowerLabs.com"} # KeywordExtractionRequestBody | 

    try:
        # Performs keyword extraction on source text
        api_response = api_instance.keyword_extraction(keyword_extraction_request_body)
        print("The response of DataExtractionApi->keyword_extraction:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->keyword_extraction: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword_extraction_request_body** | [**KeywordExtractionRequestBody**](KeywordExtractionRequestBody.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **named_entity_recognition**
> NamedEntityRecognitionResponse named_entity_recognition(named_entity_recognition_request)

Extracts named entities from provided text

This endpoint accepts a string of text and returns a list of identified entities classified into categories such as email, location, organisation, etc.

### Example


```python
import openapi_client
from openapi_client.models.named_entity_recognition_request import NamedEntityRecognitionRequest
from openapi_client.models.named_entity_recognition_response import NamedEntityRecognitionResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    named_entity_recognition_request = {"text":"Hello world! Get in touch with AI Empower Labs from Malmö Sweden via www.AIEmpowerLabs.com or email info@AIEmpowerLabs.com","entities":["email","location","organisation","url"]} # NamedEntityRecognitionRequest | 

    try:
        # Extracts named entities from provided text
        api_response = api_instance.named_entity_recognition(named_entity_recognition_request)
        print("The response of DataExtractionApi->named_entity_recognition:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->named_entity_recognition: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **named_entity_recognition_request** | [**NamedEntityRecognitionRequest**](NamedEntityRecognitionRequest.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **semantic_similarity**
> SemanticSimilarityResponse semantic_similarity(semantic_similarity_request)

Generate semantic similarity queries from text

Upon receiving a user-defined query and a set of texts, the endpoint processes this information through its semantic analysis engine. This engine leverages state-of-the-art machine learning models, such as transformer-based architectures, to encode the texts and the query into high-dimensional vectors. By operating in this semantic space, it can accurately measure the distances between the query vector and each of the text vectors, reflecting how closely the meanings align.

Use Cases:

* Content Discovery: Helps users find articles, posts, or documents that are most relevant to their query.

* Customer Support: Automatically matches customer queries to the most relevant FAQs or support documents.

* Research and Study: Assists researchers in quickly finding academic papers or resources that are closely related to their field of inquiry.

By utilizing the semantic similarity endpoint, organizations and individuals can greatly enhance the efficiency and effectiveness of their information retrieval processes, ensuring that users are connected with the content most pertinent to their needs.

### Example


```python
import openapi_client
from openapi_client.models.semantic_similarity_request import SemanticSimilarityRequest
from openapi_client.models.semantic_similarity_response import SemanticSimilarityResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    semantic_similarity_request = {"query":"Machine learning is so easy","documents":["Deep learning is so straightforward","This is so difficult, like rocket science","I can't believe how much I struggled with this"],"model":"multilingual-e5-large"} # SemanticSimilarityRequest | 

    try:
        # Generate semantic similarity queries from text
        api_response = api_instance.semantic_similarity(semantic_similarity_request)
        print("The response of DataExtractionApi->semantic_similarity:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->semantic_similarity: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semantic_similarity_request** | [**SemanticSimilarityRequest**](SemanticSimilarityRequest.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **token_count**
> TokenCountResponse token_count(token_count_request)

Count tokens in a text

The tokenCount endpoint designed for counting tokens in text data.

### Example


```python
import openapi_client
from openapi_client.models.token_count_request import TokenCountRequest
from openapi_client.models.token_count_response import TokenCountResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    token_count_request = {"name":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]} # TokenCountRequest | 

    try:
        # Count tokens in a text
        api_response = api_instance.token_count(token_count_request)
        print("The response of DataExtractionApi->token_count:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->token_count: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token_count_request** | [**TokenCountRequest**](TokenCountRequest.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tokenize**
> TokenizerResponse tokenize(tokenizer_request)

Converts data to a integer token array

The tokenizer endpoint designed for transforming textual data into integer tokens.

### Example


```python
import openapi_client
from openapi_client.models.tokenizer_request import TokenizerRequest
from openapi_client.models.tokenizer_response import TokenizerResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    tokenizer_request = {"name":"multilingual-e5-large","text":["Hello world","AI Empower Labs rocks!"]} # TokenizerRequest | 

    try:
        # Converts data to a integer token array
        api_response = api_instance.tokenize(tokenizer_request)
        print("The response of DataExtractionApi->tokenize:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->tokenize: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenizer_request** | [**TokenizerRequest**](TokenizerRequest.md)|  | 

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transcription_synchronous**
> TranscriptionResponse transcription_synchronous(files, model=model, language=language, prompt=prompt, temperature=temperature, split_on_word=split_on_word, language_detection=language_detection, enable_noise_reduction=enable_noise_reduction)

Synchronous transcribe audio

The audio transcription endpoint is a specialized web service designed to convert spoken words from audio or video files into written text. This technology relies on advanced speech recognition algorithms to accurately transcribe the content of audio or video recordings. The endpoint typically accepts files in various formats, such as MP3, WAV for audio, and MP4, AVI for video, among others. Users can upload their files directly to the service, which then processes the audio track to extract the spoken words.

The transcription process involves several steps, including noise reduction to improve audio clarity, speaker diarization to identify and differentiate between different speakers, and the actual speech-to-text conversion. The result is a detailed transcript that captures the spoken content, often including timestamps and speaker labels for easy reference.

This service is particularly useful for journalists, researchers, podcasters, and professionals who need to convert meetings, interviews, lectures, or presentations into written form for analysis, sharing, or archival purposes. The endpoint may offer additional features like language detection, support for multiple languages, and customization options to improve transcription accuracy based on specific vocabulary or industry terms.

To use the audio transcription endpoint, developers typically integrate it into applications via API calls. These calls specify the file to be transcribed and any additional parameters required by the service, such as language preference. 

Upon completion, the service returns the transcription in a JSON text format, which can then be displayed, stored, or further processed according to the user's needs.

### Example


```python
import openapi_client
from openapi_client.models.transcription_response import TranscriptionResponse
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
    api_instance = openapi_client.DataExtractionApi(api_client)
    files = None # List[bytearray] | The file object to ingest.
    model = 'model_example' # str | Model to use for transcription (Optional, default = Base) (optional)
    language = 'language_example' # str | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) (optional)
    prompt = 'prompt_example' # str | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional) (optional)
    temperature = 0 # float | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) (optional) (default to 0)
    split_on_word = False # bool | Split into word segments. (optional, default is false) (optional) (default to False)
    language_detection = False # bool | Enable transcription language detection (Optional. default is false) (optional) (default to False)
    enable_noise_reduction = False # bool | Enable noise reduction from audio stream before transcription (Optional. default is false) (optional) (default to False)

    try:
        # Synchronous transcribe audio
        api_response = api_instance.transcription_synchronous(files, model=model, language=language, prompt=prompt, temperature=temperature, split_on_word=split_on_word, language_detection=language_detection, enable_noise_reduction=enable_noise_reduction)
        print("The response of DataExtractionApi->transcription_synchronous:\n")
        pprint(api_response)
    except Exception as e:
        print("Exception when calling DataExtractionApi->transcription_synchronous: %s\n" % e)
```



### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | **List[bytearray]**| The file object to ingest. | 
 **model** | **str**| Model to use for transcription (Optional, default &#x3D; Base) | [optional] 
 **language** | **str**| The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) | [optional] 
 **prompt** | **str**| An optional text to guide the model&#39;s style or continue a previous audio segment. The prompt should match the audio language.  (optional) | [optional] 
 **temperature** | **float**| The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) | [optional] [default to 0]
 **split_on_word** | **bool**| Split into word segments. (optional, default is false) | [optional] [default to False]
 **language_detection** | **bool**| Enable transcription language detection (Optional. default is false) | [optional] [default to False]
 **enable_noise_reduction** | **bool**| Enable noise reduction from audio stream before transcription (Optional. default is false) | [optional] [default to False]

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
**200** | OK |  -  |
**400** | Invalid request parameters or validation error. |  -  |
**429** | Request rate limit exceeded. |  -  |
**500** | Internal server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

