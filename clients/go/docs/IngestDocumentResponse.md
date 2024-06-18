# IngestDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | Pointer to **string** | Ingestion queue identifier | [optional] 
**Index** | Pointer to **string** | Index ingestion is written to | [optional] 
**DocumentId** | Pointer to **string** | Identity of the document written to index | [optional] 
**Pipeline** | Pointer to **[]string** | Index ingestion is written to | [optional] 

## Methods

### NewIngestDocumentResponse

`func NewIngestDocumentResponse() *IngestDocumentResponse`

NewIngestDocumentResponse instantiates a new IngestDocumentResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewIngestDocumentResponseWithDefaults

`func NewIngestDocumentResponseWithDefaults() *IngestDocumentResponse`

NewIngestDocumentResponseWithDefaults instantiates a new IngestDocumentResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetId

`func (o *IngestDocumentResponse) GetId() string`

GetId returns the Id field if non-nil, zero value otherwise.

### GetIdOk

`func (o *IngestDocumentResponse) GetIdOk() (*string, bool)`

GetIdOk returns a tuple with the Id field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetId

`func (o *IngestDocumentResponse) SetId(v string)`

SetId sets Id field to given value.

### HasId

`func (o *IngestDocumentResponse) HasId() bool`

HasId returns a boolean if a field has been set.

### GetIndex

`func (o *IngestDocumentResponse) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *IngestDocumentResponse) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *IngestDocumentResponse) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *IngestDocumentResponse) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### GetDocumentId

`func (o *IngestDocumentResponse) GetDocumentId() string`

GetDocumentId returns the DocumentId field if non-nil, zero value otherwise.

### GetDocumentIdOk

`func (o *IngestDocumentResponse) GetDocumentIdOk() (*string, bool)`

GetDocumentIdOk returns a tuple with the DocumentId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocumentId

`func (o *IngestDocumentResponse) SetDocumentId(v string)`

SetDocumentId sets DocumentId field to given value.

### HasDocumentId

`func (o *IngestDocumentResponse) HasDocumentId() bool`

HasDocumentId returns a boolean if a field has been set.

### GetPipeline

`func (o *IngestDocumentResponse) GetPipeline() []string`

GetPipeline returns the Pipeline field if non-nil, zero value otherwise.

### GetPipelineOk

`func (o *IngestDocumentResponse) GetPipelineOk() (*[]string, bool)`

GetPipelineOk returns a tuple with the Pipeline field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPipeline

`func (o *IngestDocumentResponse) SetPipeline(v []string)`

SetPipeline sets Pipeline field to given value.

### HasPipeline

`func (o *IngestDocumentResponse) HasPipeline() bool`

HasPipeline returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


