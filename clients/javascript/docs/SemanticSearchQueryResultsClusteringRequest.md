# StudioAiEmpowerLabs.SemanticSearchQueryResultsClusteringRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**clusterCount** | **Number** | The number of clusters to be used in k-means clustering. | [optional] [default to 3]
**maxDegreeOfParallelism** | **Number** | The Maximum Degrees Of Parallelism | [optional] [default to 1]
**maxTokens** | **Number** | The maximum number of tokens to be used in the KMeans clustering algorithm. | [optional] [default to 10]
**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39;. | [optional] 
**minRelevance** | **Number** | The minimum relevance value used for querying the search result audit. | [optional] 
**maxRelevance** | **Number** | The maximum relevance value to be used in the search query. | [optional] 
**llmModel** | **String** | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. | [optional] 
**embeddingModel** | **String** | The name of the embedding model used for clustering. | [optional] 


