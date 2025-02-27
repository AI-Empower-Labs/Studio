# DocumentCitation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Link** | Pointer to **NullableString** | URL or reference to the original source document | [optional] 
**Index** | Pointer to **NullableString** | Identifier or position of the citation within the source | [optional] 
**DocumentId** | Pointer to **NullableString** | Unique identifier for the document | [optional] 
**FileId** | Pointer to **NullableString** | Unique identifier for the file in storage | [optional] 
**SourceContentType** | Pointer to **NullableString** | Format of the source (e.g., &#39;pdf&#39;, &#39;docx&#39;, &#39;chat&#39;) | [optional] 
**SourceName** | Pointer to **NullableString** | Human-readable name or title of the source | [optional] 
**SourceUrl** | Pointer to **NullableString** | Web URL of the source for online content | [optional] 
**Partitions** | Pointer to [**[]DocumentPartition**](DocumentPartition.md) | Array of text segments used from the source | [optional] 

## Methods

### NewDocumentCitation

`func NewDocumentCitation() *DocumentCitation`

NewDocumentCitation instantiates a new DocumentCitation object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewDocumentCitationWithDefaults

`func NewDocumentCitationWithDefaults() *DocumentCitation`

NewDocumentCitationWithDefaults instantiates a new DocumentCitation object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetLink

`func (o *DocumentCitation) GetLink() string`

GetLink returns the Link field if non-nil, zero value otherwise.

### GetLinkOk

`func (o *DocumentCitation) GetLinkOk() (*string, bool)`

GetLinkOk returns a tuple with the Link field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLink

`func (o *DocumentCitation) SetLink(v string)`

SetLink sets Link field to given value.

### HasLink

`func (o *DocumentCitation) HasLink() bool`

HasLink returns a boolean if a field has been set.

### SetLinkNil

`func (o *DocumentCitation) SetLinkNil(b bool)`

 SetLinkNil sets the value for Link to be an explicit nil

### UnsetLink
`func (o *DocumentCitation) UnsetLink()`

UnsetLink ensures that no value is present for Link, not even an explicit nil
### GetIndex

`func (o *DocumentCitation) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *DocumentCitation) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *DocumentCitation) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *DocumentCitation) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *DocumentCitation) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *DocumentCitation) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetDocumentId

`func (o *DocumentCitation) GetDocumentId() string`

GetDocumentId returns the DocumentId field if non-nil, zero value otherwise.

### GetDocumentIdOk

`func (o *DocumentCitation) GetDocumentIdOk() (*string, bool)`

GetDocumentIdOk returns a tuple with the DocumentId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDocumentId

`func (o *DocumentCitation) SetDocumentId(v string)`

SetDocumentId sets DocumentId field to given value.

### HasDocumentId

`func (o *DocumentCitation) HasDocumentId() bool`

HasDocumentId returns a boolean if a field has been set.

### SetDocumentIdNil

`func (o *DocumentCitation) SetDocumentIdNil(b bool)`

 SetDocumentIdNil sets the value for DocumentId to be an explicit nil

### UnsetDocumentId
`func (o *DocumentCitation) UnsetDocumentId()`

UnsetDocumentId ensures that no value is present for DocumentId, not even an explicit nil
### GetFileId

`func (o *DocumentCitation) GetFileId() string`

GetFileId returns the FileId field if non-nil, zero value otherwise.

### GetFileIdOk

`func (o *DocumentCitation) GetFileIdOk() (*string, bool)`

GetFileIdOk returns a tuple with the FileId field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFileId

`func (o *DocumentCitation) SetFileId(v string)`

SetFileId sets FileId field to given value.

### HasFileId

`func (o *DocumentCitation) HasFileId() bool`

HasFileId returns a boolean if a field has been set.

### SetFileIdNil

`func (o *DocumentCitation) SetFileIdNil(b bool)`

 SetFileIdNil sets the value for FileId to be an explicit nil

### UnsetFileId
`func (o *DocumentCitation) UnsetFileId()`

UnsetFileId ensures that no value is present for FileId, not even an explicit nil
### GetSourceContentType

`func (o *DocumentCitation) GetSourceContentType() string`

GetSourceContentType returns the SourceContentType field if non-nil, zero value otherwise.

### GetSourceContentTypeOk

`func (o *DocumentCitation) GetSourceContentTypeOk() (*string, bool)`

GetSourceContentTypeOk returns a tuple with the SourceContentType field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSourceContentType

`func (o *DocumentCitation) SetSourceContentType(v string)`

SetSourceContentType sets SourceContentType field to given value.

### HasSourceContentType

`func (o *DocumentCitation) HasSourceContentType() bool`

HasSourceContentType returns a boolean if a field has been set.

### SetSourceContentTypeNil

`func (o *DocumentCitation) SetSourceContentTypeNil(b bool)`

 SetSourceContentTypeNil sets the value for SourceContentType to be an explicit nil

### UnsetSourceContentType
`func (o *DocumentCitation) UnsetSourceContentType()`

UnsetSourceContentType ensures that no value is present for SourceContentType, not even an explicit nil
### GetSourceName

`func (o *DocumentCitation) GetSourceName() string`

GetSourceName returns the SourceName field if non-nil, zero value otherwise.

### GetSourceNameOk

`func (o *DocumentCitation) GetSourceNameOk() (*string, bool)`

GetSourceNameOk returns a tuple with the SourceName field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSourceName

`func (o *DocumentCitation) SetSourceName(v string)`

SetSourceName sets SourceName field to given value.

### HasSourceName

`func (o *DocumentCitation) HasSourceName() bool`

HasSourceName returns a boolean if a field has been set.

### SetSourceNameNil

`func (o *DocumentCitation) SetSourceNameNil(b bool)`

 SetSourceNameNil sets the value for SourceName to be an explicit nil

### UnsetSourceName
`func (o *DocumentCitation) UnsetSourceName()`

UnsetSourceName ensures that no value is present for SourceName, not even an explicit nil
### GetSourceUrl

`func (o *DocumentCitation) GetSourceUrl() string`

GetSourceUrl returns the SourceUrl field if non-nil, zero value otherwise.

### GetSourceUrlOk

`func (o *DocumentCitation) GetSourceUrlOk() (*string, bool)`

GetSourceUrlOk returns a tuple with the SourceUrl field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSourceUrl

`func (o *DocumentCitation) SetSourceUrl(v string)`

SetSourceUrl sets SourceUrl field to given value.

### HasSourceUrl

`func (o *DocumentCitation) HasSourceUrl() bool`

HasSourceUrl returns a boolean if a field has been set.

### SetSourceUrlNil

`func (o *DocumentCitation) SetSourceUrlNil(b bool)`

 SetSourceUrlNil sets the value for SourceUrl to be an explicit nil

### UnsetSourceUrl
`func (o *DocumentCitation) UnsetSourceUrl()`

UnsetSourceUrl ensures that no value is present for SourceUrl, not even an explicit nil
### GetPartitions

`func (o *DocumentCitation) GetPartitions() []DocumentPartition`

GetPartitions returns the Partitions field if non-nil, zero value otherwise.

### GetPartitionsOk

`func (o *DocumentCitation) GetPartitionsOk() (*[]DocumentPartition, bool)`

GetPartitionsOk returns a tuple with the Partitions field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPartitions

`func (o *DocumentCitation) SetPartitions(v []DocumentPartition)`

SetPartitions sets Partitions field to given value.

### HasPartitions

`func (o *DocumentCitation) HasPartitions() bool`

HasPartitions returns a boolean if a field has been set.

### SetPartitionsNil

`func (o *DocumentCitation) SetPartitionsNil(b bool)`

 SetPartitionsNil sets the value for Partitions to be an explicit nil

### UnsetPartitions
`func (o *DocumentCitation) UnsetPartitions()`

UnsetPartitions ensures that no value is present for Partitions, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


