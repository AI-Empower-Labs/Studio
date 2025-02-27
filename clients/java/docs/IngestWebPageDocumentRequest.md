

# IngestWebPageDocumentRequest


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**url** | **String** | Web page to ingest |  |
|**documentId** | **String** | Unique identifier for the document to ingest. |  |
|**index** | **String** | Optional index name where the document will be stored. |  [optional] |
|**webHookUrl** | **URI** | Optional webhook URL to notify upon completion. |  [optional] |
|**embeddingModelName** | **String** | Optional name of the embedding model to use during ingestion. |  [optional] |
|**context** | **Map&lt;String, String&gt;** | Optional key-value pairs for additional context or metadata. |  [optional] |
|**tags** | **Map&lt;String, List&lt;String&gt;&gt;** | A collection of tags associated with the document. Tags can be language-specific. |  [optional] |
|**ingestionPipeline** | **List&lt;String&gt;** | Optional list of ingestion pipeline steps. Allows custom processing. |  [optional] |
|**languageAutoDetection** | **Boolean** | Enable automatic language detection for document content. |  [optional] |
|**language** | [**LanguageEnum**](#LanguageEnum) | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. |  [optional] |



## Enum: LanguageEnum

| Name | Value |
|---- | -----|
| ARABIC | &quot;arabic&quot; |
| ARMENIAN | &quot;armenian&quot; |
| BASQUE | &quot;basque&quot; |
| CATALAN | &quot;catalan&quot; |
| DANISH | &quot;danish&quot; |
| DUTCH | &quot;dutch&quot; |
| ENGLISH | &quot;english&quot; |
| FINNISH | &quot;finnish&quot; |
| FRENCH | &quot;french&quot; |
| GERMAN | &quot;german&quot; |
| GREEK | &quot;greek&quot; |
| HINDI | &quot;hindi&quot; |
| HUNGARIAN | &quot;hungarian&quot; |
| INDONESIAN | &quot;indonesian&quot; |
| IRISH | &quot;irish&quot; |
| ITALIAN | &quot;italian&quot; |
| LITHUANIAN | &quot;lithuanian&quot; |
| NEPALI | &quot;nepali&quot; |
| NORWEGIAN | &quot;norwegian&quot; |
| PORTUGUESE | &quot;portuguese&quot; |
| ROMANIAN | &quot;romanian&quot; |
| RUSSIAN | &quot;russian&quot; |
| SERBIAN | &quot;serbian&quot; |
| SPANISH | &quot;spanish&quot; |
| SWEDISH | &quot;swedish&quot; |
| TAMIL | &quot;tamil&quot; |
| TURKISH | &quot;turkish&quot; |
| YIDDISH | &quot;yiddish&quot; |
| SIMPLE | &quot;simple&quot; |



