# StudioAiEmpowerLabs.QueryDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | **String** | Semantic query to find matching documents | [optional] 
**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**filter** | [**[DocumentFilters]**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**searchMode** | **String** | Optional search mode defining the context or process used in the query. Supported values are &#39;hybrid&#39;, &#39;semantic&#39; | [optional] 
**language** | **String** | Specifies the language of the content. | [optional] 
**languageDetection** | **Boolean** | Indicates whether language detection is enabled. | [optional] 
**ftsMinScore** | **Number** | Minimum score for full-text search. | [optional] 
**ftsWeight** | **Number** | Weight for full-text search. | [optional] 
**semanticMinRelevance** | **Number** | Minimum relevance score for semantic search. | [optional] 
**semanticWeight** | **Number** | Weight applied for semantic search. | [optional] 
**smoothingFactorK** | **Number** | Smoothing factor (k) used in calculations. | [optional] 
**minRelevance** | **Number** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**limit** | **Number** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**embeddingModel** | **String** | Embedding model to use in query | [optional] 
**args** | **{String: Object}** |  | [optional] 



## Enum: SearchModeEnum


* `hybrid` (value: `"hybrid"`)

* `semantic` (value: `"semantic"`)




