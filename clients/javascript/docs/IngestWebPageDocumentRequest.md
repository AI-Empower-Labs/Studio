# StudioAiEmpowerLabs.IngestWebPageDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**url** | **String** | Web page to ingest | 
**documentId** | **String** | Unique identifier for the document to ingest. | 
**index** | **String** | Optional index name where the document will be stored. | [optional] 
**webHookUrl** | **String** | Optional webhook URL to notify upon completion. | [optional] 
**embeddingModelName** | **String** | Optional name of the embedding model to use during ingestion. | [optional] 
**context** | **{String: String}** | Optional key-value pairs for additional context or metadata. | [optional] 
**tags** | **{String: [String]}** | A collection of tags associated with the document. Tags can be language-specific. | [optional] 
**ingestionPipeline** | **[String]** | Optional list of ingestion pipeline steps. Allows custom processing. | [optional] 
**languageAutoDetection** | **Boolean** | Enable automatic language detection for document content. | [optional] [default to false]
**language** | **String** | Force a specific language for full-text search. Use &#39;simple&#39; for no language or leave empty. | [optional] 



## Enum: LanguageEnum


* `arabic` (value: `"arabic"`)

* `armenian` (value: `"armenian"`)

* `basque` (value: `"basque"`)

* `catalan` (value: `"catalan"`)

* `danish` (value: `"danish"`)

* `dutch` (value: `"dutch"`)

* `english` (value: `"english"`)

* `finnish` (value: `"finnish"`)

* `french` (value: `"french"`)

* `german` (value: `"german"`)

* `greek` (value: `"greek"`)

* `hindi` (value: `"hindi"`)

* `hungarian` (value: `"hungarian"`)

* `indonesian` (value: `"indonesian"`)

* `irish` (value: `"irish"`)

* `italian` (value: `"italian"`)

* `lithuanian` (value: `"lithuanian"`)

* `nepali` (value: `"nepali"`)

* `norwegian` (value: `"norwegian"`)

* `portuguese` (value: `"portuguese"`)

* `romanian` (value: `"romanian"`)

* `russian` (value: `"russian"`)

* `serbian` (value: `"serbian"`)

* `spanish` (value: `"spanish"`)

* `swedish` (value: `"swedish"`)

* `tamil` (value: `"tamil"`)

* `turkish` (value: `"turkish"`)

* `yiddish` (value: `"yiddish"`)

* `simple` (value: `"simple"`)




