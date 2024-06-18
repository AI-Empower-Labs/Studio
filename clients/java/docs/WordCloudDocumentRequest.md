

# WordCloudDocumentRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**index** | **String** | Optional index to specify which index to search in. Defaults to &#39;default&#39; |  [optional] |
|**filter** | [**List&lt;DocumentFilters&gt;**](DocumentFilters.md) | Optional filtering of document id(s) and/or tags |  [optional] |
|**limit** | **Integer** | Optional filter for specifying maximum number of entries to return. Defaults to 3 |  [optional] |
|**source** | [**SourceEnum**](#SourceEnum) | Optional filter for specifying maximum number of entries to return. Defaults to 3 |  [optional] |



## Enum: SourceEnum

| Name | Value |
|---- | -----|
| DOCUMENT_KEY | &quot;document_key&quot; |
| DOCUMENT_VALUE | &quot;document_value&quot; |
| DOCUMENT_KEY_AND_VALUE | &quot;document_key_and_value&quot; |
| TAG_KEY | &quot;tag_key&quot; |
| TAG_VALUE | &quot;tag_value&quot; |
| TAG_KER_AND_VALUE | &quot;tag_ker_and_value&quot; |



