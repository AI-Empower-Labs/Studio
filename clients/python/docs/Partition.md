# Partition


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** |  | [optional] 
**relevance** | **float** |  | [optional] 
**partition_number** | **int** |  | [optional] 
**section_number** | **int** |  | [optional] 
**last_update** | **datetime** |  | [optional] 
**tags** | **Dict[str, List[str]]** |  | [optional] 

## Example

```python
from openapi_client.models.partition import Partition

# TODO update the JSON string below
json = "{}"
# create an instance of Partition from a JSON string
partition_instance = Partition.from_json(json)
# print the JSON string representation of the object
print(Partition.to_json())

# convert the object into a dict
partition_dict = partition_instance.to_dict()
# create an instance of Partition from a dict
partition_from_dict = Partition.from_dict(partition_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


