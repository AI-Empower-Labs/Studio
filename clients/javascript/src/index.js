/**
 * Studio - AI Empower Labs
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */


import ApiClient from './ApiClient';
import AskDocumentRequest from './model/AskDocumentRequest';
import AskDocumentResponse from './model/AskDocumentResponse';
import Citation from './model/Citation';
import DataPipelineStatus from './model/DataPipelineStatus';
import DeleteAccepted from './model/DeleteAccepted';
import DetectLanguageResponse from './model/DetectLanguageResponse';
import DocumentCitation from './model/DocumentCitation';
import DocumentFilters from './model/DocumentFilters';
import DocumentPartition from './model/DocumentPartition';
import EmbeddingRequest from './model/EmbeddingRequest';
import EmbeddingResponse from './model/EmbeddingResponse';
import GetLanguageResponse from './model/GetLanguageResponse';
import HttpValidationProblemDetails from './model/HttpValidationProblemDetails';
import IndexCollection from './model/IndexCollection';
import IndexDetails from './model/IndexDetails';
import IngestDocumentResponse from './model/IngestDocumentResponse';
import IngestTextDocumentRequest from './model/IngestTextDocumentRequest';
import IngestWebPageDocumentRequest from './model/IngestWebPageDocumentRequest';
import KeywordExtractionRequestBody from './model/KeywordExtractionRequestBody';
import KeywordExtractionResponse from './model/KeywordExtractionResponse';
import LanguageDetection from './model/LanguageDetection';
import ListDocumentParameters from './model/ListDocumentParameters';
import ListDocumentResponse from './model/ListDocumentResponse';
import MemoryAnswer from './model/MemoryAnswer';
import MemoryQuery from './model/MemoryQuery';
import NamedEntityRecognitionRequest from './model/NamedEntityRecognitionRequest';
import NamedEntityRecognitionResponse from './model/NamedEntityRecognitionResponse';
import Partition from './model/Partition';
import ProblemDetails from './model/ProblemDetails';
import QueryDocumentRequest from './model/QueryDocumentRequest';
import QueryDocumentResponse from './model/QueryDocumentResponse';
import ReRankDocument from './model/ReRankDocument';
import ReRankDocumentsRequest from './model/ReRankDocumentsRequest';
import ReRankDocumentsResponse from './model/ReRankDocumentsResponse';
import SearchQuery from './model/SearchQuery';
import SearchResult from './model/SearchResult';
import SegmentData from './model/SegmentData';
import SemanticSimilarityDocument from './model/SemanticSimilarityDocument';
import SemanticSimilarityRequest from './model/SemanticSimilarityRequest';
import SemanticSimilarityResponse from './model/SemanticSimilarityResponse';
import SupportedLanguage from './model/SupportedLanguage';
import TimeSpan from './model/TimeSpan';
import TokenCountRequest from './model/TokenCountRequest';
import TokenCountResponse from './model/TokenCountResponse';
import TokenizerRequest from './model/TokenizerRequest';
import TokenizerResponse from './model/TokenizerResponse';
import TranscriptionAudioUploadResult from './model/TranscriptionAudioUploadResult';
import TranscriptionResponse from './model/TranscriptionResponse';
import Translate from './model/Translate';
import TranslateResponse from './model/TranslateResponse';
import UploadAccepted from './model/UploadAccepted';
import WordCloudDocumentRequest from './model/WordCloudDocumentRequest';
import DataExtractionApi from './api/DataExtractionApi';
import KernelMemoryApi from './api/KernelMemoryApi';
import LanguageApi from './api/LanguageApi';
import MiscellaneousApi from './api/MiscellaneousApi';
import SemanticSearchApi from './api/SemanticSearchApi';
import TranscriptionApi from './api/TranscriptionApi';


