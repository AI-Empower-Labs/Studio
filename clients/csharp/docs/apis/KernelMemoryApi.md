# Org.OpenAPITools.Api.KernelMemoryApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**KernelMemoryAsk**](KernelMemoryApi.md#kernelmemoryask) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM |
| [**KernelMemoryDelete**](KernelMemoryApi.md#kernelmemorydelete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index |
| [**KernelMemoryDeleteIndex**](KernelMemoryApi.md#kernelmemorydeleteindex) | **DELETE** /api/kernelmemory/indexes | Delete index |
| [**KernelMemoryDownload**](KernelMemoryApi.md#kernelmemorydownload) | **GET** /api/kernelmemory/download | Download specific document |
| [**KernelMemoryGetIndex**](KernelMemoryApi.md#kernelmemorygetindex) | **GET** /api/kernelmemory/indexes | List indexes |
| [**KernelMemorySearch**](KernelMemoryApi.md#kernelmemorysearch) | **POST** /api/kernelmemory/search | Search for documents in specific index |
| [**KernelMemoryUpload**](KernelMemoryApi.md#kernelmemoryupload) | **POST** /api/kernelmemory/upload | Upload file for ingestion |
| [**KernelMemoryUploadStatus**](KernelMemoryApi.md#kernelmemoryuploadstatus) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document |

<a id="kernelmemoryask"></a>
# **KernelMemoryAsk**
> MemoryAnswer KernelMemoryAsk (MemoryQuery memoryQuery)

Query documents and forward result to LLM

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryAskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);
            var memoryQuery = new MemoryQuery(); // MemoryQuery | 

            try
            {
                // Query documents and forward result to LLM
                MemoryAnswer result = apiInstance.KernelMemoryAsk(memoryQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryAsk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryAskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query documents and forward result to LLM
    ApiResponse<MemoryAnswer> response = apiInstance.KernelMemoryAskWithHttpInfo(memoryQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryAskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memoryQuery** | [**MemoryQuery**](MemoryQuery.md) |  |  |

### Return type

[**MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemorydelete"></a>
# **KernelMemoryDelete**
> DeleteAccepted KernelMemoryDelete (string documentId, string index = null)

Delete document from specific index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);
            var documentId = "documentId_example";  // string | 
            var index = "index_example";  // string |  (optional) 

            try
            {
                // Delete document from specific index
                DeleteAccepted result = apiInstance.KernelMemoryDelete(documentId, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete document from specific index
    ApiResponse<DeleteAccepted> response = apiInstance.KernelMemoryDeleteWithHttpInfo(documentId, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** |  |  |
| **index** | **string** |  | [optional]  |

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemorydeleteindex"></a>
# **KernelMemoryDeleteIndex**
> DeleteAccepted KernelMemoryDeleteIndex (string index = null)

Delete index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryDeleteIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);
            var index = "index_example";  // string |  (optional) 

            try
            {
                // Delete index
                DeleteAccepted result = apiInstance.KernelMemoryDeleteIndex(index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryDeleteIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryDeleteIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete index
    ApiResponse<DeleteAccepted> response = apiInstance.KernelMemoryDeleteIndexWithHttpInfo(index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryDeleteIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **index** | **string** |  | [optional]  |

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemorydownload"></a>
# **KernelMemoryDownload**
> StreamableFileContent KernelMemoryDownload (string documentId, string filename, string index = null)

Download specific document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);
            var documentId = "documentId_example";  // string | 
            var filename = "filename_example";  // string | 
            var index = "index_example";  // string |  (optional) 

            try
            {
                // Download specific document
                StreamableFileContent result = apiInstance.KernelMemoryDownload(documentId, filename, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download specific document
    ApiResponse<StreamableFileContent> response = apiInstance.KernelMemoryDownloadWithHttpInfo(documentId, filename, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryDownloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** |  |  |
| **filename** | **string** |  |  |
| **index** | **string** |  | [optional]  |

### Return type

[**StreamableFileContent**](StreamableFileContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemorygetindex"></a>
# **KernelMemoryGetIndex**
> IndexCollection KernelMemoryGetIndex ()

List indexes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryGetIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);

            try
            {
                // List indexes
                IndexCollection result = apiInstance.KernelMemoryGetIndex();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryGetIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryGetIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List indexes
    ApiResponse<IndexCollection> response = apiInstance.KernelMemoryGetIndexWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryGetIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemorysearch"></a>
# **KernelMemorySearch**
> SearchResult KernelMemorySearch (SearchQuery searchQuery)

Search for documents in specific index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemorySearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);
            var searchQuery = new SearchQuery(); // SearchQuery | 

            try
            {
                // Search for documents in specific index
                SearchResult result = apiInstance.KernelMemorySearch(searchQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemorySearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemorySearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for documents in specific index
    ApiResponse<SearchResult> response = apiInstance.KernelMemorySearchWithHttpInfo(searchQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemorySearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchQuery** | [**SearchQuery**](SearchQuery.md) |  |  |

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemoryupload"></a>
# **KernelMemoryUpload**
> UploadAccepted KernelMemoryUpload ()

Upload file for ingestion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);

            try
            {
                // Upload file for ingestion
                UploadAccepted result = apiInstance.KernelMemoryUpload();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload file for ingestion
    ApiResponse<UploadAccepted> response = apiInstance.KernelMemoryUploadWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="kernelmemoryuploadstatus"></a>
# **KernelMemoryUploadStatus**
> DataPipelineStatus KernelMemoryUploadStatus (string documentId, string index = null)

Get ingestion status for specific document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KernelMemoryUploadStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new KernelMemoryApi(config);
            var documentId = "documentId_example";  // string | 
            var index = "index_example";  // string |  (optional) 

            try
            {
                // Get ingestion status for specific document
                DataPipelineStatus result = apiInstance.KernelMemoryUploadStatus(documentId, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryUploadStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KernelMemoryUploadStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get ingestion status for specific document
    ApiResponse<DataPipelineStatus> response = apiInstance.KernelMemoryUploadStatusWithHttpInfo(documentId, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KernelMemoryApi.KernelMemoryUploadStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** |  |  |
| **index** | **string** |  | [optional]  |

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Invalid request parameters or validation error. |  -  |
| **404** | Not Found |  -  |
| **429** | Request rate limit exceeded. |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

