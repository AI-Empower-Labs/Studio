# QueryDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | Pointer to **NullableString** | Semantic query to find matching documents | [optional] 
**Index** | Pointer to **NullableString** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | Pointer to [**[]DocumentFilters**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**SearchMode** | Pointer to **NullableString** | Optional search mode defining the context or process used in the query. Supported values are &#39;hybrid&#39;, &#39;semantic&#39; | [optional] 
**Language** | Pointer to **NullableString** | Specifies the language of the content. | [optional] 
**LanguageDetection** | Pointer to **NullableBool** | Indicates whether language detection is enabled. | [optional] 
**FtsMinScore** | Pointer to **NullableFloat32** | Minimum score for full-text search. | [optional] 
**FtsWeight** | Pointer to **NullableFloat32** | Weight for full-text search. | [optional] 
**SemanticMinRelevance** | Pointer to **NullableFloat64** | Minimum relevance score for semantic search. | [optional] 
**SemanticWeight** | Pointer to **NullableFloat32** | Weight applied for semantic search. | [optional] 
**SmoothingFactorK** | Pointer to **NullableFloat32** | Smoothing factor (k) used in calculations. | [optional] 
**MinRelevance** | Pointer to **NullableFloat64** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**Limit** | Pointer to **NullableInt32** | Optional filter for specifying maximum number of entries to return. Defaults to 3 | [optional] 
**EmbeddingModel** | Pointer to **NullableString** | Embedding model to use in query | [optional] 
**Args** | Pointer to **map[string]interface{}** |  | [optional] 

## Methods

### NewQueryDocumentRequest

`func NewQueryDocumentRequest() *QueryDocumentRequest`

NewQueryDocumentRequest instantiates a new QueryDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewQueryDocumentRequestWithDefaults

`func NewQueryDocumentRequestWithDefaults() *QueryDocumentRequest`

NewQueryDocumentRequestWithDefaults instantiates a new QueryDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQuery

`func (o *QueryDocumentRequest) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *QueryDocumentRequest) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *QueryDocumentRequest) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *QueryDocumentRequest) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### SetQueryNil

`func (o *QueryDocumentRequest) SetQueryNil(b bool)`

 SetQueryNil sets the value for Query to be an explicit nil

### UnsetQuery
`func (o *QueryDocumentRequest) UnsetQuery()`

UnsetQuery ensures that no value is present for Query, not even an explicit nil
### GetIndex

`func (o *QueryDocumentRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *QueryDocumentRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *QueryDocumentRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *QueryDocumentRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *QueryDocumentRequest) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *QueryDocumentRequest) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetFilter

`func (o *QueryDocumentRequest) GetFilter() []DocumentFilters`

GetFilter returns the Filter field if non-nil, zero value otherwise.

### GetFilterOk

`func (o *QueryDocumentRequest) GetFilterOk() (*[]DocumentFilters, bool)`

GetFilterOk returns a tuple with the Filter field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilter

`func (o *QueryDocumentRequest) SetFilter(v []DocumentFilters)`

SetFilter sets Filter field to given value.

### HasFilter

`func (o *QueryDocumentRequest) HasFilter() bool`

HasFilter returns a boolean if a field has been set.

### SetFilterNil

`func (o *QueryDocumentRequest) SetFilterNil(b bool)`

 SetFilterNil sets the value for Filter to be an explicit nil

### UnsetFilter
`func (o *QueryDocumentRequest) UnsetFilter()`

UnsetFilter ensures that no value is present for Filter, not even an explicit nil
### GetSearchMode

`func (o *QueryDocumentRequest) GetSearchMode() string`

GetSearchMode returns the SearchMode field if non-nil, zero value otherwise.

### GetSearchModeOk

`func (o *QueryDocumentRequest) GetSearchModeOk() (*string, bool)`

GetSearchModeOk returns a tuple with the SearchMode field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSearchMode

`func (o *QueryDocumentRequest) SetSearchMode(v string)`

