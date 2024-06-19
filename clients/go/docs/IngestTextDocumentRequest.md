# IngestTextDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentId** | **string** | Id that uniquely identifies content. Previously ingested documents with the same id will be overwritten | 
**Index** | Pointer to **NullableString** | Optional value to specify with index the document should be ingested. Defaults to &#39;default&#39; | [optional] 
**Tags** | Pointer to **map[string][]string** | Optionally add tags to ingestion | [optional] 
**Text** | **string** | Text to ingest | 
**Pipeline** | Pointer to **[]string** | Optional value to specify ingestion pipeline steps. Defaults to server configured defaults. | [optional] 
**WebHookUrl** | Pointer to **NullableString** | Url to use for webhook callback when operation finishes or fails. | [optional] 
**EmbeddingModel** | Pointer to **NullableString** | Embedding model to use in ingestion. Optional. Default to configured default. | [optional] 
**Args** | Pointer to **map[string]interface{}** |  | [optional] 

## Methods

### NewIngestTextDocumentRequest

`func NewIngestTextDocumentRequest(documentId string, text string, ) *IngestTextDocumentRequest`

NewIngestTextDocumentRequest instantiates a new IngestTextDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewIngestTextDocumentRequestWithDefaults

`func NewIngestTextDocumentRequestWithDefaults() *IngestTextDocumentRequest`

NewIngestTextDocumentRequestWithDefaults instantiates a new IngestTextDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetDocumentId

`func (o *IngestTextDocumentRequest) GetDocumentId() string`

GetDocumentId returns the DocumentId field if non-nil, zero value otherwise.

### GetDocumentIdOk

`func (o *IngestTextDocumentRequest) GetDocumentIdOk() (*string, bool)`

GetDocumentIdOk returns a tuple with the DocumentId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocumentId

`func (o *IngestTextDocumentRequest) SetDocumentId(v string)`

SetDocumentId sets DocumentId field to given value.


### GetIndex

`func (o *IngestTextDocumentRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *IngestTextDocumentRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *IngestTextDocumentRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *IngestTextDocumentRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *IngestTextDocumentRequest) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *IngestTextDocumentRequest) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetTags

`func (o *IngestTextDocumentRequest) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *IngestTextDocumentRequest) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *IngestTextDocumentRequest) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *IngestTextDocumentRequest) HasTags() bool`

HasTags returns a boolean if a field has been set.

### SetTagsNil

`func (o *IngestTextDocumentRequest) SetTagsNil(b bool)`

 SetTagsNil sets the value for Tags to be an explicit nil

### UnsetTags
`func (o *IngestTextDocumentRequest) UnsetTags()`

UnsetTags ensures that no value is present for Tags, not even an explicit nil
### GetText

`func (o *IngestTextDocumentRequest) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *IngestTextDocumentRequest) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *IngestTextDocumentRequest) SetText(v string)`

SetText sets Text field to given value.


### GetPipeline

`func (o *IngestTextDocumentRequest) GetPipeline() []string`

GetPipeline returns the Pipeline field if non-nil, zero value otherwise.

### GetPipelineOk

`func (o *IngestTextDocumentRequest) GetPipelineOk() (*[]string, bool)`

GetPipelineOk returns a tuple with the Pipeline field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPipeline

`func (o *IngestTextDocumentRequest) SetPipeline(v []string)`

SetPipeline sets Pipeline field to given value.

### HasPipeline

`func (o *IngestTextDocumentRequest) HasPipeline() bool`

HasPipeline returns a boolean if a field has been set.

### SetPipelineNil

`func (o *IngestTextDocumentRequest) SetPipelineNil(b bool)`

 SetPipelineNil sets the value for Pipeline to be an explicit nil

### UnsetPipeline
`func (o *IngestTextDocumentRequest) UnsetPipeline()`

UnsetPipeline ensures that no value is present for Pipeline, not even an explicit nil
### GetWebHookUrl

`func (o *IngestTextDocumentRequest) GetWebHookUrl() string`

GetWebHookUrl returns the WebHookUrl field if non-nil, zero value otherwise.

### GetWebHookUrlOk

`func (o *IngestTextDocumentRequest) GetWebHookUrlOk() (*string, bool)`

GetWebHookUrlOk returns a tuple with the WebHookUrl field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetWebHookUrl

`func (o *IngestTextDocumentRequest) SetWebHookUrl(v string)`

SetWebHookUrl sets WebHookUrl field to given value.

### HasWebHookUrl

`func (o *IngestTextDocumentRequest) HasWebHookUrl() bool`

HasWebHookUrl returns a boolean if a field has been set.

### SetWebHookUrlNil

`func (o *IngestTextDocumentRequest) SetWebHookUrlNil(b bool)`

 SetWebHookUrlNil sets the value for WebHookUrl to be an explicit nil

### UnsetWebHookUrl
`func (o *IngestTextDocumentRequest) UnsetWebHookUrl()`

UnsetWebHookUrl ensures that no value is present for WebHookUrl, not even an explicit nil
### GetEmbeddingModel

`func (o *IngestTextDocumentRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *IngestTextDocumentRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *IngestTextDocumentRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *IngestTextDocumentRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.

### SetEmbeddingModelNil

`func (o *IngestTextDocumentRequest) SetEmbeddingModelNil(b bool)`

 SetEmbeddingModelNil sets the value for EmbeddingModel to be an explicit nil

### UnsetEmbeddingModel
`func (o *IngestTextDocumentRequest) UnsetEmbeddingModel()`

UnsetEmbeddingModel ensures that no value is present for EmbeddingModel, not even an explicit nil
### GetArgs

`func (o *IngestTextDocumentRequest) GetArgs() map[string]interface{}`

GetArgs returns the Args field if non-nil, zero value otherwise.

### GetArgsOk

`func (o *IngestTextDocumentRequest) GetArgsOk() (*map[string]interface{}, bool)`

GetArgsOk returns a tuple with the Args field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetArgs

`func (o *IngestTextDocumentRequest) SetArgs(v map[string]interface{})`

SetArgs sets Args field to given value.

### HasArgs

`func (o *IngestTextDocumentRequest) HasArgs() bool`

HasArgs returns a boolean if a field has been set.

### SetArgsNil

`func (o *IngestTextDocumentRequest) SetArgsNil(b bool)`

 SetArgsNil sets the value for Args to be an explicit nil

### UnsetArgs
`func (o *IngestTextDocumentRequest) UnsetArgs()`

UnsetArgs ensures that no value is present for Args, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


