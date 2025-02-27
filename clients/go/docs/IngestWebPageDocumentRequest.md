# IngestWebPageDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Web page to ingest | 
**DocumentId** | **string** | Unique identifier for the document to ingest. | 
**Index** | Pointer to **NullableString** | Optional index name where the document will be stored. | [optional] 
**WebHookUrl** | Pointer to **NullableString** | Optional webhook URL to notify upon completion. | [optional] 
**EmbeddingModelName** | Pointer to **NullableString** | Optional name of the embedding model to use during ingestion. | [optional] 
**Context** | Pointer to **map[string]string** | Optional key-value pairs for additional context or metadata. | [optional] 
**Tags** | Pointer to **map[string][]string** | A collection of tags associated with the document. Tags can be language-specific. | [optional] 
**IngestionPipeline** | Pointer to **[]string** | Optional list of ingestion pipeline steps. Allows custom processing. | [optional] 
**LanguageAutoDetection** | Pointer to **bool** | Enable automatic language detection for document content. | [optional] [default to false]
**Language** | Pointer to **NullableString** | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] 

## Methods

### NewIngestWebPageDocumentRequest

`func NewIngestWebPageDocumentRequest(url string, documentId string, ) *IngestWebPageDocumentRequest`

NewIngestWebPageDocumentRequest instantiates a new IngestWebPageDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewIngestWebPageDocumentRequestWithDefaults

`func NewIngestWebPageDocumentRequestWithDefaults() *IngestWebPageDocumentRequest`

NewIngestWebPageDocumentRequestWithDefaults instantiates a new IngestWebPageDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

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
### GetEmbeddingModelName

`func (o *IngestWebPageDocumentRequest) GetEmbeddingModelName() string`

GetEmbeddingModelName returns the EmbeddingModelName field if non-nil, zero value otherwise.

### GetEmbeddingModelNameOk

`func (o *IngestWebPageDocumentRequest) GetEmbeddingModelNameOk() (*string, bool)`

GetEmbeddingModelNameOk returns a tuple with the EmbeddingModelName field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModelName

`func (o *IngestWebPageDocumentRequest) SetEmbeddingModelName(v string)`

SetEmbeddingModelName sets EmbeddingModelName field to given value.

### HasEmbeddingModelName

`func (o *IngestWebPageDocumentRequest) HasEmbeddingModelName() bool`

HasEmbeddingModelName returns a boolean if a field has been set.

### SetEmbeddingModelNameNil

`func (o *IngestWebPageDocumentRequest) SetEmbeddingModelNameNil(b bool)`

 SetEmbeddingModelNameNil sets the value for EmbeddingModelName to be an explicit nil

### UnsetEmbeddingModelName
`func (o *IngestWebPageDocumentRequest) UnsetEmbeddingModelName()`

UnsetEmbeddingModelName ensures that no value is present for EmbeddingModelName, not even an explicit nil
### GetContext

`func (o *IngestWebPageDocumentRequest) GetContext() map[string]string`

GetContext returns the Context field if non-nil, zero value otherwise.

### GetContextOk

`func (o *IngestWebPageDocumentRequest) GetContextOk() (*map[string]string, bool)`

GetContextOk returns a tuple with the Context field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetContext

`func (o *IngestWebPageDocumentRequest) SetContext(v map[string]string)`

SetContext sets Context field to given value.

### HasContext

`func (o *IngestWebPageDocumentRequest) HasContext() bool`

HasContext returns a boolean if a field has been set.

### SetContextNil

`func (o *IngestWebPageDocumentRequest) SetContextNil(b bool)`

 SetContextNil sets the value for Context to be an explicit nil

### UnsetContext
`func (o *IngestWebPageDocumentRequest) UnsetContext()`

UnsetContext ensures that no value is present for Context, not even an explicit nil
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
### GetIngestionPipeline

`func (o *IngestWebPageDocumentRequest) GetIngestionPipeline() []string`

GetIngestionPipeline returns the IngestionPipeline field if non-nil, zero value otherwise.

### GetIngestionPipelineOk

`func (o *IngestWebPageDocumentRequest) GetIngestionPipelineOk() (*[]string, bool)`

GetIngestionPipelineOk returns a tuple with the IngestionPipeline field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIngestionPipeline

`func (o *IngestWebPageDocumentRequest) SetIngestionPipeline(v []string)`

SetIngestionPipeline sets IngestionPipeline field to given value.

### HasIngestionPipeline

`func (o *IngestWebPageDocumentRequest) HasIngestionPipeline() bool`

HasIngestionPipeline returns a boolean if a field has been set.

### SetIngestionPipelineNil

`func (o *IngestWebPageDocumentRequest) SetIngestionPipelineNil(b bool)`

 SetIngestionPipelineNil sets the value for IngestionPipeline to be an explicit nil

### UnsetIngestionPipeline
`func (o *IngestWebPageDocumentRequest) UnsetIngestionPipeline()`

UnsetIngestionPipeline ensures that no value is present for IngestionPipeline, not even an explicit nil
### GetLanguageAutoDetection

`func (o *IngestWebPageDocumentRequest) GetLanguageAutoDetection() bool`

GetLanguageAutoDetection returns the LanguageAutoDetection field if non-nil, zero value otherwise.

### GetLanguageAutoDetectionOk

`func (o *IngestWebPageDocumentRequest) GetLanguageAutoDetectionOk() (*bool, bool)`

GetLanguageAutoDetectionOk returns a tuple with the LanguageAutoDetection field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguageAutoDetection

`func (o *IngestWebPageDocumentRequest) SetLanguageAutoDetection(v bool)`

SetLanguageAutoDetection sets LanguageAutoDetection field to given value.

### HasLanguageAutoDetection

`func (o *IngestWebPageDocumentRequest) HasLanguageAutoDetection() bool`

HasLanguageAutoDetection returns a boolean if a field has been set.

### GetLanguage

`func (o *IngestWebPageDocumentRequest) GetLanguage() string`

GetLanguage returns the Language field if non-nil, zero value otherwise.

### GetLanguageOk

`func (o *IngestWebPageDocumentRequest) GetLanguageOk() (*string, bool)`

GetLanguageOk returns a tuple with the Language field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguage

`func (o *IngestWebPageDocumentRequest) SetLanguage(v string)`

SetLanguage sets Language field to given value.

### HasLanguage

`func (o *IngestWebPageDocumentRequest) HasLanguage() bool`

HasLanguage returns a boolean if a field has been set.

### SetLanguageNil

`func (o *IngestWebPageDocumentRequest) SetLanguageNil(b bool)`

 SetLanguageNil sets the value for Language to be an explicit nil

### UnsetLanguage
`func (o *IngestWebPageDocumentRequest) UnsetLanguage()`

UnsetLanguage ensures that no value is present for Language, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


