# ListDocumentResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** | Unique record ID | [optional] 
**vector** | **object** | Embedding vector | [optional] 
**tags** | **Dict[str, List[str]]** | Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc. | [optional] 
**payload** | **Dict[str, object]** | Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc. | [optional] 

## Example

```python
from openapi_client.models.list_document_response import ListDocumentResponse

# TODO update the JSON string below
json = "{}"
# create an instance of ListDocumentResponse from a JSON string
list_document_response_instance = ListDocumentResponse.from_json(json)
# print the JSON string representation of the object
print(ListDocumentResponse.to_json())

# convert the object into a dict
list_document_response_dict = list_document_response_instance.to_dict()
# create an instance of ListDocumentResponse from a dict
list_document_response_from_dict = ListDocumentResponse.from_dict(list_document_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


