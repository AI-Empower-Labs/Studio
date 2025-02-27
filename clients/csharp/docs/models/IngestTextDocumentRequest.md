# Org.OpenAPITools.Model.IngestTextDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Text to ingest | 
**DocumentId** | **string** | Unique identifier for the document to ingest. | 
**Index** | **string** | Optional index name where the document will be stored. | [optional] 
**WebHookUrl** | **string** | Optional webhook URL to notify upon completion. | [optional] 
**EmbeddingModelName** | **string** | Optional name of the embedding model to use during ingestion. | [optional] 
**Context** | **Dictionary&lt;string, string&gt;** | Optional key-value pairs for additional context or metadata. | [optional] 
**Tags** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | A collection of tags associated with the document. Tags can be language-specific. | [optional] 
**IngestionPipeline** | **List&lt;string&gt;** | Optional list of ingestion pipeline steps. Allows custom processing. | [optional] 
**LanguageAutoDetection** | **bool** | Enable automatic language detection for document content. | [optional] [default to false]
**Language** | **string** | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

