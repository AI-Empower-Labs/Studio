# ReRankDocument


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document** | **str** |  | [optional] 
**index** | **int** |  | [optional] 
**relevance_score** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.re_rank_document import ReRankDocument

# TODO update the JSON string below
json = "{}"
# create an instance of ReRankDocument from a JSON string
re_rank_document_instance = ReRankDocument.from_json(json)
# print the JSON string representation of the object
print(ReRankDocument.to_json())

# convert the object into a dict
re_rank_document_dict = re_rank_document_instance.to_dict()
# create an instance of ReRankDocument from a dict
re_rank_document_from_dict = ReRankDocument.from_dict(re_rank_document_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


