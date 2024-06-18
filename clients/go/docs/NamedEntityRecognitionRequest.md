# NamedEntityRecognitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Text to perform Named Entity Recognition on  It recognises Persons, Organisations, Dates, Locations and Emails | 
**Model** | Pointer to **NullableString** | LLM Model to use | [optional] 
**Entities** | **[]string** | Entities to extract | 

## Methods

### NewNamedEntityRecognitionRequest

`func NewNamedEntityRecognitionRequest(text string, entities []string, ) *NamedEntityRecognitionRequest`

NewNamedEntityRecognitionRequest instantiates a new NamedEntityRecognitionRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewNamedEntityRecognitionRequestWithDefaults

`func NewNamedEntityRecognitionRequestWithDefaults() *NamedEntityRecognitionRequest`

NewNamedEntityRecognitionRequestWithDefaults instantiates a new NamedEntityRecognitionRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *NamedEntityRecognitionRequest) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *NamedEntityRecognitionRequest) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *NamedEntityRecognitionRequest) SetText(v string)`

SetText sets Text field to given value.


### GetModel

`func (o *NamedEntityRecognitionRequest) GetModel() string`

GetModel returns the Model field if non-nil, zero value otherwise.

### GetModelOk

`func (o *NamedEntityRecognitionRequest) GetModelOk() (*string, bool)`

GetModelOk returns a tuple with the Model field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetModel

`func (o *NamedEntityRecognitionRequest) SetModel(v string)`

SetModel sets Model field to given value.

### HasModel

`func (o *NamedEntityRecognitionRequest) HasModel() bool`

HasModel returns a boolean if a field has been set.

### SetModelNil

`func (o *NamedEntityRecognitionRequest) SetModelNil(b bool)`

 SetModelNil sets the value for Model to be an explicit nil

### UnsetModel
`func (o *NamedEntityRecognitionRequest) UnsetModel()`

UnsetModel ensures that no value is present for Model, not even an explicit nil
### GetEntities

`func (o *NamedEntityRecognitionRequest) GetEntities() []string`

GetEntities returns the Entities field if non-nil, zero value otherwise.

### GetEntitiesOk

`func (o *NamedEntityRecognitionRequest) GetEntitiesOk() (*[]string, bool)`

GetEntitiesOk returns a tuple with the Entities field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEntities

`func (o *NamedEntityRecognitionRequest) SetEntities(v []string)`

SetEntities sets Entities field to given value.



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


