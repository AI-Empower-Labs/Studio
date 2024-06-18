# IngestDocumentResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** | Ingestion queue identifier | [optional] 
**index** | **str** | Index ingestion is written to | [optional] 
**document_id** | **str** | Identity of the document written to index | [optional] 
**pipeline** | **List[str]** | Index ingestion is written to | [optional] 

## Example

```python
from openapi_client.models.ingest_document_response import IngestDocumentResponse

# TODO update the JSON string below
json = "{}"
# create an instance of IngestDocumentResponse from a JSON string
ingest_document_response_instance = IngestDocumentResponse.from_json(json)
# print the JSON string representation of the object
print(IngestDocumentResponse.to_json())

# convert the object into a dict
ingest_document_response_dict = ingest_document_response_instance.to_dict()
# create an instance of IngestDocumentResponse from a dict
ingest_document_response_from_dict = IngestDocumentResponse.from_dict(ingest_document_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


