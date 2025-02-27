# DocumentPartition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | Pointer to **NullableString** | Content of the document partition, aka chunk/block of text. | [optional] 
**FullTextSearchRank** | Pointer to **NullableFloat32** | Rank value calculated from full-text search, used to determine the relevance of search results. | [optional] 
**SemanticSimilarity** | Pointer to **NullableFloat32** | Represents the semantic similarity score associated with a record. | [optional] 
**FullTextSearchRrf** | Pointer to **NullableFloat32** | Reciprocal rank fusion (RRF) score specifically derived from full-text search relevance. | [optional] 
**SemanticRrf** | Pointer to **NullableFloat32** | Reciprocal Rank Fusion (RRF) score based on semantic similarity | [optional] 
**RrfScore** | Pointer to **NullableFloat32** | Represents the combined Reciprocal Rank Fusion (RRF) score, which integrates results from multiple ranking methods such as semantic similarity and full-text search to enhance result relevance. | [optional] 
**Language** | Pointer to **NullableString** | Language of partition if any. Optional. | [optional] 
**LastUpdate** | Pointer to **time.Time** | Timestamp about the file/text partition. | [optional] 
**Tags** | Pointer to **map[string][]string** | List of document tags | [optional] 

## Methods

### NewDocumentPartition

`func NewDocumentPartition() *DocumentPartition`

NewDocumentPartition instantiates a new DocumentPartition object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewDocumentPartitionWithDefaults

`func NewDocumentPartitionWithDefaults() *DocumentPartition`

NewDocumentPartitionWithDefaults instantiates a new DocumentPartition object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetText

`func (o *DocumentPartition) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *DocumentPartition) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *DocumentPartition) SetText(v string)`

SetText sets Text field to given value.

### HasText

`func (o *DocumentPartition) HasText() bool`

HasText returns a boolean if a field has been set.

### SetTextNil

`func (o *DocumentPartition) SetTextNil(b bool)`

 SetTextNil sets the value for Text to be an explicit nil

### UnsetText
`func (o *DocumentPartition) UnsetText()`

UnsetText ensures that no value is present for Text, not even an explicit nil
### GetFullTextSearchRank

`func (o *DocumentPartition) GetFullTextSearchRank() float32`

GetFullTextSearchRank returns the FullTextSearchRank field if non-nil, zero value otherwise.

### GetFullTextSearchRankOk

`func (o *DocumentPartition) GetFullTextSearchRankOk() (*float32, bool)`

GetFullTextSearchRankOk returns a tuple with the FullTextSearchRank field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFullTextSearchRank

`func (o *DocumentPartition) SetFullTextSearchRank(v float32)`

SetFullTextSearchRank sets FullTextSearchRank field to given value.

### HasFullTextSearchRank

`func (o *DocumentPartition) HasFullTextSearchRank() bool`

HasFullTextSearchRank returns a boolean if a field has been set.

### SetFullTextSearchRankNil

`func (o *DocumentPartition) SetFullTextSearchRankNil(b bool)`

 SetFullTextSearchRankNil sets the value for FullTextSearchRank to be an explicit nil

### UnsetFullTextSearchRank
`func (o *DocumentPartition) UnsetFullTextSearchRank()`

UnsetFullTextSearchRank ensures that no value is present for FullTextSearchRank, not even an explicit nil
### GetSemanticSimilarity

`func (o *DocumentPartition) GetSemanticSimilarity() float32`

GetSemanticSimilarity returns the SemanticSimilarity field if non-nil, zero value otherwise.

### GetSemanticSimilarityOk

`func (o *DocumentPartition) GetSemanticSimilarityOk() (*float32, bool)`

GetSemanticSimilarityOk returns a tuple with the SemanticSimilarity field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSemanticSimilarity

`func (o *DocumentPartition) SetSemanticSimilarity(v float32)`

SetSemanticSimilarity sets SemanticSimilarity field to given value.

### HasSemanticSimilarity

`func (o *DocumentPartition) HasSemanticSimilarity() bool`

HasSemanticSimilarity returns a boolean if a field has been set.

### SetSemanticSimilarityNil

`func (o *DocumentPartition) SetSemanticSimilarityNil(b bool)`

 SetSemanticSimilarityNil sets the value for SemanticSimilarity to be an explicit nil

### UnsetSemanticSimilarity
`func (o *DocumentPartition) UnsetSemanticSimilarity()`

UnsetSemanticSimilarity ensures that no value is present for SemanticSimilarity, not even an explicit nil
### GetFullTextSearchRrf

`func (o *DocumentPartition) GetFullTextSearchRrf() float32`

GetFullTextSearchRrf returns the FullTextSearchRrf field if non-nil, zero value otherwise.

### GetFullTextSearchRrfOk

`func (o *DocumentPartition) GetFullTextSearchRrfOk() (*float32, bool)`

