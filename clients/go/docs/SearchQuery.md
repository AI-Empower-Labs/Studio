# SearchQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | Pointer to **NullableString** |  | [optional] 
**Query** | Pointer to **NullableString** |  | [optional] 
**Filters** | Pointer to [**[]map[string][]string**](map[string][]string.md) |  | [optional] 
**MinRelevance** | Pointer to **float64** |  | [optional] 
**Limit** | Pointer to **int32** |  | [optional] 

## Methods

### NewSearchQuery

`func NewSearchQuery() *SearchQuery`

NewSearchQuery instantiates a new SearchQuery object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSearchQueryWithDefaults

`func NewSearchQueryWithDefaults() *SearchQuery`

NewSearchQueryWithDefaults instantiates a new SearchQuery object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetIndex

`func (o *SearchQuery) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *SearchQuery) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *SearchQuery) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *SearchQuery) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *SearchQuery) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *SearchQuery) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetQuery

`func (o *SearchQuery) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *SearchQuery) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *SearchQuery) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *SearchQuery) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### SetQueryNil

`func (o *SearchQuery) SetQueryNil(b bool)`

 SetQueryNil sets the value for Query to be an explicit nil

### UnsetQuery
`func (o *SearchQuery) UnsetQuery()`

UnsetQuery ensures that no value is present for Query, not even an explicit nil
### GetFilters

`func (o *SearchQuery) GetFilters() []map[string][]string`

GetFilters returns the Filters field if non-nil, zero value otherwise.

### GetFiltersOk

`func (o *SearchQuery) GetFiltersOk() (*[]map[string][]string, bool)`

GetFiltersOk returns a tuple with the Filters field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilters

`func (o *SearchQuery) SetFilters(v []map[string][]string)`

SetFilters sets Filters field to given value.

### HasFilters

`func (o *SearchQuery) HasFilters() bool`

HasFilters returns a boolean if a field has been set.

### SetFiltersNil

`func (o *SearchQuery) SetFiltersNil(b bool)`

 SetFiltersNil sets the value for Filters to be an explicit nil

### UnsetFilters
`func (o *SearchQuery) UnsetFilters()`

UnsetFilters ensures that no value is present for Filters, not even an explicit nil
### GetMinRelevance

`func (o *SearchQuery) GetMinRelevance() float64`

GetMinRelevance returns the MinRelevance field if non-nil, zero value otherwise.

### GetMinRelevanceOk

`func (o *SearchQuery) GetMinRelevanceOk() (*float64, bool)`

GetMinRelevanceOk returns a tuple with the MinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinRelevance

`func (o *SearchQuery) SetMinRelevance(v float64)`

SetMinRelevance sets MinRelevance field to given value.

### HasMinRelevance

`func (o *SearchQuery) HasMinRelevance() bool`

HasMinRelevance returns a boolean if a field has been set.

### GetLimit

`func (o *SearchQuery) GetLimit() int32`

GetLimit returns the Limit field if non-nil, zero value otherwise.

### GetLimitOk

`func (o *SearchQuery) GetLimitOk() (*int32, bool)`

GetLimitOk returns a tuple with the Limit field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLimit

`func (o *SearchQuery) SetLimit(v int32)`

SetLimit sets Limit field to given value.

### HasLimit

`func (o *SearchQuery) HasLimit() bool`

HasLimit returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