SetSearchMode sets SearchMode field to given value.

### HasSearchMode

`func (o *QueryDocumentRequest) HasSearchMode() bool`

HasSearchMode returns a boolean if a field has been set.

### SetSearchModeNil

`func (o *QueryDocumentRequest) SetSearchModeNil(b bool)`

 SetSearchModeNil sets the value for SearchMode to be an explicit nil

### UnsetSearchMode
`func (o *QueryDocumentRequest) UnsetSearchMode()`

UnsetSearchMode ensures that no value is present for SearchMode, not even an explicit nil
### GetLanguage

`func (o *QueryDocumentRequest) GetLanguage() string`

GetLanguage returns the Language field if non-nil, zero value otherwise.

### GetLanguageOk

`func (o *QueryDocumentRequest) GetLanguageOk() (*string, bool)`

GetLanguageOk returns a tuple with the Language field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguage

`func (o *QueryDocumentRequest) SetLanguage(v string)`

SetLanguage sets Language field to given value.

### HasLanguage

`func (o *QueryDocumentRequest) HasLanguage() bool`

HasLanguage returns a boolean if a field has been set.

### SetLanguageNil

`func (o *QueryDocumentRequest) SetLanguageNil(b bool)`

 SetLanguageNil sets the value for Language to be an explicit nil

### UnsetLanguage
`func (o *QueryDocumentRequest) UnsetLanguage()`

UnsetLanguage ensures that no value is present for Language, not even an explicit nil
### GetLanguageDetection

`func (o *QueryDocumentRequest) GetLanguageDetection() bool`

GetLanguageDetection returns the LanguageDetection field if non-nil, zero value otherwise.

### GetLanguageDetectionOk

`func (o *QueryDocumentRequest) GetLanguageDetectionOk() (*bool, bool)`

GetLanguageDetectionOk returns a tuple with the LanguageDetection field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguageDetection

`func (o *QueryDocumentRequest) SetLanguageDetection(v bool)`

SetLanguageDetection sets LanguageDetection field to given value.

### HasLanguageDetection

`func (o *QueryDocumentRequest) HasLanguageDetection() bool`

HasLanguageDetection returns a boolean if a field has been set.

### SetLanguageDetectionNil

`func (o *QueryDocumentRequest) SetLanguageDetectionNil(b bool)`

 SetLanguageDetectionNil sets the value for LanguageDetection to be an explicit nil

### UnsetLanguageDetection
`func (o *QueryDocumentRequest) UnsetLanguageDetection()`

UnsetLanguageDetection ensures that no value is present for LanguageDetection, not even an explicit nil
### GetFtsMinScore

`func (o *QueryDocumentRequest) GetFtsMinScore() float32`

GetFtsMinScore returns the FtsMinScore field if non-nil, zero value otherwise.

### GetFtsMinScoreOk

`func (o *QueryDocumentRequest) GetFtsMinScoreOk() (*float32, bool)`

GetFtsMinScoreOk returns a tuple with the FtsMinScore field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFtsMinScore

`func (o *QueryDocumentRequest) SetFtsMinScore(v float32)`

SetFtsMinScore sets FtsMinScore field to given value.

### HasFtsMinScore

`func (o *QueryDocumentRequest) HasFtsMinScore() bool`

HasFtsMinScore returns a boolean if a field has been set.

### SetFtsMinScoreNil

`func (o *QueryDocumentRequest) SetFtsMinScoreNil(b bool)`

 SetFtsMinScoreNil sets the value for FtsMinScore to be an explicit nil

### UnsetFtsMinScore
`func (o *QueryDocumentRequest) UnsetFtsMinScore()`

UnsetFtsMinScore ensures that no value is present for FtsMinScore, not even an explicit nil
### GetFtsWeight

`func (o *QueryDocumentRequest) GetFtsWeight() float32`

GetFtsWeight returns the FtsWeight field if non-nil, zero value otherwise.

### GetFtsWeightOk

