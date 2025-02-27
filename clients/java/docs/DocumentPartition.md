

# DocumentPartition


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**text** | **String** | Content of the document partition, aka chunk/block of text. |  [optional] |
|**fullTextSearchRank** | **Float** | Rank value calculated from full-text search, used to determine the relevance of search results. |  [optional] |
|**semanticSimilarity** | **Float** | Represents the semantic similarity score associated with a record. |  [optional] |
|**fullTextSearchRrf** | **Float** | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. |  [optional] |
|**semanticRrf** | **Float** | Reciprocal Rank Fusion (RRF) score based on semantic similarity |  [optional] |
|**rrfScore** | **Float** | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. |  [optional] |
|**language** | **String** | Language of partition if any. Optional. |  [optional] |
|**lastUpdate** | **OffsetDateTime** | Timestamp about the file/text partition. |  [optional] |
|**tags** | **Map&lt;String, List&lt;String&gt;&gt;** | List of document tags |  [optional] |



