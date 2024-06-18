# IndexCollection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Results** | Pointer to [**[]IndexDetails**](IndexDetails.md) |  | [optional] 

## Methods

### NewIndexCollection

`func NewIndexCollection() *IndexCollection`

NewIndexCollection instantiates a new IndexCollection object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewIndexCollectionWithDefaults

`func NewIndexCollectionWithDefaults() *IndexCollection`

NewIndexCollectionWithDefaults instantiates a new IndexCollection object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetResults

`func (o *IndexCollection) GetResults() []IndexDetails`

GetResults returns the Results field if non-nil, zero value otherwise.

### GetResultsOk

`func (o *IndexCollection) GetResultsOk() (*[]IndexDetails, bool)`

GetResultsOk returns a tuple with the Results field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetResults

`func (o *IndexCollection) SetResults(v []IndexDetails)`

SetResults sets Results field to given value.

### HasResults

`func (o *IndexCollection) HasResults() bool`

HasResults returns a boolean if a field has been set.

### SetResultsNil

`func (o *IndexCollection) SetResultsNil(b bool)`

 SetResultsNil sets the value for Results to be an explicit nil

### UnsetResults
`func (o *IndexCollection) UnsetResults()`

UnsetResults ensures that no value is present for Results, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


