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

// checks if the SemanticSimilarityRequest type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &SemanticSimilarityRequest{}

// SemanticSimilarityRequest struct for SemanticSimilarityRequest
type SemanticSimilarityRequest struct {
	// Query text to compare with
	Query *string `json:"query,omitempty"`
	Documents []string `json:"documents,omitempty"`
	Model NullableString `json:"model,omitempty"`
}

// NewSemanticSimilarityRequest instantiates a new SemanticSimilarityRequest object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSemanticSimilarityRequest() *SemanticSimilarityRequest {
	this := SemanticSimilarityRequest{}
	return &this
}

// NewSemanticSimilarityRequestWithDefaults instantiates a new SemanticSimilarityRequest object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSemanticSimilarityRequestWithDefaults() *SemanticSimilarityRequest {
	this := SemanticSimilarityRequest{}
	return &this
}

// GetQuery returns the Query field value if set, zero value otherwise.
func (o *SemanticSimilarityRequest) GetQuery() string {
	if o == nil || IsNil(o.Query) {
		var ret string
		return ret
	}
	return *o.Query
}

// GetQueryOk returns a tuple with the Query field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSimilarityRequest) GetQueryOk() (*string, bool) {
	if o == nil || IsNil(o.Query) {
		return nil, false
	}
	return o.Query, true
}

// HasQuery returns a boolean if a field has been set.
func (o *SemanticSimilarityRequest) HasQuery() bool {
	if o != nil && !IsNil(o.Query) {
		return true
	}

	return false
}

// SetQuery gets a reference to the given string and assigns it to the Query field.
func (o *SemanticSimilarityRequest) SetQuery(v string) {
	o.Query = &v
}

// GetDocuments returns the Documents field value if set, zero value otherwise.
func (o *SemanticSimilarityRequest) GetDocuments() []string {
	if o == nil || IsNil(o.Documents) {
		var ret []string
		return ret
	}
	return o.Documents
}

// GetDocumentsOk returns a tuple with the Documents field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSimilarityRequest) GetDocumentsOk() ([]string, bool) {
	if o == nil || IsNil(o.Documents) {
		return nil, false
	}
	return o.Documents, true
}

// HasDocuments returns a boolean if a field has been set.
func (o *SemanticSimilarityRequest) HasDocuments() bool {
	if o != nil && !IsNil(o.Documents) {
		return true
	}

	return false
}

// SetDocuments gets a reference to the given []string and assigns it to the Documents field.
func (o *SemanticSimilarityRequest) SetDocuments(v []string) {
	o.Documents = v
}

// GetModel returns the Model field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SemanticSimilarityRequest) GetModel() string {
	if o == nil || IsNil(o.Model.Get()) {
		var ret string
		return ret
	}
	return *o.Model.Get()
}

// GetModelOk returns a tuple with the Model field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SemanticSimilarityRequest) GetModelOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.Model.Get(), o.Model.IsSet()
}

// HasModel returns a boolean if a field has been set.
func (o *SemanticSimilarityRequest) HasModel() bool {
	if o != nil && o.Model.IsSet() {
		return true
	}

	return false
}

// SetModel gets a reference to the given NullableString and assigns it to the Model field.
func (o *SemanticSimilarityRequest) SetModel(v string) {
	o.Model.Set(&v)
}
// SetModelNil sets the value for Model to be an explicit nil
func (o *SemanticSimilarityRequest) SetModelNil() {
	o.Model.Set(nil)
}

// UnsetModel ensures that no value is present for Model, not even an explicit nil
func (o *SemanticSimilarityRequest) UnsetModel() {
	o.Model.Unset()
}

func (o SemanticSimilarityRequest) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o SemanticSimilarityRequest) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Query) {
		toSerialize["query"] = o.Query
	}
	if !IsNil(o.Documents) {
		toSerialize["documents"] = o.Documents
	}
	if o.Model.IsSet() {
		toSerialize["model"] = o.Model.Get()
	}
	return toSerialize, nil
}

type NullableSemanticSimilarityRequest struct {
	value *SemanticSimilarityRequest
	isSet bool
}

func (v NullableSemanticSimilarityRequest) Get() *SemanticSimilarityRequest {
	return v.value
}

func (v *NullableSemanticSimilarityRequest) Set(val *SemanticSimilarityRequest) {
	v.value = val
	v.isSet = true
}

func (v NullableSemanticSimilarityRequest) IsSet() bool {
	return v.isSet
}

func (v *NullableSemanticSimilarityRequest) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSemanticSimilarityRequest(val *SemanticSimilarityRequest) *NullableSemanticSimilarityRequest {
	return &NullableSemanticSimilarityRequest{value: val, isSet: true}
}

func (v NullableSemanticSimilarityRequest) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSemanticSimilarityRequest) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


