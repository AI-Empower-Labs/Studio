# AskDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**no_result** | Option<**bool**> |  | [optional]
**no_result_reason** | Option<**String**> | Content of the answer. | [optional]
**text** | Option<**String**> | Content of the answer. | [optional]
**relevant_sources** | Option<[**Vec<models::DocumentCitation>**](DocumentCitation.md)> | List of the relevant sources used to produce the answer.  Key = Document ID  Value = List of partitions used from the document. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


