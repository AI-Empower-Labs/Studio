# TokenizerResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokens** | **List[List[int]]** |  | [optional] 

## Example

```python
from openapi_client.models.tokenizer_response import TokenizerResponse

# TODO update the JSON string below
json = "{}"
# create an instance of TokenizerResponse from a JSON string
tokenizer_response_instance = TokenizerResponse.from_json(json)
# print the JSON string representation of the object
print(TokenizerResponse.to_json())

# convert the object into a dict
tokenizer_response_dict = tokenizer_response_instance.to_dict()
# create an instance of TokenizerResponse from a dict
tokenizer_response_from_dict = TokenizerResponse.from_dict(tokenizer_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


