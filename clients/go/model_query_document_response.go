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

// checks if the QueryDocumentResponse type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &QueryDocumentResponse{}

// QueryDocumentResponse struct for QueryDocumentResponse
type QueryDocumentResponse struct {
	// List of the relevant sources used to produce the answer.  Key = Document ID  Value = List of partitions used from the document.
	RelevantSources []DocumentCitation `json:"relevantSources,omitempty"`
}

// NewQueryDocumentResponse instantiates a new QueryDocumentResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewQueryDocumentResponse() *QueryDocumentResponse {
	this := QueryDocumentResponse{}
	return &this
}

// NewQueryDocumentResponseWithDefaults instantiates a new QueryDocumentResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewQueryDocumentResponseWithDefaults() *QueryDocumentResponse {
	this := QueryDocumentResponse{}
	return &this
}

// GetRelevantSources returns the RelevantSources field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *QueryDocumentResponse) GetRelevantSources() []DocumentCitation {
	if o == nil {
		var ret []DocumentCitation
		return ret
	}
	return o.RelevantSources
}

// GetRelevantSourcesOk returns a tuple with the RelevantSources field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *QueryDocumentResponse) GetRelevantSourcesOk() ([]DocumentCitation, bool) {
	if o == nil || IsNil(o.RelevantSources) {
		return nil, false
	}
	return o.RelevantSources, true
}

// HasRelevantSources returns a boolean if a field has been set.
func (o *QueryDocumentResponse) HasRelevantSources() bool {
	if o != nil && !IsNil(o.RelevantSources) {
		return true
	}

	return false
}

// SetRelevantSources gets a reference to the given []DocumentCitation and assigns it to the RelevantSources field.
func (o *QueryDocumentResponse) SetRelevantSources(v []DocumentCitation) {
	o.RelevantSources = v
}

func (o QueryDocumentResponse) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o QueryDocumentResponse) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if o.RelevantSources != nil {
		toSerialize["relevantSources"] = o.RelevantSources
	}
	return toSerialize, nil
}

type NullableQueryDocumentResponse struct {
	value *QueryDocumentResponse
	isSet bool
}

func (v NullableQueryDocumentResponse) Get() *QueryDocumentResponse {
	return v.value
}

func (v *NullableQueryDocumentResponse) Set(val *QueryDocumentResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableQueryDocumentResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableQueryDocumentResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableQueryDocumentResponse(val *QueryDocumentResponse) *NullableQueryDocumentResponse {
	return &NullableQueryDocumentResponse{value: val, isSet: true}
}

func (v NullableQueryDocumentResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableQueryDocumentResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


