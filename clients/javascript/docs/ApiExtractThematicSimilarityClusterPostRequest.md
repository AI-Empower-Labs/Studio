# StudioAiEmpowerLabs.ApiExtractThematicSimilarityClusterPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**input** | **[String]** | The input texts for generating clusters | 
**clusterCount** | **Number** | The number of clusters requested for generating clusters | 
**maxDegreeOfParallelism** | **Number** | The maximum degree of parallelism for the KMeans clustering algorithm | [optional] [default to 1]
**llmModel** | **String** | The name of the LLM model. Optional. | [optional] 
**embeddingModel** | **String** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. | [optional] 
**seed** | **Number** | Randomization seed. Optional. | [optional] 


