# ReRankDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Document** | Pointer to **NullableString** |  | [optional] 
**Index** | Pointer to **int32** |  | [optional] 
**RelevanceScore** | Pointer to **float32** |  | [optional] 

## Methods

### NewReRankDocument

`func NewReRankDocument() *ReRankDocument`

NewReRankDocument instantiates a new ReRankDocument object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewReRankDocumentWithDefaults

`func NewReRankDocumentWithDefaults() *ReRankDocument`

NewReRankDocumentWithDefaults instantiates a new ReRankDocument object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetDocument

`func (o *ReRankDocument) GetDocument() string`

GetDocument returns the Document field if non-nil, zero value otherwise.

### GetDocumentOk

`func (o *ReRankDocument) GetDocumentOk() (*string, bool)`

GetDocumentOk returns a tuple with the Document field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocument

`func (o *ReRankDocument) SetDocument(v string)`

SetDocument sets Document field to given value.

### HasDocument

`func (o *ReRankDocument) HasDocument() bool`

HasDocument returns a boolean if a field has been set.

### SetDocumentNil

`func (o *ReRankDocument) SetDocumentNil(b bool)`

 SetDocumentNil sets the value for Document to be an explicit nil

### UnsetDocument
`func (o *ReRankDocument) UnsetDocument()`

UnsetDocument ensures that no value is present for Document, not even an explicit nil
### GetIndex

`func (o *ReRankDocument) GetIndex() int32`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *ReRankDocument) GetIndexOk() (*int32, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *ReRankDocument) SetIndex(v int32)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *ReRankDocument) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### GetRelevanceScore

`func (o *ReRankDocument) GetRelevanceScore() float32`

GetRelevanceScore returns the RelevanceScore field if non-nil, zero value otherwise.

### GetRelevanceScoreOk

`func (o *ReRankDocument) GetRelevanceScoreOk() (*float32, bool)`

GetRelevanceScoreOk returns a tuple with the RelevanceScore field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRelevanceScore

`func (o *ReRankDocument) SetRelevanceScore(v float32)`

SetRelevanceScore sets RelevanceScore field to given value.

### HasRelevanceScore

`func (o *ReRankDocument) HasRelevanceScore() bool`

HasRelevanceScore returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


