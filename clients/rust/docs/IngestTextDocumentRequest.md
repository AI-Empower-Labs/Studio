# IngestTextDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**text** | **String** | Text to ingest | 
**document_id** | **String** | Unique identifier for the document to ingest. | 
**index** | Option<**String**> | Optional index name where the document will be stored. | [optional]
**web_hook_url** | Option<**String**> | Optional webhook URL to notify upon completion. | [optional]
**embedding_model_name** | Option<**String**> | Optional name of the embedding model to use during ingestion. | [optional]
**context** | Option<**std::collections::HashMap<String, String>**> | Optional key-value pairs for additional context or metadata. | [optional]
**tags** | Option<[**std::collections::HashMap<String, Vec<String>>**](Vec.md)> | A collection of tags associated with the document. Tags can be language-specific. | [optional]
**ingestion_pipeline** | Option<**Vec<String>**> | Optional list of ingestion pipeline steps. Allows custom processing. | [optional]
**language_auto_detection** | Option<**bool**> | Enable automatic language detection for document content. | [optional][default to false]
**language** | Option<**String**> | Force a specific language for full-text search. Use 'simple' for no language or leave empty. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


