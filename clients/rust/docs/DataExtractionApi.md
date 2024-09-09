# \DataExtractionApi

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



## api_extract_thematic_similarity_cluster_post

> models::KMeansCluster api_extract_thematic_similarity_cluster_post(api_extract_thematic_similarity_cluster_post_request)
Generate thematic similarity clusters using the K-Means algorithm

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**api_extract_thematic_similarity_cluster_post_request** | [**ApiExtractThematicSimilarityClusterPostRequest**](ApiExtractThematicSimilarityClusterPostRequest.md) |  | [required] |

### Return type

[**models::KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/csv, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## embedding

> models::EmbeddingResponse embedding(embedding_request)
Converts data to a numerical vector array

The embedding endpoint is a sophisticated API designed for transforming textual data into high-dimensional vectors, facilitating a wide array of natural language processing (NLP) tasks. This transformation process encodes the semantic properties and contextual meanings of the input text into a vector space, enabling machines to understand and process language in a manner analogous to human comprehension.  ## Core Features:  * Semantic Encoding: Leverages advanced machine learning models, particularly those based on transformer architectures, to capture the deep semantic and syntactic nuances of the input text. This ensures that similar words and phrases are positioned closely in the vector space, reflecting their semantic proximity. * High-Dimensional Representation: Transforms texts into vectors in a high-dimensional space, typically ranging from hundreds to thousands of dimensions. This rich representation captures a comprehensive spectrum of linguistic features and relationships. * Scalability: Engineered to handle a wide range of text sizes, from short tweets to extensive documents, without compromising on the accuracy of the vector representations.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**embedding_request** | [**EmbeddingRequest**](EmbeddingRequest.md) |  | [required] |

### Return type

[**models::EmbeddingResponse**](EmbeddingResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## keyword_extraction

> models::KeywordExtractionResponse keyword_extraction(keyword_extraction_request_body)
Performs keyword extraction on source text

This endpoint accepts a string of text and returns a list of key words or phrases that best describe the content of the text. This can be used for tagging, summarizing, indexing, or categorizing content.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**keyword_extraction_request_body** | [**KeywordExtractionRequestBody**](KeywordExtractionRequestBody.md) |  | [required] |

### Return type

[**models::KeywordExtractionResponse**](KeywordExtractionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## named_entity_recognition

> models::NamedEntityRecognitionResponse named_entity_recognition(named_entity_recognition_request)
Extracts named entities from provided text

This endpoint accepts a string of text and returns a list of identified entities classified into categories such as email, location, organisation, etc.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**named_entity_recognition_request** | [**NamedEntityRecognitionRequest**](NamedEntityRecognitionRequest.md) |  | [required] |

### Return type

[**models::NamedEntityRecognitionResponse**](NamedEntityRecognitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_similarity

> models::SemanticSimilarityResponse semantic_similarity(semantic_similarity_request)
Generate semantic similarity queries from text

Upon receiving a user-defined query and a set of texts, the endpoint processes this information through its semantic analysis engine. This engine leverages state-of-the-art machine learning models, such as transformer-based architectures, to encode the texts and the query into high-dimensional vectors. By operating in this semantic space, it can accurately measure the distances between the query vector and each of the text vectors, reflecting how closely the meanings align.  Use Cases:  * Content Discovery: Helps users find articles, posts, or documents that are most relevant to their query.  * Customer Support: Automatically matches customer queries to the most relevant FAQs or support documents.  * Research and Study: Assists researchers in quickly finding academic papers or resources that are closely related to their field of inquiry.  By utilizing the semantic similarity endpoint, organizations and individuals can greatly enhance the efficiency and effectiveness of their information retrieval processes, ensuring that users are connected with the content most pertinent to their needs.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**semantic_similarity_request** | [**SemanticSimilarityRequest**](SemanticSimilarityRequest.md) |  | [required] |

### Return type

[**models::SemanticSimilarityResponse**](SemanticSimilarityResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## token_count

> models::TokenCountResponse token_count(token_count_request)
Count tokens in a text

The tokenCount endpoint designed for counting tokens in text data.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**token_count_request** | [**TokenCountRequest**](TokenCountRequest.md) |  | [required] |

### Return type

[**models::TokenCountResponse**](TokenCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## tokenize

> models::TokenizerResponse tokenize(tokenizer_request)
Converts data to a integer token array

The tokenizer endpoint designed for transforming textual data into integer tokens.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**tokenizer_request** | [**TokenizerRequest**](TokenizerRequest.md) |  | [required] |

### Return type

[**models::TokenizerResponse**](TokenizerResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## transcription_synchronous

> models::TranscriptionResponse transcription_synchronous(files, model, language, prompt, temperature, split_on_word, language_detection, enable_noise_reduction)
Synchronous transcribe audio

The audio transcription endpoint is a specialized web service designed to convert spoken words from audio or video files into written text. This technology relies on advanced speech recognition algorithms to accurately transcribe the content of audio or video recordings. The endpoint typically accepts files in various formats, such as MP3, WAV for audio, and MP4, AVI for video, among others. Users can upload their files directly to the service, which then processes the audio track to extract the spoken words.  The transcription process involves several steps, including noise reduction to improve audio clarity, speaker diarization to identify and differentiate between different speakers, and the actual speech-to-text conversion. The result is a detailed transcript that captures the spoken content, often including timestamps and speaker labels for easy reference.  This service is particularly useful for journalists, researchers, podcasters, and professionals who need to convert meetings, interviews, lectures, or presentations into written form for analysis, sharing, or archival purposes. The endpoint may offer additional features like language detection, support for multiple languages, and customization options to improve transcription accuracy based on specific vocabulary or industry terms.  To use the audio transcription endpoint, developers typically integrate it into applications via API calls. These calls specify the file to be transcribed and any additional parameters required by the service, such as language preference.   Upon completion, the service returns the transcription in a JSON text format, which can then be displayed, stored, or further processed according to the user's needs.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**files** | [**Vec<std::path::PathBuf>**](std::path::PathBuf.md) | The file object to ingest. | [required] |
**model** | Option<**String**> | Model to use for transcription (Optional, default = Base) |  |
**language** | Option<**String**> | The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.  (optional) |  |
**prompt** | Option<**String**> | An optional text to guide the model's style or continue a previous audio segment. The prompt should match the audio language.  (optional) |  |
**temperature** | Option<**f64**> | The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (optional, default to 0M) |  |[default to 0]
**split_on_word** | Option<**bool**> | Split into word segments. (optional, default is false) |  |[default to false]
**language_detection** | Option<**bool**> | Enable transcription language detection (Optional. default is false) |  |[default to false]
**enable_noise_reduction** | Option<**bool**> | Enable noise reduction from audio stream before transcription (Optional. default is false) |  |[default to false]

### Return type

[**models::TranscriptionResponse**](TranscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

