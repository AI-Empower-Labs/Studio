# TokenCountResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokens** | **int** |  | [optional] 

## Example

```python
from openapi_client.models.token_count_response import TokenCountResponse

# TODO update the JSON string below
json = "{}"
# create an instance of TokenCountResponse from a JSON string
token_count_response_instance = TokenCountResponse.from_json(json)
# print the JSON string representation of the object
print(TokenCountResponse.to_json())

# convert the object into a dict
token_count_response_dict = token_count_response_instance.to_dict()
# create an instance of TokenCountResponse from a dict
token_count_response_from_dict = TokenCountResponse.from_dict(token_count_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