/**
* # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you&#39;re building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don&#39;t hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms..<br>
* The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
* <p>
* An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
* <pre>
* var StudioAiEmpowerLabs = require('index'); // See note below*.
* var xxxSvc = new StudioAiEmpowerLabs.XxxApi(); // Allocate the API class we're going to use.
* var yyyModel = new StudioAiEmpowerLabs.Yyy(); // Construct a model instance.
* yyyModel.someProperty = 'someValue';
* ...
* var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
* ...
* </pre>
* <em>*NOTE: For a top-level AMD script, use require(['index'], function(){...})
* and put the application logic within the callback function.</em>
* </p>
* <p>
* A non-AMD browser application (discouraged) might do something like this:
* <pre>
* var xxxSvc = new StudioAiEmpowerLabs.XxxApi(); // Allocate the API class we're going to use.
* var yyy = new StudioAiEmpowerLabs.Yyy(); // Construct a model instance.
* yyyModel.someProperty = 'someValue';
* ...
* var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
* ...
* </pre>
* </p>
* @module index
* @version v1
*/
export {
    /**
     * The ApiClient constructor.
     * @property {module:ApiClient}
     */
    ApiClient,

    /**
     * The AskDocumentRequest model constructor.
     * @property {module:model/AskDocumentRequest}
     */
    AskDocumentRequest,

    /**
     * The AskDocumentResponse model constructor.
     * @property {module:model/AskDocumentResponse}
     */
    AskDocumentResponse,

    /**
     * The Citation model constructor.
     * @property {module:model/Citation}
     */
    Citation,

    /**
     * The DataPipelineStatus model constructor.
     * @property {module:model/DataPipelineStatus}
     */
    DataPipelineStatus,

    /**
     * The DeleteAccepted model constructor.
     * @property {module:model/DeleteAccepted}
     */
    DeleteAccepted,

    /**
     * The DetectLanguageResponse model constructor.
     * @property {module:model/DetectLanguageResponse}
     */
    DetectLanguageResponse,

    /**
     * The DocumentCitation model constructor.
     * @property {module:model/DocumentCitation}
     */
    DocumentCitation,

    /**
     * The DocumentFilters model constructor.
     * @property {module:model/DocumentFilters}
     */
    DocumentFilters,

    /**
     * The DocumentPartition model constructor.
     * @property {module:model/DocumentPartition}
     */
    DocumentPartition,

    /**
     * The EmbeddingRequest model constructor.
     * @property {module:model/EmbeddingRequest}
     */
    EmbeddingRequest,

    /**
     * The EmbeddingResponse model constructor.
     * @property {module:model/EmbeddingResponse}
     */
    EmbeddingResponse,

    /**
     * The GetLanguageResponse model constructor.
     * @property {module:model/GetLanguageResponse}
     */
    GetLanguageResponse,

    /**
     * The HttpValidationProblemDetails model constructor.
     * @property {module:model/HttpValidationProblemDetails}
     */
    HttpValidationProblemDetails,

    /**
     * The IndexCollection model constructor.
     * @property {module:model/IndexCollection}
     */
    IndexCollection,

    /**
     * The IndexDetails model constructor.
     * @property {module:model/IndexDetails}
     */
    IndexDetails,

    /**
     * The IngestDocumentResponse model constructor.
     * @property {module:model/IngestDocumentResponse}
     */
    IngestDocumentResponse,

    /**
     * The IngestTextDocumentRequest model constructor.
     * @property {module:model/IngestTextDocumentRequest}
     */
    IngestTextDocumentRequest,

    /**
     * The IngestWebPageDocumentRequest model constructor.
     * @property {module:model/IngestWebPageDocumentRequest}
     */
    IngestWebPageDocumentRequest,

    /**
     * The KeywordExtractionRequestBody model constructor.
     * @property {module:model/KeywordExtractionRequestBody}
     */
    KeywordExtractionRequestBody,

    /**
     * The KeywordExtractionResponse model constructor.
     * @property {module:model/KeywordExtractionResponse}
     */
    KeywordExtractionResponse,

    /**
     * The LanguageDetection model constructor.
     * @property {module:model/LanguageDetection}
     */
    LanguageDetection,

    /**
     * The ListDocumentParameters model constructor.
     * @property {module:model/ListDocumentParameters}
     */
    ListDocumentParameters,

    /**
     * The ListDocumentResponse model constructor.
     * @property {module:model/ListDocumentResponse}
     */
    ListDocumentResponse,

    /**
     * The MemoryAnswer model constructor.
     * @property {module:model/MemoryAnswer}
     */
    MemoryAnswer,

    /**
     * The MemoryQuery model constructor.
     * @property {module:model/MemoryQuery}
     */
    MemoryQuery,

    /**
     * The NamedEntityRecognitionRequest model constructor.
     * @property {module:model/NamedEntityRecognitionRequest}
     */
    NamedEntityRecognitionRequest,

    /**
     * The NamedEntityRecognitionResponse model constructor.
     * @property {module:model/NamedEntityRecognitionResponse}
     */
    NamedEntityRecognitionResponse,

    /**
     * The Partition model constructor.
     * @property {module:model/Partition}
     */
    Partition,

    /**
     * The ProblemDetails model constructor.
     * @property {module:model/ProblemDetails}
     */
    ProblemDetails,

    /**
     * The QueryDocumentRequest model constructor.
     * @property {module:model/QueryDocumentRequest}
     */
    QueryDocumentRequest,

    /**
     * The QueryDocumentResponse model constructor.
     * @property {module:model/QueryDocumentResponse}
     */
    QueryDocumentResponse,

    /**
     * The ReRankDocument model constructor.
     * @property {module:model/ReRankDocument}
     */
    ReRankDocument,

    /**
     * The ReRankDocumentsRequest model constructor.
     * @property {module:model/ReRankDocumentsRequest}
     */
    ReRankDocumentsRequest,

    /**
     * The ReRankDocumentsResponse model constructor.
     * @property {module:model/ReRankDocumentsResponse}
     */
    ReRankDocumentsResponse,

    /**
     * The SearchQuery model constructor.
     * @property {module:model/SearchQuery}
     */
    SearchQuery,

    /**
     * The SearchResult model constructor.
     * @property {module:model/SearchResult}
     */
    SearchResult,

    /**
     * The SegmentData model constructor.
     * @property {module:model/SegmentData}
     */
    SegmentData,

    /**
     * The SemanticSimilarityDocument model constructor.
     * @property {module:model/SemanticSimilarityDocument}
     */
    SemanticSimilarityDocument,

    /**
     * The SemanticSimilarityRequest model constructor.
     * @property {module:model/SemanticSimilarityRequest}
     */
    SemanticSimilarityRequest,

    /**
     * The SemanticSimilarityResponse model constructor.
     * @property {module:model/SemanticSimilarityResponse}
     */
    SemanticSimilarityResponse,

    /**
     * The SupportedLanguage model constructor.
     * @property {module:model/SupportedLanguage}
     */
    SupportedLanguage,

    /**
     * The TimeSpan model constructor.
     * @property {module:model/TimeSpan}
     */
    TimeSpan,

    /**
     * The TokenCountRequest model constructor.
     * @property {module:model/TokenCountRequest}
     */
    TokenCountRequest,

    /**
     * The TokenCountResponse model constructor.
     * @property {module:model/TokenCountResponse}
     */
    TokenCountResponse,

    /**
     * The TokenizerRequest model constructor.
     * @property {module:model/TokenizerRequest}
     */
    TokenizerRequest,

    /**
     * The TokenizerResponse model constructor.
     * @property {module:model/TokenizerResponse}
     */
    TokenizerResponse,

    /**
     * The TranscriptionAudioUploadResult model constructor.
     * @property {module:model/TranscriptionAudioUploadResult}
     */
    TranscriptionAudioUploadResult,

    /**
     * The TranscriptionResponse model constructor.
     * @property {module:model/TranscriptionResponse}
     */
    TranscriptionResponse,

    /**
     * The Translate model constructor.
     * @property {module:model/Translate}
     */
    Translate,

    /**
     * The TranslateResponse model constructor.
     * @property {module:model/TranslateResponse}
     */
    TranslateResponse,

    /**
     * The UploadAccepted model constructor.
     * @property {module:model/UploadAccepted}
     */
    UploadAccepted,

    /**
     * The WordCloudDocumentRequest model constructor.
     * @property {module:model/WordCloudDocumentRequest}
     */
    WordCloudDocumentRequest,

    /**
    * The DataExtractionApi service constructor.
    * @property {module:api/DataExtractionApi}
    */
    DataExtractionApi,

    /**
    * The KernelMemoryApi service constructor.
    * @property {module:api/KernelMemoryApi}
    */
    KernelMemoryApi,

    /**
    * The LanguageApi service constructor.
    * @property {module:api/LanguageApi}
    */
    LanguageApi,

    /**
    * The MiscellaneousApi service constructor.
    * @property {module:api/MiscellaneousApi}
    */
    MiscellaneousApi,

    /**
    * The SemanticSearchApi service constructor.
    * @property {module:api/SemanticSearchApi}
    */
    SemanticSearchApi,

    /**
    * The TranscriptionApi service constructor.
    * @property {module:api/TranscriptionApi}
    */
    TranscriptionApi
};