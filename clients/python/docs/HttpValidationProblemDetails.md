# HttpValidationProblemDetails


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**type** | **str** |  | [optional] 
**title** | **str** |  | [optional] 
**status** | **int** |  | [optional] 
**detail** | **str** |  | [optional] 
**instance** | **str** |  | [optional] 
**errors** | **Dict[str, List[str]]** |  | [optional] 

## Example

```python
from openapi_client.models.http_validation_problem_details import HttpValidationProblemDetails

# TODO update the JSON string below
json = "{}"
# create an instance of HttpValidationProblemDetails from a JSON string
http_validation_problem_details_instance = HttpValidationProblemDetails.from_json(json)
# print the JSON string representation of the object
print(HttpValidationProblemDetails.to_json())

# convert the object into a dict
http_validation_problem_details_dict = http_validation_problem_details_instance.to_dict()
# create an instance of HttpValidationProblemDetails from a dict
http_validation_problem_details_from_dict = HttpValidationProblemDetails.from_dict(http_validation_problem_details_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


