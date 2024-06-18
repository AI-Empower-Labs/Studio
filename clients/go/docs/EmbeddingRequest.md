# EmbeddingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Model** | Pointer to **NullableString** |  | [optional] 
**Text** | Pointer to **[]string** |  | [optional] 

## Methods

### NewEmbeddingRequest

`func NewEmbeddingRequest() *EmbeddingRequest`

NewEmbeddingRequest instantiates a new EmbeddingRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewEmbeddingRequestWithDefaults

`func NewEmbeddingRequestWithDefaults() *EmbeddingRequest`

NewEmbeddingRequestWithDefaults instantiates a new EmbeddingRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetModel

`func (o *EmbeddingRequest) GetModel() string`

GetModel returns the Model field if non-nil, zero value otherwise.

### GetModelOk

`func (o *EmbeddingRequest) GetModelOk() (*string, bool)`

GetModelOk returns a tuple with the Model field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetModel

`func (o *EmbeddingRequest) SetModel(v string)`

SetModel sets Model field to given value.

### HasModel

`func (o *EmbeddingRequest) HasModel() bool`

HasModel returns a boolean if a field has been set.

### SetModelNil

`func (o *EmbeddingRequest) SetModelNil(b bool)`

 SetModelNil sets the value for Model to be an explicit nil

### UnsetModel
`func (o *EmbeddingRequest) UnsetModel()`

UnsetModel ensures that no value is present for Model, not even an explicit nil
### GetText

`func (o *EmbeddingRequest) GetText() []string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *EmbeddingRequest) GetTextOk() (*[]string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *EmbeddingRequest) SetText(v []string)`

SetText sets Text field to given value.

### HasText

`func (o *EmbeddingRequest) HasText() bool`

HasText returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


