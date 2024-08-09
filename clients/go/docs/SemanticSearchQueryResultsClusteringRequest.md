# SemanticSearchQueryResultsClusteringRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterCount** | Pointer to **int32** | The number of clusters to be used in k-means clustering. | [optional] [default to 3]
**MaxDegreeOfParallelism** | Pointer to **int32** | The Maximum Degrees Of Parallelism | [optional] [default to 1]
**MaxTokens** | Pointer to **int32** | The maximum number of tokens to be used in the KMeans clustering algorithm. | [optional] [default to 10]
**Index** | Pointer to **string** | Optional index to specify which index to search in. Defaults to &#39;default&#39;. | [optional] 
**MinRelevance** | Pointer to **float32** | The minimum relevance value used for querying the search result audit. | [optional] 
**MaxRelevance** | Pointer to **float32** | The maximum relevance value to be used in the search query. | [optional] 
**LlmModel** | Pointer to **string** | Specifies the name of the LLM (Language Model) to be used in the KMeans clustering algorithm. | [optional] 
**EmbeddingModel** | Pointer to **string** | The name of the embedding model used for clustering. | [optional] 

## Methods

### NewSemanticSearchQueryResultsClusteringRequest

`func NewSemanticSearchQueryResultsClusteringRequest() *SemanticSearchQueryResultsClusteringRequest`

NewSemanticSearchQueryResultsClusteringRequest instantiates a new SemanticSearchQueryResultsClusteringRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSemanticSearchQueryResultsClusteringRequestWithDefaults

`func NewSemanticSearchQueryResultsClusteringRequestWithDefaults() *SemanticSearchQueryResultsClusteringRequest`

NewSemanticSearchQueryResultsClusteringRequestWithDefaults instantiates a new SemanticSearchQueryResultsClusteringRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetClusterCount

`func (o *SemanticSearchQueryResultsClusteringRequest) GetClusterCount() int32`

GetClusterCount returns the ClusterCount field if non-nil, zero value otherwise.

### GetClusterCountOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetClusterCountOk() (*int32, bool)`

GetClusterCountOk returns a tuple with the ClusterCount field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetClusterCount

`func (o *SemanticSearchQueryResultsClusteringRequest) SetClusterCount(v int32)`

SetClusterCount sets ClusterCount field to given value.

### HasClusterCount

`func (o *SemanticSearchQueryResultsClusteringRequest) HasClusterCount() bool`

HasClusterCount returns a boolean if a field has been set.

### GetMaxDegreeOfParallelism

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxDegreeOfParallelism() int32`

GetMaxDegreeOfParallelism returns the MaxDegreeOfParallelism field if non-nil, zero value otherwise.

### GetMaxDegreeOfParallelismOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxDegreeOfParallelismOk() (*int32, bool)`

GetMaxDegreeOfParallelismOk returns a tuple with the MaxDegreeOfParallelism field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMaxDegreeOfParallelism

`func (o *SemanticSearchQueryResultsClusteringRequest) SetMaxDegreeOfParallelism(v int32)`

SetMaxDegreeOfParallelism sets MaxDegreeOfParallelism field to given value.

### HasMaxDegreeOfParallelism

`func (o *SemanticSearchQueryResultsClusteringRequest) HasMaxDegreeOfParallelism() bool`

HasMaxDegreeOfParallelism returns a boolean if a field has been set.

### GetMaxTokens

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxTokens() int32`

GetMaxTokens returns the MaxTokens field if non-nil, zero value otherwise.

### GetMaxTokensOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxTokensOk() (*int32, bool)`

GetMaxTokensOk returns a tuple with the MaxTokens field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMaxTokens

`func (o *SemanticSearchQueryResultsClusteringRequest) SetMaxTokens(v int32)`

SetMaxTokens sets MaxTokens field to given value.

### HasMaxTokens

`func (o *SemanticSearchQueryResultsClusteringRequest) HasMaxTokens() bool`

HasMaxTokens returns a boolean if a field has been set.

### GetIndex

`func (o *SemanticSearchQueryResultsClusteringRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *SemanticSearchQueryResultsClusteringRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *SemanticSearchQueryResultsClusteringRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### GetMinRelevance

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMinRelevance() float32`

GetMinRelevance returns the MinRelevance field if non-nil, zero value otherwise.

### GetMinRelevanceOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMinRelevanceOk() (*float32, bool)`

GetMinRelevanceOk returns a tuple with the MinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinRelevance

`func (o *SemanticSearchQueryResultsClusteringRequest) SetMinRelevance(v float32)`

SetMinRelevance sets MinRelevance field to given value.

### HasMinRelevance

`func (o *SemanticSearchQueryResultsClusteringRequest) HasMinRelevance() bool`

HasMinRelevance returns a boolean if a field has been set.

### GetMaxRelevance

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxRelevance() float32`

GetMaxRelevance returns the MaxRelevance field if non-nil, zero value otherwise.

### GetMaxRelevanceOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetMaxRelevanceOk() (*float32, bool)`

GetMaxRelevanceOk returns a tuple with the MaxRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMaxRelevance

`func (o *SemanticSearchQueryResultsClusteringRequest) SetMaxRelevance(v float32)`

SetMaxRelevance sets MaxRelevance field to given value.

### HasMaxRelevance

`func (o *SemanticSearchQueryResultsClusteringRequest) HasMaxRelevance() bool`

HasMaxRelevance returns a boolean if a field has been set.

### GetLlmModel

`func (o *SemanticSearchQueryResultsClusteringRequest) GetLlmModel() string`

GetLlmModel returns the LlmModel field if non-nil, zero value otherwise.

### GetLlmModelOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetLlmModelOk() (*string, bool)`

GetLlmModelOk returns a tuple with the LlmModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLlmModel

`func (o *SemanticSearchQueryResultsClusteringRequest) SetLlmModel(v string)`

SetLlmModel sets LlmModel field to given value.

### HasLlmModel

`func (o *SemanticSearchQueryResultsClusteringRequest) HasLlmModel() bool`

HasLlmModel returns a boolean if a field has been set.

### GetEmbeddingModel

`func (o *SemanticSearchQueryResultsClusteringRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *SemanticSearchQueryResultsClusteringRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *SemanticSearchQueryResultsClusteringRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *SemanticSearchQueryResultsClusteringRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


