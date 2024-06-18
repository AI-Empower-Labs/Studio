# ListDocumentParameters


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**index** | **str** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**filter** | [**List[DocumentFilters]**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**with_embeddings** | **bool** | Optionally specifies if embedding should be returned in response. Default is false | [optional] 
**limit** | **int** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**offset** | **int** | Optional filter for specifying list offset for paging. Default is 0 | [optional] 

## Example

```python
from openapi_client.models.list_document_parameters import ListDocumentParameters

# TODO update the JSON string below
json = "{}"
# create an instance of ListDocumentParameters from a JSON string
list_document_parameters_instance = ListDocumentParameters.from_json(json)
# print the JSON string representation of the object
print(ListDocumentParameters.to_json())

# convert the object into a dict
list_document_parameters_dict = list_document_parameters_instance.to_dict()
# create an instance of ListDocumentParameters from a dict
list_document_parameters_from_dict = ListDocumentParameters.from_dict(list_document_parameters_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


