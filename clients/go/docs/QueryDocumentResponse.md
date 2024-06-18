# QueryDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelevantSources** | Pointer to [**[]DocumentCitation**](DocumentCitation.md) | List of the relevant sources used to produce the answer.  Key &#x3D; Document ID  Value &#x3D; List of partitions used from the document. | [optional] 

## Methods

### NewQueryDocumentResponse

`func NewQueryDocumentResponse() *QueryDocumentResponse`

NewQueryDocumentResponse instantiates a new QueryDocumentResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewQueryDocumentResponseWithDefaults

`func NewQueryDocumentResponseWithDefaults() *QueryDocumentResponse`

NewQueryDocumentResponseWithDefaults instantiates a new QueryDocumentResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetRelevantSources

`func (o *QueryDocumentResponse) GetRelevantSources() []DocumentCitation`

GetRelevantSources returns the RelevantSources field if non-nil, zero value otherwise.

### GetRelevantSourcesOk

`func (o *QueryDocumentResponse) GetRelevantSourcesOk() (*[]DocumentCitation, bool)`

GetRelevantSourcesOk returns a tuple with the RelevantSources field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetRelevantSources

`func (o *QueryDocumentResponse) SetRelevantSources(v []DocumentCitation)`

SetRelevantSources sets RelevantSources field to given value.

### HasRelevantSources

`func (o *QueryDocumentResponse) HasRelevantSources() bool`

HasRelevantSources returns a boolean if a field has been set.

### SetRelevantSourcesNil

`func (o *QueryDocumentResponse) SetRelevantSourcesNil(b bool)`

 SetRelevantSourcesNil sets the value for RelevantSources to be an explicit nil

### UnsetRelevantSources
`func (o *QueryDocumentResponse) UnsetRelevantSources()`

UnsetRelevantSources ensures that no value is present for RelevantSources, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


