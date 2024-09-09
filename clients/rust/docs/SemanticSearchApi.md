# \SemanticSearchApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**semantic_search_ask**](SemanticSearchApi.md#semantic_search_ask) | **POST** /api/semantic/ask | 
[**semantic_search_delete_document**](SemanticSearchApi.md#semantic_search_delete_document) | **DELETE** /api/semantic/{documentId} | 
[**semantic_search_delete_index**](SemanticSearchApi.md#semantic_search_delete_index) | **DELETE** /api/semantic/index | 
[**semantic_search_file_ingestion**](SemanticSearchApi.md#semantic_search_file_ingestion) | **POST** /api/ingest/file | 
[**semantic_search_ingestion_status**](SemanticSearchApi.md#semantic_search_ingestion_status) | **GET** /api/ingest/status | 
[**semantic_search_list**](SemanticSearchApi.md#semantic_search_list) | **POST** /api/semantic/list | 
[**semantic_search_query**](SemanticSearchApi.md#semantic_search_query) | **POST** /api/semantic/query | 
[**semantic_search_query_results_clustering**](SemanticSearchApi.md#semantic_search_query_results_clustering) | **POST** /api/semantic/query-results-clustering | 
[**semantic_search_rerank**](SemanticSearchApi.md#semantic_search_rerank) | **POST** /api/semantic/rerank | 
[**semantic_search_text_ingestion**](SemanticSearchApi.md#semantic_search_text_ingestion) | **POST** /api/ingest/text | 
[**semantic_search_webpage_ingestion**](SemanticSearchApi.md#semantic_search_webpage_ingestion) | **POST** /api/ingest/webpage | 



## semantic_search_ask

> models::AskDocumentResponse semantic_search_ask(ask_document_request)


Ask questions over ingested documents

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**ask_document_request** | [**AskDocumentRequest**](AskDocumentRequest.md) |  | [required] |

### Return type

[**models::AskDocumentResponse**](AskDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


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

> models::IngestDocumentResponse semantic_search_file_ingestion(files, document_id, index, pipeline, web_hook_url, embedding_model, args, tags)


Import file document into semantic search

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**files** | [**Vec<std::path::PathBuf>**](std::path::PathBuf.md) | The file object to ingest. | [required] |
**document_id** | Option<**String**> | Id that uniquely identifies content within an index. Previously ingested documents with the same id will be overwritten schema. |  |
**index** | Option<**String**> | Optional value to specify with index the document should be ingested. Defaults to 'default'. |  |
**pipeline** | Option<[**Vec<String>**](String.md)> | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. |  |
**web_hook_url** | Option<**String**> | Url to use for webhook callback when operation finishes or fails. |  |
**embedding_model** | Option<**String**> | Embedding model to use in ingestion. Optional. Default to configured default. |  |
**args** | Option<[**std::collections::HashMap<String, serde_json::Value>**](std::collections::HashMap.md)> |  |  |
**tags** | Option<[**std::collections::HashMap<String, serde_json::Value>**](std::collections::HashMap.md)> | Tags to associate with ingestion |  |

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


Query ingested documents using semantic search

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


Import plain text into semantic search

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

