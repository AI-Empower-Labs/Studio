
# SemanticSearchQueryResultsClusteringRequest

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **clusterCount** | **kotlin.Int** | The number of clusters to be used in k-means clustering. |  [optional] |
| **maxDegreeOfParallelism** | **kotlin.Int** | The Maximum Degrees Of Parallelism |  [optional] |
| **maxTokens** | **kotlin.Int** | The maximum number of tokens to be used in the KMeans clustering algorithm. |  [optional] |
| **index** | **kotlin.String** | Optional index to specify which index to search in. Defaults to &#39;default&#39;. |  [optional] |
| **minRelevance** | [**java.math.BigDecimal**](java.math.BigDecimal.md) | The minimum relevance value used for querying the search result audit. |  [optional] |
| **maxRelevance** | [**java.math.BigDecimal**](java.math.BigDecimal.md) | The maximum relevance value to be used in the search query. |  [optional] |
| **llmModel** | **kotlin.String** | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. |  [optional] |
| **embeddingModel** | **kotlin.String** | The name of the embedding model used for clustering. |  [optional] |



