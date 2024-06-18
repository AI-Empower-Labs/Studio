# SemanticSimilarityResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**documents** | [**List[SemanticSimilarityDocument]**](SemanticSimilarityDocument.md) |  | [optional] 

## Example

```python
from openapi_client.models.semantic_similarity_response import SemanticSimilarityResponse

# TODO update the JSON string below
json = "{}"
# create an instance of SemanticSimilarityResponse from a JSON string
semantic_similarity_response_instance = SemanticSimilarityResponse.from_json(json)
# print the JSON string representation of the object
print(SemanticSimilarityResponse.to_json())

# convert the object into a dict
semantic_similarity_response_dict = semantic_similarity_response_instance.to_dict()
# create an instance of SemanticSimilarityResponse from a dict
semantic_similarity_response_from_dict = SemanticSimilarityResponse.from_dict(semantic_similarity_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


