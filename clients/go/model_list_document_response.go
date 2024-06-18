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
)

// checks if the ListDocumentResponse type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ListDocumentResponse{}

// ListDocumentResponse struct for ListDocumentResponse
type ListDocumentResponse struct {
	// Unique record ID
	Id NullableString `json:"id,omitempty"`
	// Embedding vector
	Vector map[string]interface{} `json:"vector,omitempty"`
	// Optional Searchable Key=Value tags (string => string[] collection)                Multiple values per keys are supported.  e.g. [ \"Collection=Work\", \"Project=1\", \"Project=2\", \"Project=3\", \"Type=Chat\", \"LLM=AzureAda2\" ]                Use cases:   * collections, e.g. [ \"Collection=Project1\", \"Collection=Work\" ]   * folders, e.g. [ \"Folder=Inbox\", \"Folder=Spam\" ]   * content types, e.g. [ \"Type=Chat\" ]   * versioning, e.g. [ \"LLM=AzureAda2\", \"Schema=1.0\" ]   * etc.
	Tags *map[string][]string `json:"tags,omitempty"`
	// Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc.
	Payload map[string]interface{} `json:"payload,omitempty"`
}

// NewListDocumentResponse instantiates a new ListDocumentResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewListDocumentResponse() *ListDocumentResponse {
	this := ListDocumentResponse{}
	return &this
}

// NewListDocumentResponseWithDefaults instantiates a new ListDocumentResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewListDocumentResponseWithDefaults() *ListDocumentResponse {
	this := ListDocumentResponse{}
	return &this
}

// GetId returns the Id field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *ListDocumentResponse) GetId() string {
	if o == nil || IsNil(o.Id.Get()) {
		var ret string
		return ret
	}
	return *o.Id.Get()
}

// GetIdOk returns a tuple with the Id field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *ListDocumentResponse) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.Id.Get(), o.Id.IsSet()
}

// HasId returns a boolean if a field has been set.
func (o *ListDocumentResponse) HasId() bool {
	if o != nil && o.Id.IsSet() {
		return true
	}

	return false
}

// SetId gets a reference to the given NullableString and assigns it to the Id field.
func (o *ListDocumentResponse) SetId(v string) {
	o.Id.Set(&v)
}
// SetIdNil sets the value for Id to be an explicit nil
func (o *ListDocumentResponse) SetIdNil() {
	o.Id.Set(nil)
}

// UnsetId ensures that no value is present for Id, not even an explicit nil
func (o *ListDocumentResponse) UnsetId() {
	o.Id.Unset()
}

// GetVector returns the Vector field value if set, zero value otherwise.
func (o *ListDocumentResponse) GetVector() map[string]interface{} {
	if o == nil || IsNil(o.Vector) {
		var ret map[string]interface{}
		return ret
	}
	return o.Vector
}

// GetVectorOk returns a tuple with the Vector field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ListDocumentResponse) GetVectorOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.Vector) {
		return map[string]interface{}{}, false
	}
	return o.Vector, true
}

// HasVector returns a boolean if a field has been set.
func (o *ListDocumentResponse) HasVector() bool {
	if o != nil && !IsNil(o.Vector) {
		return true
	}

	return false
}

// SetVector gets a reference to the given map[string]interface{} and assigns it to the Vector field.
func (o *ListDocumentResponse) SetVector(v map[string]interface{}) {
	o.Vector = v
}

// GetTags returns the Tags field value if set, zero value otherwise.
func (o *ListDocumentResponse) GetTags() map[string][]string {
	if o == nil || IsNil(o.Tags) {
		var ret map[string][]string
		return ret
	}
	return *o.Tags
}

// GetTagsOk returns a tuple with the Tags field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ListDocumentResponse) GetTagsOk() (*map[string][]string, bool) {
	if o == nil || IsNil(o.Tags) {
		return nil, false
	}
	return o.Tags, true
}

// HasTags returns a boolean if a field has been set.
func (o *ListDocumentResponse) HasTags() bool {
	if o != nil && !IsNil(o.Tags) {
		return true
	}

	return false
}

// SetTags gets a reference to the given map[string][]string and assigns it to the Tags field.
func (o *ListDocumentResponse) SetTags(v map[string][]string) {
	o.Tags = &v
}

// GetPayload returns the Payload field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *ListDocumentResponse) GetPayload() map[string]interface{} {
	if o == nil {
		var ret map[string]interface{}
		return ret
	}
	return o.Payload
}

// GetPayloadOk returns a tuple with the Payload field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *ListDocumentResponse) GetPayloadOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.Payload) {
		return map[string]interface{}{}, false
	}
	return o.Payload, true
}

// HasPayload returns a boolean if a field has been set.
func (o *ListDocumentResponse) HasPayload() bool {
	if o != nil && !IsNil(o.Payload) {
		return true
	}

	return false
}

// SetPayload gets a reference to the given map[string]interface{} and assigns it to the Payload field.
func (o *ListDocumentResponse) SetPayload(v map[string]interface{}) {
	o.Payload = v
}

func (o ListDocumentResponse) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ListDocumentResponse) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if o.Id.IsSet() {
		toSerialize["id"] = o.Id.Get()
	}
	if !IsNil(o.Vector) {
		toSerialize["vector"] = o.Vector
	}
	if !IsNil(o.Tags) {
		toSerialize["tags"] = o.Tags
	}
	if o.Payload != nil {
		toSerialize["payload"] = o.Payload
	}
	return toSerialize, nil
}

type NullableListDocumentResponse struct {
	value *ListDocumentResponse
	isSet bool
}

func (v NullableListDocumentResponse) Get() *ListDocumentResponse {
	return v.value
}

func (v *NullableListDocumentResponse) Set(val *ListDocumentResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableListDocumentResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableListDocumentResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableListDocumentResponse(val *ListDocumentResponse) *NullableListDocumentResponse {
	return &NullableListDocumentResponse{value: val, isSet: true}
}

func (v NullableListDocumentResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableListDocumentResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

