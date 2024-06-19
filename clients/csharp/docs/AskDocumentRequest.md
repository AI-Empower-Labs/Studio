# Org.OpenAPITools.Model.AskDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** | Semantic query to find matching documents and ask questions over | [optional] 
**Index** | **string** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | [**List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**MinRelevance** | **double?** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**LlmModel** | **string** | Large language model to use in query | [optional] 
**EmbeddingModel** | **string** | Embedding model to use in query | [optional] 
**Args** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

