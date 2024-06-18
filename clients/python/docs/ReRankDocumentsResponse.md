# ReRankDocumentsResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**documents** | [**List[ReRankDocument]**](ReRankDocument.md) |  | [optional] 

## Example

```python
from openapi_client.models.re_rank_documents_response import ReRankDocumentsResponse

# TODO update the JSON string below
json = "{}"
# create an instance of ReRankDocumentsResponse from a JSON string
re_rank_documents_response_instance = ReRankDocumentsResponse.from_json(json)
# print the JSON string representation of the object
print(ReRankDocumentsResponse.to_json())

# convert the object into a dict
re_rank_documents_response_dict = re_rank_documents_response_instance.to_dict()
# create an instance of ReRankDocumentsResponse from a dict
re_rank_documents_response_from_dict = ReRankDocumentsResponse.from_dict(re_rank_documents_response_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


