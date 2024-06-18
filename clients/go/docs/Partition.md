# Partition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | Pointer to **NullableString** |  | [optional] 
**Relevance** | Pointer to **float32** |  | [optional] 
**PartitionNumber** | Pointer to **int32** |  | [optional] 
**SectionNumber** | Pointer to **int32** |  | [optional] 
**LastUpdate** | Pointer to **time.Time** |  | [optional] 
**Tags** | Pointer to **map[string][]string** |  | [optional] 

## Methods

### NewPartition

`func NewPartition() *Partition`

NewPartition instantiates a new Partition object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewPartitionWithDefaults

`func NewPartitionWithDefaults() *Partition`

NewPartitionWithDefaults instantiates a new Partition object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *Partition) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *Partition) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *Partition) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *Partition) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *Partition) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *Partition) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetRelevance

`func (o *Partition) GetRelevance() float32`

GetRelevance returns the Relevance field if non-nil, zero value otherwise.

### GetRelevanceOk

`func (o *Partition) GetRelevanceOk() (*float32, bool)`

GetRelevanceOk returns a tuple with the Relevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRelevance

`func (o *Partition) SetRelevance(v float32)`

SetRelevance sets Relevance field to given value.

### HasRelevance

`func (o *Partition) HasRelevance() bool`

HasRelevance returns a boolean if a field has been set.

### GetPartitionNumber

`func (o *Partition) GetPartitionNumber() int32`

GetPartitionNumber returns the PartitionNumber field if non-nil, zero value otherwise.

### GetPartitionNumberOk

`func (o *Partition) GetPartitionNumberOk() (*int32, bool)`

GetPartitionNumberOk returns a tuple with the PartitionNumber field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPartitionNumber

`func (o *Partition) SetPartitionNumber(v int32)`

SetPartitionNumber sets PartitionNumber field to given value.

### HasPartitionNumber

`func (o *Partition) HasPartitionNumber() bool`

HasPartitionNumber returns a boolean if a field has been set.

### GetSectionNumber

`func (o *Partition) GetSectionNumber() int32`

GetSectionNumber returns the SectionNumber field if non-nil, zero value otherwise.

### GetSectionNumberOk

`func (o *Partition) GetSectionNumberOk() (*int32, bool)`

GetSectionNumberOk returns a tuple with the SectionNumber field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSectionNumber

`func (o *Partition) SetSectionNumber(v int32)`

SetSectionNumber sets SectionNumber field to given value.

### HasSectionNumber

`func (o *Partition) HasSectionNumber() bool`

HasSectionNumber returns a boolean if a field has been set.

### GetLastUpdate

`func (o *Partition) GetLastUpdate() time.Time`

GetLastUpdate returns the LastUpdate field if non-nil, zero value otherwise.

### GetLastUpdateOk

`func (o *Partition) GetLastUpdateOk() (*time.Time, bool)`

GetLastUpdateOk returns a tuple with the LastUpdate field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLastUpdate

`func (o *Partition) SetLastUpdate(v time.Time)`

SetLastUpdate sets LastUpdate field to given value.

### HasLastUpdate

`func (o *Partition) HasLastUpdate() bool`

HasLastUpdate returns a boolean if a field has been set.

### GetTags

`func (o *Partition) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *Partition) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *Partition) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *Partition) HasTags() bool`

HasTags returns a boolean if a field has been set.

### SetTagsNil

`func (o *Partition) SetTagsNil(b bool)`

 SetTagsNil sets the value for Tags to be an explicit nil

### UnsetTags
`func (o *Partition) UnsetTags()`

UnsetTags ensures that no value is present for Tags, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


