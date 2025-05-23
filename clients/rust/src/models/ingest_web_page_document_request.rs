/*
 * Studio - AI Empower Labs
 *
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct IngestWebPageDocumentRequest {
    /// Web page to ingest
    #[serde(rename = "url")]
    pub url: String,
    /// Unique identifier for the document to ingest.
    #[serde(rename = "documentId")]
    pub document_id: String,
    /// Optional index name where the document will be stored.
    #[serde(rename = "index", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub index: Option<Option<String>>,
    /// Optional webhook URL to notify upon completion.
    #[serde(rename = "webHookUrl", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub web_hook_url: Option<Option<String>>,
    /// Optional name of the embedding model to use during ingestion.
    #[serde(rename = "embeddingModelName", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub embedding_model_name: Option<Option<String>>,
    /// Optional key-value pairs for additional context or metadata.
    #[serde(rename = "context", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub context: Option<Option<std::collections::HashMap<String, String>>>,
    /// A collection of tags associated with the document. Tags can be language-specific.
    #[serde(rename = "tags", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub tags: Option<Option<std::collections::HashMap<String, Vec<String>>>>,
    /// Optional list of ingestion pipeline steps. Allows custom processing.
    #[serde(rename = "ingestionPipeline", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub ingestion_pipeline: Option<Option<Vec<String>>>,
    /// Enable automatic language detection for document content.
    #[serde(rename = "languageAutoDetection", skip_serializing_if = "Option::is_none")]
    pub language_auto_detection: Option<bool>,
    /// Force a specific language for full-text search. Use 'simple' for no language or leave empty.
    #[serde(rename = "language", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub language: Option<Option<Language>>,
}

impl IngestWebPageDocumentRequest {
    pub fn new(url: String, document_id: String) -> IngestWebPageDocumentRequest {
        IngestWebPageDocumentRequest {
            url,
            document_id,
            index: None,
            web_hook_url: None,
            embedding_model_name: None,
            context: None,
            tags: None,
            ingestion_pipeline: None,
            language_auto_detection: None,
            language: None,
        }
    }
}
/// Force a specific language for full-text search. Use 'simple' for no language or leave empty.
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum Language {
    #[serde(rename = "arabic")]
    Arabic,
    #[serde(rename = "armenian")]
    Armenian,
    #[serde(rename = "basque")]
    Basque,
    #[serde(rename = "catalan")]
    Catalan,
    #[serde(rename = "danish")]
    Danish,
    #[serde(rename = "dutch")]
    Dutch,
    #[serde(rename = "english")]
    English,
    #[serde(rename = "finnish")]
    Finnish,
    #[serde(rename = "french")]
    French,
    #[serde(rename = "german")]
    German,
    #[serde(rename = "greek")]
    Greek,
    #[serde(rename = "hindi")]
    Hindi,
    #[serde(rename = "hungarian")]
    Hungarian,
    #[serde(rename = "indonesian")]
    Indonesian,
    #[serde(rename = "irish")]
    Irish,
    #[serde(rename = "italian")]
    Italian,
    #[serde(rename = "lithuanian")]
    Lithuanian,
    #[serde(rename = "nepali")]
    Nepali,
    #[serde(rename = "norwegian")]
    Norwegian,
    #[serde(rename = "portuguese")]
    Portuguese,
    #[serde(rename = "romanian")]
    Romanian,
    #[serde(rename = "russian")]
    Russian,
    #[serde(rename = "serbian")]
    Serbian,
    #[serde(rename = "spanish")]
    Spanish,
    #[serde(rename = "swedish")]
    Swedish,
    #[serde(rename = "tamil")]
    Tamil,
    #[serde(rename = "turkish")]
    Turkish,
    #[serde(rename = "yiddish")]
    Yiddish,
    #[serde(rename = "simple")]
    Simple,
}

impl Default for Language {
    fn default() -> Language {
        Self::Arabic
    }
}

