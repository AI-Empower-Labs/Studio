# SemanticSearchQueryResultsClusteringRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cluster_count** | Option<**i32**> | The number of clusters to be used in k-means clustering. | [optional][default to 3]
**max_degree_of_parallelism** | Option<**i32**> | The Maximum Degrees Of Parallelism | [optional][default to 1]
**max_tokens** | Option<**i32**> | The maximum number of tokens to be used in the KMeans clustering algorithm. | [optional][default to 10]
**index** | Option<**String**> | Optional index to specify which index to search in. Defaults to 'default'. | [optional]
**min_relevance** | Option<**f64**> | The minimum relevance value used for querying the search result audit. | [optional]
**max_relevance** | Option<**f64**> | The maximum relevance value to be used in the search query. | [optional]
**llm_model** | Option<**String**> | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. | [optional]
**embedding_model** | Option<**String**> | The name of the embedding model used for clustering. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