`func (o *QueryDocumentRequest) GetFtsWeightOk() (*float32, bool)`

GetFtsWeightOk returns a tuple with the FtsWeight field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFtsWeight

`func (o *QueryDocumentRequest) SetFtsWeight(v float32)`

SetFtsWeight sets FtsWeight field to given value.

### HasFtsWeight

`func (o *QueryDocumentRequest) HasFtsWeight() bool`

HasFtsWeight returns a boolean if a field has been set.

### SetFtsWeightNil

`func (o *QueryDocumentRequest) SetFtsWeightNil(b bool)`

 SetFtsWeightNil sets the value for FtsWeight to be an explicit nil

### UnsetFtsWeight
`func (o *QueryDocumentRequest) UnsetFtsWeight()`

UnsetFtsWeight ensures that no value is present for FtsWeight, not even an explicit nil
### GetSemanticMinRelevance

`func (o *QueryDocumentRequest) GetSemanticMinRelevance() float64`

GetSemanticMinRelevance returns the SemanticMinRelevance field if non-nil, zero value otherwise.

### GetSemanticMinRelevanceOk

`func (o *QueryDocumentRequest) GetSemanticMinRelevanceOk() (*float64, bool)`

GetSemanticMinRelevanceOk returns a tuple with the SemanticMinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSemanticMinRelevance

`func (o *QueryDocumentRequest) SetSemanticMinRelevance(v float64)`

SetSemanticMinRelevance sets SemanticMinRelevance field to given value.

### HasSemanticMinRelevance

`func (o *QueryDocumentRequest) HasSemanticMinRelevance() bool`

HasSemanticMinRelevance returns a boolean if a field has been set.

### SetSemanticMinRelevanceNil

`func (o *QueryDocumentRequest) SetSemanticMinRelevanceNil(b bool)`

 SetSemanticMinRelevanceNil sets the value for SemanticMinRelevance to be an explicit nil

### UnsetSemanticMinRelevance
`func (o *QueryDocumentRequest) UnsetSemanticMinRelevance()`

UnsetSemanticMinRelevance ensures that no value is present for SemanticMinRelevance, not even an explicit nil
### GetSemanticWeight

`func (o *QueryDocumentRequest) GetSemanticWeight() float32`

GetSemanticWeight returns the SemanticWeight field if non-nil, zero value otherwise.

### GetSemanticWeightOk

`func (o *QueryDocumentRequest) GetSemanticWeightOk() (*float32, bool)`

GetSemanticWeightOk returns a tuple with the SemanticWeight field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSemanticWeight

`func (o *QueryDocumentRequest) SetSemanticWeight(v float32)`

SetSemanticWeight sets SemanticWeight field to given value.

### HasSemanticWeight

`func (o *QueryDocumentRequest) HasSemanticWeight() bool`

HasSemanticWeight returns a boolean if a field has been set.

### SetSemanticWeightNil

`func (o *QueryDocumentRequest) SetSemanticWeightNil(b bool)`

 SetSemanticWeightNil sets the value for SemanticWeight to be an explicit nil

### UnsetSemanticWeight
`func (o *QueryDocumentRequest) UnsetSemanticWeight()`

UnsetSemanticWeight ensures that no value is present for SemanticWeight, not even an explicit nil
### GetSmoothingFactorK

`func (o *QueryDocumentRequest) GetSmoothingFactorK() float32`

GetSmoothingFactorK returns the SmoothingFactorK field if non-nil, zero value otherwise.

### GetSmoothingFactorKOk

`func (o *QueryDocumentRequest) GetSmoothingFactorKOk() (*float32, bool)`

GetSmoothingFactorKOk returns a tuple with the SmoothingFactorK field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSmoothingFactorK

`func (o *QueryDocumentRequest) SetSmoothingFactorK(v float32)`

SetSmoothingFactorK sets SmoothingFactorK field to given value.

### HasSmoothingFactorK

`func (o *QueryDocumentRequest) HasSmoothingFactorK() bool`

