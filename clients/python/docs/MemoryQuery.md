# MemoryQuery


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**index** | **str** |  | [optional] 
**question** | **str** |  | [optional] 
**filters** | **List[Dict[str, List[str]]]** |  | [optional] 
**min_relevance** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.memory_query import MemoryQuery

# TODO update the JSON string below
json = "{}"
# create an instance of MemoryQuery from a JSON string
memory_query_instance = MemoryQuery.from_json(json)
# print the JSON string representation of the object
print(MemoryQuery.to_json())

# convert the object into a dict
memory_query_dict = memory_query_instance.to_dict()
# create an instance of MemoryQuery from a dict
memory_query_from_dict = MemoryQuery.from_dict(memory_query_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


