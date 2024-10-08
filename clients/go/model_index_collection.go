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

// checks if the IndexCollection type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &IndexCollection{}

// IndexCollection struct for IndexCollection
type IndexCollection struct {
	Results []IndexDetails `json:"results,omitempty"`
}

// NewIndexCollection instantiates a new IndexCollection object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewIndexCollection() *IndexCollection {
	this := IndexCollection{}
	return &this
}

// NewIndexCollectionWithDefaults instantiates a new IndexCollection object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewIndexCollectionWithDefaults() *IndexCollection {
	this := IndexCollection{}
	return &this
}

// GetResults returns the Results field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *IndexCollection) GetResults() []IndexDetails {
	if o == nil {
		var ret []IndexDetails
		return ret
	}
	return o.Results
}

// GetResultsOk returns a tuple with the Results field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *IndexCollection) GetResultsOk() ([]IndexDetails, bool) {
	if o == nil || IsNil(o.Results) {
		return nil, false
	}
	return o.Results, true
}

// HasResults returns a boolean if a field has been set.
func (o *IndexCollection) HasResults() bool {
	if o != nil && !IsNil(o.Results) {
		return true
	}

	return false
}

// SetResults gets a reference to the given []IndexDetails and assigns it to the Results field.
func (o *IndexCollection) SetResults(v []IndexDetails) {
	o.Results = v
}

func (o IndexCollection) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o IndexCollection) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if o.Results != nil {
		toSerialize["results"] = o.Results
	}
	return toSerialize, nil
}

type NullableIndexCollection struct {
	value *IndexCollection
	isSet bool
}

func (v NullableIndexCollection) Get() *IndexCollection {
	return v.value
}

func (v *NullableIndexCollection) Set(val *IndexCollection) {
	v.value = val
	v.isSet = true
}

func (v NullableIndexCollection) IsSet() bool {
	return v.isSet
}

func (v *NullableIndexCollection) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableIndexCollection(val *IndexCollection) *NullableIndexCollection {
	return &NullableIndexCollection{value: val, isSet: true}
}

func (v NullableIndexCollection) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableIndexCollection) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


