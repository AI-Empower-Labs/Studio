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

// checks if the SemanticSearchQueryResultsClusteringRequest type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &SemanticSearchQueryResultsClusteringRequest{}

// SemanticSearchQueryResultsClusteringRequest struct for SemanticSearchQueryResultsClusteringRequest
type SemanticSearchQueryResultsClusteringRequest struct {
	// The number of clusters to be used in k-means clustering.
	ClusterCount *int32 `json:"clusterCount,omitempty"`
	// The Maximum Degrees Of Parallelism
	MaxDegreeOfParallelism *int32 `json:"maxDegreeOfParallelism,omitempty"`
	// Optional index to specify which index to search in. Defaults to 'default'.
	Index *string `json:"index,omitempty"`
	// The minimum relevance value used for querying the search result audit.
	MinRelevance *float32 `json:"minRelevance,omitempty"`
	// The maximum relevance value to be used in the search query.
	MaxRelevance *float32 `json:"maxRelevance,omitempty"`
	// Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm.
	LlmModel *string `json:"llmModel,omitempty"`
	// The name of the embedding model used for clustering.
	EmbeddingModel *string `json:"embeddingModel,omitempty"`
}

// NewSemanticSearchQueryResultsClusteringRequest instantiates a new SemanticSearchQueryResultsClusteringRequest object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSemanticSearchQueryResultsClusteringRequest() *SemanticSearchQueryResultsClusteringRequest {
	this := SemanticSearchQueryResultsClusteringRequest{}
	var clusterCount int32 = 3
	this.ClusterCount = &clusterCount
	var maxDegreeOfParallelism int32 = 1
	this.MaxDegreeOfParallelism = &maxDegreeOfParallelism
	return &this
}

// NewSemanticSearchQueryResultsClusteringRequestWithDefaults instantiates a new SemanticSearchQueryResultsClusteringRequest object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSemanticSearchQueryResultsClusteringRequestWithDefaults() *SemanticSearchQueryResultsClusteringRequest {
	this := SemanticSearchQueryResultsClusteringRequest{}
	var clusterCount int32 = 3
	this.ClusterCount = &clusterCount
	var maxDegreeOfParallelism int32 = 1
	this.MaxDegreeOfParallelism = &maxDegreeOfParallelism
	return &this
}

// GetClusterCount returns the ClusterCount field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetClusterCount() int32 {
	if o == nil || IsNil(o.ClusterCount) {
		var ret int32
		return ret
	}
	return *o.ClusterCount
}

// GetClusterCountOk returns a tuple with the ClusterCount field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetClusterCountOk() (*int32, bool) {
	if o == nil || IsNil(o.ClusterCount) {
		return nil, false
	}
	return o.ClusterCount, true
}

// HasClusterCount returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasClusterCount() bool {
	if o != nil && !IsNil(o.ClusterCount) {
		return true
	}

	return false
}

// SetClusterCount gets a reference to the given int32 and assigns it to the ClusterCount field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetClusterCount(v int32) {
	o.ClusterCount = &v
}

// GetMaxDegreeOfParallelism returns the MaxDegreeOfParallelism field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxDegreeOfParallelism() int32 {
	if o == nil || IsNil(o.MaxDegreeOfParallelism) {
		var ret int32
		return ret
	}
	return *o.MaxDegreeOfParallelism
}

// GetMaxDegreeOfParallelismOk returns a tuple with the MaxDegreeOfParallelism field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxDegreeOfParallelismOk() (*int32, bool) {
	if o == nil || IsNil(o.MaxDegreeOfParallelism) {
		return nil, false
	}
	return o.MaxDegreeOfParallelism, true
}

// HasMaxDegreeOfParallelism returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasMaxDegreeOfParallelism() bool {
	if o != nil && !IsNil(o.MaxDegreeOfParallelism) {
		return true
	}

	return false
}

// SetMaxDegreeOfParallelism gets a reference to the given int32 and assigns it to the MaxDegreeOfParallelism field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetMaxDegreeOfParallelism(v int32) {
	o.MaxDegreeOfParallelism = &v
}

// GetIndex returns the Index field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetIndex() string {
	if o == nil || IsNil(o.Index) {
		var ret string
		return ret
	}
	return *o.Index
}

// GetIndexOk returns a tuple with the Index field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetIndexOk() (*string, bool) {
	if o == nil || IsNil(o.Index) {
		return nil, false
	}
	return o.Index, true
}

// HasIndex returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasIndex() bool {
	if o != nil && !IsNil(o.Index) {
		return true
	}

	return false
}

// SetIndex gets a reference to the given string and assigns it to the Index field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetIndex(v string) {
	o.Index = &v
}

// GetMinRelevance returns the MinRelevance field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetMinRelevance() float32 {
	if o == nil || IsNil(o.MinRelevance) {
		var ret float32
		return ret
	}
	return *o.MinRelevance
}

// GetMinRelevanceOk returns a tuple with the MinRelevance field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetMinRelevanceOk() (*float32, bool) {
	if o == nil || IsNil(o.MinRelevance) {
		return nil, false
	}
	return o.MinRelevance, true
}

