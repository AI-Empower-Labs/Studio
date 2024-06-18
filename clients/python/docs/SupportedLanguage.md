# SupportedLanguage


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**language_code** | **str** |  | [optional] 
**name** | **str** |  | [optional] 
**targets** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.supported_language import SupportedLanguage

# TODO update the JSON string below
json = "{}"
# create an instance of SupportedLanguage from a JSON string
supported_language_instance = SupportedLanguage.from_json(json)
# print the JSON string representation of the object
print(SupportedLanguage.to_json())

# convert the object into a dict
supported_language_dict = supported_language_instance.to_dict()
# create an instance of SupportedLanguage from a dict
supported_language_from_dict = SupportedLanguage.from_dict(supported_language_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