HasSmoothingFactorK returns a boolean if a field has been set.

### SetSmoothingFactorKNil

`func (o *QueryDocumentRequest) SetSmoothingFactorKNil(b bool)`

 SetSmoothingFactorKNil sets the value for SmoothingFactorK to be an explicit nil

### UnsetSmoothingFactorK
`func (o *QueryDocumentRequest) UnsetSmoothingFactorK()`

UnsetSmoothingFactorK ensures that no value is present for SmoothingFactorK, not even an explicit nil
### GetMinRelevance

`func (o *QueryDocumentRequest) GetMinRelevance() float64`

GetMinRelevance returns the MinRelevance field if non-nil, zero value otherwise.

### GetMinRelevanceOk

`func (o *QueryDocumentRequest) GetMinRelevanceOk() (*float64, bool)`

GetMinRelevanceOk returns a tuple with the MinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinRelevance

`func (o *QueryDocumentRequest) SetMinRelevance(v float64)`

SetMinRelevance sets MinRelevance field to given value.

### HasMinRelevance

`func (o *QueryDocumentRequest) HasMinRelevance() bool`

HasMinRelevance returns a boolean if a field has been set.

### SetMinRelevanceNil

`func (o *QueryDocumentRequest) SetMinRelevanceNil(b bool)`

 SetMinRelevanceNil sets the value for MinRelevance to be an explicit nil

### UnsetMinRelevance
`func (o *QueryDocumentRequest) UnsetMinRelevance()`

UnsetMinRelevance ensures that no value is present for MinRelevance, not even an explicit nil
### GetLimit

`func (o *QueryDocumentRequest) GetLimit() int32`

GetLimit returns the Limit field if non-nil, zero value otherwise.

### GetLimitOk

`func (o *QueryDocumentRequest) GetLimitOk() (*int32, bool)`

GetLimitOk returns a tuple with the Limit field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLimit

`func (o *QueryDocumentRequest) SetLimit(v int32)`

SetLimit sets Limit field to given value.

### HasLimit

`func (o *QueryDocumentRequest) HasLimit() bool`

HasLimit returns a boolean if a field has been set.

### SetLimitNil

`func (o *QueryDocumentRequest) SetLimitNil(b bool)`

 SetLimitNil sets the value for Limit to be an explicit nil

### UnsetLimit
`func (o *QueryDocumentRequest) UnsetLimit()`

UnsetLimit ensures that no value is present for Limit, not even an explicit nil
### GetEmbeddingModel

`func (o *QueryDocumentRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *QueryDocumentRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *QueryDocumentRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *QueryDocumentRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.

### SetEmbeddingModelNil

`func (o *QueryDocumentRequest) SetEmbeddingModelNil(b bool)`

 SetEmbeddingModelNil sets the value for EmbeddingModel to be an explicit nil

### UnsetEmbeddingModel
`func (o *QueryDocumentRequest) UnsetEmbeddingModel()`

UnsetEmbeddingModel ensures that no value is present for EmbeddingModel, not even an explicit nil
### GetArgs

`func (o *QueryDocumentRequest) GetArgs() map[string]interface{}`

GetArgs returns the Args field if non-nil, zero value otherwise.

### GetArgsOk

`func (o *QueryDocumentRequest) GetArgsOk() (*map[string]interface{}, bool)`

GetArgsOk returns a tuple with the Args field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetArgs

`func (o *QueryDocumentRequest) SetArgs(v map[string]interface{})`

SetArgs sets Args field to given value.

### HasArgs

`func (o *QueryDocumentRequest) HasArgs() bool`

HasArgs returns a boolean if a field has been set.

### SetArgsNil

`func (o *QueryDocumentRequest) SetArgsNil(b bool)`

 SetArgsNil sets the value for Args to be an explicit nil

### UnsetArgs
`func (o *QueryDocumentRequest) UnsetArgs()`

UnsetArgs ensures that no value is present for Args, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


