# DocumentCitation


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**link** | **str** | URL or reference to the original source document | [optional] 
**index** | **str** | Identifier or position of the citation within the source | [optional] 
**document_id** | **str** | Unique identifier for the document | [optional] 
**file_id** | **str** | Unique identifier for the file in storage | [optional] 
**source_content_type** | **str** | Format of the source (e.g., &#39;pdf&#39;, &#39;docx&#39;, &#39;chat&#39;) | [optional] 
**source_name** | **str** | Human-readable name or title of the source | [optional] 
**source_url** | **str** | Web URL of the source for online content | [optional] 
**partitions** | [**List[DocumentPartition]**](DocumentPartition.md) | Array of text segments used from the source | [optional] 

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


