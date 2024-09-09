# AskDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | Option<**String**> | Semantic query to find matching documents and ask questions over | [optional]
**index** | Option<**String**> | Optional index to specify which index to search in. Defaults to 'default' | [optional]
**filter** | Option<[**Vec<models::DocumentFilters>**](DocumentFilters.md)> | Optional filtering of document id(s) and/or tags | [optional]
**min_relevance** | Option<**f64**> | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional]
**llm_model** | Option<**String**> | Large language model to use in query | [optional]
**embedding_model** | Option<**String**> | Embedding model to use in query | [optional]
**args** | Option<[**std::collections::HashMap<String, serde_json::Value>**](serde_json::Value.md)> |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


