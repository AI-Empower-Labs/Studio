# GetLanguageResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Languages** | Pointer to [**[]SupportedLanguage**](SupportedLanguage.md) |  | [optional] 

## Methods

### NewGetLanguageResponse

`func NewGetLanguageResponse() *GetLanguageResponse`

NewGetLanguageResponse instantiates a new GetLanguageResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewGetLanguageResponseWithDefaults

`func NewGetLanguageResponseWithDefaults() *GetLanguageResponse`

NewGetLanguageResponseWithDefaults instantiates a new GetLanguageResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetLanguages

`func (o *GetLanguageResponse) GetLanguages() []SupportedLanguage`

GetLanguages returns the Languages field if non-nil, zero value otherwise.

### GetLanguagesOk

`func (o *GetLanguageResponse) GetLanguagesOk() (*[]SupportedLanguage, bool)`

GetLanguagesOk returns a tuple with the Languages field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguages

`func (o *GetLanguageResponse) SetLanguages(v []SupportedLanguage)`

SetLanguages sets Languages field to given value.

### HasLanguages

`func (o *GetLanguageResponse) HasLanguages() bool`

HasLanguages returns a boolean if a field has been set.

### SetLanguagesNil

`func (o *GetLanguageResponse) SetLanguagesNil(b bool)`

 SetLanguagesNil sets the value for Languages to be an explicit nil

### UnsetLanguages
`func (o *GetLanguageResponse) UnsetLanguages()`

UnsetLanguages ensures that no value is present for Languages, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


