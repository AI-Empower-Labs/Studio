# \KernelMemoryApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**download_get**](KernelMemoryApi.md#download_get) | **GET** /download | 
[**kernel_memory_ask**](KernelMemoryApi.md#kernel_memory_ask) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM
[**kernel_memory_delete**](KernelMemoryApi.md#kernel_memory_delete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index
[**kernel_memory_delete_index**](KernelMemoryApi.md#kernel_memory_delete_index) | **DELETE** /api/kernelmemory/indexes | Delete index
[**kernel_memory_get_index**](KernelMemoryApi.md#kernel_memory_get_index) | **GET** /api/kernelmemory/indexes | List indexes
[**kernel_memory_search**](KernelMemoryApi.md#kernel_memory_search) | **POST** /api/kernelmemory/search | Search for documents in specific index
[**kernel_memory_upload**](KernelMemoryApi.md#kernel_memory_upload) | **POST** /api/kernelmemory/upload | Upload file for ingestion
[**kernel_memory_upload_status**](KernelMemoryApi.md#kernel_memory_upload_status) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document



## download_get

> models::StreamableFileContent download_get(document_id, filename, index)


### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**document_id** | **String** |  | [required] |
**filename** | **String** |  | [required] |
**index** | Option<**String**> |  |  |

### Return type

[**models::StreamableFileContent**](StreamableFileContent.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_ask

> models::MemoryAnswer kernel_memory_ask(memory_query)
Query documents and forward result to LLM

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**memory_query** | [**MemoryQuery**](MemoryQuery.md) |  | [required] |

### Return type

[**models::MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_delete

> models::DeleteAccepted kernel_memory_delete(document_id, index)
Delete document from specific index

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**document_id** | **String** |  | [required] |
**index** | Option<**String**> |  |  |

### Return type

[**models::DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_delete_index

> models::DeleteAccepted kernel_memory_delete_index(index)
Delete index

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**index** | Option<**String**> |  |  |

### Return type

[**models::DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_get_index

> models::IndexCollection kernel_memory_get_index()
List indexes

### Parameters

This endpoint does not need any parameter.

### Return type

[**models::IndexCollection**](IndexCollection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_search

> models::SearchResult kernel_memory_search(search_query)
Search for documents in specific index

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**search_query** | [**SearchQuery**](SearchQuery.md) |  | [required] |

### Return type

[**models::SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_upload

> models::UploadAccepted kernel_memory_upload()
Upload file for ingestion

### Parameters

This endpoint does not need any parameter.

### Return type

[**models::UploadAccepted**](UploadAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## kernel_memory_upload_status

> models::DataPipelineStatus kernel_memory_upload_status(document_id, index)
Get ingestion status for specific document

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**document_id** | **String** |  | [required] |
**index** | Option<**String**> |  |  |

### Return type

[**models::DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

