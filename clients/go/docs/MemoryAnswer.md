# MemoryAnswer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Question** | Pointer to **NullableString** |  | [optional] 
**NoResult** | Pointer to **bool** |  | [optional] 
**NoResultReason** | Pointer to **NullableString** |  | [optional] 
**Text** | Pointer to **NullableString** |  | [optional] 
**RelevantSources** | Pointer to [**[]Citation**](Citation.md) |  | [optional] 

## Methods

### NewMemoryAnswer

`func NewMemoryAnswer() *MemoryAnswer`

NewMemoryAnswer instantiates a new MemoryAnswer object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewMemoryAnswerWithDefaults

`func NewMemoryAnswerWithDefaults() *MemoryAnswer`

NewMemoryAnswerWithDefaults instantiates a new MemoryAnswer object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQuestion

`func (o *MemoryAnswer) GetQuestion() string`

GetQuestion returns the Question field if non-nil, zero value otherwise.

### GetQuestionOk

`func (o *MemoryAnswer) GetQuestionOk() (*string, bool)`

GetQuestionOk returns a tuple with the Question field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuestion

`func (o *MemoryAnswer) SetQuestion(v string)`

SetQuestion sets Question field to given value.

### HasQuestion

`func (o *MemoryAnswer) HasQuestion() bool`

HasQuestion returns a boolean if a field has been set.

### SetQuestionNil

`func (o *MemoryAnswer) SetQuestionNil(b bool)`

 SetQuestionNil sets the value for Question to be an explicit nil

### UnsetQuestion
`func (o *MemoryAnswer) UnsetQuestion()`

UnsetQuestion ensures that no value is present for Question, not even an explicit nil
### GetNoResult

`func (o *MemoryAnswer) GetNoResult() bool`

GetNoResult returns the NoResult field if non-nil, zero value otherwise.

### GetNoResultOk

`func (o *MemoryAnswer) GetNoResultOk() (*bool, bool)`

GetNoResultOk returns a tuple with the NoResult field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNoResult

`func (o *MemoryAnswer) SetNoResult(v bool)`

SetNoResult sets NoResult field to given value.

### HasNoResult

`func (o *MemoryAnswer) HasNoResult() bool`

HasNoResult returns a boolean if a field has been set.

### GetNoResultReason

`func (o *MemoryAnswer) GetNoResultReason() string`

GetNoResultReason returns the NoResultReason field if non-nil, zero value otherwise.

### GetNoResultReasonOk

`func (o *MemoryAnswer) GetNoResultReasonOk() (*string, bool)`

GetNoResultReasonOk returns a tuple with the NoResultReason field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNoResultReason

`func (o *MemoryAnswer) SetNoResultReason(v string)`

SetNoResultReason sets NoResultReason field to given value.

### HasNoResultReason

`func (o *MemoryAnswer) HasNoResultReason() bool`

HasNoResultReason returns a boolean if a field has been set.

### SetNoResultReasonNil

`func (o *MemoryAnswer) SetNoResultReasonNil(b bool)`

 SetNoResultReasonNil sets the value for NoResultReason to be an explicit nil

### UnsetNoResultReason
`func (o *MemoryAnswer) UnsetNoResultReason()`

UnsetNoResultReason ensures that no value is present for NoResultReason, not even an explicit nil
### GetText

`func (o *MemoryAnswer) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *MemoryAnswer) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *MemoryAnswer) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *MemoryAnswer) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *MemoryAnswer) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *MemoryAnswer) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetRelevantSources

`func (o *MemoryAnswer) GetRelevantSources() []Citation`

GetRelevantSources returns the RelevantSources field if non-nil, zero value otherwise.

### GetRelevantSourcesOk

`func (o *MemoryAnswer) GetRelevantSourcesOk() (*[]Citation, bool)`

GetRelevantSourcesOk returns a tuple with the RelevantSources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRelevantSources

`func (o *MemoryAnswer) SetRelevantSources(v []Citation)`

SetRelevantSources sets RelevantSources field to given value.

### HasRelevantSources

`func (o *MemoryAnswer) HasRelevantSources() bool`

HasRelevantSources returns a boolean if a field has been set.

### SetRelevantSourcesNil

`func (o *MemoryAnswer) SetRelevantSourcesNil(b bool)`

 SetRelevantSourcesNil sets the value for RelevantSources to be an explicit nil

### UnsetRelevantSources
`func (o *MemoryAnswer) UnsetRelevantSources()`

UnsetRelevantSources ensures that no value is present for RelevantSources, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


