# KeywordExtractionRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Text to perform keyword extraction on | 
**Model** | Pointer to **NullableString** | Text to perform keyword extraction on | [optional] 

## Methods

### NewKeywordExtractionRequestBody

`func NewKeywordExtractionRequestBody(text string, ) *KeywordExtractionRequestBody`

NewKeywordExtractionRequestBody instantiates a new KeywordExtractionRequestBody object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewKeywordExtractionRequestBodyWithDefaults

`func NewKeywordExtractionRequestBodyWithDefaults() *KeywordExtractionRequestBody`

NewKeywordExtractionRequestBodyWithDefaults instantiates a new KeywordExtractionRequestBody object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *KeywordExtractionRequestBody) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *KeywordExtractionRequestBody) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *KeywordExtractionRequestBody) SetText(v string)`

SetText sets Text field to given value.


### GetModel

`func (o *KeywordExtractionRequestBody) GetModel() string`

GetModel returns the Model field if non-nil, zero value otherwise.

### GetModelOk

`func (o *KeywordExtractionRequestBody) GetModelOk() (*string, bool)`

GetModelOk returns a tuple with the Model field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetModel

`func (o *KeywordExtractionRequestBody) SetModel(v string)`

SetModel sets Model field to given value.

### HasModel

`func (o *KeywordExtractionRequestBody) HasModel() bool`

HasModel returns a boolean if a field has been set.

### SetModelNil

`func (o *KeywordExtractionRequestBody) SetModelNil(b bool)`

 SetModelNil sets the value for Model to be an explicit nil

### UnsetModel
`func (o *KeywordExtractionRequestBody) UnsetModel()`

UnsetModel ensures that no value is present for Model, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


