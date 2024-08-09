# Org.OpenAPITools.Model.ApiExtractThematicSimilarityClusterPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Input** | **List&lt;string&gt;** | The input texts for generating clusters | 
**ClusterCount** | **int** | The number of clusters requested for generating clusters | 
**MaxDegreeOfParallelism** | **int** | The maximum degree of parallelism for the KMeans clustering algorithm | [optional] [default to 1]
**MaxTokens** | **int** | The maximum number of tokens | [optional] [default to 10]
**LlmModel** | **string** | The name of the LLM model. Optional. | [optional] 
**EmbeddingModel** | **string** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

