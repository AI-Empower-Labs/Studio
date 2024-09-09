# DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | Option<**String**> | Content of the document partition, aka chunk/block of text. | [optional]
**relevance** | Option<**f32**> | Relevance of this partition against the given query.  Value usually is between 0 and 1, when using cosine similarity. | [optional]
**last_update** | Option<**String**> | Timestamp about the file/text partition. | [optional]
**tags** | Option<[**std::collections::HashMap<String, Vec<String>>**](Vec.md)> | List of document tags | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


