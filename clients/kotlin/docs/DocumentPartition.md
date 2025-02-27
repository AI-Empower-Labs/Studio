
# DocumentPartition

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **text** | **kotlin.String** | Content of the document partition, aka chunk/block of text. |  [optional] |
| **fullTextSearchRank** | **kotlin.Float** | Rank value calculated from full-text search, used to determine the relevance of search results. |  [optional] |
| **semanticSimilarity** | **kotlin.Float** | Represents the semantic similarity score associated with a record. |  [optional] |
| **fullTextSearchRrf** | **kotlin.Float** | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. |  [optional] |
| **semanticRrf** | **kotlin.Float** | Reciprocal Rank Fusion (RRF) score based on semantic similarity |  [optional] |
| **rrfScore** | **kotlin.Float** | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. |  [optional] |
| **language** | **kotlin.String** | Language of partition if any. Optional. |  [optional] |
| **lastUpdate** | [**java.time.OffsetDateTime**](java.time.OffsetDateTime.md) | Timestamp about the file/text partition. |  [optional] |
| **tags** | **kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;** | List of document tags |  [optional] |



