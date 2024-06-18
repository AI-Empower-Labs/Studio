# Org.OpenAPITools.Model.DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Content of the document partition, aka chunk/block of text. | [optional] 
**Relevance** | **float** | Relevance of this partition against the given query.  Value usually is between 0 and 1, when using cosine similarity. | [optional] 
**LastUpdate** | **DateTime** | Timestamp about the file/text partition. | [optional] 
**Tags** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | List of document tags | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

