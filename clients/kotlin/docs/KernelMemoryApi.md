# KernelMemoryApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**downloadGet**](KernelMemoryApi.md#downloadGet) | **GET** /download |  |
| [**kernelMemoryAsk**](KernelMemoryApi.md#kernelMemoryAsk) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM |
| [**kernelMemoryDelete**](KernelMemoryApi.md#kernelMemoryDelete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index |
| [**kernelMemoryDeleteIndex**](KernelMemoryApi.md#kernelMemoryDeleteIndex) | **DELETE** /api/kernelmemory/indexes | Delete index |
| [**kernelMemoryGetIndex**](KernelMemoryApi.md#kernelMemoryGetIndex) | **GET** /api/kernelmemory/indexes | List indexes |
| [**kernelMemorySearch**](KernelMemoryApi.md#kernelMemorySearch) | **POST** /api/kernelmemory/search | Search for documents in specific index |
| [**kernelMemoryUpload**](KernelMemoryApi.md#kernelMemoryUpload) | **POST** /api/kernelmemory/upload | Upload file for ingestion |
| [**kernelMemoryUploadStatus**](KernelMemoryApi.md#kernelMemoryUploadStatus) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document |


<a id="downloadGet"></a>
# **downloadGet**
> StreamableFileContent downloadGet(documentId, filename, index)



### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
val documentId : kotlin.String = documentId_example // kotlin.String | 
val filename : kotlin.String = filename_example // kotlin.String | 
val index : kotlin.String = index_example // kotlin.String | 
try {
    val result : StreamableFileContent = apiInstance.downloadGet(documentId, filename, index)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#downloadGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#downloadGet")
    e.printStackTrace()
}
```

### Parameters
| **documentId** | **kotlin.String**|  | |
| **filename** | **kotlin.String**|  | |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **index** | **kotlin.String**|  | [optional] |

### Return type

[**StreamableFileContent**](StreamableFileContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

<a id="kernelMemoryAsk"></a>
# **kernelMemoryAsk**
> MemoryAnswer kernelMemoryAsk(memoryQuery)

Query documents and forward result to LLM

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
val memoryQuery : MemoryQuery =  // MemoryQuery | 
try {
    val result : MemoryAnswer = apiInstance.kernelMemoryAsk(memoryQuery)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemoryAsk")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemoryAsk")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **memoryQuery** | [**MemoryQuery**](MemoryQuery.md)|  | |

### Return type

[**MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="kernelMemoryDelete"></a>
# **kernelMemoryDelete**
> DeleteAccepted kernelMemoryDelete(documentId, index)

Delete document from specific index

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
val documentId : kotlin.String = documentId_example // kotlin.String | 
val index : kotlin.String = index_example // kotlin.String | 
try {
    val result : DeleteAccepted = apiInstance.kernelMemoryDelete(documentId, index)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemoryDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemoryDelete")
    e.printStackTrace()
}
```

### Parameters
| **documentId** | **kotlin.String**|  | |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **index** | **kotlin.String**|  | [optional] |

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

<a id="kernelMemoryDeleteIndex"></a>
# **kernelMemoryDeleteIndex**
> DeleteAccepted kernelMemoryDeleteIndex(index)

Delete index

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
val index : kotlin.String = index_example // kotlin.String | 
try {
    val result : DeleteAccepted = apiInstance.kernelMemoryDeleteIndex(index)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemoryDeleteIndex")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemoryDeleteIndex")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **index** | **kotlin.String**|  | [optional] |

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

<a id="kernelMemoryGetIndex"></a>
# **kernelMemoryGetIndex**
> IndexCollection kernelMemoryGetIndex()

List indexes

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
try {
    val result : IndexCollection = apiInstance.kernelMemoryGetIndex()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemoryGetIndex")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemoryGetIndex")
    e.printStackTrace()
}
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

<a id="kernelMemorySearch"></a>
# **kernelMemorySearch**
> SearchResult kernelMemorySearch(searchQuery)

Search for documents in specific index

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
val searchQuery : SearchQuery =  // SearchQuery | 
try {
    val result : SearchResult = apiInstance.kernelMemorySearch(searchQuery)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemorySearch")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemorySearch")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **searchQuery** | [**SearchQuery**](SearchQuery.md)|  | |

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json

<a id="kernelMemoryUpload"></a>
# **kernelMemoryUpload**
> UploadAccepted kernelMemoryUpload()

Upload file for ingestion

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
try {
    val result : UploadAccepted = apiInstance.kernelMemoryUpload()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemoryUpload")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemoryUpload")
    e.printStackTrace()
}
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

<a id="kernelMemoryUploadStatus"></a>
# **kernelMemoryUploadStatus**
> DataPipelineStatus kernelMemoryUploadStatus(documentId, index)

Get ingestion status for specific document

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = KernelMemoryApi()
val documentId : kotlin.String = documentId_example // kotlin.String | 
val index : kotlin.String = index_example // kotlin.String | 
try {
    val result : DataPipelineStatus = apiInstance.kernelMemoryUploadStatus(documentId, index)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling KernelMemoryApi#kernelMemoryUploadStatus")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling KernelMemoryApi#kernelMemoryUploadStatus")
    e.printStackTrace()
}
```

### Parameters
| **documentId** | **kotlin.String**|  | |
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **index** | **kotlin.String**|  | [optional] |

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json