GetFullTextSearchRrfOk returns a tuple with the FullTextSearchRrf field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFullTextSearchRrf

`func (o *DocumentPartition) SetFullTextSearchRrf(v float32)`

SetFullTextSearchRrf sets FullTextSearchRrf field to given value.

### HasFullTextSearchRrf

`func (o *DocumentPartition) HasFullTextSearchRrf() bool`

HasFullTextSearchRrf returns a boolean if a field has been set.

### SetFullTextSearchRrfNil

`func (o *DocumentPartition) SetFullTextSearchRrfNil(b bool)`

 SetFullTextSearchRrfNil sets the value for FullTextSearchRrf to be an explicit nil

### UnsetFullTextSearchRrf
`func (o *DocumentPartition) UnsetFullTextSearchRrf()`

UnsetFullTextSearchRrf ensures that no value is present for FullTextSearchRrf, not even an explicit nil
### GetSemanticRrf

`func (o *DocumentPartition) GetSemanticRrf() float32`

GetSemanticRrf returns the SemanticRrf field if non-nil, zero value otherwise.

### GetSemanticRrfOk

`func (o *DocumentPartition) GetSemanticRrfOk() (*float32, bool)`

GetSemanticRrfOk returns a tuple with the SemanticRrf field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSemanticRrf

`func (o *DocumentPartition) SetSemanticRrf(v float32)`

SetSemanticRrf sets SemanticRrf field to given value.

### HasSemanticRrf

`func (o *DocumentPartition) HasSemanticRrf() bool`

HasSemanticRrf returns a boolean if a field has been set.

### SetSemanticRrfNil

`func (o *DocumentPartition) SetSemanticRrfNil(b bool)`

 SetSemanticRrfNil sets the value for SemanticRrf to be an explicit nil

### UnsetSemanticRrf
`func (o *DocumentPartition) UnsetSemanticRrf()`

UnsetSemanticRrf ensures that no value is present for SemanticRrf, not even an explicit nil
### GetRrfScore

`func (o *DocumentPartition) GetRrfScore() float32`

GetRrfScore returns the RrfScore field if non-nil, zero value otherwise.

### GetRrfScoreOk

`func (o *DocumentPartition) GetRrfScoreOk() (*float32, bool)`

GetRrfScoreOk returns a tuple with the RrfScore field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRrfScore

`func (o *DocumentPartition) SetRrfScore(v float32)`

SetRrfScore sets RrfScore field to given value.

### HasRrfScore

`func (o *DocumentPartition) HasRrfScore() bool`

HasRrfScore returns a boolean if a field has been set.

### SetRrfScoreNil

`func (o *DocumentPartition) SetRrfScoreNil(b bool)`

 SetRrfScoreNil sets the value for RrfScore to be an explicit nil

### UnsetRrfScore
`func (o *DocumentPartition) UnsetRrfScore()`

UnsetRrfScore ensures that no value is present for RrfScore, not even an explicit nil
### GetLanguage

`func (o *DocumentPartition) GetLanguage() string`

GetLanguage returns the Language field if non-nil, zero value otherwise.

### GetLanguageOk

`func (o *DocumentPartition) GetLanguageOk() (*string, bool)`

GetLanguageOk returns a tuple with the Language field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLanguage

`func (o *DocumentPartition) SetLanguage(v string)`

SetLanguage sets Language field to given value.

### HasLanguage

`func (o *DocumentPartition) HasLanguage() bool`

HasLanguage returns a boolean if a field has been set.

### SetLanguageNil

`func (o *DocumentPartition) SetLanguageNil(b bool)`

 SetLanguageNil sets the value for Language to be an explicit nil

### UnsetLanguage
`func (o *DocumentPartition) UnsetLanguage()`

UnsetLanguage ensures that no value is present for Language, not even an explicit nil
### GetLastUpdate

`func (o *DocumentPartition) GetLastUpdate() time.Time`

GetLastUpdate returns the LastUpdate field if non-nil, zero value otherwise.

### GetLastUpdateOk

`func (o *DocumentPartition) GetLastUpdateOk() (*time.Time, bool)`

GetLastUpdateOk returns a tuple with the LastUpdate field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLastUpdate

`func (o *DocumentPartition) SetLastUpdate(v time.Time)`

SetLastUpdate sets LastUpdate field to given value.

### HasLastUpdate

`func (o *DocumentPartition) HasLastUpdate() bool`

HasLastUpdate returns a boolean if a field has been set.

### GetTags

`func (o *DocumentPartition) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *DocumentPartition) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *DocumentPartition) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *DocumentPartition) HasTags() bool`

HasTags returns a boolean if a field has been set.

### SetTagsNil

`func (o *DocumentPartition) SetTagsNil(b bool)`

 SetTagsNil sets the value for Tags to be an explicit nil

### UnsetTags
`func (o *DocumentPartition) UnsetTags()`

UnsetTags ensures that no value is present for Tags, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


