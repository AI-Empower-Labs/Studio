

# ApiExtractThematicSimilarityClusterPostRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**input** | **List&lt;String&gt;** | The input texts for generating clusters |  |
|**clusterCount** | **Integer** | The number of clusters requested for generating clusters |  |
|**maxDegreeOfParallelism** | **Integer** | The maximum degree of parallelism for the KMeans clustering algorithm |  [optional] |
|**maxTokens** | **Integer** | The maximum number of tokens |  [optional] |
|**llmModel** | **String** | The name of the LLM model. Optional. |  [optional] |
|**embeddingModel** | **String** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. |  [optional] |
|**seed** | **Integer** | Randomization seed. Optional. |  [optional] |



