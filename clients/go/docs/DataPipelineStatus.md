# DataPipelineStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Completed** | Pointer to **bool** |  | [optional] 
**Failed** | Pointer to **bool** |  | [optional] 
**Empty** | Pointer to **bool** |  | [optional] 
**Index** | Pointer to **NullableString** |  | [optional] 
**DocumentId** | Pointer to **NullableString** |  | [optional] 
**Tags** | Pointer to **map[string][]string** |  | [optional] 
**Creation** | Pointer to **time.Time** |  | [optional] 
**LastUpdate** | Pointer to **time.Time** |  | [optional] 
**Steps** | Pointer to **[]string** |  | [optional] 
**RemainingSteps** | Pointer to **[]string** |  | [optional] 
**CompletedSteps** | Pointer to **[]string** |  | [optional] 

## Methods

### NewDataPipelineStatus

`func NewDataPipelineStatus() *DataPipelineStatus`

NewDataPipelineStatus instantiates a new DataPipelineStatus object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewDataPipelineStatusWithDefaults

`func NewDataPipelineStatusWithDefaults() *DataPipelineStatus`

NewDataPipelineStatusWithDefaults instantiates a new DataPipelineStatus object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetCompleted

`func (o *DataPipelineStatus) GetCompleted() bool`

GetCompleted returns the Completed field if non-nil, zero value otherwise.

### GetCompletedOk

`func (o *DataPipelineStatus) GetCompletedOk() (*bool, bool)`

GetCompletedOk returns a tuple with the Completed field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCompleted

`func (o *DataPipelineStatus) SetCompleted(v bool)`

SetCompleted sets Completed field to given value.

### HasCompleted

`func (o *DataPipelineStatus) HasCompleted() bool`

HasCompleted returns a boolean if a field has been set.

### GetFailed

`func (o *DataPipelineStatus) GetFailed() bool`

GetFailed returns the Failed field if non-nil, zero value otherwise.

### GetFailedOk

`func (o *DataPipelineStatus) GetFailedOk() (*bool, bool)`

GetFailedOk returns a tuple with the Failed field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFailed

`func (o *DataPipelineStatus) SetFailed(v bool)`

SetFailed sets Failed field to given value.

### HasFailed

`func (o *DataPipelineStatus) HasFailed() bool`

HasFailed returns a boolean if a field has been set.

### GetEmpty

`func (o *DataPipelineStatus) GetEmpty() bool`

GetEmpty returns the Empty field if non-nil, zero value otherwise.

### GetEmptyOk

`func (o *DataPipelineStatus) GetEmptyOk() (*bool, bool)`

GetEmptyOk returns a tuple with the Empty field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmpty

`func (o *DataPipelineStatus) SetEmpty(v bool)`

SetEmpty sets Empty field to given value.

### HasEmpty

`func (o *DataPipelineStatus) HasEmpty() bool`

HasEmpty returns a boolean if a field has been set.

### GetIndex

