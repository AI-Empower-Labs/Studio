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
pub struct AskDocumentRequest {
    /// Semantic query to find matching documents and ask questions over
    #[serde(rename = "query", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub query: Option<Option<String>>,
    /// Optional index to specify which index to search in. Defaults to 'default'
    #[serde(rename = "index", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub index: Option<Option<String>>,
    /// Optional filtering of document id(s) and/or tags
    #[serde(rename = "filter", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub filter: Option<Option<Vec<models::DocumentFilters>>>,
    /// Optional filter to specify minimum relevance. Typically values between 0 and 1
    #[serde(rename = "minRelevance", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub min_relevance: Option<Option<f64>>,
    /// Large language model to use in query
    #[serde(rename = "llmModel", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub llm_model: Option<Option<String>>,
    /// Embedding model to use in query
    #[serde(rename = "embeddingModel", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub embedding_model: Option<Option<String>>,
    #[serde(rename = "args", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub args: Option<Option<std::collections::HashMap<String, serde_json::Value>>>,
}

impl AskDocumentRequest {
    pub fn new() -> AskDocumentRequest {
        AskDocumentRequest {
            query: None,
            index: None,
            filter: None,
            min_relevance: None,
            llm_model: None,
            embedding_model: None,
            args: None,
        }
    }
}
