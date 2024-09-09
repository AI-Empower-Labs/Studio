# ApiExtractThematicSimilarityClusterPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**input** | **Vec<String>** | The input texts for generating clusters | 
**cluster_count** | **i32** | The number of clusters requested for generating clusters | 
**max_degree_of_parallelism** | Option<**i32**> | The maximum degree of parallelism for the KMeans clustering algorithm | [optional][default to 1]
**max_tokens** | Option<**i32**> | The maximum number of tokens | [optional][default to 10]
**llm_model** | Option<**String**> | The name of the LLM model. Optional. | [optional]
**embedding_model** | Option<**String**> | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. | [optional]
**seed** | Option<**i32**> | Randomization seed. Optional. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


