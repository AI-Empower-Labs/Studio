# AskDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NoResult** | Pointer to **bool** |  | [optional] 
**NoResultReason** | Pointer to **NullableString** | Content of the answer. | [optional] 
**Text** | Pointer to **NullableString** | Content of the answer. | [optional] 
**RelevantSources** | Pointer to [**[]DocumentCitation**](DocumentCitation.md) | List of the relevant sources used to produce the answer.  Key &#x3D; Document ID  Value &#x3D; List of partitions used from the document. | [optional] 

## Methods

### NewAskDocumentResponse

`func NewAskDocumentResponse() *AskDocumentResponse`

NewAskDocumentResponse instantiates a new AskDocumentResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewAskDocumentResponseWithDefaults

`func NewAskDocumentResponseWithDefaults() *AskDocumentResponse`

NewAskDocumentResponseWithDefaults instantiates a new AskDocumentResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetNoResult

`func (o *AskDocumentResponse) GetNoResult() bool`

GetNoResult returns the NoResult field if non-nil, zero value otherwise.

### GetNoResultOk

`func (o *AskDocumentResponse) GetNoResultOk() (*bool, bool)`

GetNoResultOk returns a tuple with the NoResult field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNoResult

`func (o *AskDocumentResponse) SetNoResult(v bool)`

SetNoResult sets NoResult field to given value.

### HasNoResult

`func (o *AskDocumentResponse) HasNoResult() bool`

HasNoResult returns a boolean if a field has been set.

### GetNoResultReason

`func (o *AskDocumentResponse) GetNoResultReason() string`

GetNoResultReason returns the NoResultReason field if non-nil, zero value otherwise.

### GetNoResultReasonOk

`func (o *AskDocumentResponse) GetNoResultReasonOk() (*string, bool)`

GetNoResultReasonOk returns a tuple with the NoResultReason field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNoResultReason

`func (o *AskDocumentResponse) SetNoResultReason(v string)`

SetNoResultReason sets NoResultReason field to given value.

### HasNoResultReason

`func (o *AskDocumentResponse) HasNoResultReason() bool`

HasNoResultReason returns a boolean if a field has been set.

### SetNoResultReasonNil

`func (o *AskDocumentResponse) SetNoResultReasonNil(b bool)`

 SetNoResultReasonNil sets the value for NoResultReason to be an explicit nil

### UnsetNoResultReason
`func (o *AskDocumentResponse) UnsetNoResultReason()`

UnsetNoResultReason ensures that no value is present for NoResultReason, not even an explicit nil
### GetText

`func (o *AskDocumentResponse) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *AskDocumentResponse) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *AskDocumentResponse) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *AskDocumentResponse) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *AskDocumentResponse) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *AskDocumentResponse) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetRelevantSources

`func (o *AskDocumentResponse) GetRelevantSources() []DocumentCitation`

GetRelevantSources returns the RelevantSources field if non-nil, zero value otherwise.

### GetRelevantSourcesOk

`func (o *AskDocumentResponse) GetRelevantSourcesOk() (*[]DocumentCitation, bool)`

GetRelevantSourcesOk returns a tuple with the RelevantSources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRelevantSources

`func (o *AskDocumentResponse) SetRelevantSources(v []DocumentCitation)`

SetRelevantSources sets RelevantSources field to given value.

### HasRelevantSources

`func (o *AskDocumentResponse) HasRelevantSources() bool`

HasRelevantSources returns a boolean if a field has been set.

### SetRelevantSourcesNil

`func (o *AskDocumentResponse) SetRelevantSourcesNil(b bool)`

 SetRelevantSourcesNil sets the value for RelevantSources to be an explicit nil

### UnsetRelevantSources
`func (o *AskDocumentResponse) UnsetRelevantSources()`

UnsetRelevantSources ensures that no value is present for RelevantSources, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


