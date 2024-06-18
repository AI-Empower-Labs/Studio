# DocumentPartition


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **str** | Content of the document partition, aka chunk/block of text. | [optional] 
**relevance** | **float** | Relevance of this partition against the given query.  Value usually is between 0 and 1, when using cosine similarity. | [optional] 
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


