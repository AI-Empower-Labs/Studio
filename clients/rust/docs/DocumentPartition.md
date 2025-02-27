# DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | Option<**String**> | Content of the document partition, aka chunk/block of text. | [optional]
**full_text_search_rank** | Option<**f32**> | Rank value calculated from full-text search, used to determine the relevance of search results. | [optional]
**semantic_similarity** | Option<**f32**> | Represents the semantic similarity score associated with a record. | [optional]
**full_text_search_rrf** | Option<**f32**> | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. | [optional]
**semantic_rrf** | Option<**f32**> | Reciprocal Rank Fusion (RRF) score based on semantic similarity | [optional]
**rrf_score** | Option<**f32**> | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. | [optional]
**language** | Option<**String**> | Language of partition if any. Optional. | [optional]
**last_update** | Option<**String**> | Timestamp about the file/text partition. | [optional]
**tags** | Option<[**std::collections::HashMap<String, Vec<String>>**](Vec.md)> | List of document tags | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


