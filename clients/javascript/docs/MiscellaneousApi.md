# StudioAiEmpowerLabs.MiscellaneousApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteLlmCacheEntry**](MiscellaneousApi.md#deleteLlmCacheEntry) | **DELETE** /api/cache | 
[**getConfiguration**](MiscellaneousApi.md#getConfiguration) | **GET** /info | 



## deleteLlmCacheEntry

> deleteLlmCacheEntry(opts)



Delete LLM cache entry

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.MiscellaneousApi();
let opts = {
  'cacheKey': "cacheKey_example" // String | The LLM cache key to remove
};
apiInstance.deleteLlmCacheEntry(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cacheKey** | **String**| The LLM cache key to remove | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json


## getConfiguration

> [{String: [String]}] getConfiguration()



Get configuration information

### Example

```javascript
import StudioAiEmpowerLabs from 'studio_ai_empower_labs';

let apiInstance = new StudioAiEmpowerLabs.MiscellaneousApi();
apiInstance.getConfiguration((error, data, response) => {
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

**[{String: [String]}]**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

