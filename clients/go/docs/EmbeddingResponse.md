# EmbeddingResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vectors** | Pointer to **[][]float32** |  | [optional] 

## Methods

### NewEmbeddingResponse

`func NewEmbeddingResponse() *EmbeddingResponse`

NewEmbeddingResponse instantiates a new EmbeddingResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewEmbeddingResponseWithDefaults

`func NewEmbeddingResponseWithDefaults() *EmbeddingResponse`

NewEmbeddingResponseWithDefaults instantiates a new EmbeddingResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetVectors

`func (o *EmbeddingResponse) GetVectors() [][]float32`

GetVectors returns the Vectors field if non-nil, zero value otherwise.

### GetVectorsOk

`func (o *EmbeddingResponse) GetVectorsOk() (*[][]float32, bool)`

GetVectorsOk returns a tuple with the Vectors field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetVectors

`func (o *EmbeddingResponse) SetVectors(v [][]float32)`

SetVectors sets Vectors field to given value.

### HasVectors

`func (o *EmbeddingResponse) HasVectors() bool`

HasVectors returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


