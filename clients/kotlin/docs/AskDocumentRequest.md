
# AskDocumentRequest

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **query** | **kotlin.String** | Semantic query to find matching documents and ask questions over |  [optional] |
| **index** | **kotlin.String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; |  [optional] |
| **filter** | [**kotlin.collections.List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags |  [optional] |
| **minRelevance** | **kotlin.Double** | Optional filter to specify minimum relevance. Typically values between 0 and 1 |  [optional] |
| **llmModel** | **kotlin.String** | Large language model to use in query |  [optional] |
| **embeddingModel** | **kotlin.String** | Embedding model to use in query |  [optional] |
| **args** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.Any&gt;**](kotlin.Any.md) |  |  [optional] |



