# KeywordExtractionResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**keywords** | **List[str]** |  | [optional] 

## Example

```python
from openapi_client.models.keyword_extraction_response import KeywordExtractionResponse

# TODO update the JSON string below
json = "{}"
# create an instance of KeywordExtractionResponse from a JSON string
keyword_extraction_response_instance = KeywordExtractionResponse.from_json(json)
# print the JSON string representation of the object
print(KeywordExtractionResponse.to_json())

# convert the object into a dict
keyword_extraction_response_dict = keyword_extraction_response_instance.to_dict()
# create an instance of KeywordExtractionResponse from a dict
keyword_extraction_response_from_dict = KeywordExtractionResponse.from_dict(keyword_extraction_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


