# QueryDocumentResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**relevant_sources** | [**List[DocumentCitation]**](DocumentCitation.md) | List of the relevant sources used to produce the answer.  Key &#x3D; Document ID  Value &#x3D; List of partitions used from the document. | [optional] 

## Example

```python
from openapi_client.models.query_document_response import QueryDocumentResponse

# TODO update the JSON string below
json = "{}"
# create an instance of QueryDocumentResponse from a JSON string
query_document_response_instance = QueryDocumentResponse.from_json(json)
# print the JSON string representation of the object
print(QueryDocumentResponse.to_json())

# convert the object into a dict
query_document_response_dict = query_document_response_instance.to_dict()
# create an instance of QueryDocumentResponse from a dict
query_document_response_from_dict = QueryDocumentResponse.from_dict(query_document_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


