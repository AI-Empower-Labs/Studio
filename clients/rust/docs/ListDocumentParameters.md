# ListDocumentParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**index** | Option<**String**> | Optional index to specify which index to search in. Defaults to 'default' | [optional]
**filter** | Option<[**Vec<models::DocumentFilters>**](DocumentFilters.md)> | Optional filtering of document id(s) and/or tags | [optional]
**with_embeddings** | Option<**bool**> | Optionally specifies if embedding should be returned in response. Default is false | [optional]
**limit** | Option<**i32**> | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional]
**offset** | Option<**i32**> | Optional filter for specifying list offset for paging. Default is 0 | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


