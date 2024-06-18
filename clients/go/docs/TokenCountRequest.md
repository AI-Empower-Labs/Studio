# TokenCountRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | Pointer to **NullableString** |  | [optional] 
**Text** | Pointer to **[]string** |  | [optional] 

## Methods

### NewTokenCountRequest

`func NewTokenCountRequest() *TokenCountRequest`

NewTokenCountRequest instantiates a new TokenCountRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewTokenCountRequestWithDefaults

`func NewTokenCountRequestWithDefaults() *TokenCountRequest`

NewTokenCountRequestWithDefaults instantiates a new TokenCountRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetName

`func (o *TokenCountRequest) GetName() string`

GetName returns the Name field if non-nil, zero value otherwise.

### GetNameOk

`func (o *TokenCountRequest) GetNameOk() (*string, bool)`

GetNameOk returns a tuple with the Name field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetName

`func (o *TokenCountRequest) SetName(v string)`

SetName sets Name field to given value.

### HasName

`func (o *TokenCountRequest) HasName() bool`

HasName returns a boolean if a field has been set.

### SetNameNil

`func (o *TokenCountRequest) SetNameNil(b bool)`

 SetNameNil sets the value for Name to be an explicit nil

### UnsetName
`func (o *TokenCountRequest) UnsetName()`

UnsetName ensures that no value is present for Name, not even an explicit nil
### GetText

`func (o *TokenCountRequest) GetText() []string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *TokenCountRequest) GetTextOk() (*[]string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *TokenCountRequest) SetText(v []string)`

SetText sets Text field to given value.

### HasText

`func (o *TokenCountRequest) HasText() bool`

HasText returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


