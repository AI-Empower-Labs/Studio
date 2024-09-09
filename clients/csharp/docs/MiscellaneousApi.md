# Org.OpenAPITools.Api.MiscellaneousApi

All URIs are relative to *https://studio.aiempowerlabs.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteLlmCacheEntry**](MiscellaneousApi.md#deletellmcacheentry) | **DELETE** /api/cache |  |
| [**GetConfiguration**](MiscellaneousApi.md#getconfiguration) | **GET** /info |  |

<a id="deletellmcacheentry"></a>
# **DeleteLlmCacheEntry**
> void DeleteLlmCacheEntry (string? cacheKey = null)



Delete LLM cache entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteLlmCacheEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new MiscellaneousApi(config);
            var cacheKey = "cacheKey_example";  // string? | The LLM cache key to remove (optional) 

            try
            {
                apiInstance.DeleteLlmCacheEntry(cacheKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.DeleteLlmCacheEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLlmCacheEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteLlmCacheEntryWithHttpInfo(cacheKey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.DeleteLlmCacheEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cacheKey** | **string?** | The LLM cache key to remove | [optional]  |

### Return type

void (empty response body)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconfiguration"></a>
# **GetConfiguration**
> List&lt;Dictionary&lt;string, List&lt;string&gt;&gt;&gt; GetConfiguration ()



Get configuration information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://studio.aiempowerlabs.com";
            var apiInstance = new MiscellaneousApi(config);

            try
            {
                List<Dictionary<string, List<string>>> result = apiInstance.GetConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Dictionary<string, List<string>>>> response = apiInstance.GetConfigurationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<Dictionary<string, List<string>>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Current configuration |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

