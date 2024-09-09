# MiscellaneousApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**deleteLlmCacheEntry**](MiscellaneousApi.md#deleteLlmCacheEntry) | **DELETE** /api/cache |  |
| [**getConfiguration**](MiscellaneousApi.md#getConfiguration) | **GET** /info |  |


<a id="deleteLlmCacheEntry"></a>
# **deleteLlmCacheEntry**
> deleteLlmCacheEntry(cacheKey)



Delete LLM cache entry

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MiscellaneousApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    MiscellaneousApi apiInstance = new MiscellaneousApi(defaultClient);
    String cacheKey = "cacheKey_example"; // String | The LLM cache key to remove
    try {
      apiInstance.deleteLlmCacheEntry(cacheKey);
    } catch (ApiException e) {
      System.err.println("Exception when calling MiscellaneousApi#deleteLlmCacheEntry");
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
| **cacheKey** | **String**| The LLM cache key to remove | [optional] |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - Cache was deleted |  -  |
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

<a id="getConfiguration"></a>
# **getConfiguration**
> List&lt;Map&lt;String, List&lt;String&gt;&gt;&gt; getConfiguration()



Get configuration information

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MiscellaneousApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://studio.aiempowerlabs.com");

    MiscellaneousApi apiInstance = new MiscellaneousApi(defaultClient);
    try {
      List<Map<String, List<String>>> result = apiInstance.getConfiguration();
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling MiscellaneousApi#getConfiguration");
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

[**List&lt;Map&lt;String, List&lt;String&gt;&gt;&gt;**](Map.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Current configuration |  -  |

