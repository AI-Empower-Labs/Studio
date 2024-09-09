# ListDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | Option<**String**> | Unique record ID | [optional]
**vector** | Option<[**serde_json::Value**](.md)> | Embedding vector | [optional]
**tags** | Option<[**std::collections::HashMap<String, Vec<String>>**](Vec.md)> | Optional Searchable Key=Value tags (string => string[] collection)                Multiple values per keys are supported.  e.g. [ \"Collection=Work\", \"Project=1\", \"Project=2\", \"Project=3\", \"Type=Chat\", \"LLM=AzureAda2\" ]                Use cases:   * collections, e.g. [ \"Collection=Project1\", \"Collection=Work\" ]   * folders, e.g. [ \"Folder=Inbox\", \"Folder=Spam\" ]   * content types, e.g. [ \"Type=Chat\" ]   * versioning, e.g. [ \"LLM=AzureAda2\", \"Schema=1.0\" ]   * etc. | [optional]
**payload** | Option<[**std::collections::HashMap<String, serde_json::Value>**](serde_json::Value.md)> | Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


