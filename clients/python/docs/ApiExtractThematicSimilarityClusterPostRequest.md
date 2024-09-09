# ApiExtractThematicSimilarityClusterPostRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**input** | **List[str]** | The input texts for generating clusters | 
**cluster_count** | **int** | The number of clusters requested for generating clusters | 
**max_degree_of_parallelism** | **int** | The maximum degree of parallelism for the KMeans clustering algorithm | [optional] [default to 1]
**max_tokens** | **int** | The maximum number of tokens | [optional] [default to 10]
**llm_model** | **str** | The name of the LLM model. Optional. | [optional] 
**embedding_model** | **str** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. | [optional] 
**seed** | **int** | Randomization seed. Optional. | [optional] 

## Example

```python
from openapi_client.models.api_extract_thematic_similarity_cluster_post_request import ApiExtractThematicSimilarityClusterPostRequest

# TODO update the JSON string below
json = "{}"
# create an instance of ApiExtractThematicSimilarityClusterPostRequest from a JSON string
api_extract_thematic_similarity_cluster_post_request_instance = ApiExtractThematicSimilarityClusterPostRequest.from_json(json)
# print the JSON string representation of the object
print(ApiExtractThematicSimilarityClusterPostRequest.to_json())

# convert the object into a dict
api_extract_thematic_similarity_cluster_post_request_dict = api_extract_thematic_similarity_cluster_post_request_instance.to_dict()
# create an instance of ApiExtractThematicSimilarityClusterPostRequest from a dict
api_extract_thematic_similarity_cluster_post_request_from_dict = ApiExtractThematicSimilarityClusterPostRequest.from_dict(api_extract_thematic_similarity_cluster_post_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


