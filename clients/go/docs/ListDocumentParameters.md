# ListDocumentParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | Pointer to **NullableString** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | Pointer to [**[]DocumentFilters**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**WithEmbeddings** | Pointer to **NullableBool** | Optionally specifies if embedding should be returned in response. Default is false | [optional] 
**Limit** | Pointer to **NullableInt32** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**Offset** | Pointer to **NullableInt32** | Optional filter for specifying list offset for paging. Default is 0 | [optional] 

## Methods

### NewListDocumentParameters

`func NewListDocumentParameters() *ListDocumentParameters`

NewListDocumentParameters instantiates a new ListDocumentParameters object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewListDocumentParametersWithDefaults

`func NewListDocumentParametersWithDefaults() *ListDocumentParameters`

NewListDocumentParametersWithDefaults instantiates a new ListDocumentParameters object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetIndex

`func (o *ListDocumentParameters) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *ListDocumentParameters) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *ListDocumentParameters) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *ListDocumentParameters) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *ListDocumentParameters) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *ListDocumentParameters) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetFilter

`func (o *ListDocumentParameters) GetFilter() []DocumentFilters`

GetFilter returns the Filter field if non-nil, zero value otherwise.

### GetFilterOk

`func (o *ListDocumentParameters) GetFilterOk() (*[]DocumentFilters, bool)`

GetFilterOk returns a tuple with the Filter field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilter

`func (o *ListDocumentParameters) SetFilter(v []DocumentFilters)`

SetFilter sets Filter field to given value.

### HasFilter

`func (o *ListDocumentParameters) HasFilter() bool`

HasFilter returns a boolean if a field has been set.

### SetFilterNil

`func (o *ListDocumentParameters) SetFilterNil(b bool)`

 SetFilterNil sets the value for Filter to be an explicit nil

### UnsetFilter
`func (o *ListDocumentParameters) UnsetFilter()`

UnsetFilter ensures that no value is present for Filter, not even an explicit nil
### GetWithEmbeddings

`func (o *ListDocumentParameters) GetWithEmbeddings() bool`

GetWithEmbeddings returns the WithEmbeddings field if non-nil, zero value otherwise.

### GetWithEmbeddingsOk

`func (o *ListDocumentParameters) GetWithEmbeddingsOk() (*bool, bool)`

GetWithEmbeddingsOk returns a tuple with the WithEmbeddings field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetWithEmbeddings

`func (o *ListDocumentParameters) SetWithEmbeddings(v bool)`

SetWithEmbeddings sets WithEmbeddings field to given value.

### HasWithEmbeddings

`func (o *ListDocumentParameters) HasWithEmbeddings() bool`

HasWithEmbeddings returns a boolean if a field has been set.

### SetWithEmbeddingsNil

`func (o *ListDocumentParameters) SetWithEmbeddingsNil(b bool)`

 SetWithEmbeddingsNil sets the value for WithEmbeddings to be an explicit nil

### UnsetWithEmbeddings
`func (o *ListDocumentParameters) UnsetWithEmbeddings()`

UnsetWithEmbeddings ensures that no value is present for WithEmbeddings, not even an explicit nil
### GetLimit

`func (o *ListDocumentParameters) GetLimit() int32`

GetLimit returns the Limit field if non-nil, zero value otherwise.

### GetLimitOk

`func (o *ListDocumentParameters) GetLimitOk() (*int32, bool)`

GetLimitOk returns a tuple with the Limit field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLimit

`func (o *ListDocumentParameters) SetLimit(v int32)`

SetLimit sets Limit field to given value.

### HasLimit

`func (o *ListDocumentParameters) HasLimit() bool`

HasLimit returns a boolean if a field has been set.

### SetLimitNil

`func (o *ListDocumentParameters) SetLimitNil(b bool)`

 SetLimitNil sets the value for Limit to be an explicit nil

### UnsetLimit
`func (o *ListDocumentParameters) UnsetLimit()`

UnsetLimit ensures that no value is present for Limit, not even an explicit nil
### GetOffset

`func (o *ListDocumentParameters) GetOffset() int32`

GetOffset returns the Offset field if non-nil, zero value otherwise.

### GetOffsetOk

`func (o *ListDocumentParameters) GetOffsetOk() (*int32, bool)`

GetOffsetOk returns a tuple with the Offset field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetOffset

`func (o *ListDocumentParameters) SetOffset(v int32)`

SetOffset sets Offset field to given value.

### HasOffset

`func (o *ListDocumentParameters) HasOffset() bool`

HasOffset returns a boolean if a field has been set.

### SetOffsetNil

`func (o *ListDocumentParameters) SetOffsetNil(b bool)`

 SetOffsetNil sets the value for Offset to be an explicit nil

### UnsetOffset
`func (o *ListDocumentParameters) UnsetOffset()`

UnsetOffset ensures that no value is present for Offset, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


