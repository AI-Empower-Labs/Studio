# DataPipelineStatus


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**completed** | **bool** |  | [optional] 
**failed** | **bool** |  | [optional] 
**empty** | **bool** |  | [optional] 
**index** | **str** |  | [optional] 
**document_id** | **str** |  | [optional] 
**tags** | **Dict[str, List[str]]** |  | [optional] 
**creation** | **datetime** |  | [optional] 
**last_update** | **datetime** |  | [optional] 
**steps** | **List[str]** |  | [optional] 
**remaining_steps** | **List[str]** |  | [optional] 
**completed_steps** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.data_pipeline_status import DataPipelineStatus

# TODO update the JSON string below
json = "{}"
# create an instance of DataPipelineStatus from a JSON string
data_pipeline_status_instance = DataPipelineStatus.from_json(json)
# print the JSON string representation of the object
print(DataPipelineStatus.to_json())

# convert the object into a dict
data_pipeline_status_dict = data_pipeline_status_instance.to_dict()
# create an instance of DataPipelineStatus from a dict
data_pipeline_status_from_dict = DataPipelineStatus.from_dict(data_pipeline_status_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


