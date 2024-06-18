# MemoryQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | Pointer to **NullableString** |  | [optional] 
**Question** | Pointer to **NullableString** |  | [optional] 
**Filters** | Pointer to [**[]map[string][]string**](map[string][]string.md) |  | [optional] 
**MinRelevance** | Pointer to **float64** |  | [optional] 

## Methods

### NewMemoryQuery

`func NewMemoryQuery() *MemoryQuery`

NewMemoryQuery instantiates a new MemoryQuery object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewMemoryQueryWithDefaults

`func NewMemoryQueryWithDefaults() *MemoryQuery`

NewMemoryQueryWithDefaults instantiates a new MemoryQuery object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetIndex

`func (o *MemoryQuery) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *MemoryQuery) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *MemoryQuery) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *MemoryQuery) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *MemoryQuery) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *MemoryQuery) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetQuestion

`func (o *MemoryQuery) GetQuestion() string`

GetQuestion returns the Question field if non-nil, zero value otherwise.

### GetQuestionOk

`func (o *MemoryQuery) GetQuestionOk() (*string, bool)`

GetQuestionOk returns a tuple with the Question field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuestion

`func (o *MemoryQuery) SetQuestion(v string)`

SetQuestion sets Question field to given value.

### HasQuestion

`func (o *MemoryQuery) HasQuestion() bool`

HasQuestion returns a boolean if a field has been set.

### SetQuestionNil

`func (o *MemoryQuery) SetQuestionNil(b bool)`

 SetQuestionNil sets the value for Question to be an explicit nil

### UnsetQuestion
`func (o *MemoryQuery) UnsetQuestion()`

UnsetQuestion ensures that no value is present for Question, not even an explicit nil
### GetFilters

`func (o *MemoryQuery) GetFilters() []map[string][]string`

GetFilters returns the Filters field if non-nil, zero value otherwise.

### GetFiltersOk

`func (o *MemoryQuery) GetFiltersOk() (*[]map[string][]string, bool)`

GetFiltersOk returns a tuple with the Filters field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilters

`func (o *MemoryQuery) SetFilters(v []map[string][]string)`

SetFilters sets Filters field to given value.

### HasFilters

`func (o *MemoryQuery) HasFilters() bool`

HasFilters returns a boolean if a field has been set.

### SetFiltersNil

`func (o *MemoryQuery) SetFiltersNil(b bool)`

 SetFiltersNil sets the value for Filters to be an explicit nil

### UnsetFilters
`func (o *MemoryQuery) UnsetFilters()`

UnsetFilters ensures that no value is present for Filters, not even an explicit nil
### GetMinRelevance

`func (o *MemoryQuery) GetMinRelevance() float64`

GetMinRelevance returns the MinRelevance field if non-nil, zero value otherwise.

### GetMinRelevanceOk

`func (o *MemoryQuery) GetMinRelevanceOk() (*float64, bool)`

GetMinRelevanceOk returns a tuple with the MinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinRelevance

`func (o *MemoryQuery) SetMinRelevance(v float64)`

SetMinRelevance sets MinRelevance field to given value.

### HasMinRelevance

`func (o *MemoryQuery) HasMinRelevance() bool`

HasMinRelevance returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


