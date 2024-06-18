# AskDocumentResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**no_result** | **bool** |  | [optional] 
**no_result_reason** | **str** | Content of the answer. | [optional] 
**text** | **str** | Content of the answer. | [optional] 
**relevant_sources** | [**List[DocumentCitation]**](DocumentCitation.md) | List of the relevant sources used to produce the answer.  Key &#x3D; Document ID  Value &#x3D; List of partitions used from the document. | [optional] 

## Example

```python
from openapi_client.models.ask_document_response import AskDocumentResponse

# TODO update the JSON string below
json = "{}"
# create an instance of AskDocumentResponse from a JSON string
ask_document_response_instance = AskDocumentResponse.from_json(json)
# print the JSON string representation of the object
print(AskDocumentResponse.to_json())

# convert the object into a dict
ask_document_response_dict = ask_document_response_instance.to_dict()
# create an instance of AskDocumentResponse from a dict
ask_document_response_from_dict = AskDocumentResponse.from_dict(ask_document_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


