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

// checks if the SearchResult type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &SearchResult{}

// SearchResult struct for SearchResult
type SearchResult struct {
	Query NullableString `json:"query,omitempty"`
	NoResult *bool `json:"noResult,omitempty"`
	Results []Citation `json:"results,omitempty"`
}

// NewSearchResult instantiates a new SearchResult object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSearchResult() *SearchResult {
	this := SearchResult{}
	return &this
}

// NewSearchResultWithDefaults instantiates a new SearchResult object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSearchResultWithDefaults() *SearchResult {
	this := SearchResult{}
	return &this
}

// GetQuery returns the Query field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchResult) GetQuery() string {
	if o == nil || IsNil(o.Query.Get()) {
		var ret string
		return ret
	}
	return *o.Query.Get()
}

// GetQueryOk returns a tuple with the Query field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchResult) GetQueryOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.Query.Get(), o.Query.IsSet()
}

// HasQuery returns a boolean if a field has been set.
func (o *SearchResult) HasQuery() bool {
	if o != nil && o.Query.IsSet() {
		return true
	}

	return false
}

// SetQuery gets a reference to the given NullableString and assigns it to the Query field.
func (o *SearchResult) SetQuery(v string) {
	o.Query.Set(&v)
}
// SetQueryNil sets the value for Query to be an explicit nil
func (o *SearchResult) SetQueryNil() {
	o.Query.Set(nil)
}

// UnsetQuery ensures that no value is present for Query, not even an explicit nil
func (o *SearchResult) UnsetQuery() {
	o.Query.Unset()
}

// GetNoResult returns the NoResult field value if set, zero value otherwise.
func (o *SearchResult) GetNoResult() bool {
	if o == nil || IsNil(o.NoResult) {
		var ret bool
		return ret
	}
	return *o.NoResult
}

// GetNoResultOk returns a tuple with the NoResult field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchResult) GetNoResultOk() (*bool, bool) {
	if o == nil || IsNil(o.NoResult) {
		return nil, false
	}
	return o.NoResult, true
}

// HasNoResult returns a boolean if a field has been set.
func (o *SearchResult) HasNoResult() bool {
	if o != nil && !IsNil(o.NoResult) {
		return true
	}

	return false
}

// SetNoResult gets a reference to the given bool and assigns it to the NoResult field.
func (o *SearchResult) SetNoResult(v bool) {
	o.NoResult = &v
}

// GetResults returns the Results field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchResult) GetResults() []Citation {
	if o == nil {
		var ret []Citation
		return ret
	}
	return o.Results
}

// GetResultsOk returns a tuple with the Results field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *SearchResult) GetResultsOk() ([]Citation, bool) {
	if o == nil || IsNil(o.Results) {
		return nil, false
	}
	return o.Results, true
}

// HasResults returns a boolean if a field has been set.
func (o *SearchResult) HasResults() bool {
	if o != nil && !IsNil(o.Results) {
		return true
	}

	return false
}

// SetResults gets a reference to the given []Citation and assigns it to the Results field.
func (o *SearchResult) SetResults(v []Citation) {
	o.Results = v
}

func (o SearchResult) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o SearchResult) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if o.Query.IsSet() {
		toSerialize["query"] = o.Query.Get()
	}
	if !IsNil(o.NoResult) {
		toSerialize["noResult"] = o.NoResult
	}
	if o.Results != nil {
		toSerialize["results"] = o.Results
	}
	return toSerialize, nil
}

type NullableSearchResult struct {
	value *SearchResult
	isSet bool
}

func (v NullableSearchResult) Get() *SearchResult {
	return v.value
}

func (v *NullableSearchResult) Set(val *SearchResult) {
	v.value = val
	v.isSet = true
}

func (v NullableSearchResult) IsSet() bool {
	return v.isSet
}

func (v *NullableSearchResult) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSearchResult(val *SearchResult) *NullableSearchResult {
	return &NullableSearchResult{value: val, isSet: true}
}

func (v NullableSearchResult) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSearchResult) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

