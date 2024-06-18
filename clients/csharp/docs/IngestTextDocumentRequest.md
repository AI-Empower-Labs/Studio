# Org.OpenAPITools.Model.IngestTextDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentId** | **string** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten | 
**Index** | **string** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; | [optional] 
**Tags** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Optionally add tags to ingestion | [optional] 
**Text** | **string** | Text to ingest | 
**Pipeline** | **List&lt;string&gt;** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
**WebHookUrl** | **string** | Url to use for webhook callback when operation finishes or fails. | [optional] 
**EmbeddingModel** | **string** | Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

