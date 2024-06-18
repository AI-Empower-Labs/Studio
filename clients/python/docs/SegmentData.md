# SegmentData


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** |  | [optional] 
**start** | [**TimeSpan**](TimeSpan.md) |  | [optional] 
**end** | [**TimeSpan**](TimeSpan.md) |  | [optional] 
**probability** | **float** |  | [optional] 
**language** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.segment_data import SegmentData

# TODO update the JSON string below
json = "{}"
# create an instance of SegmentData from a JSON string
segment_data_instance = SegmentData.from_json(json)
# print the JSON string representation of the object
print(SegmentData.to_json())

# convert the object into a dict
segment_data_dict = segment_data_instance.to_dict()
# create an instance of SegmentData from a dict
segment_data_from_dict = SegmentData.from_dict(segment_data_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


