# IngestTextDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document_id** | **String** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten | 
**index** | Option<**String**> | Optional value to specify with index the document should be ingested. Defaults to 'default' | [optional]
**tags** | Option<[**std::collections::HashMap<String, Vec<String>>**](Vec.md)> | Optionally add tags to ingestion | [optional]
**text** | **String** | Text to ingest | 
**pipeline** | Option<**Vec<String>**> | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional]
**web_hook_url** | Option<**String**> | Url to use for webhook callback when operation finishes or fails. | [optional]
**embedding_model** | Option<**String**> | Embedding model to use in ingestion. Optional. Default to configured default. | [optional]
**args** | Option<[**std::collections::HashMap<String, serde_json::Value>**](serde_json::Value.md)> |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


