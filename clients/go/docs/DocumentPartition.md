# DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | Pointer to **NullableString** | Content of the document partition, aka chunk/block of text. | [optional] 
**Relevance** | Pointer to **float32** | Relevance of this partition against the given query.  Value usually is between 0 and 1, when using cosine similarity. | [optional] 
**LastUpdate** | Pointer to **time.Time** | Timestamp about the file/text partition. | [optional] 
**Tags** | Pointer to **map[string][]string** | List of document tags | [optional] 

## Methods

### NewDocumentPartition

`func NewDocumentPartition() *DocumentPartition`

NewDocumentPartition instantiates a new DocumentPartition object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewDocumentPartitionWithDefaults

`func NewDocumentPartitionWithDefaults() *DocumentPartition`

NewDocumentPartitionWithDefaults instantiates a new DocumentPartition object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *DocumentPartition) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *DocumentPartition) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *DocumentPartition) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *DocumentPartition) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *DocumentPartition) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *DocumentPartition) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetRelevance

`func (o *DocumentPartition) GetRelevance() float32`

GetRelevance returns the Relevance field if non-nil, zero value otherwise.

### GetRelevanceOk

`func (o *DocumentPartition) GetRelevanceOk() (*float32, bool)`

GetRelevanceOk returns a tuple with the Relevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRelevance

`func (o *DocumentPartition) SetRelevance(v float32)`

SetRelevance sets Relevance field to given value.

### HasRelevance

`func (o *DocumentPartition) HasRelevance() bool`

HasRelevance returns a boolean if a field has been set.

### GetLastUpdate

`func (o *DocumentPartition) GetLastUpdate() time.Time`

GetLastUpdate returns the LastUpdate field if non-nil, zero value otherwise.

### GetLastUpdateOk

`func (o *DocumentPartition) GetLastUpdateOk() (*time.Time, bool)`

GetLastUpdateOk returns a tuple with the LastUpdate field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLastUpdate

`func (o *DocumentPartition) SetLastUpdate(v time.Time)`

SetLastUpdate sets LastUpdate field to given value.

### HasLastUpdate

`func (o *DocumentPartition) HasLastUpdate() bool`

HasLastUpdate returns a boolean if a field has been set.

### GetTags

`func (o *DocumentPartition) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *DocumentPartition) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *DocumentPartition) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *DocumentPartition) HasTags() bool`

HasTags returns a boolean if a field has been set.

### SetTagsNil

`func (o *DocumentPartition) SetTagsNil(b bool)`

 SetTagsNil sets the value for Tags to be an explicit nil

### UnsetTags
`func (o *DocumentPartition) UnsetTags()`

UnsetTags ensures that no value is present for Tags, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


