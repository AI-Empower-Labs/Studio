# Citation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Link** | Pointer to **NullableString** |  | [optional] 
**Index** | Pointer to **NullableString** |  | [optional] 
**DocumentId** | Pointer to **NullableString** |  | [optional] 
**FileId** | Pointer to **NullableString** |  | [optional] 
**SourceContentType** | Pointer to **NullableString** |  | [optional] 
**SourceName** | Pointer to **NullableString** |  | [optional] 
**SourceUrl** | Pointer to **NullableString** |  | [optional] 
**Partitions** | Pointer to [**[]Partition**](Partition.md) |  | [optional] 

## Methods

### NewCitation

`func NewCitation() *Citation`

NewCitation instantiates a new Citation object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewCitationWithDefaults

`func NewCitationWithDefaults() *Citation`

NewCitationWithDefaults instantiates a new Citation object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetLink

`func (o *Citation) GetLink() string`

GetLink returns the Link field if non-nil, zero value otherwise.

### GetLinkOk

`func (o *Citation) GetLinkOk() (*string, bool)`

GetLinkOk returns a tuple with the Link field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLink

`func (o *Citation) SetLink(v string)`

SetLink sets Link field to given value.

### HasLink

`func (o *Citation) HasLink() bool`

HasLink returns a boolean if a field has been set.

### SetLinkNil

`func (o *Citation) SetLinkNil(b bool)`

 SetLinkNil sets the value for Link to be an explicit nil

### UnsetLink
`func (o *Citation) UnsetLink()`

UnsetLink ensures that no value is present for Link, not even an explicit nil
### GetIndex

`func (o *Citation) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *Citation) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *Citation) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *Citation) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *Citation) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *Citation) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetDocumentId

`func (o *Citation) GetDocumentId() string`

GetDocumentId returns the DocumentId field if non-nil, zero value otherwise.

### GetDocumentIdOk

`func (o *Citation) GetDocumentIdOk() (*string, bool)`

GetDocumentIdOk returns a tuple with the DocumentId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocumentId

`func (o *Citation) SetDocumentId(v string)`

SetDocumentId sets DocumentId field to given value.

### HasDocumentId

`func (o *Citation) HasDocumentId() bool`

HasDocumentId returns a boolean if a field has been set.

### SetDocumentIdNil

`func (o *Citation) SetDocumentIdNil(b bool)`

 SetDocumentIdNil sets the value for DocumentId to be an explicit nil

### UnsetDocumentId
`func (o *Citation) UnsetDocumentId()`

UnsetDocumentId ensures that no value is present for DocumentId, not even an explicit nil
### GetFileId

`func (o *Citation) GetFileId() string`

GetFileId returns the FileId field if non-nil, zero value otherwise.

### GetFileIdOk

`func (o *Citation) GetFileIdOk() (*string, bool)`

GetFileIdOk returns a tuple with the FileId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFileId

`func (o *Citation) SetFileId(v string)`

SetFileId sets FileId field to given value.

### HasFileId

`func (o *Citation) HasFileId() bool`

HasFileId returns a boolean if a field has been set.

### SetFileIdNil

`func (o *Citation) SetFileIdNil(b bool)`

 SetFileIdNil sets the value for FileId to be an explicit nil

### UnsetFileId
`func (o *Citation) UnsetFileId()`

UnsetFileId ensures that no value is present for FileId, not even an explicit nil
### GetSourceContentType

`func (o *Citation) GetSourceContentType() string`

GetSourceContentType returns the SourceContentType field if non-nil, zero value otherwise.

### GetSourceContentTypeOk

`func (o *Citation) GetSourceContentTypeOk() (*string, bool)`

GetSourceContentTypeOk returns a tuple with the SourceContentType field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSourceContentType

`func (o *Citation) SetSourceContentType(v string)`

SetSourceContentType sets SourceContentType field to given value.

### HasSourceContentType

`func (o *Citation) HasSourceContentType() bool`

HasSourceContentType returns a boolean if a field has been set.

### SetSourceContentTypeNil

`func (o *Citation) SetSourceContentTypeNil(b bool)`

 SetSourceContentTypeNil sets the value for SourceContentType to be an explicit nil

### UnsetSourceContentType
`func (o *Citation) UnsetSourceContentType()`

UnsetSourceContentType ensures that no value is present for SourceContentType, not even an explicit nil
### GetSourceName

`func (o *Citation) GetSourceName() string`

GetSourceName returns the SourceName field if non-nil, zero value otherwise.

### GetSourceNameOk

`func (o *Citation) GetSourceNameOk() (*string, bool)`

GetSourceNameOk returns a tuple with the SourceName field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSourceName

`func (o *Citation) SetSourceName(v string)`

SetSourceName sets SourceName field to given value.

### HasSourceName

`func (o *Citation) HasSourceName() bool`

HasSourceName returns a boolean if a field has been set.

### SetSourceNameNil

`func (o *Citation) SetSourceNameNil(b bool)`

 SetSourceNameNil sets the value for SourceName to be an explicit nil

### UnsetSourceName
`func (o *Citation) UnsetSourceName()`

UnsetSourceName ensures that no value is present for SourceName, not even an explicit nil
### GetSourceUrl

`func (o *Citation) GetSourceUrl() string`

GetSourceUrl returns the SourceUrl field if non-nil, zero value otherwise.

### GetSourceUrlOk

`func (o *Citation) GetSourceUrlOk() (*string, bool)`

GetSourceUrlOk returns a tuple with the SourceUrl field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSourceUrl

`func (o *Citation) SetSourceUrl(v string)`

SetSourceUrl sets SourceUrl field to given value.

### HasSourceUrl

`func (o *Citation) HasSourceUrl() bool`

HasSourceUrl returns a boolean if a field has been set.

### SetSourceUrlNil

`func (o *Citation) SetSourceUrlNil(b bool)`

 SetSourceUrlNil sets the value for SourceUrl to be an explicit nil

### UnsetSourceUrl
`func (o *Citation) UnsetSourceUrl()`

UnsetSourceUrl ensures that no value is present for SourceUrl, not even an explicit nil
### GetPartitions

`func (o *Citation) GetPartitions() []Partition`

GetPartitions returns the Partitions field if non-nil, zero value otherwise.

### GetPartitionsOk

`func (o *Citation) GetPartitionsOk() (*[]Partition, bool)`

GetPartitionsOk returns a tuple with the Partitions field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPartitions

`func (o *Citation) SetPartitions(v []Partition)`

SetPartitions sets Partitions field to given value.

### HasPartitions

`func (o *Citation) HasPartitions() bool`

HasPartitions returns a boolean if a field has been set.

### SetPartitionsNil

`func (o *Citation) SetPartitionsNil(b bool)`

 SetPartitionsNil sets the value for Partitions to be an explicit nil

### UnsetPartitions
`func (o *Citation) UnsetPartitions()`

UnsetPartitions ensures that no value is present for Partitions, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


