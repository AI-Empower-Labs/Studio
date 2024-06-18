# ReRankDocumentsRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**model** | **str** | Optional embedding model. Defaults to configured default | [optional] 
**query** | **str** | Semantic query to find matching documents | [optional] 
**documents** | **List[str]** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**limit** | **int** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 

## Example

```python
from openapi_client.models.re_rank_documents_request import ReRankDocumentsRequest

# TODO update the JSON string below
json = "{}"
# create an instance of ReRankDocumentsRequest from a JSON string
re_rank_documents_request_instance = ReRankDocumentsRequest.from_json(json)
# print the JSON string representation of the object
print(ReRankDocumentsRequest.to_json())

# convert the object into a dict
re_rank_documents_request_dict = re_rank_documents_request_instance.to_dict()
# create an instance of ReRankDocumentsRequest from a dict
re_rank_documents_request_from_dict = ReRankDocumentsRequest.from_dict(re_rank_documents_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


