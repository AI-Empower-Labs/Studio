# QueryDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**query** | Option<**String**> | Semantic query to find matching documents | [optional]
**index** | Option<**String**> | Optional index to specify which index to search in. Defaults to 'default' | [optional]
**filter** | Option<[**Vec<models::DocumentFilters>**](DocumentFilters.md)> | Optional filtering of document id(s) and/or tags | [optional]
**search_mode** | Option<**String**> | Optional search mode defining the context or process used in the query. Supported values are 'hybrid', 'semantic' | [optional]
**language** | Option<**String**> | Specifies the language of the content. | [optional]
**language_detection** | Option<**bool**> | Indicates whether language detection is enabled. | [optional]
**fts_min_score** | Option<**f32**> | Minimum score for full-text search. | [optional]
**fts_weight** | Option<**f32**> | Weight for full-text search. | [optional]
**semantic_min_relevance** | Option<**f64**> | Minimum relevance score for semantic search. | [optional]
**semantic_weight** | Option<**f32**> | Weight applied for semantic search. | [optional]
**smoothing_factor_k** | Option<**f32**> | Smoothing factor (k) used in calculations. | [optional]
**min_relevance** | Option<**f64**> | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional]
**limit** | Option<**i32**> | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional]
**embedding_model** | Option<**String**> | Embedding model to use in query | [optional]
**args** | Option<[**std::collections::HashMap<String, serde_json::Value>**](serde_json::Value.md)> |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


