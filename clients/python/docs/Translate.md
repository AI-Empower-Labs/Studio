# Translate

Represents a translation request with the source text, source language, and target language.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** | The input text to be translated. | [optional] 
**source** | **str** | The language code of the input text. | [optional] 
**target** | **str** | The language code of the desired output translation. | [optional] 

## Example

```python
from openapi_client.models.translate import Translate

# TODO update the JSON string below
json = "{}"
# create an instance of Translate from a JSON string
translate_instance = Translate.from_json(json)
# print the JSON string representation of the object
print(Translate.to_json())

# convert the object into a dict
translate_dict = translate_instance.to_dict()
# create an instance of Translate from a dict
translate_from_dict = Translate.from_dict(translate_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