`func (o *DataPipelineStatus) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *DataPipelineStatus) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *DataPipelineStatus) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *DataPipelineStatus) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *DataPipelineStatus) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *DataPipelineStatus) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetDocumentId

`func (o *DataPipelineStatus) GetDocumentId() string`

GetDocumentId returns the DocumentId field if non-nil, zero value otherwise.

### GetDocumentIdOk

`func (o *DataPipelineStatus) GetDocumentIdOk() (*string, bool)`

GetDocumentIdOk returns a tuple with the DocumentId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocumentId

`func (o *DataPipelineStatus) SetDocumentId(v string)`

SetDocumentId sets DocumentId field to given value.

### HasDocumentId

`func (o *DataPipelineStatus) HasDocumentId() bool`

HasDocumentId returns a boolean if a field has been set.

### SetDocumentIdNil

`func (o *DataPipelineStatus) SetDocumentIdNil(b bool)`

 SetDocumentIdNil sets the value for DocumentId to be an explicit nil

### UnsetDocumentId
`func (o *DataPipelineStatus) UnsetDocumentId()`

UnsetDocumentId ensures that no value is present for DocumentId, not even an explicit nil
### GetTags

`func (o *DataPipelineStatus) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *DataPipelineStatus) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *DataPipelineStatus) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *DataPipelineStatus) HasTags() bool`

HasTags returns a boolean if a field has been set.

### SetTagsNil

`func (o *DataPipelineStatus) SetTagsNil(b bool)`

 SetTagsNil sets the value for Tags to be an explicit nil

### UnsetTags
`func (o *DataPipelineStatus) UnsetTags()`

UnsetTags ensures that no value is present for Tags, not even an explicit nil
### GetCreation

`func (o *DataPipelineStatus) GetCreation() time.Time`

GetCreation returns the Creation field if non-nil, zero value otherwise.

### GetCreationOk

`func (o *DataPipelineStatus) GetCreationOk() (*time.Time, bool)`

GetCreationOk returns a tuple with the Creation field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCreation

`func (o *DataPipelineStatus) SetCreation(v time.Time)`

SetCreation sets Creation field to given value.

### HasCreation

`func (o *DataPipelineStatus) HasCreation() bool`

HasCreation returns a boolean if a field has been set.

### GetLastUpdate

`func (o *DataPipelineStatus) GetLastUpdate() time.Time`

GetLastUpdate returns the LastUpdate field if non-nil, zero value otherwise.

### GetLastUpdateOk

`func (o *DataPipelineStatus) GetLastUpdateOk() (*time.Time, bool)`

GetLastUpdateOk returns a tuple with the LastUpdate field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLastUpdate

`func (o *DataPipelineStatus) SetLastUpdate(v time.Time)`

SetLastUpdate sets LastUpdate field to given value.

### HasLastUpdate

`func (o *DataPipelineStatus) HasLastUpdate() bool`

HasLastUpdate returns a boolean if a field has been set.

### GetSteps

`func (o *DataPipelineStatus) GetSteps() []string`

GetSteps returns the Steps field if non-nil, zero value otherwise.

### GetStepsOk

`func (o *DataPipelineStatus) GetStepsOk() (*[]string, bool)`

GetStepsOk returns a tuple with the Steps field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSteps

`func (o *DataPipelineStatus) SetSteps(v []string)`

SetSteps sets Steps field to given value.

### HasSteps

`func (o *DataPipelineStatus) HasSteps() bool`

HasSteps returns a boolean if a field has been set.

### SetStepsNil

`func (o *DataPipelineStatus) SetStepsNil(b bool)`

 SetStepsNil sets the value for Steps to be an explicit nil

### UnsetSteps
`func (o *DataPipelineStatus) UnsetSteps()`

UnsetSteps ensures that no value is present for Steps, not even an explicit nil
### GetRemainingSteps

`func (o *DataPipelineStatus) GetRemainingSteps() []string`

GetRemainingSteps returns the RemainingSteps field if non-nil, zero value otherwise.

### GetRemainingStepsOk

`func (o *DataPipelineStatus) GetRemainingStepsOk() (*[]string, bool)`

GetRemainingStepsOk returns a tuple with the RemainingSteps field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRemainingSteps

`func (o *DataPipelineStatus) SetRemainingSteps(v []string)`

SetRemainingSteps sets RemainingSteps field to given value.

### HasRemainingSteps

`func (o *DataPipelineStatus) HasRemainingSteps() bool`

HasRemainingSteps returns a boolean if a field has been set.

### SetRemainingStepsNil

`func (o *DataPipelineStatus) SetRemainingStepsNil(b bool)`

 SetRemainingStepsNil sets the value for RemainingSteps to be an explicit nil

### UnsetRemainingSteps
`func (o *DataPipelineStatus) UnsetRemainingSteps()`

UnsetRemainingSteps ensures that no value is present for RemainingSteps, not even an explicit nil
### GetCompletedSteps

`func (o *DataPipelineStatus) GetCompletedSteps() []string`

GetCompletedSteps returns the CompletedSteps field if non-nil, zero value otherwise.

### GetCompletedStepsOk

`func (o *DataPipelineStatus) GetCompletedStepsOk() (*[]string, bool)`

GetCompletedStepsOk returns a tuple with the CompletedSteps field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCompletedSteps

`func (o *DataPipelineStatus) SetCompletedSteps(v []string)`

SetCompletedSteps sets CompletedSteps field to given value.

### HasCompletedSteps

`func (o *DataPipelineStatus) HasCompletedSteps() bool`

HasCompletedSteps returns a boolean if a field has been set.

### SetCompletedStepsNil

`func (o *DataPipelineStatus) SetCompletedStepsNil(b bool)`

 SetCompletedStepsNil sets the value for CompletedSteps to be an explicit nil

### UnsetCompletedSteps
`func (o *DataPipelineStatus) UnsetCompletedSteps()`

UnsetCompletedSteps ensures that no value is present for CompletedSteps, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


