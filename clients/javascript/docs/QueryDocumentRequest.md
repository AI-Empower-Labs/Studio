# StudioAiEmpowerLabs.QueryDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | **String** | Semantic query to find matching documents | [optional] 
**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**filter** | [**[DocumentFilters]**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**minRelevance** | **Number** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**limit** | **Number** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**embeddingModel** | **String** | Embedding model to use in query | [optional] 


