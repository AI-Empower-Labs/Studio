# NamedEntityRecognitionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | Pointer to **map[string][]string** |  | [optional] 

## Methods

### NewNamedEntityRecognitionResponse

`func NewNamedEntityRecognitionResponse() *NamedEntityRecognitionResponse`

NewNamedEntityRecognitionResponse instantiates a new NamedEntityRecognitionResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewNamedEntityRecognitionResponseWithDefaults

`func NewNamedEntityRecognitionResponseWithDefaults() *NamedEntityRecognitionResponse`

NewNamedEntityRecognitionResponseWithDefaults instantiates a new NamedEntityRecognitionResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetEntities

`func (o *NamedEntityRecognitionResponse) GetEntities() map[string][]string`

GetEntities returns the Entities field if non-nil, zero value otherwise.

### GetEntitiesOk

`func (o *NamedEntityRecognitionResponse) GetEntitiesOk() (*map[string][]string, bool)`

GetEntitiesOk returns a tuple with the Entities field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEntities

`func (o *NamedEntityRecognitionResponse) SetEntities(v map[string][]string)`

SetEntities sets Entities field to given value.

### HasEntities

`func (o *NamedEntityRecognitionResponse) HasEntities() bool`

HasEntities returns a boolean if a field has been set.

### SetEntitiesNil

`func (o *NamedEntityRecognitionResponse) SetEntitiesNil(b bool)`

 SetEntitiesNil sets the value for Entities to be an explicit nil

### UnsetEntities
`func (o *NamedEntityRecognitionResponse) UnsetEntities()`

UnsetEntities ensures that no value is present for Entities, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


