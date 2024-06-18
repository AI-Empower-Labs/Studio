

# DocumentPartition


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**text** | **String** | Content of the document partition, aka chunk/block of text. |  [optional] |
|**relevance** | **Float** | Relevance of this partition against the given query.  Value usually is between 0 and 1, when using cosine similarity. |  [optional] |
|**lastUpdate** | **OffsetDateTime** | Timestamp about the file/text partition. |  [optional] |
|**tags** | **Map&lt;String, List&lt;String&gt;&gt;** | List of document tags |  [optional] |



