# ApiExtractThematicSimilarityClusterPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Input** | **[]string** | The input texts for generating clusters | 
**ClusterCount** | **int32** | The number of clusters requested for generating clusters | 
**MaxDegreeOfParallelism** | Pointer to **int32** | The maximum degree of parallelism for the KMeans clustering algorithm | [optional] [default to 1]
**LlmModel** | Pointer to **NullableString** | The name of the LLM model. Optional. | [optional] 
**EmbeddingModel** | Pointer to **NullableString** | The name of the embedding model used in the GenerateClusterHttpRequest. Optional. | [optional] 
**Seed** | Pointer to **NullableInt32** | Randomization seed. Optional. | [optional] 

## Methods

### NewApiExtractThematicSimilarityClusterPostRequest

`func NewApiExtractThematicSimilarityClusterPostRequest(input []string, clusterCount int32, ) *ApiExtractThematicSimilarityClusterPostRequest`

NewApiExtractThematicSimilarityClusterPostRequest instantiates a new ApiExtractThematicSimilarityClusterPostRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewApiExtractThematicSimilarityClusterPostRequestWithDefaults

`func NewApiExtractThematicSimilarityClusterPostRequestWithDefaults() *ApiExtractThematicSimilarityClusterPostRequest`

NewApiExtractThematicSimilarityClusterPostRequestWithDefaults instantiates a new ApiExtractThematicSimilarityClusterPostRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetInput

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetInput() []string`

GetInput returns the Input field if non-nil, zero value otherwise.

### GetInputOk

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetInputOk() (*[]string, bool)`

GetInputOk returns a tuple with the Input field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetInput

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetInput(v []string)`

SetInput sets Input field to given value.


### GetClusterCount

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetClusterCount() int32`

GetClusterCount returns the ClusterCount field if non-nil, zero value otherwise.

### GetClusterCountOk

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetClusterCountOk() (*int32, bool)`

GetClusterCountOk returns a tuple with the ClusterCount field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetClusterCount

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetClusterCount(v int32)`

SetClusterCount sets ClusterCount field to given value.


### GetMaxDegreeOfParallelism

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetMaxDegreeOfParallelism() int32`

GetMaxDegreeOfParallelism returns the MaxDegreeOfParallelism field if non-nil, zero value otherwise.

### GetMaxDegreeOfParallelismOk

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetMaxDegreeOfParallelismOk() (*int32, bool)`

GetMaxDegreeOfParallelismOk returns a tuple with the MaxDegreeOfParallelism field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMaxDegreeOfParallelism

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetMaxDegreeOfParallelism(v int32)`

SetMaxDegreeOfParallelism sets MaxDegreeOfParallelism field to given value.

### HasMaxDegreeOfParallelism

`func (o *ApiExtractThematicSimilarityClusterPostRequest) HasMaxDegreeOfParallelism() bool`

HasMaxDegreeOfParallelism returns a boolean if a field has been set.

### GetLlmModel

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetLlmModel() string`

GetLlmModel returns the LlmModel field if non-nil, zero value otherwise.

### GetLlmModelOk

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetLlmModelOk() (*string, bool)`

GetLlmModelOk returns a tuple with the LlmModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLlmModel

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetLlmModel(v string)`

SetLlmModel sets LlmModel field to given value.

### HasLlmModel

`func (o *ApiExtractThematicSimilarityClusterPostRequest) HasLlmModel() bool`

HasLlmModel returns a boolean if a field has been set.

### SetLlmModelNil

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetLlmModelNil(b bool)`

 SetLlmModelNil sets the value for LlmModel to be an explicit nil

### UnsetLlmModel
`func (o *ApiExtractThematicSimilarityClusterPostRequest) UnsetLlmModel()`

UnsetLlmModel ensures that no value is present for LlmModel, not even an explicit nil
### GetEmbeddingModel

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *ApiExtractThematicSimilarityClusterPostRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.

### SetEmbeddingModelNil

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetEmbeddingModelNil(b bool)`

 SetEmbeddingModelNil sets the value for EmbeddingModel to be an explicit nil

### UnsetEmbeddingModel
`func (o *ApiExtractThematicSimilarityClusterPostRequest) UnsetEmbeddingModel()`

UnsetEmbeddingModel ensures that no value is present for EmbeddingModel, not even an explicit nil
### GetSeed

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetSeed() int32`

GetSeed returns the Seed field if non-nil, zero value otherwise.

### GetSeedOk

`func (o *ApiExtractThematicSimilarityClusterPostRequest) GetSeedOk() (*int32, bool)`

GetSeedOk returns a tuple with the Seed field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSeed

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetSeed(v int32)`

SetSeed sets Seed field to given value.

### HasSeed

`func (o *ApiExtractThematicSimilarityClusterPostRequest) HasSeed() bool`

HasSeed returns a boolean if a field has been set.

### SetSeedNil

`func (o *ApiExtractThematicSimilarityClusterPostRequest) SetSeedNil(b bool)`

 SetSeedNil sets the value for Seed to be an explicit nil

### UnsetSeed
`func (o *ApiExtractThematicSimilarityClusterPostRequest) UnsetSeed()`

UnsetSeed ensures that no value is present for Seed, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


