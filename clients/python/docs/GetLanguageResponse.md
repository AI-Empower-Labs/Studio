# GetLanguageResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**languages** | [**List[SupportedLanguage]**](SupportedLanguage.md) |  | [optional] 

## Example

```python
from openapi_client.models.get_language_response import GetLanguageResponse

# TODO update the JSON string below
json = "{}"
# create an instance of GetLanguageResponse from a JSON string
get_language_response_instance = GetLanguageResponse.from_json(json)
# print the JSON string representation of the object
print(GetLanguageResponse.to_json())

# convert the object into a dict
get_language_response_dict = get_language_response_instance.to_dict()
# create an instance of GetLanguageResponse from a dict
get_language_response_from_dict = GetLanguageResponse.from_dict(get_language_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