// HasMinRelevance returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasMinRelevance() bool {
	if o != nil && !IsNil(o.MinRelevance) {
		return true
	}

	return false
}

// SetMinRelevance gets a reference to the given float32 and assigns it to the MinRelevance field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetMinRelevance(v float32) {
	o.MinRelevance = &v
}

// GetMaxRelevance returns the MaxRelevance field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxRelevance() float32 {
	if o == nil || IsNil(o.MaxRelevance) {
		var ret float32
		return ret
	}
	return *o.MaxRelevance
}

// GetMaxRelevanceOk returns a tuple with the MaxRelevance field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxRelevanceOk() (*float32, bool) {
	if o == nil || IsNil(o.MaxRelevance) {
		return nil, false
	}
	return o.MaxRelevance, true
}

// HasMaxRelevance returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasMaxRelevance() bool {
	if o != nil && !IsNil(o.MaxRelevance) {
		return true
	}

	return false
}

// SetMaxRelevance gets a reference to the given float32 and assigns it to the MaxRelevance field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetMaxRelevance(v float32) {
	o.MaxRelevance = &v
}

// GetLlmModel returns the LlmModel field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetLlmModel() string {
	if o == nil || IsNil(o.LlmModel) {
		var ret string
		return ret
	}
	return *o.LlmModel
}

// GetLlmModelOk returns a tuple with the LlmModel field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetLlmModelOk() (*string, bool) {
	if o == nil || IsNil(o.LlmModel) {
		return nil, false
	}
	return o.LlmModel, true
}

// HasLlmModel returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasLlmModel() bool {
	if o != nil && !IsNil(o.LlmModel) {
		return true
	}

	return false
}

// SetLlmModel gets a reference to the given string and assigns it to the LlmModel field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetLlmModel(v string) {
	o.LlmModel = &v
}

// GetEmbeddingModel returns the EmbeddingModel field value if set, zero value otherwise.
func (o *SemanticSearchQueryResultsClusteringRequest) GetEmbeddingModel() string {
	if o == nil || IsNil(o.EmbeddingModel) {
		var ret string
		return ret
	}
	return *o.EmbeddingModel
}

// GetEmbeddingModelOk returns a tuple with the EmbeddingModel field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) GetEmbeddingModelOk() (*string, bool) {
	if o == nil || IsNil(o.EmbeddingModel) {
		return nil, false
	}
	return o.EmbeddingModel, true
}

// HasEmbeddingModel returns a boolean if a field has been set.
func (o *SemanticSearchQueryResultsClusteringRequest) HasEmbeddingModel() bool {
	if o != nil && !IsNil(o.EmbeddingModel) {
		return true
	}

	return false
}

// SetEmbeddingModel gets a reference to the given string and assigns it to the EmbeddingModel field.
func (o *SemanticSearchQueryResultsClusteringRequest) SetEmbeddingModel(v string) {
	o.EmbeddingModel = &v
}

func (o SemanticSearchQueryResultsClusteringRequest) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o SemanticSearchQueryResultsClusteringRequest) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.ClusterCount) {
		toSerialize["clusterCount"] = o.ClusterCount
	}
	if !IsNil(o.MaxDegreeOfParallelism) {
		toSerialize["maxDegreeOfParallelism"] = o.MaxDegreeOfParallelism
	}
	if !IsNil(o.Index) {
		toSerialize["index"] = o.Index
	}
	if !IsNil(o.MinRelevance) {
		toSerialize["minRelevance"] = o.MinRelevance
	}
	if !IsNil(o.MaxRelevance) {
		toSerialize["maxRelevance"] = o.MaxRelevance
	}
	if !IsNil(o.LlmModel) {
		toSerialize["llmModel"] = o.LlmModel
	}
	if !IsNil(o.EmbeddingModel) {
		toSerialize["embeddingModel"] = o.EmbeddingModel
	}
	return toSerialize, nil
}

type NullableSemanticSearchQueryResultsClusteringRequest struct {
	value *SemanticSearchQueryResultsClusteringRequest
	isSet bool
}

func (v NullableSemanticSearchQueryResultsClusteringRequest) Get() *SemanticSearchQueryResultsClusteringRequest {
	return v.value
}

func (v *NullableSemanticSearchQueryResultsClusteringRequest) Set(val *SemanticSearchQueryResultsClusteringRequest) {
	v.value = val
	v.isSet = true
}

func (v NullableSemanticSearchQueryResultsClusteringRequest) IsSet() bool {
	return v.isSet
}

func (v *NullableSemanticSearchQueryResultsClusteringRequest) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSemanticSearchQueryResultsClusteringRequest(val *SemanticSearchQueryResultsClusteringRequest) *NullableSemanticSearchQueryResultsClusteringRequest {
	return &NullableSemanticSearchQueryResultsClusteringRequest{value: val, isSet: true}
}

func (v NullableSemanticSearchQueryResultsClusteringRequest) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSemanticSearchQueryResultsClusteringRequest) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


