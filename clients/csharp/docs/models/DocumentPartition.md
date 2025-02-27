# Org.OpenAPITools.Model.DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Content of the document partition, aka chunk/block of text. | [optional] 
**FullTextSearchRank** | **float** | Rank value calculated from full-text search, used to determine the relevance of search results. | [optional] 
**SemanticSimilarity** | **float** | Represents the semantic similarity score associated with a record. | [optional] 
**FullTextSearchRrf** | **float** | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. | [optional] 
**SemanticRrf** | **float** | Reciprocal Rank Fusion (RRF) score based on semantic similarity | [optional] 
**RrfScore** | **float** | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. | [optional] 
**Language** | **string** | Language of partition if any. Optional. | [optional] 
**LastUpdate** | **DateTime** | Timestamp about the file/text partition. | [optional] 
**Tags** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | List of document tags | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

