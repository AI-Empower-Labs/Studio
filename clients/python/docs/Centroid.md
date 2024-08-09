# Centroid

Represents a centroid for a cluster, includes coordinate and array of datapoints

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**coordinate** | [**Coordinate**](Coordinate.md) |  | [optional] 
**data_points** | [**List[Coordinate]**](Coordinate.md) | Array of data points belonging to the centroid | [optional] 

## Example

```python
from openapi_client.models.centroid import Centroid

# TODO update the JSON string below
json = "{}"
# create an instance of Centroid from a JSON string
centroid_instance = Centroid.from_json(json)
# print the JSON string representation of the object
print(Centroid.to_json())

# convert the object into a dict
centroid_dict = centroid_instance.to_dict()
# create an instance of Centroid from a dict
centroid_from_dict = Centroid.from_dict(centroid_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


