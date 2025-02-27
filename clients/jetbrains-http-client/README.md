# Studio - AI Empower Labs - Jetbrains API Client

## General API description

# Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you&#39;re building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don&#39;t hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.

* API basepath : [https://studio.aiempowerlabs.com](https://studio.aiempowerlabs.com)
* Version : v1

## Documentation for API Endpoints

All URIs are relative to *https://studio.aiempowerlabs.com*, but will link to the `.http` file that contains the endpoint definition.
There may be multiple requests for a single endpoint, one for each example described in the OpenAPI specification.

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataExtractionApi* | [**apiExtractThematicSimilarityClusterPost**](Apis/DataExtractionApi.http#apiextractthematicsimilarityclusterpost) | **POST** /api/extract/thematic-similarity-cluster | Generate thematic similarity clusters using the K-Means algorithm
*DataExtractionApi* | [**embedding**](Apis/DataExtractionApi.http#embedding) | **POST** /api/extract/embed | Converts data to a numerical vector array
*DataExtractionApi* | [**keywordExtraction**](Apis/DataExtractionApi.http#keywordextraction) | **POST** /api/extract/keywords | Performs keyword extraction on source text
*DataExtractionApi* | [**namedEntityRecognition**](Apis/DataExtractionApi.http#namedentityrecognition) | **POST** /api/extract/entities | Extracts named entities from provided text
*DataExtractionApi* | [**semanticSimilarity**](Apis/DataExtractionApi.http#semanticsimilarity) | **POST** /api/extract/similarity | Generate semantic similarity queries from text
*DataExtractionApi* | [**tokenCount**](Apis/DataExtractionApi.http#tokencount) | **POST** /api/extract/tokenCount | Count tokens in a text
*DataExtractionApi* | [**tokenize**](Apis/DataExtractionApi.http#tokenize) | **POST** /api/extract/tokenize | Converts data to a integer token array
*DataExtractionApi* | [**transcriptionSynchronous**](Apis/DataExtractionApi.http#transcriptionsynchronous) | **POST** /api/extract/transcription | Synchronous transcribe audio
*KernelMemoryApi* | [**kernelMemoryAsk**](Apis/KernelMemoryApi.http#kernelmemoryask) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM
*KernelMemoryApi* | [**kernelMemoryDelete**](Apis/KernelMemoryApi.http#kernelmemorydelete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index
*KernelMemoryApi* | [**kernelMemoryDeleteIndex**](Apis/KernelMemoryApi.http#kernelmemorydeleteindex) | **DELETE** /api/kernelmemory/indexes | Delete index
*KernelMemoryApi* | [**kernelMemoryDownload**](Apis/KernelMemoryApi.http#kernelmemorydownload) | **GET** /api/kernelmemory/download | Download specific document
*KernelMemoryApi* | [**kernelMemoryGetIndex**](Apis/KernelMemoryApi.http#kernelmemorygetindex) | **GET** /api/kernelmemory/indexes | List indexes
*KernelMemoryApi* | [**kernelMemorySearch**](Apis/KernelMemoryApi.http#kernelmemorysearch) | **POST** /api/kernelmemory/search | Search for documents in specific index
*KernelMemoryApi* | [**kernelMemoryUpload**](Apis/KernelMemoryApi.http#kernelmemoryupload) | **POST** /api/kernelmemory/upload | Upload file for ingestion
*KernelMemoryApi* | [**kernelMemoryUploadStatus**](Apis/KernelMemoryApi.http#kernelmemoryuploadstatus) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document
*LanguageApi* | [**languageDetection**](Apis/LanguageApi.http#languagedetection) | **GET** /api/language/detect | Detects language of a text
*LanguageApi* | [**languageGetLanguageList**](Apis/LanguageApi.http#languagegetlanguagelist) | **GET** /api/language | List of supported languages for translation
*LanguageApi* | [**languageTranslate**](Apis/LanguageApi.http#languagetranslate) | **POST** /api/language/translate | Translation of text from one language to another
*MiscellaneousApi* | [**deleteLlmCacheEntry**](Apis/MiscellaneousApi.http#deletellmcacheentry) | **DELETE** /api/cache | 
*MiscellaneousApi* | [**getConfiguration**](Apis/MiscellaneousApi.http#getconfiguration) | **GET** /info | 
*SemanticSearchApi* | [**semanticSearchDeleteDocument**](Apis/SemanticSearchApi.http#semanticsearchdeletedocument) | **DELETE** /api/semantic/{documentId} | 
*SemanticSearchApi* | [**semanticSearchDeleteIndex**](Apis/SemanticSearchApi.http#semanticsearchdeleteindex) | **DELETE** /api/semantic/index/{name} | 
*SemanticSearchApi* | [**semanticSearchFileIngestion**](Apis/SemanticSearchApi.http#semanticsearchfileingestion) | **POST** /api/ingest/file | Ingest a File into Semantic Search
*SemanticSearchApi* | [**semanticSearchIngestionStatus**](Apis/SemanticSearchApi.http#semanticsearchingestionstatus) | **GET** /api/ingest/status | 
*SemanticSearchApi* | [**semanticSearchList**](Apis/SemanticSearchApi.http#semanticsearchlist) | **POST** /api/semantic/list | 
*SemanticSearchApi* | [**semanticSearchQuery**](Apis/SemanticSearchApi.http#semanticsearchquery) | **POST** /api/semantic/query | 
*SemanticSearchApi* | [**semanticSearchQueryResultsClustering**](Apis/SemanticSearchApi.http#semanticsearchqueryresultsclustering) | **POST** /api/semantic/query-results-clustering | 
*SemanticSearchApi* | [**semanticSearchRerank**](Apis/SemanticSearchApi.http#semanticsearchrerank) | **POST** /api/semantic/rerank | 
*SemanticSearchApi* | [**semanticSearchTextIngestion**](Apis/SemanticSearchApi.http#semanticsearchtextingestion) | **POST** /api/ingest/text | Ingest Plain Text for Semantic Search
*SemanticSearchApi* | [**semanticSearchWebpageIngestion**](Apis/SemanticSearchApi.http#semanticsearchwebpageingestion) | **POST** /api/ingest/webpage | 
*TranscriptionApi* | [**transcriptionAsynchronous**](Apis/TranscriptionApi.http#transcriptionasynchronous) | **POST** /api/transcribe/upload | Upload audio file for asynchronous transcription
*TranscriptionApi* | [**transcriptionGetById**](Apis/TranscriptionApi.http#transcriptiongetbyid) | **GET** /api/transcribe | Get transcription status and data


## Usage

### Prerequisites

You need [IntelliJ](https://www.jetbrains.com/idea/) to be able to run those queries. More information can be found [here](https://www.jetbrains.com/help/idea/http-client-in-product-code-editor.html).
You may have some luck running queries using the [Code REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) as well, but your mileage may vary.

### Variables and Environment files

* Generally speaking, you want queries to be specific using custom variables. All variables in the `.http` files have the `` format.
* You can create [public or private environment files](https://www.jetbrains.com/help/idea/exploring-http-syntax.html#environment-variables) to dynamically replace the variables at runtime.

_Note: don't commit private environment files! They typically will contain sensitive information like API Keys._

### Customizations

If you have control over the generation of the files here, there are two main things you can do

* Select elements to replace as variables during generation. The process is case-sensitive. For example, API_KEY -> 
    * For this, run the generation with the `bodyVariables` property, followed by a "-" separated list of variables
    * Example: `--additional-properties bodyVariables=YOUR_MERCHANT_ACCOUNT-YOUR_COMPANY_ACCOUNT-YOUR_BALANCE_PLATFORM`
* Add custom headers to _all_ requests. This can be useful for example if your specifications are missing [security schemes](https://github.com/github/rest-api-description/issues/237).
    * For this, run the generation with the `customHeaders` property, followed by a "&" separated list of variables
    * Example : `--additional-properties=customHeaders="Cookie:X-API-KEY="&"Accept-Encoding=gzip"`

_This client was generated by the [jetbrains-http-client](https://openapi-generator.tech/docs/generators/jetbrains-http-client) generator of OpenAPI Generator_