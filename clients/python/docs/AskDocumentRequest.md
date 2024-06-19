# AskDocumentRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | **str** | Semantic query to find matching documents and ask questions over | [optional] 
**index** | **str** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**filter** | [**List[DocumentFilters]**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**min_relevance** | **float** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**llm_model** | **str** | Large language model to use in query | [optional] 
**embedding_model** | **str** | Embedding model to use in query | [optional] 
**args** | **Dict[str, Optional[object]]** |  | [optional] 

## Example

```python
from openapi_client.models.ask_document_request import AskDocumentRequest

# TODO update the JSON string below
json = "{}"
# create an instance of AskDocumentRequest from a JSON string
ask_document_request_instance = AskDocumentRequest.from_json(json)
# print the JSON string representation of the object
print(AskDocumentRequest.to_json())

# convert the object into a dict
ask_document_request_dict = ask_document_request_instance.to_dict()
# create an instance of AskDocumentRequest from a dict
ask_document_request_from_dict = AskDocumentRequest.from_dict(ask_document_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


