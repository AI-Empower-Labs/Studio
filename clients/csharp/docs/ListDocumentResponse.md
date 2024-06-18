# Org.OpenAPITools.Model.ListDocumentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique record ID | [optional] 
**Vector** | **Object** | Embedding vector | [optional] 
**Tags** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Optional Searchable Key&#x3D;Value tags (string &#x3D;&gt; string[] collection)                Multiple values per keys are supported.  e.g. [ \&quot;Collection&#x3D;Work\&quot;, \&quot;Project&#x3D;1\&quot;, \&quot;Project&#x3D;2\&quot;, \&quot;Project&#x3D;3\&quot;, \&quot;Type&#x3D;Chat\&quot;, \&quot;LLM&#x3D;AzureAda2\&quot; ]                Use cases:   * collections, e.g. [ \&quot;Collection&#x3D;Project1\&quot;, \&quot;Collection&#x3D;Work\&quot; ]   * folders, e.g. [ \&quot;Folder&#x3D;Inbox\&quot;, \&quot;Folder&#x3D;Spam\&quot; ]   * content types, e.g. [ \&quot;Type&#x3D;Chat\&quot; ]   * versioning, e.g. [ \&quot;LLM&#x3D;AzureAda2\&quot;, \&quot;Schema&#x3D;1.0\&quot; ]   * etc. | [optional] 
**Payload** | **Dictionary&lt;string, Object&gt;** | Optional Non-Searchable payload processed client side.                Use cases:   * citations   * original text   * descriptions   * embedding generator name   * URLs   * content type   * timestamps   * etc. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

