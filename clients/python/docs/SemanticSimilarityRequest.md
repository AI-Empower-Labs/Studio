# SemanticSimilarityRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | **str** | Query text to compare with | [optional] 
**documents** | **List[str]** |  | [optional] 
**model** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.semantic_similarity_request import SemanticSimilarityRequest

# TODO update the JSON string below
json = "{}"
# create an instance of SemanticSimilarityRequest from a JSON string
semantic_similarity_request_instance = SemanticSimilarityRequest.from_json(json)
# print the JSON string representation of the object
print(SemanticSimilarityRequest.to_json())

# convert the object into a dict
semantic_similarity_request_dict = semantic_similarity_request_instance.to_dict()
# create an instance of SemanticSimilarityRequest from a dict
semantic_similarity_request_from_dict = SemanticSimilarityRequest.from_dict(semantic_similarity_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


