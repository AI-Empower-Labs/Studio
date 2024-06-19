# IngestTextDocumentRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document_id** | **str** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten | 
**index** | **str** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; | [optional] 
**tags** | **Dict[str, List[str]]** | Optionally add tags to ingestion | [optional] 
**text** | **str** | Text to ingest | 
**pipeline** | **List[str]** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
**web_hook_url** | **str** | Url to use for webhook callback when operation finishes or fails. | [optional] 
**embedding_model** | **str** | Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 
**args** | **Dict[str, Optional[object]]** |  | [optional] 

## Example

```python
from openapi_client.models.ingest_text_document_request import IngestTextDocumentRequest

# TODO update the JSON string below
json = "{}"
# create an instance of IngestTextDocumentRequest from a JSON string
ingest_text_document_request_instance = IngestTextDocumentRequest.from_json(json)
# print the JSON string representation of the object
print(IngestTextDocumentRequest.to_json())

# convert the object into a dict
ingest_text_document_request_dict = ingest_text_document_request_instance.to_dict()
# create an instance of IngestTextDocumentRequest from a dict
ingest_text_document_request_from_dict = IngestTextDocumentRequest.from_dict(ingest_text_document_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


