# Citation


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**link** | **str** |  | [optional] 
**index** | **str** |  | [optional] 
**document_id** | **str** |  | [optional] 
**file_id** | **str** |  | [optional] 
**source_content_type** | **str** |  | [optional] 
**source_name** | **str** |  | [optional] 
**source_url** | **str** |  | [optional] 
**partitions** | [**List[Partition]**](Partition.md) |  | [optional] 

## Example

```python
from openapi_client.models.citation import Citation

# TODO update the JSON string below
json = "{}"
# create an instance of Citation from a JSON string
citation_instance = Citation.from_json(json)
# print the JSON string representation of the object
print(Citation.to_json())

# convert the object into a dict
citation_dict = citation_instance.to_dict()
# create an instance of Citation from a dict
citation_from_dict = Citation.from_dict(citation_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


