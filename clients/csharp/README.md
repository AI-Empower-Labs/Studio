# Org.OpenAPITools - the C# library for the Studio - AI Empower Labs

# Studio API Documentation

## Introduction
Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.

Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.

Support and Feedback
We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.

Terms of Use
Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Generator version: 7.9.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://www.AIEmpowerLabs.com](https://www.AIEmpowerLabs.com)

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataExtractionApi.ApiExtractThematicSimilarityClusterPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://studio.aiempowerlabs.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataExtractionApi* | [**ApiExtractThematicSimilarityClusterPost**](docs/DataExtractionApi.md#apiextractthematicsimilarityclusterpost) | **POST** /api/extract/thematic-similarity-cluster | Generate thematic similarity clusters using the K-Means algorithm
*DataExtractionApi* | [**Embedding**](docs/DataExtractionApi.md#embedding) | **POST** /api/extract/embed | Converts data to a numerical vector array
*DataExtractionApi* | [**KeywordExtraction**](docs/DataExtractionApi.md#keywordextraction) | **POST** /api/extract/keywords | Performs keyword extraction on source text
*DataExtractionApi* | [**NamedEntityRecognition**](docs/DataExtractionApi.md#namedentityrecognition) | **POST** /api/extract/entities | Extracts named entities from provided text
*DataExtractionApi* | [**SemanticSimilarity**](docs/DataExtractionApi.md#semanticsimilarity) | **POST** /api/extract/similarity | Generate semantic similarity queries from text
*DataExtractionApi* | [**TokenCount**](docs/DataExtractionApi.md#tokencount) | **POST** /api/extract/tokenCount | Count tokens in a text
*DataExtractionApi* | [**Tokenize**](docs/DataExtractionApi.md#tokenize) | **POST** /api/extract/tokenize | Converts data to a integer token array
*DataExtractionApi* | [**TranscriptionSynchronous**](docs/DataExtractionApi.md#transcriptionsynchronous) | **POST** /api/extract/transcription | Synchronous transcribe audio
*KernelMemoryApi* | [**DownloadGet**](docs/KernelMemoryApi.md#downloadget) | **GET** /download | 
*KernelMemoryApi* | [**KernelMemoryAsk**](docs/KernelMemoryApi.md#kernelmemoryask) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM
*KernelMemoryApi* | [**KernelMemoryDelete**](docs/KernelMemoryApi.md#kernelmemorydelete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index
*KernelMemoryApi* | [**KernelMemoryDeleteIndex**](docs/KernelMemoryApi.md#kernelmemorydeleteindex) | **DELETE** /api/kernelmemory/indexes | Delete index
*KernelMemoryApi* | [**KernelMemoryGetIndex**](docs/KernelMemoryApi.md#kernelmemorygetindex) | **GET** /api/kernelmemory/indexes | List indexes
*KernelMemoryApi* | [**KernelMemorySearch**](docs/KernelMemoryApi.md#kernelmemorysearch) | **POST** /api/kernelmemory/search | Search for documents in specific index
*KernelMemoryApi* | [**KernelMemoryUpload**](docs/KernelMemoryApi.md#kernelmemoryupload) | **POST** /api/kernelmemory/upload | Upload file for ingestion
*KernelMemoryApi* | [**KernelMemoryUploadStatus**](docs/KernelMemoryApi.md#kernelmemoryuploadstatus) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document
*LanguageApi* | [**LanguageDetection**](docs/LanguageApi.md#languagedetection) | **GET** /api/language/detect | Detects language of a text
*LanguageApi* | [**LanguageGetLanguageList**](docs/LanguageApi.md#languagegetlanguagelist) | **GET** /api/language | List of supported languages for translation
*LanguageApi* | [**LanguageTranslate**](docs/LanguageApi.md#languagetranslate) | **POST** /api/language/translate | Translation of text from one language to another
*MiscellaneousApi* | [**DeleteLlmCacheEntry**](docs/MiscellaneousApi.md#deletellmcacheentry) | **DELETE** /api/cache | 
*MiscellaneousApi* | [**GetConfiguration**](docs/MiscellaneousApi.md#getconfiguration) | **GET** /info | 
*SemanticSearchApi* | [**SemanticSearchAsk**](docs/SemanticSearchApi.md#semanticsearchask) | **POST** /api/semantic/ask | 
*SemanticSearchApi* | [**SemanticSearchDeleteDocument**](docs/SemanticSearchApi.md#semanticsearchdeletedocument) | **DELETE** /api/semantic/{documentId} | 
*SemanticSearchApi* | [**SemanticSearchDeleteIndex**](docs/SemanticSearchApi.md#semanticsearchdeleteindex) | **DELETE** /api/semantic/index | 
*SemanticSearchApi* | [**SemanticSearchFileIngestion**](docs/SemanticSearchApi.md#semanticsearchfileingestion) | **POST** /api/ingest/file | 
*SemanticSearchApi* | [**SemanticSearchIngestionStatus**](docs/SemanticSearchApi.md#semanticsearchingestionstatus) | **GET** /api/ingest/status | 
*SemanticSearchApi* | [**SemanticSearchList**](docs/SemanticSearchApi.md#semanticsearchlist) | **POST** /api/semantic/list | 
*SemanticSearchApi* | [**SemanticSearchQuery**](docs/SemanticSearchApi.md#semanticsearchquery) | **POST** /api/semantic/query | 
*SemanticSearchApi* | [**SemanticSearchQueryResultsClustering**](docs/SemanticSearchApi.md#semanticsearchqueryresultsclustering) | **POST** /api/semantic/query-results-clustering | 
*SemanticSearchApi* | [**SemanticSearchRerank**](docs/SemanticSearchApi.md#semanticsearchrerank) | **POST** /api/semantic/rerank | 
*SemanticSearchApi* | [**SemanticSearchTextIngestion**](docs/SemanticSearchApi.md#semanticsearchtextingestion) | **POST** /api/ingest/text | 
*SemanticSearchApi* | [**SemanticSearchWebpageIngestion**](docs/SemanticSearchApi.md#semanticsearchwebpageingestion) | **POST** /api/ingest/webpage | 
*TranscriptionApi* | [**TranscriptionAsynchronous**](docs/TranscriptionApi.md#transcriptionasynchronous) | **POST** /api/transcribe/upload | Upload audio file for asynchronous transcription
*TranscriptionApi* | [**TranscriptionGetById**](docs/TranscriptionApi.md#transcriptiongetbyid) | **GET** /api/transcribe | Get transcription status and data


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiExtractThematicSimilarityClusterPostRequest](docs/ApiExtractThematicSimilarityClusterPostRequest.md)
 - [Model.AskDocumentRequest](docs/AskDocumentRequest.md)
 - [Model.AskDocumentResponse](docs/AskDocumentResponse.md)
 - [Model.Centroid](docs/Centroid.md)
 - [Model.Citation](docs/Citation.md)
 - [Model.Coordinate](docs/Coordinate.md)
 - [Model.DataPipelineStatus](docs/DataPipelineStatus.md)
 - [Model.DeleteAccepted](docs/DeleteAccepted.md)
 - [Model.DetectLanguageResponse](docs/DetectLanguageResponse.md)
 - [Model.DocumentCitation](docs/DocumentCitation.md)
 - [Model.DocumentFilters](docs/DocumentFilters.md)
 - [Model.DocumentPartition](docs/DocumentPartition.md)
 - [Model.EmbeddingRequest](docs/EmbeddingRequest.md)
 - [Model.EmbeddingResponse](docs/EmbeddingResponse.md)
 - [Model.GetLanguageResponse](docs/GetLanguageResponse.md)
 - [Model.HttpValidationProblemDetails](docs/HttpValidationProblemDetails.md)
 - [Model.IndexCollection](docs/IndexCollection.md)
 - [Model.IndexDetails](docs/IndexDetails.md)
 - [Model.IngestDocumentResponse](docs/IngestDocumentResponse.md)
 - [Model.IngestTextDocumentRequest](docs/IngestTextDocumentRequest.md)
 - [Model.IngestWebPageDocumentRequest](docs/IngestWebPageDocumentRequest.md)
 - [Model.KMeansCluster](docs/KMeansCluster.md)
 - [Model.KeywordExtractionRequestBody](docs/KeywordExtractionRequestBody.md)
 - [Model.KeywordExtractionResponse](docs/KeywordExtractionResponse.md)
 - [Model.LanguageDetection](docs/LanguageDetection.md)
 - [Model.ListDocumentParameters](docs/ListDocumentParameters.md)
 - [Model.ListDocumentResponse](docs/ListDocumentResponse.md)
 - [Model.MemoryAnswer](docs/MemoryAnswer.md)
 - [Model.MemoryQuery](docs/MemoryQuery.md)
 - [Model.NamedEntityRecognitionRequest](docs/NamedEntityRecognitionRequest.md)
 - [Model.NamedEntityRecognitionResponse](docs/NamedEntityRecognitionResponse.md)
 - [Model.Partition](docs/Partition.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.QueryDocumentRequest](docs/QueryDocumentRequest.md)
 - [Model.QueryDocumentResponse](docs/QueryDocumentResponse.md)
 - [Model.ReRankDocument](docs/ReRankDocument.md)
 - [Model.ReRankDocumentsRequest](docs/ReRankDocumentsRequest.md)
 - [Model.ReRankDocumentsResponse](docs/ReRankDocumentsResponse.md)
 - [Model.SearchQuery](docs/SearchQuery.md)
 - [Model.SearchResult](docs/SearchResult.md)
 - [Model.SegmentData](docs/SegmentData.md)
 - [Model.SemanticSearchQueryResultsClusteringRequest](docs/SemanticSearchQueryResultsClusteringRequest.md)
 - [Model.SemanticSimilarityDocument](docs/SemanticSimilarityDocument.md)
 - [Model.SemanticSimilarityRequest](docs/SemanticSimilarityRequest.md)
 - [Model.SemanticSimilarityResponse](docs/SemanticSimilarityResponse.md)
 - [Model.StreamableFileContent](docs/StreamableFileContent.md)
 - [Model.SupportedLanguage](docs/SupportedLanguage.md)
 - [Model.TimeSpan](docs/TimeSpan.md)
 - [Model.TokenCountRequest](docs/TokenCountRequest.md)
 - [Model.TokenCountResponse](docs/TokenCountResponse.md)
 - [Model.TokenizerRequest](docs/TokenizerRequest.md)
 - [Model.TokenizerResponse](docs/TokenizerResponse.md)
 - [Model.TranscriptionAudioUploadResult](docs/TranscriptionAudioUploadResult.md)
 - [Model.TranscriptionResponse](docs/TranscriptionResponse.md)
 - [Model.Translate](docs/Translate.md)
 - [Model.TranslateResponse](docs/TranslateResponse.md)
 - [Model.UploadAccepted](docs/UploadAccepted.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

