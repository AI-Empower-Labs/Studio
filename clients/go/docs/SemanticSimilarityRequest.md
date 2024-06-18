# SemanticSimilarityRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | Pointer to **string** | Query text to compare with | [optional] 
**Documents** | Pointer to **[]string** |  | [optional] 
**Model** | Pointer to **NullableString** |  | [optional] 

## Methods

### NewSemanticSimilarityRequest

`func NewSemanticSimilarityRequest() *SemanticSimilarityRequest`

NewSemanticSimilarityRequest instantiates a new SemanticSimilarityRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSemanticSimilarityRequestWithDefaults

`func NewSemanticSimilarityRequestWithDefaults() *SemanticSimilarityRequest`

NewSemanticSimilarityRequestWithDefaults instantiates a new SemanticSimilarityRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQuery

`func (o *SemanticSimilarityRequest) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *SemanticSimilarityRequest) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *SemanticSimilarityRequest) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *SemanticSimilarityRequest) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### GetDocuments

`func (o *SemanticSimilarityRequest) GetDocuments() []string`

GetDocuments returns the Documents field if non-nil, zero value otherwise.

### GetDocumentsOk

`func (o *SemanticSimilarityRequest) GetDocumentsOk() (*[]string, bool)`

GetDocumentsOk returns a tuple with the Documents field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocuments

`func (o *SemanticSimilarityRequest) SetDocuments(v []string)`

SetDocuments sets Documents field to given value.

### HasDocuments

`func (o *SemanticSimilarityRequest) HasDocuments() bool`

HasDocuments returns a boolean if a field has been set.

### GetModel

`func (o *SemanticSimilarityRequest) GetModel() string`

GetModel returns the Model field if non-nil, zero value otherwise.

### GetModelOk

`func (o *SemanticSimilarityRequest) GetModelOk() (*string, bool)`

GetModelOk returns a tuple with the Model field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetModel

`func (o *SemanticSimilarityRequest) SetModel(v string)`

SetModel sets Model field to given value.

### HasModel

`func (o *SemanticSimilarityRequest) HasModel() bool`

HasModel returns a boolean if a field has been set.

### SetModelNil

`func (o *SemanticSimilarityRequest) SetModelNil(b bool)`

 SetModelNil sets the value for Model to be an explicit nil

### UnsetModel
`func (o *SemanticSimilarityRequest) UnsetModel()`

UnsetModel ensures that no value is present for Model, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


