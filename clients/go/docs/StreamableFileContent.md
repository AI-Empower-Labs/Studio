# StreamableFileContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | Pointer to **NullableString** |  | [optional] [readonly] 
**FileSize** | Pointer to **int64** |  | [optional] [readonly] 
**FileType** | Pointer to **NullableString** |  | [optional] [readonly] 
**LastWrite** | Pointer to **time.Time** |  | [optional] [readonly] 

## Methods

### NewStreamableFileContent

`func NewStreamableFileContent() *StreamableFileContent`

NewStreamableFileContent instantiates a new StreamableFileContent object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewStreamableFileContentWithDefaults

`func NewStreamableFileContentWithDefaults() *StreamableFileContent`

NewStreamableFileContentWithDefaults instantiates a new StreamableFileContent object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetFileName

`func (o *StreamableFileContent) GetFileName() string`

GetFileName returns the FileName field if non-nil, zero value otherwise.

### GetFileNameOk

`func (o *StreamableFileContent) GetFileNameOk() (*string, bool)`

GetFileNameOk returns a tuple with the FileName field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFileName

`func (o *StreamableFileContent) SetFileName(v string)`

SetFileName sets FileName field to given value.

### HasFileName

`func (o *StreamableFileContent) HasFileName() bool`

HasFileName returns a boolean if a field has been set.

### SetFileNameNil

`func (o *StreamableFileContent) SetFileNameNil(b bool)`

 SetFileNameNil sets the value for FileName to be an explicit nil

### UnsetFileName
`func (o *StreamableFileContent) UnsetFileName()`

UnsetFileName ensures that no value is present for FileName, not even an explicit nil
### GetFileSize

`func (o *StreamableFileContent) GetFileSize() int64`

GetFileSize returns the FileSize field if non-nil, zero value otherwise.

### GetFileSizeOk

`func (o *StreamableFileContent) GetFileSizeOk() (*int64, bool)`

GetFileSizeOk returns a tuple with the FileSize field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFileSize

`func (o *StreamableFileContent) SetFileSize(v int64)`

SetFileSize sets FileSize field to given value.

### HasFileSize

`func (o *StreamableFileContent) HasFileSize() bool`

HasFileSize returns a boolean if a field has been set.

### GetFileType

`func (o *StreamableFileContent) GetFileType() string`

GetFileType returns the FileType field if non-nil, zero value otherwise.

### GetFileTypeOk

`func (o *StreamableFileContent) GetFileTypeOk() (*string, bool)`

GetFileTypeOk returns a tuple with the FileType field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFileType

`func (o *StreamableFileContent) SetFileType(v string)`

SetFileType sets FileType field to given value.

### HasFileType

`func (o *StreamableFileContent) HasFileType() bool`

HasFileType returns a boolean if a field has been set.

### SetFileTypeNil

`func (o *StreamableFileContent) SetFileTypeNil(b bool)`

 SetFileTypeNil sets the value for FileType to be an explicit nil

### UnsetFileType
`func (o *StreamableFileContent) UnsetFileType()`

UnsetFileType ensures that no value is present for FileType, not even an explicit nil
### GetLastWrite

`func (o *StreamableFileContent) GetLastWrite() time.Time`

GetLastWrite returns the LastWrite field if non-nil, zero value otherwise.

### GetLastWriteOk

`func (o *StreamableFileContent) GetLastWriteOk() (*time.Time, bool)`

GetLastWriteOk returns a tuple with the LastWrite field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLastWrite

`func (o *StreamableFileContent) SetLastWrite(v time.Time)`

SetLastWrite sets LastWrite field to given value.

### HasLastWrite

`func (o *StreamableFileContent) HasLastWrite() bool`

HasLastWrite returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


