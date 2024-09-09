
# DocumentPartition

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **text** | **kotlin.String** | Content of the document partition, aka chunk/block of text. |  [optional] |
| **relevance** | **kotlin.Float** | Relevance of this partition against the given query.  Value usually is between 0 and 1, when using cosine similarity. |  [optional] |
| **lastUpdate** | [**java.time.OffsetDateTime**](java.time.OffsetDateTime.md) | Timestamp about the file/text partition. |  [optional] |
| **tags** | **kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;** | List of document tags |  [optional] |



