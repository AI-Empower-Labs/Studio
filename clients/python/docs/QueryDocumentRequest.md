# QueryDocumentRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | **str** | Semantic query to find matching documents | [optional] 
**index** | **str** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**filter** | [**List[DocumentFilters]**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**search_mode** | **str** | Optional search mode defining the context or process used in the query. Supported values are &#39;hybrid&#39;, &#39;semantic&#39; | [optional] 
**language** | **str** | Specifies the language of the content. | [optional] 
**language_detection** | **bool** | Indicates whether language detection is enabled. | [optional] 
**fts_min_score** | **float** | Minimum score for full-text search. | [optional] 
**fts_weight** | **float** | Weight for full-text search. | [optional] 
**semantic_min_relevance** | **float** | Minimum relevance score for semantic search. | [optional] 
**semantic_weight** | **float** | Weight applied for semantic search. | [optional] 
**smoothing_factor_k** | **float** | Smoothing factor (k) used in calculations. | [optional] 
**min_relevance** | **float** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**limit** | **int** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**embedding_model** | **str** | Embedding model to use in query | [optional] 
**args** | **Dict[str, Optional[object]]** |  | [optional] 

## Example

```python
from openapi_client.models.query_document_request import QueryDocumentRequest

# TODO update the JSON string below
json = "{}"
# create an instance of QueryDocumentRequest from a JSON string
query_document_request_instance = QueryDocumentRequest.from_json(json)
# print the JSON string representation of the object
print(QueryDocumentRequest.to_json())

# convert the object into a dict
query_document_request_dict = query_document_request_instance.to_dict()
# create an instance of QueryDocumentRequest from a dict
query_document_request_from_dict = QueryDocumentRequest.from_dict(query_document_request_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


