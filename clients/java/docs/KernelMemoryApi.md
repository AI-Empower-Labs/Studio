# KernelMemoryApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**kernelMemoryAsk**](KernelMemoryApi.md#kernelMemoryAsk) | **POST** /api/kernelmemory/ask | Query documents and forward result to LLM |
| [**kernelMemoryDelete**](KernelMemoryApi.md#kernelMemoryDelete) | **DELETE** /api/kernelmemory/documents | Delete document from specific index |
| [**kernelMemoryDeleteIndex**](KernelMemoryApi.md#kernelMemoryDeleteIndex) | **DELETE** /api/kernelmemory/indexes | Delete index |
| [**kernelMemoryGetIndex**](KernelMemoryApi.md#kernelMemoryGetIndex) | **GET** /api/kernelmemory/indexes | List indexes |
| [**kernelMemorySearch**](KernelMemoryApi.md#kernelMemorySearch) | **POST** /api/kernelmemory/search | Search for documents in specific index |
| [**kernelMemoryUpload**](KernelMemoryApi.md#kernelMemoryUpload) | **POST** /api/kernelmemory/upload | Upload file for ingestion |
| [**kernelMemoryUploadStatus**](KernelMemoryApi.md#kernelMemoryUploadStatus) | **GET** /api/kernelmemory/upload-status | Get ingestion status for specific document |


<a id="kernelMemoryAsk"></a>
# **kernelMemoryAsk**
> MemoryAnswer kernelMemoryAsk(memoryQuery)

Query documents and forward result to LLM

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    MemoryQuery memoryQuery = new MemoryQuery(); // MemoryQuery | 
    try {
      MemoryAnswer result = apiInstance.kernelMemoryAsk(memoryQuery);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemoryAsk");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **memoryQuery** | [**MemoryQuery**](MemoryQuery.md)|  | |

### Return type

[**MemoryAnswer**](MemoryAnswer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

<a id="kernelMemoryDelete"></a>
# **kernelMemoryDelete**
> DeleteAccepted kernelMemoryDelete(documentId, index)

Delete document from specific index

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    String documentId = "documentId_example"; // String | 
    String index = "index_example"; // String | 
    try {
      DeleteAccepted result = apiInstance.kernelMemoryDelete(documentId, index);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemoryDelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **String**|  | |
| **index** | **String**|  | [optional] |

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

<a id="kernelMemoryDeleteIndex"></a>
# **kernelMemoryDeleteIndex**
> DeleteAccepted kernelMemoryDeleteIndex(index)

Delete index

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    String index = "index_example"; // String | 
    try {
      DeleteAccepted result = apiInstance.kernelMemoryDeleteIndex(index);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemoryDeleteIndex");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **index** | **String**|  | [optional] |

### Return type

[**DeleteAccepted**](DeleteAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

<a id="kernelMemoryGetIndex"></a>
# **kernelMemoryGetIndex**
> IndexCollection kernelMemoryGetIndex()

List indexes

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    try {
      IndexCollection result = apiInstance.kernelMemoryGetIndex();
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemoryGetIndex");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

<a id="kernelMemorySearch"></a>
# **kernelMemorySearch**
> SearchResult kernelMemorySearch(searchQuery)

Search for documents in specific index

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    SearchQuery searchQuery = new SearchQuery(); // SearchQuery | 
    try {
      SearchResult result = apiInstance.kernelMemorySearch(searchQuery);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemorySearch");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **searchQuery** | [**SearchQuery**](SearchQuery.md)|  | |

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

<a id="kernelMemoryUpload"></a>
# **kernelMemoryUpload**
> UploadAccepted kernelMemoryUpload()

Upload file for ingestion

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    try {
      UploadAccepted result = apiInstance.kernelMemoryUpload();
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemoryUpload");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **503** | Service Unavailable |  -  |

<a id="kernelMemoryUploadStatus"></a>
# **kernelMemoryUploadStatus**
> DataPipelineStatus kernelMemoryUploadStatus(documentId, index)

Get ingestion status for specific document

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.KernelMemoryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    KernelMemoryApi apiInstance = new KernelMemoryApi(defaultClient);
    String documentId = "documentId_example"; // String | 
    String index = "index_example"; // String | 
    try {
      DataPipelineStatus result = apiInstance.kernelMemoryUploadStatus(documentId, index);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling KernelMemoryApi#kernelMemoryUploadStatus");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **documentId** | **String**|  | |
| **index** | **String**|  | [optional] |

### Return type

[**DataPipelineStatus**](DataPipelineStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

