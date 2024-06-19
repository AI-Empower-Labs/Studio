# StreamableFileContent


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**file_name** | **str** |  | [optional] [readonly] 
**file_size** | **int** |  | [optional] [readonly] 
**file_type** | **str** |  | [optional] [readonly] 
**last_write** | **datetime** |  | [optional] [readonly] 

## Example

```python
from openapi_client.models.streamable_file_content import StreamableFileContent

# TODO update the JSON string below
json = "{}"
# create an instance of StreamableFileContent from a JSON string
streamable_file_content_instance = StreamableFileContent.from_json(json)
# print the JSON string representation of the object
print(StreamableFileContent.to_json())

# convert the object into a dict
streamable_file_content_dict = streamable_file_content_instance.to_dict()
# create an instance of StreamableFileContent from a dict
streamable_file_content_from_dict = StreamableFileContent.from_dict(streamable_file_content_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


