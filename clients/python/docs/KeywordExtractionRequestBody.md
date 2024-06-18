# KeywordExtractionRequestBody


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** | Text to perform keyword extraction on | 
**model** | **str** | Text to perform keyword extraction on | [optional] 

## Example

```python
from openapi_client.models.keyword_extraction_request_body import KeywordExtractionRequestBody

# TODO update the JSON string below
json = "{}"
# create an instance of KeywordExtractionRequestBody from a JSON string
keyword_extraction_request_body_instance = KeywordExtractionRequestBody.from_json(json)
# print the JSON string representation of the object
print(KeywordExtractionRequestBody.to_json())

# convert the object into a dict
keyword_extraction_request_body_dict = keyword_extraction_request_body_instance.to_dict()
# create an instance of KeywordExtractionRequestBody from a dict
keyword_extraction_request_body_from_dict = KeywordExtractionRequestBody.from_dict(keyword_extraction_request_body_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


