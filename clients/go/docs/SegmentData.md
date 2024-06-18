# SegmentData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | Pointer to **NullableString** |  | [optional] 
**Start** | Pointer to [**TimeSpan**](TimeSpan.md) |  | [optional] 
**End** | Pointer to [**TimeSpan**](TimeSpan.md) |  | [optional] 
**Probability** | Pointer to **float32** |  | [optional] 
**Language** | Pointer to **NullableString** |  | [optional] 

## Methods

### NewSegmentData

`func NewSegmentData() *SegmentData`

NewSegmentData instantiates a new SegmentData object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSegmentDataWithDefaults

`func NewSegmentDataWithDefaults() *SegmentData`

NewSegmentDataWithDefaults instantiates a new SegmentData object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *SegmentData) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *SegmentData) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *SegmentData) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *SegmentData) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *SegmentData) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *SegmentData) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetStart

`func (o *SegmentData) GetStart() TimeSpan`

GetStart returns the Start field if non-nil, zero value otherwise.

### GetStartOk

`func (o *SegmentData) GetStartOk() (*TimeSpan, bool)`

GetStartOk returns a tuple with the Start field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStart

`func (o *SegmentData) SetStart(v TimeSpan)`

SetStart sets Start field to given value.

### HasStart

`func (o *SegmentData) HasStart() bool`

HasStart returns a boolean if a field has been set.

### GetEnd

`func (o *SegmentData) GetEnd() TimeSpan`

GetEnd returns the End field if non-nil, zero value otherwise.

### GetEndOk

`func (o *SegmentData) GetEndOk() (*TimeSpan, bool)`

GetEndOk returns a tuple with the End field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEnd

`func (o *SegmentData) SetEnd(v TimeSpan)`

SetEnd sets End field to given value.

### HasEnd

`func (o *SegmentData) HasEnd() bool`

HasEnd returns a boolean if a field has been set.

### GetProbability

`func (o *SegmentData) GetProbability() float32`

GetProbability returns the Probability field if non-nil, zero value otherwise.

### GetProbabilityOk

`func (o *SegmentData) GetProbabilityOk() (*float32, bool)`

GetProbabilityOk returns a tuple with the Probability field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetProbability

`func (o *SegmentData) SetProbability(v float32)`

SetProbability sets Probability field to given value.

### HasProbability

`func (o *SegmentData) HasProbability() bool`

HasProbability returns a boolean if a field has been set.

### GetLanguage

`func (o *SegmentData) GetLanguage() string`

GetLanguage returns the Language field if non-nil, zero value otherwise.

### GetLanguageOk

`func (o *SegmentData) GetLanguageOk() (*string, bool)`

GetLanguageOk returns a tuple with the Language field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguage

`func (o *SegmentData) SetLanguage(v string)`

SetLanguage sets Language field to given value.

### HasLanguage

`func (o *SegmentData) HasLanguage() bool`

HasLanguage returns a boolean if a field has been set.

### SetLanguageNil

`func (o *SegmentData) SetLanguageNil(b bool)`

 SetLanguageNil sets the value for Language to be an explicit nil

### UnsetLanguage
`func (o *SegmentData) UnsetLanguage()`

UnsetLanguage ensures that no value is present for Language, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


