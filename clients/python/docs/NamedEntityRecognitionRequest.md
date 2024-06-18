# NamedEntityRecognitionRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** | Text to perform Named Entity Recognition on  It recognises Persons, Organisations, Dates, Locations and Emails | 
**model** | **str** | LLM Model to use | [optional] 
**entities** | **List[str]** | Entities to extract | 

## Example

```python
from openapi_client.models.named_entity_recognition_request import NamedEntityRecognitionRequest

# TODO update the JSON string below
json = "{}"
# create an instance of NamedEntityRecognitionRequest from a JSON string
named_entity_recognition_request_instance = NamedEntityRecognitionRequest.from_json(json)
# print the JSON string representation of the object
print(NamedEntityRecognitionRequest.to_json())

# convert the object into a dict
named_entity_recognition_request_dict = named_entity_recognition_request_instance.to_dict()
# create an instance of NamedEntityRecognitionRequest from a dict
named_entity_recognition_request_from_dict = NamedEntityRecognitionRequest.from_dict(named_entity_recognition_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


