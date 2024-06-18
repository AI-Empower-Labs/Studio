# WordCloudDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | Pointer to **NullableString** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | Pointer to [**[]DocumentFilters**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**Limit** | Pointer to **NullableInt32** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**Source** | Pointer to **string** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 

## Methods

### NewWordCloudDocumentRequest

`func NewWordCloudDocumentRequest() *WordCloudDocumentRequest`

NewWordCloudDocumentRequest instantiates a new WordCloudDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewWordCloudDocumentRequestWithDefaults

`func NewWordCloudDocumentRequestWithDefaults() *WordCloudDocumentRequest`

NewWordCloudDocumentRequestWithDefaults instantiates a new WordCloudDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetIndex

`func (o *WordCloudDocumentRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *WordCloudDocumentRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *WordCloudDocumentRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *WordCloudDocumentRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *WordCloudDocumentRequest) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *WordCloudDocumentRequest) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetFilter

`func (o *WordCloudDocumentRequest) GetFilter() []DocumentFilters`

GetFilter returns the Filter field if non-nil, zero value otherwise.

### GetFilterOk

`func (o *WordCloudDocumentRequest) GetFilterOk() (*[]DocumentFilters, bool)`

GetFilterOk returns a tuple with the Filter field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilter

`func (o *WordCloudDocumentRequest) SetFilter(v []DocumentFilters)`

SetFilter sets Filter field to given value.

### HasFilter

`func (o *WordCloudDocumentRequest) HasFilter() bool`

HasFilter returns a boolean if a field has been set.

### SetFilterNil

`func (o *WordCloudDocumentRequest) SetFilterNil(b bool)`

 SetFilterNil sets the value for Filter to be an explicit nil

### UnsetFilter
`func (o *WordCloudDocumentRequest) UnsetFilter()`

UnsetFilter ensures that no value is present for Filter, not even an explicit nil
### GetLimit

`func (o *WordCloudDocumentRequest) GetLimit() int32`

GetLimit returns the Limit field if non-nil, zero value otherwise.

### GetLimitOk

`func (o *WordCloudDocumentRequest) GetLimitOk() (*int32, bool)`

GetLimitOk returns a tuple with the Limit field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLimit

`func (o *WordCloudDocumentRequest) SetLimit(v int32)`

SetLimit sets Limit field to given value.

### HasLimit

`func (o *WordCloudDocumentRequest) HasLimit() bool`

HasLimit returns a boolean if a field has been set.

### SetLimitNil

`func (o *WordCloudDocumentRequest) SetLimitNil(b bool)`

 SetLimitNil sets the value for Limit to be an explicit nil

### UnsetLimit
`func (o *WordCloudDocumentRequest) UnsetLimit()`

UnsetLimit ensures that no value is present for Limit, not even an explicit nil
### GetSource

`func (o *WordCloudDocumentRequest) GetSource() string`

GetSource returns the Source field if non-nil, zero value otherwise.

### GetSourceOk

`func (o *WordCloudDocumentRequest) GetSourceOk() (*string, bool)`

GetSourceOk returns a tuple with the Source field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSource

`func (o *WordCloudDocumentRequest) SetSource(v string)`

SetSource sets Source field to given value.

### HasSource

`func (o *WordCloudDocumentRequest) HasSource() bool`

HasSource returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


