# QueryDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | Pointer to **NullableString** | Semantic query to find matching documents | [optional] 
**Index** | Pointer to **NullableString** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | Pointer to [**[]DocumentFilters**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**MinRelevance** | Pointer to **NullableFloat64** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**Limit** | Pointer to **NullableInt32** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**EmbeddingModel** | Pointer to **NullableString** | Embedding model to use in query | [optional] 

## Methods

### NewQueryDocumentRequest

`func NewQueryDocumentRequest() *QueryDocumentRequest`

NewQueryDocumentRequest instantiates a new QueryDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewQueryDocumentRequestWithDefaults

`func NewQueryDocumentRequestWithDefaults() *QueryDocumentRequest`

NewQueryDocumentRequestWithDefaults instantiates a new QueryDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQuery

`func (o *QueryDocumentRequest) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *QueryDocumentRequest) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *QueryDocumentRequest) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *QueryDocumentRequest) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### SetQueryNil

`func (o *QueryDocumentRequest) SetQueryNil(b bool)`

 SetQueryNil sets the value for Query to be an explicit nil

### UnsetQuery
`func (o *QueryDocumentRequest) UnsetQuery()`

UnsetQuery ensures that no value is present for Query, not even an explicit nil
### GetIndex

`func (o *QueryDocumentRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *QueryDocumentRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *QueryDocumentRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *QueryDocumentRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *QueryDocumentRequest) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *QueryDocumentRequest) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetFilter

`func (o *QueryDocumentRequest) GetFilter() []DocumentFilters`

GetFilter returns the Filter field if non-nil, zero value otherwise.

### GetFilterOk

`func (o *QueryDocumentRequest) GetFilterOk() (*[]DocumentFilters, bool)`

GetFilterOk returns a tuple with the Filter field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilter

`func (o *QueryDocumentRequest) SetFilter(v []DocumentFilters)`

SetFilter sets Filter field to given value.

### HasFilter

`func (o *QueryDocumentRequest) HasFilter() bool`

HasFilter returns a boolean if a field has been set.

### SetFilterNil

`func (o *QueryDocumentRequest) SetFilterNil(b bool)`

 SetFilterNil sets the value for Filter to be an explicit nil

### UnsetFilter
`func (o *QueryDocumentRequest) UnsetFilter()`

UnsetFilter ensures that no value is present for Filter, not even an explicit nil
### GetMinRelevance

`func (o *QueryDocumentRequest) GetMinRelevance() float64`

GetMinRelevance returns the MinRelevance field if non-nil, zero value otherwise.

### GetMinRelevanceOk

`func (o *QueryDocumentRequest) GetMinRelevanceOk() (*float64, bool)`

GetMinRelevanceOk returns a tuple with the MinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinRelevance

`func (o *QueryDocumentRequest) SetMinRelevance(v float64)`

SetMinRelevance sets MinRelevance field to given value.

### HasMinRelevance

`func (o *QueryDocumentRequest) HasMinRelevance() bool`

HasMinRelevance returns a boolean if a field has been set.

### SetMinRelevanceNil

`func (o *QueryDocumentRequest) SetMinRelevanceNil(b bool)`

 SetMinRelevanceNil sets the value for MinRelevance to be an explicit nil

### UnsetMinRelevance
`func (o *QueryDocumentRequest) UnsetMinRelevance()`

UnsetMinRelevance ensures that no value is present for MinRelevance, not even an explicit nil
### GetLimit

`func (o *QueryDocumentRequest) GetLimit() int32`

GetLimit returns the Limit field if non-nil, zero value otherwise.

### GetLimitOk

`func (o *QueryDocumentRequest) GetLimitOk() (*int32, bool)`

GetLimitOk returns a tuple with the Limit field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLimit

`func (o *QueryDocumentRequest) SetLimit(v int32)`

SetLimit sets Limit field to given value.

### HasLimit

`func (o *QueryDocumentRequest) HasLimit() bool`

HasLimit returns a boolean if a field has been set.

### SetLimitNil

`func (o *QueryDocumentRequest) SetLimitNil(b bool)`

 SetLimitNil sets the value for Limit to be an explicit nil

### UnsetLimit
`func (o *QueryDocumentRequest) UnsetLimit()`

UnsetLimit ensures that no value is present for Limit, not even an explicit nil
### GetEmbeddingModel

`func (o *QueryDocumentRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *QueryDocumentRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *QueryDocumentRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *QueryDocumentRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.

### SetEmbeddingModelNil

`func (o *QueryDocumentRequest) SetEmbeddingModelNil(b bool)`

 SetEmbeddingModelNil sets the value for EmbeddingModel to be an explicit nil

### UnsetEmbeddingModel
`func (o *QueryDocumentRequest) UnsetEmbeddingModel()`

UnsetEmbeddingModel ensures that no value is present for EmbeddingModel, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


