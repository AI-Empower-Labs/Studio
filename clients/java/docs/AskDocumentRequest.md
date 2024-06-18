

# AskDocumentRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**query** | **String** | Semantic query to find matching documents and ask questions over |  [optional] |
|**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; |  [optional] |
|**filter** | [**List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags |  [optional] |
|**minRelevance** | **Double** | Optional filter to specify minimum relevance. Typically values between 0 and 1 |  [optional] |
|**llmModel** | **String** | Large language model to use in query |  [optional] |
|**embeddingModel** | **String** | Embedding model to use in query |  [optional] |



