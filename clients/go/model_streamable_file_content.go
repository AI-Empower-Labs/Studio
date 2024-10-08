/*
Studio - AI Empower Labs

# Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.

API version: v1
Contact: support@aiempowerlabs.com
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package openapi

import (
	"encoding/json"
	"time"
)

// checks if the StreamableFileContent type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &StreamableFileContent{}

// StreamableFileContent struct for StreamableFileContent
type StreamableFileContent struct {
	FileName NullableString `json:"fileName,omitempty"`
	FileSize *int64 `json:"fileSize,omitempty"`
	FileType NullableString `json:"fileType,omitempty"`
	LastWrite *time.Time `json:"lastWrite,omitempty"`
}

// NewStreamableFileContent instantiates a new StreamableFileContent object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewStreamableFileContent() *StreamableFileContent {
	this := StreamableFileContent{}
	return &this
}

// NewStreamableFileContentWithDefaults instantiates a new StreamableFileContent object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewStreamableFileContentWithDefaults() *StreamableFileContent {
	this := StreamableFileContent{}
	return &this
}

// GetFileName returns the FileName field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *StreamableFileContent) GetFileName() string {
	if o == nil || IsNil(o.FileName.Get()) {
		var ret string
		return ret
	}
	return *o.FileName.Get()
}

// GetFileNameOk returns a tuple with the FileName field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *StreamableFileContent) GetFileNameOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.FileName.Get(), o.FileName.IsSet()
}

// HasFileName returns a boolean if a field has been set.
func (o *StreamableFileContent) HasFileName() bool {
	if o != nil && o.FileName.IsSet() {
		return true
	}

	return false
}

// SetFileName gets a reference to the given NullableString and assigns it to the FileName field.
func (o *StreamableFileContent) SetFileName(v string) {
	o.FileName.Set(&v)
}
// SetFileNameNil sets the value for FileName to be an explicit nil
func (o *StreamableFileContent) SetFileNameNil() {
	o.FileName.Set(nil)
}

// UnsetFileName ensures that no value is present for FileName, not even an explicit nil
func (o *StreamableFileContent) UnsetFileName() {
	o.FileName.Unset()
}

// GetFileSize returns the FileSize field value if set, zero value otherwise.
func (o *StreamableFileContent) GetFileSize() int64 {
	if o == nil || IsNil(o.FileSize) {
		var ret int64
		return ret
	}
	return *o.FileSize
}

// GetFileSizeOk returns a tuple with the FileSize field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *StreamableFileContent) GetFileSizeOk() (*int64, bool) {
	if o == nil || IsNil(o.FileSize) {
		return nil, false
	}
	return o.FileSize, true
}

// HasFileSize returns a boolean if a field has been set.
func (o *StreamableFileContent) HasFileSize() bool {
	if o != nil && !IsNil(o.FileSize) {
		return true
	}

	return false
}

// SetFileSize gets a reference to the given int64 and assigns it to the FileSize field.
func (o *StreamableFileContent) SetFileSize(v int64) {
	o.FileSize = &v
}

// GetFileType returns the FileType field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *StreamableFileContent) GetFileType() string {
	if o == nil || IsNil(o.FileType.Get()) {
		var ret string
		return ret
	}
	return *o.FileType.Get()
}

// GetFileTypeOk returns a tuple with the FileType field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *StreamableFileContent) GetFileTypeOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.FileType.Get(), o.FileType.IsSet()
}

// HasFileType returns a boolean if a field has been set.
func (o *StreamableFileContent) HasFileType() bool {
	if o != nil && o.FileType.IsSet() {
		return true
	}

	return false
}

// SetFileType gets a reference to the given NullableString and assigns it to the FileType field.
func (o *StreamableFileContent) SetFileType(v string) {
	o.FileType.Set(&v)
}
// SetFileTypeNil sets the value for FileType to be an explicit nil
func (o *StreamableFileContent) SetFileTypeNil() {
	o.FileType.Set(nil)
}

// UnsetFileType ensures that no value is present for FileType, not even an explicit nil
func (o *StreamableFileContent) UnsetFileType() {
	o.FileType.Unset()
}

// GetLastWrite returns the LastWrite field value if set, zero value otherwise.
func (o *StreamableFileContent) GetLastWrite() time.Time {
	if o == nil || IsNil(o.LastWrite) {
		var ret time.Time
		return ret
	}
	return *o.LastWrite
}

// GetLastWriteOk returns a tuple with the LastWrite field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *StreamableFileContent) GetLastWriteOk() (*time.Time, bool) {
	if o == nil || IsNil(o.LastWrite) {
		return nil, false
	}
	return o.LastWrite, true
}

// HasLastWrite returns a boolean if a field has been set.
func (o *StreamableFileContent) HasLastWrite() bool {
	if o != nil && !IsNil(o.LastWrite) {
		return true
	}

	return false
}

// SetLastWrite gets a reference to the given time.Time and assigns it to the LastWrite field.
func (o *StreamableFileContent) SetLastWrite(v time.Time) {
	o.LastWrite = &v
}

func (o StreamableFileContent) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o StreamableFileContent) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if o.FileName.IsSet() {
		toSerialize["fileName"] = o.FileName.Get()
	}
	if !IsNil(o.FileSize) {
		toSerialize["fileSize"] = o.FileSize
	}
	if o.FileType.IsSet() {
		toSerialize["fileType"] = o.FileType.Get()
	}
	if !IsNil(o.LastWrite) {
		toSerialize["lastWrite"] = o.LastWrite
	}
	return toSerialize, nil
}

type NullableStreamableFileContent struct {
	value *StreamableFileContent
	isSet bool
}

func (v NullableStreamableFileContent) Get() *StreamableFileContent {
	return v.value
}

func (v *NullableStreamableFileContent) Set(val *StreamableFileContent) {
	v.value = val
	v.isSet = true
}

func (v NullableStreamableFileContent) IsSet() bool {
	return v.isSet
}

func (v *NullableStreamableFileContent) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableStreamableFileContent(val *StreamableFileContent) *NullableStreamableFileContent {
	return &NullableStreamableFileContent{value: val, isSet: true}
}

func (v NullableStreamableFileContent) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableStreamableFileContent) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


