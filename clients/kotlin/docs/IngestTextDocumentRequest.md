
# IngestTextDocumentRequest

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **documentId** | **kotlin.String** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten |  |
| **text** | **kotlin.String** | Text to ingest |  |
| **index** | **kotlin.String** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; |  [optional] |
| **tags** | **kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;** | Optionally add tags to ingestion |  [optional] |
| **pipeline** | **kotlin.collections.List&lt;kotlin.String&gt;** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. |  [optional] |
| **webHookUrl** | **kotlin.String** | Url to use for webhook callback when operation finishes or fails. |  [optional] |
| **embeddingModel** | **kotlin.String** | Embedding model to use in ingestion. Optional. Default to configured default. |  [optional] |
| **args** | [**kotlin.collections.Map&lt;kotlin.String, kotlin.Any&gt;**](kotlin.Any.md) |  |  [optional] |



