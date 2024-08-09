# SemanticSearchQueryResultsClusteringRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cluster_count** | **int** | The number of clusters to be used in k-means clustering. | [optional] [default to 3]
**max_degree_of_parallelism** | **int** | The Maximum Degrees Of Parallelism | [optional] [default to 1]
**max_tokens** | **int** | The maximum number of tokens to be used in the KMeans clustering algorithm. | [optional] [default to 10]
**index** | **str** | Optional index to specify which index to search in. Defaults to &#39;default&#39;. | [optional] 
**min_relevance** | **float** | The minimum relevance value used for querying the search result audit. | [optional] 
**max_relevance** | **float** | The maximum relevance value to be used in the search query. | [optional] 
**llm_model** | **str** | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. | [optional] 
**embedding_model** | **str** | The name of the embedding model used for clustering. | [optional] 

## Example

```python
from openapi_client.models.semantic_search_query_results_clustering_request import SemanticSearchQueryResultsClusteringRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SemanticSearchQueryResultsClusteringRequest from a JSON string
semantic_search_query_results_clustering_request_instance = SemanticSearchQueryResultsClusteringRequest.from_json(json)
# print the JSON string representation of the object
print(SemanticSearchQueryResultsClusteringRequest.to_json())

# convert the object into a dict
semantic_search_query_results_clustering_request_dict = semantic_search_query_results_clustering_request_instance.to_dict()
# create an instance of SemanticSearchQueryResultsClusteringRequest from a dict
semantic_search_query_results_clustering_request_from_dict = SemanticSearchQueryResultsClusteringRequest.from_dict(semantic_search_query_results_clustering_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


