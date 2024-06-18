# ReRankDocumentsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Model** | Pointer to **NullableString** | Optional embedding model. Defaults to configured default | [optional] 
**Query** | Pointer to **NullableString** | Semantic query to find matching documents | [optional] 
**Documents** | Pointer to **[]string** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Limit** | Pointer to **NullableInt32** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 

## Methods

### NewReRankDocumentsRequest

`func NewReRankDocumentsRequest() *ReRankDocumentsRequest`

NewReRankDocumentsRequest instantiates a new ReRankDocumentsRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewReRankDocumentsRequestWithDefaults

`func NewReRankDocumentsRequestWithDefaults() *ReRankDocumentsRequest`

NewReRankDocumentsRequestWithDefaults instantiates a new ReRankDocumentsRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetModel

`func (o *ReRankDocumentsRequest) GetModel() string`

GetModel returns the Model field if non-nil, zero value otherwise.

### GetModelOk

`func (o *ReRankDocumentsRequest) GetModelOk() (*string, bool)`

GetModelOk returns a tuple with the Model field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetModel

`func (o *ReRankDocumentsRequest) SetModel(v string)`

SetModel sets Model field to given value.

### HasModel

`func (o *ReRankDocumentsRequest) HasModel() bool`

HasModel returns a boolean if a field has been set.

### SetModelNil

`func (o *ReRankDocumentsRequest) SetModelNil(b bool)`

 SetModelNil sets the value for Model to be an explicit nil

### UnsetModel
`func (o *ReRankDocumentsRequest) UnsetModel()`

UnsetModel ensures that no value is present for Model, not even an explicit nil
### GetQuery

`func (o *ReRankDocumentsRequest) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *ReRankDocumentsRequest) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *ReRankDocumentsRequest) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *ReRankDocumentsRequest) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### SetQueryNil

`func (o *ReRankDocumentsRequest) SetQueryNil(b bool)`

 SetQueryNil sets the value for Query to be an explicit nil

### UnsetQuery
`func (o *ReRankDocumentsRequest) UnsetQuery()`

UnsetQuery ensures that no value is present for Query, not even an explicit nil
### GetDocuments

`func (o *ReRankDocumentsRequest) GetDocuments() []string`

GetDocuments returns the Documents field if non-nil, zero value otherwise.

### GetDocumentsOk

`func (o *ReRankDocumentsRequest) GetDocumentsOk() (*[]string, bool)`

GetDocumentsOk returns a tuple with the Documents field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocuments

`func (o *ReRankDocumentsRequest) SetDocuments(v []string)`

SetDocuments sets Documents field to given value.

### HasDocuments

`func (o *ReRankDocumentsRequest) HasDocuments() bool`

HasDocuments returns a boolean if a field has been set.

### SetDocumentsNil

`func (o *ReRankDocumentsRequest) SetDocumentsNil(b bool)`

 SetDocumentsNil sets the value for Documents to be an explicit nil

### UnsetDocuments
`func (o *ReRankDocumentsRequest) UnsetDocuments()`

UnsetDocuments ensures that no value is present for Documents, not even an explicit nil
### GetLimit

`func (o *ReRankDocumentsRequest) GetLimit() int32`

GetLimit returns the Limit field if non-nil, zero value otherwise.

### GetLimitOk

`func (o *ReRankDocumentsRequest) GetLimitOk() (*int32, bool)`

GetLimitOk returns a tuple with the Limit field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLimit

`func (o *ReRankDocumentsRequest) SetLimit(v int32)`

SetLimit sets Limit field to given value.

### HasLimit

`func (o *ReRankDocumentsRequest) HasLimit() bool`

HasLimit returns a boolean if a field has been set.

### SetLimitNil

`func (o *ReRankDocumentsRequest) SetLimitNil(b bool)`

 SetLimitNil sets the value for Limit to be an explicit nil

### UnsetLimit
`func (o *ReRankDocumentsRequest) UnsetLimit()`

UnsetLimit ensures that no value is present for Limit, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


