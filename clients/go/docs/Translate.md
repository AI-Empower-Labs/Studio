# Translate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | Pointer to **NullableString** | The input text to be translated. | [optional] 
**Source** | Pointer to **string** | The language code of the input text. | [optional] 
**Target** | Pointer to **string** | The language code of the desired output translation. | [optional] 

## Methods

### NewTranslate

`func NewTranslate() *Translate`

NewTranslate instantiates a new Translate object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewTranslateWithDefaults

`func NewTranslateWithDefaults() *Translate`

NewTranslateWithDefaults instantiates a new Translate object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *Translate) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *Translate) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *Translate) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *Translate) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *Translate) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *Translate) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetSource

`func (o *Translate) GetSource() string`

GetSource returns the Source field if non-nil, zero value otherwise.

### GetSourceOk

`func (o *Translate) GetSourceOk() (*string, bool)`

GetSourceOk returns a tuple with the Source field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSource

`func (o *Translate) SetSource(v string)`

SetSource sets Source field to given value.

### HasSource

`func (o *Translate) HasSource() bool`

HasSource returns a boolean if a field has been set.

### GetTarget

`func (o *Translate) GetTarget() string`

GetTarget returns the Target field if non-nil, zero value otherwise.

### GetTargetOk

`func (o *Translate) GetTargetOk() (*string, bool)`

GetTargetOk returns a tuple with the Target field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTarget

`func (o *Translate) SetTarget(v string)`

SetTarget sets Target field to given value.

### HasTarget

`func (o *Translate) HasTarget() bool`

HasTarget returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


