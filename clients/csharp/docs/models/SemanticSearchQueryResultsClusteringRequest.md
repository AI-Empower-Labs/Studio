# Org.OpenAPITools.Model.SemanticSearchQueryResultsClusteringRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterCount** | **int** | The number of clusters to be used in k-means clustering. | [optional] [default to 3]
**MaxDegreeOfParallelism** | **int** | The Maximum Degrees Of Parallelism | [optional] [default to 1]
**Index** | **string** | Optional index to specify which index to search in. Defaults to &#39;default&#39;. | [optional] 
**MinRelevance** | **decimal** | The minimum relevance value used for querying the search result audit. | [optional] 
**MaxRelevance** | **decimal** | The maximum relevance value to be used in the search query. | [optional] 
**LlmModel** | **string** | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. | [optional] 
**EmbeddingModel** | **string** | The name of the embedding model used for clustering. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

