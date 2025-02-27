# MiscellaneousApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**deleteLlmCacheEntry**](MiscellaneousApi.md#deleteLlmCacheEntry) | **DELETE** /api/cache |  |
| [**getConfiguration**](MiscellaneousApi.md#getConfiguration) | **GET** /info |  |


<a id="deleteLlmCacheEntry"></a>
# **deleteLlmCacheEntry**
> deleteLlmCacheEntry(key)



Delete LLM cache entry

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MiscellaneousApi()
val key : kotlin.String = key_example // kotlin.String | The LLM cache key to remove
try {
    apiInstance.deleteLlmCacheEntry(key)
} catch (e: ClientException) {
    println("4xx response calling MiscellaneousApi#deleteLlmCacheEntry")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MiscellaneousApi#deleteLlmCacheEntry")
    e.printStackTrace()
}
```

### Parameters
| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **key** | **kotlin.String**| The LLM cache key to remove | [optional] |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json

<a id="getConfiguration"></a>
# **getConfiguration**
> kotlin.collections.List&lt;kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;&gt; getConfiguration()



Get configuration information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MiscellaneousApi()
try {
    val result : kotlin.collections.List<kotlin.collections.Map<kotlin.String, kotlin.collections.List<kotlin.String>>> = apiInstance.getConfiguration()
    println(result)
} catch (e: ClientException) {
    println("4xx response calling MiscellaneousApi#getConfiguration")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MiscellaneousApi#getConfiguration")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**kotlin.collections.List&lt;kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;&gt;**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

