# Go API client for openapi

# Studio API Documentation

## Introduction
Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.

Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.

Support and Feedback
We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.

Terms of Use
Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.

## Overview
This API client was generated by the [OpenAPI Generator](https://openapi-generator.tech) project.  By using the [OpenAPI-spec](https://www.openapis.org/) from a remote server, you can easily generate an API client.

- API version: v1
- Package version: 1.0.0
- Generator version: 7.7.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.GoClientCodegen
For more information, please visit [https://www.AIEmpowerLabs.com](https://www.AIEmpowerLabs.com)

## Installation

Install the following dependencies:

```sh
go get github.com/stretchr/testify/assert
go get golang.org/x/net/context
```

Put the package under your project folder and add the following in import:

```go
import openapi "github.com/GIT_USER_ID/GIT_REPO_ID"
```

To use a proxy, set the environment variable `HTTP_PROXY`:

```go
os.Setenv("HTTP_PROXY", "http://proxy_name:proxy_port")
```

## Configuration of Server URL

Default configuration comes with `Servers` field that contains server objects as defined in the OpenAPI specification.

### Select Server Configuration

For using other server than the one defined on index 0 set context value `openapi.ContextServerIndex` of type `int`.

```go
ctx := context.WithValue(context.Background(), openapi.ContextServerIndex, 1)
```

### Templated Server URL

Templated server URL is formatted using default variables from configuration or from context value `openapi.ContextServerVariables` of type `map[string]string`.

```go
ctx := context.WithValue(context.Background(), openapi.ContextServerVariables, map[string]string{
	"basePath": "v2",
})
```

Note, enum values are always validated and all unused variables are silently ignored.

### URLs Configuration per Operation

Each operation can use different server URL defined using `OperationServers` map in the `Configuration`.
An operation is uniquely identified by `"{classname}Service.{nickname}"` string.
Similar rules for overriding default operation server index and variables applies by using `openapi.ContextOperationServerIndices` and `openapi.ContextOperationServerVariables` context maps.

```go
ctx := context.WithValue(context.Background(), openapi.ContextOperationServerIndices, map[string]int{
	"{classname}Service.{nickname}": 2,
})
ctx = context.WithValue(context.Background(), openapi.ContextOperationServerVariables, map[string]map[string]string{
	"{classname}Service.{nickname}": {
		"port": "8443",
	},
})
```

## Documentation for API Endpoints

All URIs are relative to *https://studio.aiempowerlabs.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataExtractionAPI* | [**Embedding**](docs/DataExtractionAPI.md#embedding) | **Post** /api/extract/embed | Converts data to a numerical vector array
*DataExtractionAPI* | [**KeywordExtraction**](docs/DataExtractionAPI.md#keywordextraction) | **Post** /api/extract/keywords | Performs keyword extraction on source text
*DataExtractionAPI* | [**NamedEntityRecognition**](docs/DataExtractionAPI.md#namedentityrecognition) | **Post** /api/extract/entities | Extracts named entities from provided text
*DataExtractionAPI* | [**SemanticSimilarity**](docs/DataExtractionAPI.md#semanticsimilarity) | **Post** /api/extract/similarity | Generate semantic similarity queries from text
*DataExtractionAPI* | [**TokenCount**](docs/DataExtractionAPI.md#tokencount) | **Post** /api/extract/tokenCount | Count tokens in a text
*DataExtractionAPI* | [**Tokenize**](docs/DataExtractionAPI.md#tokenize) | **Post** /api/extract/tokenize | Converts data to a integer token array
*DataExtractionAPI* | [**TranscriptionSynchronous**](docs/DataExtractionAPI.md#transcriptionsynchronous) | **Post** /api/extract/transcription | Synchronous transcribe audio
*KernelMemoryAPI* | [**KernelMemoryAsk**](docs/KernelMemoryAPI.md#kernelmemoryask) | **Post** /api/kernelmemory/ask | Query documents and forward result to LLM
*KernelMemoryAPI* | [**KernelMemoryDelete**](docs/KernelMemoryAPI.md#kernelmemorydelete) | **Delete** /api/kernelmemory/documents | Delete document from specific index
*KernelMemoryAPI* | [**KernelMemoryDeleteIndex**](docs/KernelMemoryAPI.md#kernelmemorydeleteindex) | **Delete** /api/kernelmemory/indexes | Delete index
*KernelMemoryAPI* | [**KernelMemoryGetIndex**](docs/KernelMemoryAPI.md#kernelmemorygetindex) | **Get** /api/kernelmemory/indexes | List indexes
*KernelMemoryAPI* | [**KernelMemorySearch**](docs/KernelMemoryAPI.md#kernelmemorysearch) | **Post** /api/kernelmemory/search | Search for documents in specific index
*KernelMemoryAPI* | [**KernelMemoryUpload**](docs/KernelMemoryAPI.md#kernelmemoryupload) | **Post** /api/kernelmemory/upload | Upload file for ingestion
*KernelMemoryAPI* | [**KernelMemoryUploadStatus**](docs/KernelMemoryAPI.md#kernelmemoryuploadstatus) | **Get** /api/kernelmemory/upload-status | Get ingestion status for specific document
*LanguageAPI* | [**LanguageDetection**](docs/LanguageAPI.md#languagedetection) | **Get** /api/language/detect | Detects language of a text
*LanguageAPI* | [**LanguageGetLanguageList**](docs/LanguageAPI.md#languagegetlanguagelist) | **Get** /api/language | List of supported languages for translation
*LanguageAPI* | [**LanguageTranslate**](docs/LanguageAPI.md#languagetranslate) | **Post** /api/language/translate | Translation of text from one language to another
*MiscellaneousAPI* | [**GetConfiguration**](docs/MiscellaneousAPI.md#getconfiguration) | **Get** /info | 
*SemanticSearchAPI* | [**SemanticSearchAsk**](docs/SemanticSearchAPI.md#semanticsearchask) | **Post** /api/semantic/ask | 
*SemanticSearchAPI* | [**SemanticSearchDeleteDocument**](docs/SemanticSearchAPI.md#semanticsearchdeletedocument) | **Delete** /api/semantic/{documentId} | 
*SemanticSearchAPI* | [**SemanticSearchDeleteIndex**](docs/SemanticSearchAPI.md#semanticsearchdeleteindex) | **Delete** /api/semantic/index | 
*SemanticSearchAPI* | [**SemanticSearchFileIngestion**](docs/SemanticSearchAPI.md#semanticsearchfileingestion) | **Post** /api/semantic/ingest/file | 
*SemanticSearchAPI* | [**SemanticSearchIngestionStatus**](docs/SemanticSearchAPI.md#semanticsearchingestionstatus) | **Get** /api/semantic/ingest/status | 
*SemanticSearchAPI* | [**SemanticSearchList**](docs/SemanticSearchAPI.md#semanticsearchlist) | **Post** /api/semantic/list | 
*SemanticSearchAPI* | [**SemanticSearchQuery**](docs/SemanticSearchAPI.md#semanticsearchquery) | **Post** /api/semantic/query | 
*SemanticSearchAPI* | [**SemanticSearchRerank**](docs/SemanticSearchAPI.md#semanticsearchrerank) | **Post** /api/semantic/rerank | 
*SemanticSearchAPI* | [**SemanticSearchTextIngestion**](docs/SemanticSearchAPI.md#semanticsearchtextingestion) | **Post** /api/semantic/ingest/text | 
*SemanticSearchAPI* | [**SemanticSearchWebpageIngestion**](docs/SemanticSearchAPI.md#semanticsearchwebpageingestion) | **Post** /api/semantic/ingest/webpage | 
*SemanticSearchAPI* | [**SemanticSearchWordcloud**](docs/SemanticSearchAPI.md#semanticsearchwordcloud) | **Post** /api/semantic/wordcloud | 
*TranscriptionAPI* | [**TranscriptionAsynchronous**](docs/TranscriptionAPI.md#transcriptionasynchronous) | **Post** /api/transcribe/upload | Upload audio file for asynchronous transcription
*TranscriptionAPI* | [**TranscriptionGetById**](docs/TranscriptionAPI.md#transcriptiongetbyid) | **Get** /api/transcribe | Get transcription status and data


## Documentation For Models

 - [AskDocumentRequest](docs/AskDocumentRequest.md)
 - [AskDocumentResponse](docs/AskDocumentResponse.md)
 - [Citation](docs/Citation.md)
 - [DataPipelineStatus](docs/DataPipelineStatus.md)
 - [DeleteAccepted](docs/DeleteAccepted.md)
 - [DetectLanguageResponse](docs/DetectLanguageResponse.md)
 - [DocumentCitation](docs/DocumentCitation.md)
 - [DocumentFilters](docs/DocumentFilters.md)
 - [DocumentPartition](docs/DocumentPartition.md)
 - [EmbeddingRequest](docs/EmbeddingRequest.md)
 - [EmbeddingResponse](docs/EmbeddingResponse.md)
 - [GetLanguageResponse](docs/GetLanguageResponse.md)
 - [HttpValidationProblemDetails](docs/HttpValidationProblemDetails.md)
 - [IndexCollection](docs/IndexCollection.md)
 - [IndexDetails](docs/IndexDetails.md)
 - [IngestDocumentResponse](docs/IngestDocumentResponse.md)
 - [IngestTextDocumentRequest](docs/IngestTextDocumentRequest.md)
 - [IngestWebPageDocumentRequest](docs/IngestWebPageDocumentRequest.md)
 - [KeywordExtractionRequestBody](docs/KeywordExtractionRequestBody.md)
 - [KeywordExtractionResponse](docs/KeywordExtractionResponse.md)
 - [LanguageDetection](docs/LanguageDetection.md)
 - [ListDocumentParameters](docs/ListDocumentParameters.md)
 - [ListDocumentResponse](docs/ListDocumentResponse.md)
 - [MemoryAnswer](docs/MemoryAnswer.md)
 - [MemoryQuery](docs/MemoryQuery.md)
 - [NamedEntityRecognitionRequest](docs/NamedEntityRecognitionRequest.md)
 - [NamedEntityRecognitionResponse](docs/NamedEntityRecognitionResponse.md)
 - [Partition](docs/Partition.md)
 - [ProblemDetails](docs/ProblemDetails.md)
 - [QueryDocumentRequest](docs/QueryDocumentRequest.md)
 - [QueryDocumentResponse](docs/QueryDocumentResponse.md)
 - [ReRankDocument](docs/ReRankDocument.md)
 - [ReRankDocumentsRequest](docs/ReRankDocumentsRequest.md)
 - [ReRankDocumentsResponse](docs/ReRankDocumentsResponse.md)
 - [SearchQuery](docs/SearchQuery.md)
 - [SearchResult](docs/SearchResult.md)
 - [SegmentData](docs/SegmentData.md)
 - [SemanticSimilarityDocument](docs/SemanticSimilarityDocument.md)
 - [SemanticSimilarityRequest](docs/SemanticSimilarityRequest.md)
 - [SemanticSimilarityResponse](docs/SemanticSimilarityResponse.md)
 - [SupportedLanguage](docs/SupportedLanguage.md)
 - [TimeSpan](docs/TimeSpan.md)
 - [TokenCountRequest](docs/TokenCountRequest.md)
 - [TokenCountResponse](docs/TokenCountResponse.md)
 - [TokenizerRequest](docs/TokenizerRequest.md)
 - [TokenizerResponse](docs/TokenizerResponse.md)
 - [TranscriptionAudioUploadResult](docs/TranscriptionAudioUploadResult.md)
 - [TranscriptionResponse](docs/TranscriptionResponse.md)
 - [Translate](docs/Translate.md)
 - [TranslateResponse](docs/TranslateResponse.md)
 - [UploadAccepted](docs/UploadAccepted.md)
 - [WordCloudDocumentRequest](docs/WordCloudDocumentRequest.md)


## Documentation For Authorization

Endpoints do not require authorization.


## Documentation for Utility Methods

Due to the fact that model structure members are all pointers, this package contains
a number of utility functions to easily obtain pointers to values of basic types.
Each of these functions takes a value of the given basic type and returns a pointer to it:

* `PtrBool`
* `PtrInt`
* `PtrInt32`
* `PtrInt64`
* `PtrFloat`
* `PtrFloat32`
* `PtrFloat64`
* `PtrString`
* `PtrTime`

## Author

support@aiempowerlabs.com
