# Org.OpenAPITools.Model.QueryDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** | Semantic query to find matching documents | [optional] 
**Index** | **string** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | [**List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**SearchMode** | **string** | Optional search mode defining the context or process used in the query. Supported values are &#39;hybrid&#39;, &#39;semantic&#39; | [optional] 
**Language** | **string** | Specifies the language of the content. | [optional] 
**LanguageDetection** | **bool** | Indicates whether language detection is enabled. | [optional] 
**FtsMinScore** | **float** | Minimum score for full-text search. | [optional] 
**FtsWeight** | **float** | Weight for full-text search. | [optional] 
**SemanticMinRelevance** | **double** | Minimum relevance score for semantic search. | [optional] 
**SemanticWeight** | **float** | Weight applied for semantic search. | [optional] 
**SmoothingFactorK** | **float** | Smoothing factor (k) used in calculations. | [optional] 
**MinRelevance** | **double** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**Limit** | **int** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**EmbeddingModel** | **string** | Embedding model to use in query | [optional] 
**Args** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

