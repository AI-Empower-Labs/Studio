
# QueryDocumentRequest

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **query** | **kotlin.String** | Semantic query to find matching documents |  [optional] |
| **index** | **kotlin.String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; |  [optional] |
| **filter** | [**kotlin.collections.List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags |  [optional] |
| **searchMode** | [**inline**](#SearchMode) | Optional search mode defining the context or process used in the query. Supported values are &#39;hybrid&#39;, &#39;semantic&#39; |  [optional] |
| **language** | **kotlin.String** | Specifies the language of the content. |  [optional] |
| **languageDetection** | **kotlin.Boolean** | Indicates whether language detection is enabled. |  [optional] |
| **ftsMinScore** | **kotlin.Float** | Minimum score for full-text search. |  [optional] |
| **ftsWeight** | **kotlin.Float** | Weight for full-text search. |  [optional] |
| **semanticMinRelevance** | **kotlin.Double** | Minimum relevance score for semantic search. |  [optional] |
| **semanticWeight** | **kotlin.Float** | Weight applied for semantic search. |  [optional] |
| **smoothingFactorK** | **kotlin.Float** | Smoothing factor (k) used in calculations. |  [optional] |
| **minRelevance** | **kotlin.Double** | Optional filter to specify minimum relevance. Typically values between 0 and 1 |  [optional] |
| **limit** | **kotlin.Int** | Optional filter for specifying maximum number of entries to return. Defaults to 3 |  [optional] |
| **embeddingModel** | **kotlin.String** | Embedding model to use in query |  [optional] |
| **args** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.Any&gt;**](kotlin.Any.md) |  |  [optional] |


<a id="SearchMode"></a>
## Enum: searchMode
| Name | Value |
| ---- | ----- |
| searchMode | hybrid, semantic |



