# \SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**semantic_search_delete_document**](SemanticSearchApi.md#semantic_search_delete_document) | **DELETE** /api/semantic/{documentId} | 
[**semantic_search_delete_index**](SemanticSearchApi.md#semantic_search_delete_index) | **DELETE** /api/semantic/index/{name} | 
[**semantic_search_file_ingestion**](SemanticSearchApi.md#semantic_search_file_ingestion) | **POST** /api/ingest/file | Ingest a File into Semantic Search
[**semantic_search_ingestion_status**](SemanticSearchApi.md#semantic_search_ingestion_status) | **GET** /api/ingest/status | 
[**semantic_search_list**](SemanticSearchApi.md#semantic_search_list) | **POST** /api/semantic/list | 
[**semantic_search_query**](SemanticSearchApi.md#semantic_search_query) | **POST** /api/semantic/query | 
[**semantic_search_query_results_clustering**](SemanticSearchApi.md#semantic_search_query_results_clustering) | **POST** /api/semantic/query-results-clustering | 
[**semantic_search_rerank**](SemanticSearchApi.md#semantic_search_rerank) | **POST** /api/semantic/rerank | 
[**semantic_search_text_ingestion**](SemanticSearchApi.md#semantic_search_text_ingestion) | **POST** /api/ingest/text | Ingest Plain Text for Semantic Search
[**semantic_search_webpage_ingestion**](SemanticSearchApi.md#semantic_search_webpage_ingestion) | **POST** /api/ingest/webpage | 



## semantic_search_delete_document

> semantic_search_delete_document(document_id, index)


Delete specific document by id

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**document_id** | **String** |  | [required] |
**index** | **String** |  | [required] |

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_delete_index

> semantic_search_delete_index(name)


Delete specific index by name

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**name** | **String** |  | [required] |

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_file_ingestion

> models::IngestDocumentResponse semantic_search_file_ingestion(files, document_id, index, pipeline, web_hook_url, embedding_model, document_id2, index2, web_hook_url2, embedding_model_name, context, tags, ingestion_pipeline, language_auto_detection, language)
Ingest a File into Semantic Search

Uploads and ingests a file document into the semantic search index. Supports optional configuration of index, ingestion pipeline, embedding model, and webhook for processing status.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**files** | [**Vec<std::path::PathBuf>**](std::path::PathBuf.md) | A collection of files to be ingested. Must contain at least one file. | [required] |
**document_id** | Option<**String**> | A unique identifier for the document within the index. Documents with the same ID will be overwritten. |  |
**index** | Option<**String**> | The name of the index where the document will be ingested. Defaults to 'default' if not specified. |  |
**pipeline** | Option<[**Vec<String>**](String.md)> | An array of ingestion pipeline step names. If not provided, server default steps will be used. |  |
**web_hook_url** | Option<**String**> | A URL to receive a callback via webhook when the ingestion process is completed or fails. |  |
**embedding_model** | Option<**String**> | The embedding model to use during ingestion. If not specified, the server's default model will be applied. |  |
**document_id2** | Option<**String**> | Unique identifier for the document to ingest. |  |
**index2** | Option<**String**> | Optional index name where the document will be stored. |  |
**web_hook_url2** | Option<**String**> | Optional webhook URL to notify upon completion. |  |
**embedding_model_name** | Option<**String**> | Optional name of the embedding model to use during ingestion. |  |
**context** | Option<[**std::collections::HashMap<String, String>**](std::collections::HashMap.md)> | Optional key-value pairs for additional context or metadata. |  |
**tags** | Option<[**std::collections::HashMap<String, Vec<String>>**](std::collections::HashMap.md)> | A collection of tags associated with the document. Tags can be language-specific. |  |
**ingestion_pipeline** | Option<[**Vec<String>**](String.md)> | Optional list of ingestion pipeline steps. Allows custom processing. |  |
**language_auto_detection** | Option<**bool**> | Enable automatic language detection for document content. |  |[default to false]
**language** | Option<**String**> | Force a specific language for full-text search. Use 'simple' for no language or leave empty. |  |

### Return type

[**models::IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_ingestion_status

> models::DataPipelineStatus semantic_search_ingestion_status(id)


Get queue status for ingestion job

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**id** | **uuid::Uuid** |  | [required] |

### Return type

[**models::DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_list

> models::ListDocumentResponse semantic_search_list(list_document_parameters)


List - and filter - for ingested documents

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**list_document_parameters** | [**ListDocumentParameters**](ListDocumentParameters.md) |  | [required] |

### Return type

[**models::ListDocumentResponse**](ListDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_query

> models::QueryDocumentResponse semantic_search_query(query_document_request)


Performs semantic or hybrid search over previously ingested data.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**query_document_request** | [**QueryDocumentRequest**](QueryDocumentRequest.md) |  | [required] |

### Return type

[**models::QueryDocumentResponse**](QueryDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_query_results_clustering

> models::KMeansCluster semantic_search_query_results_clustering(semantic_search_query_results_clustering_request)


Perform k-means clustering over semantic search log entries

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**semantic_search_query_results_clustering_request** | [**SemanticSearchQueryResultsClusteringRequest**](SemanticSearchQueryResultsClusteringRequest.md) |  | [required] |

### Return type

[**models::KMeansCluster**](KMeansCluster.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/csv, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_rerank

> models::ReRankDocumentsResponse semantic_search_rerank(re_rank_documents_request)


Rerank documents

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**re_rank_documents_request** | [**ReRankDocumentsRequest**](ReRankDocumentsRequest.md) |  | [required] |

### Return type

[**models::ReRankDocumentsResponse**](ReRankDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_text_ingestion

> models::IngestDocumentResponse semantic_search_text_ingestion(ingest_text_document_request)
Ingest Plain Text for Semantic Search

Ingests a plain text document into the semantic search index. This endpoint allows associating tags and specifying the target index for enhanced search capabilities.

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**ingest_text_document_request** | [**IngestTextDocumentRequest**](IngestTextDocumentRequest.md) |  | [required] |

### Return type

[**models::IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## semantic_search_webpage_ingestion

> models::IngestDocumentResponse semantic_search_webpage_ingestion(ingest_web_page_document_request)


Import web page text into semantic search

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**ingest_web_page_document_request** | [**IngestWebPageDocumentRequest**](IngestWebPageDocumentRequest.md) |  | [required] |

### Return type

[**models::IngestDocumentResponse**](IngestDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

