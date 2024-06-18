# MemoryAnswer


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**question** | **str** |  | [optional] 
**no_result** | **bool** |  | [optional] 
**no_result_reason** | **str** |  | [optional] 
**text** | **str** |  | [optional] 
**relevant_sources** | [**List[Citation]**](Citation.md) |  | [optional] 

## Example

```python
from openapi_client.models.memory_answer import MemoryAnswer

# TODO update the JSON string below
json = "{}"
# create an instance of MemoryAnswer from a JSON string
memory_answer_instance = MemoryAnswer.from_json(json)
# print the JSON string representation of the object
print(MemoryAnswer.to_json())

# convert the object into a dict
memory_answer_dict = memory_answer_instance.to_dict()
# create an instance of MemoryAnswer from a dict
memory_answer_from_dict = MemoryAnswer.from_dict(memory_answer_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


