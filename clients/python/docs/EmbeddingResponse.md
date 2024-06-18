# EmbeddingResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**vectors** | **List[List[float]]** |  | [optional] 

## Example

```python
from openapi_client.models.embedding_response import EmbeddingResponse

# TODO update the JSON string below
json = "{}"
# create an instance of EmbeddingResponse from a JSON string
embedding_response_instance = EmbeddingResponse.from_json(json)
# print the JSON string representation of the object
print(EmbeddingResponse.to_json())

# convert the object into a dict
embedding_response_dict = embedding_response_instance.to_dict()
# create an instance of EmbeddingResponse from a dict
embedding_response_from_dict = EmbeddingResponse.from_dict(embedding_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


