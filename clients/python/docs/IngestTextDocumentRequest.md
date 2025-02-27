# IngestTextDocumentRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** | Text to ingest | 
**document_id** | **str** | Unique identifier for the document to ingest. | 
**index** | **str** | Optional index name where the document will be stored. | [optional] 
**web_hook_url** | **str** | Optional webhook URL to notify upon completion. | [optional] 
**embedding_model_name** | **str** | Optional name of the embedding model to use during ingestion. | [optional] 
**context** | **Dict[str, str]** | Optional key-value pairs for additional context or metadata. | [optional] 
**tags** | **Dict[str, List[str]]** | A collection of tags associated with the document. Tags can be language-specific. | [optional] 
**ingestion_pipeline** | **List[str]** | Optional list of ingestion pipeline steps. Allows custom processing. | [optional] 
**language_auto_detection** | **bool** | Enable automatic language detection for document content. | [optional] [default to False]
**language** | **str** | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] 

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


