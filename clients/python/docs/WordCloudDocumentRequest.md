# WordCloudDocumentRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**index** | **str** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**filter** | [**List[DocumentFilters]**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**limit** | **int** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**source** | **str** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 

## Example

```python
from openapi_client.models.word_cloud_document_request import WordCloudDocumentRequest

# TODO update the JSON string below
json = "{}"
# create an instance of WordCloudDocumentRequest from a JSON string
word_cloud_document_request_instance = WordCloudDocumentRequest.from_json(json)
# print the JSON string representation of the object
print(WordCloudDocumentRequest.to_json())

# convert the object into a dict
word_cloud_document_request_dict = word_cloud_document_request_instance.to_dict()
# create an instance of WordCloudDocumentRequest from a dict
word_cloud_document_request_from_dict = WordCloudDocumentRequest.from_dict(word_cloud_document_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


