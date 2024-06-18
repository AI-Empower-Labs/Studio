# TokenCountRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** |  | [optional] 
**text** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.token_count_request import TokenCountRequest

# TODO update the JSON string below
json = "{}"
# create an instance of TokenCountRequest from a JSON string
token_count_request_instance = TokenCountRequest.from_json(json)
# print the JSON string representation of the object
print(TokenCountRequest.to_json())

# convert the object into a dict
token_count_request_dict = token_count_request_instance.to_dict()
# create an instance of TokenCountRequest from a dict
token_count_request_from_dict = TokenCountRequest.from_dict(token_count_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


