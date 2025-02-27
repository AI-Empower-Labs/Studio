# DocumentPartition


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** | Content of the document partition, aka chunk/block of text. | [optional] 
**full_text_search_rank** | **float** | Rank value calculated from full-text search, used to determine the relevance of search results. | [optional] 
**semantic_similarity** | **float** | Represents the semantic similarity score associated with a record. | [optional] 
**full_text_search_rrf** | **float** | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. | [optional] 
**semantic_rrf** | **float** | Reciprocal Rank Fusion (RRF) score based on semantic similarity | [optional] 
**rrf_score** | **float** | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. | [optional] 
**language** | **str** | Language of partition if any. Optional. | [optional] 
**last_update** | **datetime** | Timestamp about the file/text partition. | [optional] 
**tags** | **Dict[str, List[str]]** | List of document tags | [optional] 

## Example

```python
from openapi_client.models.document_partition import DocumentPartition

# TODO update the JSON string below
json = "{}"
# create an instance of DocumentPartition from a JSON string
document_partition_instance = DocumentPartition.from_json(json)
# print the JSON string representation of the object
print(DocumentPartition.to_json())

# convert the object into a dict
document_partition_dict = document_partition_instance.to_dict()
# create an instance of DocumentPartition from a dict
document_partition_from_dict = DocumentPartition.from_dict(document_partition_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


