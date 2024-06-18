# ListDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | Pointer to **NullableString** | Unique record ID | [optional] 
**Vector** | Pointer to **map[string]interface{}** | Embedding vector | [optional] 
**Tags** | Pointer to **map[string][]string** | Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc. | [optional] 
**Payload** | Pointer to **map[string]interface{}** | Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc. | [optional] 

## Methods

### NewListDocumentResponse

`func NewListDocumentResponse() *ListDocumentResponse`

NewListDocumentResponse instantiates a new ListDocumentResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewListDocumentResponseWithDefaults

`func NewListDocumentResponseWithDefaults() *ListDocumentResponse`

NewListDocumentResponseWithDefaults instantiates a new ListDocumentResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetId

`func (o *ListDocumentResponse) GetId() string`

GetId returns the Id field if non-nil, zero value otherwise.

### GetIdOk

`func (o *ListDocumentResponse) GetIdOk() (*string, bool)`

GetIdOk returns a tuple with the Id field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetId

`func (o *ListDocumentResponse) SetId(v string)`

SetId sets Id field to given value.

### HasId

`func (o *ListDocumentResponse) HasId() bool`

HasId returns a boolean if a field has been set.

### SetIdNil

`func (o *ListDocumentResponse) SetIdNil(b bool)`

 SetIdNil sets the value for Id to be an explicit nil

### UnsetId
`func (o *ListDocumentResponse) UnsetId()`

UnsetId ensures that no value is present for Id, not even an explicit nil
### GetVector

`func (o *ListDocumentResponse) GetVector() map[string]interface{}`

GetVector returns the Vector field if non-nil, zero value otherwise.

### GetVectorOk

`func (o *ListDocumentResponse) GetVectorOk() (*map[string]interface{}, bool)`

GetVectorOk returns a tuple with the Vector field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetVector

`func (o *ListDocumentResponse) SetVector(v map[string]interface{})`

SetVector sets Vector field to given value.

### HasVector

`func (o *ListDocumentResponse) HasVector() bool`

HasVector returns a boolean if a field has been set.

### GetTags

`func (o *ListDocumentResponse) GetTags() map[string][]string`

GetTags returns the Tags field if non-nil, zero value otherwise.

### GetTagsOk

`func (o *ListDocumentResponse) GetTagsOk() (*map[string][]string, bool)`

GetTagsOk returns a tuple with the Tags field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTags

`func (o *ListDocumentResponse) SetTags(v map[string][]string)`

SetTags sets Tags field to given value.

### HasTags

`func (o *ListDocumentResponse) HasTags() bool`

HasTags returns a boolean if a field has been set.

### GetPayload

`func (o *ListDocumentResponse) GetPayload() map[string]interface{}`

GetPayload returns the Payload field if non-nil, zero value otherwise.

### GetPayloadOk

`func (o *ListDocumentResponse) GetPayloadOk() (*map[string]interface{}, bool)`

GetPayloadOk returns a tuple with the Payload field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetPayload

`func (o *ListDocumentResponse) SetPayload(v map[string]interface{})`

SetPayload sets Payload field to given value.

### HasPayload

`func (o *ListDocumentResponse) HasPayload() bool`

HasPayload returns a boolean if a field has been set.

### SetPayloadNil

`func (o *ListDocumentResponse) SetPayloadNil(b bool)`

 SetPayloadNil sets the value for Payload to be an explicit nil

### UnsetPayload
`func (o *ListDocumentResponse) UnsetPayload()`

UnsetPayload ensures that no value is present for Payload, not even an explicit nil

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


