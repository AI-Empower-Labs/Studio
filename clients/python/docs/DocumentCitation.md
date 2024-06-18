# DocumentCitation


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**link** | **str** | Link to the source, if available. | [optional] 
**index** | **str** | Link to the source, if available. | [optional] 
**document_id** | **str** | Link to the source, if available. | [optional] 
**file_id** | **str** | Link to the source, if available. | [optional] 
**source_content_type** | **str** | Type of source, e.g. PDF, Word, Chat, etc. | [optional] 
**source_name** | **str** | Name of the source, e.g. file name. | [optional] 
**source_url** | **str** | URL of the source, used for web pages and external data | [optional] 
**partitions** | [**List[DocumentPartition]**](DocumentPartition.md) | List of chunks/blocks of text used. | [optional] 

## Example

```python
from openapi_client.models.document_citation import DocumentCitation

# TODO update the JSON string below
json = "{}"
# create an instance of DocumentCitation from a JSON string
document_citation_instance = DocumentCitation.from_json(json)
# print the JSON string representation of the object
print(DocumentCitation.to_json())

# convert the object into a dict
document_citation_dict = document_citation_instance.to_dict()
# create an instance of DocumentCitation from a dict
document_citation_from_dict = DocumentCitation.from_dict(document_citation_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


