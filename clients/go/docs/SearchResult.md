# SearchResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | Pointer to **NullableString** |  | [optional] 
**NoResult** | Pointer to **bool** |  | [optional] [readonly] 
**Results** | Pointer to [**[]Citation**](Citation.md) |  | [optional] 

## Methods

### NewSearchResult

`func NewSearchResult() *SearchResult`

NewSearchResult instantiates a new SearchResult object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSearchResultWithDefaults

`func NewSearchResultWithDefaults() *SearchResult`

NewSearchResultWithDefaults instantiates a new SearchResult object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQuery

`func (o *SearchResult) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *SearchResult) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *SearchResult) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *SearchResult) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### SetQueryNil

`func (o *SearchResult) SetQueryNil(b bool)`

 SetQueryNil sets the value for Query to be an explicit nil

### UnsetQuery
`func (o *SearchResult) UnsetQuery()`

UnsetQuery ensures that no value is present for Query, not even an explicit nil
### GetNoResult

`func (o *SearchResult) GetNoResult() bool`

GetNoResult returns the NoResult field if non-nil, zero value otherwise.

### GetNoResultOk

`func (o *SearchResult) GetNoResultOk() (*bool, bool)`

GetNoResultOk returns a tuple with the NoResult field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNoResult

`func (o *SearchResult) SetNoResult(v bool)`

SetNoResult sets NoResult field to given value.

### HasNoResult

`func (o *SearchResult) HasNoResult() bool`

HasNoResult returns a boolean if a field has been set.

### GetResults

`func (o *SearchResult) GetResults() []Citation`

GetResults returns the Results field if non-nil, zero value otherwise.

### GetResultsOk

`func (o *SearchResult) GetResultsOk() (*[]Citation, bool)`

GetResultsOk returns a tuple with the Results field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetResults

`func (o *SearchResult) SetResults(v []Citation)`

SetResults sets Results field to given value.

### HasResults

`func (o *SearchResult) HasResults() bool`

HasResults returns a boolean if a field has been set.

### SetResultsNil

`func (o *SearchResult) SetResultsNil(b bool)`

 SetResultsNil sets the value for Results to be an explicit nil

### UnsetResults
`func (o *SearchResult) UnsetResults()`

UnsetResults ensures that no value is present for Results, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


