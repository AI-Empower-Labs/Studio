# AskDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | Pointer to **NullableString** | Semantic query to find matching documents and ask questions over | [optional] 
**Index** | Pointer to **NullableString** | Optional index to specify which index to search in. Defaults to &#39;default&#39; | [optional] 
**Filter** | Pointer to [**[]DocumentFilters**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags | [optional] 
**MinRelevance** | Pointer to **NullableFloat64** | Optional filter to specify minimum relevance. Typically values between 0 and 1 | [optional] 
**LlmModel** | Pointer to **NullableString** | Large language model to use in query | [optional] 
**EmbeddingModel** | Pointer to **NullableString** | Embedding model to use in query | [optional] 
**Args** | Pointer to **map[string]interface{}** |  | [optional] 

## Methods

### NewAskDocumentRequest

`func NewAskDocumentRequest() *AskDocumentRequest`

NewAskDocumentRequest instantiates a new AskDocumentRequest object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewAskDocumentRequestWithDefaults

`func NewAskDocumentRequestWithDefaults() *AskDocumentRequest`

NewAskDocumentRequestWithDefaults instantiates a new AskDocumentRequest object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetQuery

`func (o *AskDocumentRequest) GetQuery() string`

GetQuery returns the Query field if non-nil, zero value otherwise.

### GetQueryOk

`func (o *AskDocumentRequest) GetQueryOk() (*string, bool)`

GetQueryOk returns a tuple with the Query field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetQuery

`func (o *AskDocumentRequest) SetQuery(v string)`

SetQuery sets Query field to given value.

### HasQuery

`func (o *AskDocumentRequest) HasQuery() bool`

HasQuery returns a boolean if a field has been set.

### SetQueryNil

`func (o *AskDocumentRequest) SetQueryNil(b bool)`

 SetQueryNil sets the value for Query to be an explicit nil

### UnsetQuery
`func (o *AskDocumentRequest) UnsetQuery()`

UnsetQuery ensures that no value is present for Query, not even an explicit nil
### GetIndex

`func (o *AskDocumentRequest) GetIndex() string`

GetIndex returns the Index field if non-nil, zero value otherwise.

### GetIndexOk

`func (o *AskDocumentRequest) GetIndexOk() (*string, bool)`

GetIndexOk returns a tuple with the Index field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIndex

`func (o *AskDocumentRequest) SetIndex(v string)`

SetIndex sets Index field to given value.

### HasIndex

`func (o *AskDocumentRequest) HasIndex() bool`

HasIndex returns a boolean if a field has been set.

### SetIndexNil

`func (o *AskDocumentRequest) SetIndexNil(b bool)`

 SetIndexNil sets the value for Index to be an explicit nil

### UnsetIndex
`func (o *AskDocumentRequest) UnsetIndex()`

UnsetIndex ensures that no value is present for Index, not even an explicit nil
### GetFilter

`func (o *AskDocumentRequest) GetFilter() []DocumentFilters`

GetFilter returns the Filter field if non-nil, zero value otherwise.

### GetFilterOk

`func (o *AskDocumentRequest) GetFilterOk() (*[]DocumentFilters, bool)`

GetFilterOk returns a tuple with the Filter field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetFilter

`func (o *AskDocumentRequest) SetFilter(v []DocumentFilters)`

SetFilter sets Filter field to given value.

### HasFilter

`func (o *AskDocumentRequest) HasFilter() bool`

HasFilter returns a boolean if a field has been set.

### SetFilterNil

`func (o *AskDocumentRequest) SetFilterNil(b bool)`

 SetFilterNil sets the value for Filter to be an explicit nil

### UnsetFilter
`func (o *AskDocumentRequest) UnsetFilter()`

UnsetFilter ensures that no value is present for Filter, not even an explicit nil
### GetMinRelevance

`func (o *AskDocumentRequest) GetMinRelevance() float64`

GetMinRelevance returns the MinRelevance field if non-nil, zero value otherwise.

### GetMinRelevanceOk

`func (o *AskDocumentRequest) GetMinRelevanceOk() (*float64, bool)`

GetMinRelevanceOk returns a tuple with the MinRelevance field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMinRelevance

`func (o *AskDocumentRequest) SetMinRelevance(v float64)`

SetMinRelevance sets MinRelevance field to given value.

### HasMinRelevance

`func (o *AskDocumentRequest) HasMinRelevance() bool`

HasMinRelevance returns a boolean if a field has been set.

### SetMinRelevanceNil

`func (o *AskDocumentRequest) SetMinRelevanceNil(b bool)`

 SetMinRelevanceNil sets the value for MinRelevance to be an explicit nil

### UnsetMinRelevance
`func (o *AskDocumentRequest) UnsetMinRelevance()`

UnsetMinRelevance ensures that no value is present for MinRelevance, not even an explicit nil
### GetLlmModel

`func (o *AskDocumentRequest) GetLlmModel() string`

GetLlmModel returns the LlmModel field if non-nil, zero value otherwise.

### GetLlmModelOk

`func (o *AskDocumentRequest) GetLlmModelOk() (*string, bool)`

GetLlmModelOk returns a tuple with the LlmModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetLlmModel

`func (o *AskDocumentRequest) SetLlmModel(v string)`

SetLlmModel sets LlmModel field to given value.

### HasLlmModel

`func (o *AskDocumentRequest) HasLlmModel() bool`

HasLlmModel returns a boolean if a field has been set.

### SetLlmModelNil

`func (o *AskDocumentRequest) SetLlmModelNil(b bool)`

 SetLlmModelNil sets the value for LlmModel to be an explicit nil

### UnsetLlmModel
`func (o *AskDocumentRequest) UnsetLlmModel()`

UnsetLlmModel ensures that no value is present for LlmModel, not even an explicit nil
### GetEmbeddingModel

`func (o *AskDocumentRequest) GetEmbeddingModel() string`

GetEmbeddingModel returns the EmbeddingModel field if non-nil, zero value otherwise.

### GetEmbeddingModelOk

`func (o *AskDocumentRequest) GetEmbeddingModelOk() (*string, bool)`

GetEmbeddingModelOk returns a tuple with the EmbeddingModel field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmbeddingModel

`func (o *AskDocumentRequest) SetEmbeddingModel(v string)`

SetEmbeddingModel sets EmbeddingModel field to given value.

### HasEmbeddingModel

`func (o *AskDocumentRequest) HasEmbeddingModel() bool`

HasEmbeddingModel returns a boolean if a field has been set.

### SetEmbeddingModelNil

`func (o *AskDocumentRequest) SetEmbeddingModelNil(b bool)`

 SetEmbeddingModelNil sets the value for EmbeddingModel to be an explicit nil

### UnsetEmbeddingModel
`func (o *AskDocumentRequest) UnsetEmbeddingModel()`

UnsetEmbeddingModel ensures that no value is present for EmbeddingModel, not even an explicit nil
### GetArgs

`func (o *AskDocumentRequest) GetArgs() map[string]interface{}`

GetArgs returns the Args field if non-nil, zero value otherwise.

### GetArgsOk

`func (o *AskDocumentRequest) GetArgsOk() (*map[string]interface{}, bool)`

GetArgsOk returns a tuple with the Args field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetArgs

`func (o *AskDocumentRequest) SetArgs(v map[string]interface{})`

SetArgs sets Args field to given value.

### HasArgs

`func (o *AskDocumentRequest) HasArgs() bool`

HasArgs returns a boolean if a field has been set.

### SetArgsNil

`func (o *AskDocumentRequest) SetArgsNil(b bool)`

 SetArgsNil sets the value for Args to be an explicit nil

### UnsetArgs
`func (o *AskDocumentRequest) UnsetArgs()`

UnsetArgs ensures that no value is present for Args, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


