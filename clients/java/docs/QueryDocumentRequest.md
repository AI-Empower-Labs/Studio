

# QueryDocumentRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**query** | **String** | Semantic query to find matching documents |  [optional] |
|**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; |  [optional] |
|**filter** | [**List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags |  [optional] |
|**minRelevance** | **Double** | Optional filter to specify minimum relevance. Typically values between 0 and 1 |  [optional] |
|**limit** | **Integer** | Optional filter for specifying maximum number of entries to return. Defaults to 3 |  [optional] |
|**embeddingModel** | **String** | Embedding model to use in query |  [optional] |



