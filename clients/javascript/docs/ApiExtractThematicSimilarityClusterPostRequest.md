# StudioAiEmpowerLabs.ApiExtractThematicSimilarityClusterPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**input** | **[String]** | The input texts for generating clusters | 
**clusterCount** | **Number** | The number of clusters requested for generating clusters | 
**maxDegreeOfParallelism** | **Number** | The maximum degree of parallelism for the KMeans clustering algorithm | [optional] [default to 1]
**maxTokens** | **Number** | The maximum number of tokens | [optional] [default to 10]
**llmModel** | **String** | The name of the LLM model. Optional. | [optional] 
**embeddingModel** | **String** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. | [optional] 


