

# SemanticSearchQueryResultsClusteringRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**clusterCount** | **Integer** | The number of clusters to be used in k-means clustering. |  [optional] |
|**maxDegreeOfParallelism** | **Integer** | The Maximum Degrees Of Parallelism |  [optional] |
|**maxTokens** | **Integer** | The maximum number of tokens to be used in the KMeans clustering algorithm. |  [optional] |
|**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39;. |  [optional] |
|**minRelevance** | **BigDecimal** | The minimum relevance value used for querying the search result audit. |  [optional] |
|**maxRelevance** | **BigDecimal** | The maximum relevance value to be used in the search query. |  [optional] |
|**llmModel** | **String** | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. |  [optional] |
|**embeddingModel** | **String** | The name of the embedding model used for clustering. |  [optional] |



