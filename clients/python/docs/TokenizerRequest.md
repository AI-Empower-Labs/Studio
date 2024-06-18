# TokenizerRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** |  | [optional] 
**text** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.tokenizer_request import TokenizerRequest

# TODO update the JSON string below
json = "{}"
# create an instance of TokenizerRequest from a JSON string
tokenizer_request_instance = TokenizerRequest.from_json(json)
# print the JSON string representation of the object
print(TokenizerRequest.to_json())

# convert the object into a dict
tokenizer_request_dict = tokenizer_request_instance.to_dict()
# create an instance of TokenizerRequest from a dict
tokenizer_request_from_dict = TokenizerRequest.from_dict(tokenizer_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


