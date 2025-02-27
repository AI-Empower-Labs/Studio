# StudioAiEmpowerLabs.DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **String** | Content of the document partition, aka chunk/block of text. | [optional] 
**fullTextSearchRank** | **Number** | Rank value calculated from full-text search, used to determine the relevance of search results. | [optional] 
**semanticSimilarity** | **Number** | Represents the semantic similarity score associated with a record. | [optional] 
**fullTextSearchRrf** | **Number** | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. | [optional] 
**semanticRrf** | **Number** | Reciprocal Rank Fusion (RRF) score based on semantic similarity | [optional] 
**rrfScore** | **Number** | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. | [optional] 
**language** | **String** | Language of partition if any. Optional. | [optional] 
**lastUpdate** | **Date** | Timestamp about the file/text partition. | [optional] 
**tags** | **{String: [String]}** | List of document tags | [optional] 


