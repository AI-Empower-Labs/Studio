# SemanticSimilarityDocument


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document** | **str** |  | [optional] 
**distance** | **float** |  | [optional] 

## Example

```python
from openapi_client.models.semantic_similarity_document import SemanticSimilarityDocument

# TODO update the JSON string below
json = "{}"
# create an instance of SemanticSimilarityDocument from a JSON string
semantic_similarity_document_instance = SemanticSimilarityDocument.from_json(json)
# print the JSON string representation of the object
print(SemanticSimilarityDocument.to_json())

# convert the object into a dict
semantic_similarity_document_dict = semantic_similarity_document_instance.to_dict()
# create an instance of SemanticSimilarityDocument from a dict
semantic_similarity_document_from_dict = SemanticSimilarityDocument.from_dict(semantic_similarity_document_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


