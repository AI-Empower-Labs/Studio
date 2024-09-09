# \MiscellaneousApi

All URIs are relative to *https://studio.aiempowerlabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**delete_llm_cache_entry**](MiscellaneousApi.md#delete_llm_cache_entry) | **DELETE** /api/cache | 
[**get_configuration**](MiscellaneousApi.md#get_configuration) | **GET** /info | 



## delete_llm_cache_entry

> delete_llm_cache_entry(cache_key)


Delete LLM cache entry

### Parameters


Name | Type | Description  | Required | Notes
------------- | ------------- | ------------- | ------------- | -------------
**cache_key** | Option<**String**> | The LLM cache key to remove |  |

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/problem+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## get_configuration

> Vec<std::collections::HashMap<String, Vec<String>>> get_configuration()


Get configuration information

### Parameters

This endpoint does not need any parameter.

### Return type

[**Vec<std::collections::HashMap<String, Vec<String>>>**](std::collections::HashMap.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

