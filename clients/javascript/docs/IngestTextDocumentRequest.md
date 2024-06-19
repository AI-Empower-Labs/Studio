# StudioAiEmpowerLabs.IngestTextDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**documentId** | **String** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten | 
**index** | **String** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; | [optional] 
**tags** | **{String: [String]}** | Optionally add tags to ingestion | [optional] 
**text** | **String** | Text to ingest | 
**pipeline** | **[String]** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
**webHookUrl** | **String** | Url to use for webhook callback when operation finishes or fails. | [optional] 
**embeddingModel** | **String** | Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 
**args** | **{String: Object}** |  | [optional] 


