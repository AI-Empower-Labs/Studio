# StudioAiEmpowerLabs.KernelMemoryApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**kernelMemoryAsk**](KernelMemoryApi.md#kernelMemoryAsk) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM
[**kernelMemoryDelete**](KernelMemoryApi.md#kernelMemoryDelete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index
[**kernelMemoryDeleteIndex**](KernelMemoryApi.md#kernelMemoryDeleteIndex) | **DELETE** /api/kernelmemory/indexes | Delete index
[**kernelMemoryDownload**](KernelMemoryApi.md#kernelMemoryDownload) | **GET** /api/kernelmemory/download | Download specific document
[**kernelMemoryGetIndex**](KernelMemoryApi.md#kernelMemoryGetIndex) | **GET** /api/kernelmemory/indexes | List indexes
[**kernelMemorySearch**](KernelMemoryApi.md#kernelMemorySearch) | **POST** /api/kernelmemory/search | Search for documents in specific index
[**kernelMemoryUpload**](KernelMemoryApi.md#kernelMemoryUpload) | **POST** /api/kernelmemory/upload | Upload file for ingestion
[**kernelMemoryUploadStatus**](KernelMemoryApi.md#kernelMemoryUploadStatus) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document



## kernelMemoryAsk

> MemoryAnswer kernelMemoryAsk(memoryQuery)

Query documents and forward result to LLM

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
let memoryQuery = new StudioAiEmpowerLabs.MemoryQuery(); // MemoryQuery | 
apiInstance.kernelMemoryAsk(memoryQuery, (error, data, response) => {
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
 **memoryQuery** | [**MemoryQuery**](MemoryQuery.md)|  | 

### Return type

[**MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## kernelMemoryDelete

> DeleteAccepted kernelMemoryDelete(documentId, opts)

Delete document from specific index

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
let documentId = "documentId_example"; // String | 
let opts = {
  'index': "index_example" // String | 
};
apiInstance.kernelMemoryDelete(documentId, opts, (error, data, response) => {
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
 **documentId** | **String**|  | 
 **index** | **String**|  | [optional] 

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json


## kernelMemoryDeleteIndex

> DeleteAccepted kernelMemoryDeleteIndex(opts)

Delete index

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
let opts = {
  'index': "index_example" // String | 
};
apiInstance.kernelMemoryDeleteIndex(opts, (error, data, response) => {
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
 **index** | **String**|  | [optional] 

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json


## kernelMemoryDownload

> StreamableFileContent kernelMemoryDownload(documentId, filename, opts)

Download specific document

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
let documentId = "documentId_example"; // String | 
let filename = "filename_example"; // String | 
let opts = {
  'index': "index_example" // String | 
};
apiInstance.kernelMemoryDownload(documentId, filename, opts, (error, data, response) => {
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
 **documentId** | **String**|  | 
 **filename** | **String**|  | 
 **index** | **String**|  | [optional] 

### Return type

[**StreamableFileContent**](StreamableFileContent.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json


## kernelMemoryGetIndex

> IndexCollection kernelMemoryGetIndex()

List indexes

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
apiInstance.kernelMemoryGetIndex((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**IndexCollection**](IndexCollection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json


## kernelMemorySearch

> SearchResult kernelMemorySearch(searchQuery)

Search for documents in specific index

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
let searchQuery = new StudioAiEmpowerLabs.SearchQuery(); // SearchQuery | 
apiInstance.kernelMemorySearch(searchQuery, (error, data, response) => {
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
 **searchQuery** | [**SearchQuery**](SearchQuery.md)|  | 

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/problem+json


## kernelMemoryUpload

> UploadAccepted kernelMemoryUpload()

Upload file for ingestion

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
apiInstance.kernelMemoryUpload((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**UploadAccepted**](UploadAccepted.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json


## kernelMemoryUploadStatus

> DataPipelineStatus kernelMemoryUploadStatus(documentId, opts)

Get ingestion status for specific document

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.KernelMemoryApi();
let documentId = "documentId_example"; // String | 
let opts = {
  'index': "index_example" // String | 
};
apiInstance.kernelMemoryUploadStatus(documentId, opts, (error, data, response) => {
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
 **documentId** | **String**|  | 
 **index** | **String**|  | [optional] 

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/problem+json

