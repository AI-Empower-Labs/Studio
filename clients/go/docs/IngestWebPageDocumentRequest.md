# IngestWebPageDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentId** | **string** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten | 
**Index** | Pointer to **NullableString** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; | [optional] 
**Tags** | Pointer to **map[string][]string** | Optionally add tags to ingestion | [optional] 
**Url** | **string** | Web page to ingest | 
**Pipeline** | Pointer to **[]string** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
**WebHookUrl** | Pointer to **NullableString** | Url to use for webhook callback when operation finishes or fails. | [optional] 
**EmbeddingModel** | Pointer to **NullableString** | Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 

## Methods

### NewIngestWebPageDocumentRequest

`func NewIngestWebPageDocumentRequest(documentId string, url string, ) *IngestWebPageDocumentRequest`

NewIngestWebPageDocumentRequest instantiates a new IngestWebPageDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewIngestWebPageDocumentRequestWithDefaults

`func NewIngestWebPageDocumentRequestWithDefaults() *IngestWebPageDocumentRequest`

NewIngestWebPageDocumentRequestWithDefaults instantiates a new IngestWebPageDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetDocumentId

`func (o *IngestWebPageDocumentRequest) GetDocumentId() string`

GetDocumentId returns the DocumentId field if non-nil, zero value otherwise.

### GetDocumentIdOk

`func (o *IngestWebPageDocumentRequest) GetDocumentIdOk() (*string, bool)`

GetDocumentIdOk returns a tuple with the DocumentId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocumentId

`func (o *IngestWebPageDocumentRequest) SetDocumentId(v string)`

SetDocumentId sets DocumentId field to given value.


### GetIndex

`func (o *IngestWebPageDocumentRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *IngestWebPageDocumentRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *IngestWebPageDocumentRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *IngestWebPageDocumentRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *IngestWebPageDocumentRequest) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *IngestWebPageDocumentRequest) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetTags

`func (o *IngestWebPageDocumentRequest) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *IngestWebPageDocumentRequest) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *IngestWebPageDocumentRequest) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *IngestWebPageDocumentRequest) HasTags() bool`

HasTags returns a boolean if a field has been set.

### SetTagsNil

`func (o *IngestWebPageDocumentRequest) SetTagsNil(b bool)`

 SetTagsNil sets the value for Tags to be an explicit nil

### UnsetTags
`func (o *IngestWebPageDocumentRequest) UnsetTags()`

UnsetTags ensures that no value is present for Tags, not even an explicit nil
### GetUrl

`func (o *IngestWebPageDocumentRequest) GetUrl() string`

GetUrl returns the Url field if non-nil, zero value otherwise.

### GetUrlOk

`func (o *IngestWebPageDocumentRequest) GetUrlOk() (*string, bool)`

GetUrlOk returns a tuple with the Url field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetUrl

`func (o *IngestWebPageDocumentRequest) SetUrl(v string)`

SetUrl sets Url field to given value.


### GetPipeline

`func (o *IngestWebPageDocumentRequest) GetPipeline() []string`

GetPipeline returns the Pipeline field if non-nil, zero value otherwise.

### GetPipelineOk

`func (o *IngestWebPageDocumentRequest) GetPipelineOk() (*[]string, bool)`

GetPipelineOk returns a tuple with the Pipeline field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPipeline

`func (o *IngestWebPageDocumentRequest) SetPipeline(v []string)`

SetPipeline sets Pipeline field to given value.

### HasPipeline

`func (o *IngestWebPageDocumentRequest) HasPipeline() bool`

HasPipeline returns a boolean if a field has been set.

### SetPipelineNil

`func (o *IngestWebPageDocumentRequest) SetPipelineNil(b bool)`

 SetPipelineNil sets the value for Pipeline to be an explicit nil

### UnsetPipeline
`func (o *IngestWebPageDocumentRequest) UnsetPipeline()`

UnsetPipeline ensures that no value is present for Pipeline, not even an explicit nil
### GetWebHookUrl

`func (o *IngestWebPageDocumentRequest) GetWebHookUrl() string`

GetWebHookUrl returns the WebHookUrl field if non-nil, zero value otherwise.

### GetWebHookUrlOk

`func (o *IngestWebPageDocumentRequest) GetWebHookUrlOk() (*string, bool)`

GetWebHookUrlOk returns a tuple with the WebHookUrl field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetWebHookUrl

`func (o *IngestWebPageDocumentRequest) SetWebHookUrl(v string)`

SetWebHookUrl sets WebHookUrl field to given value.

### HasWebHookUrl

`func (o *IngestWebPageDocumentRequest) HasWebHookUrl() bool`

HasWebHookUrl returns a boolean if a field has been set.

### SetWebHookUrlNil

`func (o *IngestWebPageDocumentRequest) SetWebHookUrlNil(b bool)`

 SetWebHookUrlNil sets the value for WebHookUrl to be an explicit nil

### UnsetWebHookUrl
`func (o *IngestWebPageDocumentRequest) UnsetWebHookUrl()`

UnsetWebHookUrl ensures that no value is present for WebHookUrl, not even an explicit nil
### GetEmbeddingModel

`func (o *IngestWebPageDocumentRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *IngestWebPageDocumentRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *IngestWebPageDocumentRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *IngestWebPageDocumentRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.

### SetEmbeddingModelNil

`func (o *IngestWebPageDocumentRequest) SetEmbeddingModelNil(b bool)`

 SetEmbeddingModelNil sets the value for EmbeddingModel to be an explicit nil

### UnsetEmbeddingModel
`func (o *IngestWebPageDocumentRequest) UnsetEmbeddingModel()`

UnsetEmbeddingModel ensures that no value is present for EmbeddingModel, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


