# TranscriptionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | Pointer to **NullableString** |  | [optional] 
**Duration** | Pointer to [**TimeSpan**](TimeSpan.md) |  | [optional] 
**Data** | Pointer to [**[]SegmentData**](SegmentData.md) |  | [optional] 

## Methods

### NewTranscriptionResponse

`func NewTranscriptionResponse() *TranscriptionResponse`

NewTranscriptionResponse instantiates a new TranscriptionResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewTranscriptionResponseWithDefaults

`func NewTranscriptionResponseWithDefaults() *TranscriptionResponse`

NewTranscriptionResponseWithDefaults instantiates a new TranscriptionResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *TranscriptionResponse) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *TranscriptionResponse) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *TranscriptionResponse) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *TranscriptionResponse) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *TranscriptionResponse) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *TranscriptionResponse) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetDuration

`func (o *TranscriptionResponse) GetDuration() TimeSpan`

GetDuration returns the Duration field if non-nil, zero value otherwise.

### GetDurationOk

`func (o *TranscriptionResponse) GetDurationOk() (*TimeSpan, bool)`

GetDurationOk returns a tuple with the Duration field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDuration

`func (o *TranscriptionResponse) SetDuration(v TimeSpan)`

SetDuration sets Duration field to given value.

### HasDuration

`func (o *TranscriptionResponse) HasDuration() bool`

HasDuration returns a boolean if a field has been set.

### GetData

`func (o *TranscriptionResponse) GetData() []SegmentData`

GetData returns the Data field if non-nil, zero value otherwise.

### GetDataOk

`func (o *TranscriptionResponse) GetDataOk() (*[]SegmentData, bool)`

GetDataOk returns a tuple with the Data field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetData

`func (o *TranscriptionResponse) SetData(v []SegmentData)`

SetData sets Data field to given value.

### HasData

`func (o *TranscriptionResponse) HasData() bool`

HasData returns a boolean if a field has been set.

### SetDataNil

`func (o *TranscriptionResponse) SetDataNil(b bool)`

 SetDataNil sets the value for Data to be an explicit nil

### UnsetData
`func (o *TranscriptionResponse) UnsetData()`

UnsetData ensures that no value is present for Data, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


