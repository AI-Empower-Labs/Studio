# NamedEntityRecognitionResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**entities** | **Dict[str, List[str]]** |  | [optional] 

## Example

```python
from openapi_client.models.named_entity_recognition_response import NamedEntityRecognitionResponse

# TODO update the JSON string below
json = "{}"
# create an instance of NamedEntityRecognitionResponse from a JSON string
named_entity_recognition_response_instance = NamedEntityRecognitionResponse.from_json(json)
# print the JSON string representation of the object
print(NamedEntityRecognitionResponse.to_json())

# convert the object into a dict
named_entity_recognition_response_dict = named_entity_recognition_response_instance.to_dict()
# create an instance of NamedEntityRecognitionResponse from a dict
named_entity_recognition_response_from_dict = NamedEntityRecognitionResponse.from_dict(named_entity_recognition_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


