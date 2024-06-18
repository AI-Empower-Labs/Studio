# HttpValidationProblemDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | Pointer to **NullableString** |  | [optional] 
**Title** | Pointer to **NullableString** |  | [optional] 
**Status** | Pointer to **NullableInt32** |  | [optional] 
**Detail** | Pointer to **NullableString** |  | [optional] 
**Instance** | Pointer to **NullableString** |  | [optional] 
**Errors** | Pointer to **map[string][]string** |  | [optional] 

## Methods

### NewHttpValidationProblemDetails

`func NewHttpValidationProblemDetails() *HttpValidationProblemDetails`

NewHttpValidationProblemDetails instantiates a new HttpValidationProblemDetails object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewHttpValidationProblemDetailsWithDefaults

`func NewHttpValidationProblemDetailsWithDefaults() *HttpValidationProblemDetails`

NewHttpValidationProblemDetailsWithDefaults instantiates a new HttpValidationProblemDetails object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetType

`func (o *HttpValidationProblemDetails) GetType() string`

GetType returns the Type field if non-nil, zero value otherwise.

### GetTypeOk

`func (o *HttpValidationProblemDetails) GetTypeOk() (*string, bool)`

GetTypeOk returns a tuple with the Type field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetType

`func (o *HttpValidationProblemDetails) SetType(v string)`

SetType sets Type field to given value.

### HasType

`func (o *HttpValidationProblemDetails) HasType() bool`

HasType returns a boolean if a field has been set.

### SetTypeNil

`func (o *HttpValidationProblemDetails) SetTypeNil(b bool)`

 SetTypeNil sets the value for Type to be an explicit nil

### UnsetType
`func (o *HttpValidationProblemDetails) UnsetType()`

UnsetType ensures that no value is present for Type, not even an explicit nil
### GetTitle

`func (o *HttpValidationProblemDetails) GetTitle() string`

GetTitle returns the Title field if non-nil, zero value otherwise.

### GetTitleOk

`func (o *HttpValidationProblemDetails) GetTitleOk() (*string, bool)`

GetTitleOk returns a tuple with the Title field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTitle

`func (o *HttpValidationProblemDetails) SetTitle(v string)`

SetTitle sets Title field to given value.

### HasTitle

`func (o *HttpValidationProblemDetails) HasTitle() bool`

HasTitle returns a boolean if a field has been set.

### SetTitleNil

`func (o *HttpValidationProblemDetails) SetTitleNil(b bool)`

 SetTitleNil sets the value for Title to be an explicit nil

### UnsetTitle
`func (o *HttpValidationProblemDetails) UnsetTitle()`

UnsetTitle ensures that no value is present for Title, not even an explicit nil
### GetStatus

`func (o *HttpValidationProblemDetails) GetStatus() int32`

GetStatus returns the Status field if non-nil, zero value otherwise.

### GetStatusOk

`func (o *HttpValidationProblemDetails) GetStatusOk() (*int32, bool)`

GetStatusOk returns a tuple with the Status field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatus

`func (o *HttpValidationProblemDetails) SetStatus(v int32)`

SetStatus sets Status field to given value.

### HasStatus

`func (o *HttpValidationProblemDetails) HasStatus() bool`

HasStatus returns a boolean if a field has been set.

### SetStatusNil

`func (o *HttpValidationProblemDetails) SetStatusNil(b bool)`

 SetStatusNil sets the value for Status to be an explicit nil

### UnsetStatus
`func (o *HttpValidationProblemDetails) UnsetStatus()`

UnsetStatus ensures that no value is present for Status, not even an explicit nil
### GetDetail

`func (o *HttpValidationProblemDetails) GetDetail() string`

GetDetail returns the Detail field if non-nil, zero value otherwise.

### GetDetailOk

`func (o *HttpValidationProblemDetails) GetDetailOk() (*string, bool)`

GetDetailOk returns a tuple with the Detail field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDetail

`func (o *HttpValidationProblemDetails) SetDetail(v string)`

SetDetail sets Detail field to given value.

### HasDetail

`func (o *HttpValidationProblemDetails) HasDetail() bool`

HasDetail returns a boolean if a field has been set.

### SetDetailNil

`func (o *HttpValidationProblemDetails) SetDetailNil(b bool)`

 SetDetailNil sets the value for Detail to be an explicit nil

### UnsetDetail
`func (o *HttpValidationProblemDetails) UnsetDetail()`

UnsetDetail ensures that no value is present for Detail, not even an explicit nil
### GetInstance

`func (o *HttpValidationProblemDetails) GetInstance() string`

GetInstance returns the Instance field if non-nil, zero value otherwise.

### GetInstanceOk

`func (o *HttpValidationProblemDetails) GetInstanceOk() (*string, bool)`

GetInstanceOk returns a tuple with the Instance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetInstance

`func (o *HttpValidationProblemDetails) SetInstance(v string)`

SetInstance sets Instance field to given value.

### HasInstance

`func (o *HttpValidationProblemDetails) HasInstance() bool`

HasInstance returns a boolean if a field has been set.

### SetInstanceNil

`func (o *HttpValidationProblemDetails) SetInstanceNil(b bool)`

 SetInstanceNil sets the value for Instance to be an explicit nil

### UnsetInstance
`func (o *HttpValidationProblemDetails) UnsetInstance()`

UnsetInstance ensures that no value is present for Instance, not even an explicit nil
### GetErrors

`func (o *HttpValidationProblemDetails) GetErrors() map[string][]string`

GetErrors returns the Errors field if non-nil, zero value otherwise.

### GetErrorsOk

`func (o *HttpValidationProblemDetails) GetErrorsOk() (*map[string][]string, bool)`

GetErrorsOk returns a tuple with the Errors field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetErrors

`func (o *HttpValidationProblemDetails) SetErrors(v map[string][]string)`

SetErrors sets Errors field to given value.

### HasErrors

`func (o *HttpValidationProblemDetails) HasErrors() bool`

HasErrors returns a boolean if a field has been set.

### SetErrorsNil

`func (o *HttpValidationProblemDetails) SetErrorsNil(b bool)`

 SetErrorsNil sets the value for Errors to be an explicit nil

### UnsetErrors
`func (o *HttpValidationProblemDetails) UnsetErrors()`

UnsetErrors ensures that no value is present for Errors, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


