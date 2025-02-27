
# IngestTextDocumentRequest

## Properties
| Name | Type | Description | Notes |
| ------------ | ------------- | ------------- | ------------- |
| **text** | **kotlin.String** | Text to ingest |  |
| **documentId** | **kotlin.String** | Unique identifier for the document to ingest. |  |
| **index** | **kotlin.String** | Optional index name where the document will be stored. |  [optional] |
| **webHookUrl** | [**java.net.URI**](java.net.URI.md) | Optional webhook URL to notify upon completion. |  [optional] |
| **embeddingModelName** | **kotlin.String** | Optional name of the embedding model to use during ingestion. |  [optional] |
| **context** | **kotlin.collections.Map&lt;kotlin.String, kotlin.String&gt;** | Optional key-value pairs for additional context or metadata. |  [optional] |
| **tags** | **kotlin.collections.Map&lt;kotlin.String, kotlin.collections.List&lt;kotlin.String&gt;&gt;** | A collection of tags associated with the document. Tags can be language-specific. |  [optional] |
| **ingestionPipeline** | **kotlin.collections.List&lt;kotlin.String&gt;** | Optional list of ingestion pipeline steps. Allows custom processing. |  [optional] |
| **languageAutoDetection** | **kotlin.Boolean** | Enable automatic language detection for document content. |  [optional] |
| **language** | [**inline**](#Language) | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. |  [optional] |


<a id="Language"></a>
## Enum: language
| Name | Value |
| ---- | ----- |
| language | arabic, armenian, basque, catalan, danish, dutch, english, finnish, french, german, greek, hindi, hungarian, indonesian, irish, italian, lithuanian, nepali, norwegian, portuguese, romanian, russian, serbian, spanish, swedish, tamil, turkish, yiddish, simple |



