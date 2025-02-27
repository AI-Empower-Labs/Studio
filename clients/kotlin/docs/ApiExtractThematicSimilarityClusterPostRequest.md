
# ApiExtractThematicSimilarityClusterPostRequest

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **input** | **kotlin.collections.List&lt;kotlin.String&gt;** | The input texts for generating clusters |  |
| **clusterCount** | **kotlin.Int** | The number of clusters requested for generating clusters |  |
| **maxDegreeOfParallelism** | **kotlin.Int** | The maximum degree of parallelism for the KMeans clustering algorithm |  [optional] |
| **llmModel** | **kotlin.String** | The name of the LLM model. Optional. |  [optional] |
| **embeddingModel** | **kotlin.String** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. |  [optional] |
| **seed** | **kotlin.Int** | Randomization seed. Optional. |  [optional] |



