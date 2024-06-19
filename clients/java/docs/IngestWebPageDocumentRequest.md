

# IngestWebPageDocumentRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**documentId** | **String** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten |  |
|**index** | **String** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; |  [optional] |
|**tags** | **Map&lt;String, List&lt;String&gt;&gt;** | Optionally add tags to ingestion |  [optional] |
|**url** | **String** | Web page to ingest |  |
|**pipeline** | **List&lt;String&gt;** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. |  [optional] |
|**webHookUrl** | **String** | Url to use for webhook callback when operation finishes or fails. |  [optional] |
|**embeddingModel** | **String** | Embedding model to use in ingestion. Optional. Default to configured default. |  [optional] |
|**args** | **Map&lt;String, Object&gt;** |  |  [optional] |



