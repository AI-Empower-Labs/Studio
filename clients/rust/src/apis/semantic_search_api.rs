/*
 * Studio - AI Empower Labs
 *
 * # Studio API Documentation  ## Introduction Welcome to Studio by AI Empower Labs API documentation! We are thrilled to offer developers around the world access to our cutting-edge artificial intelligence technology and semantic search. Our API is designed to empower your applications with state-of-the-art AI capabilities, including but not limited to natural language processing, audio transcription, embedding, and predictive analytics.  Our mission is to make AI technology accessible and easy to integrate, enabling you to enhance your applications, improve user experiences, and innovate in your field. Whether you're building complex systems, developing mobile apps, or creating web services, our API provides you with the tools you need to incorporate AI functionalities seamlessly.  Support and Feedback We are committed to providing exceptional support to our developer community. If you have any questions, encounter any issues, or have feedback on how we can improve our API, please don't hesitate to contact our support team @ support@AIEmpowerLabs.com.  Terms of Use Please review our terms of use and privacy policy before integrating our API into your application. By using our API, you agree to comply with these terms.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@aiempowerlabs.com
 * Generated by: https://openapi-generator.tech
 */


use reqwest;
use serde::{Deserialize, Serialize};
use crate::{apis::ResponseContent, models};
use super::{Error, configuration};


/// struct for typed errors of method [`semantic_search_ask`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchAskError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_delete_document`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchDeleteDocumentError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_delete_index`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchDeleteIndexError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_file_ingestion`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchFileIngestionError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_ingestion_status`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchIngestionStatusError {
    Status400(models::HttpValidationProblemDetails),
    Status404(models::ProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_list`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchListError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_query`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchQueryError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_query_results_clustering`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchQueryResultsClusteringError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_rerank`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchRerankError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_text_ingestion`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchTextIngestionError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`semantic_search_webpage_ingestion`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SemanticSearchWebpageIngestionError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}


/// Ask questions over ingested documents
pub async fn semantic_search_ask(configuration: &configuration::Configuration, ask_document_request: models::AskDocumentRequest) -> Result<models::AskDocumentResponse, Error<SemanticSearchAskError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/ask", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&ask_document_request);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchAskError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Delete specific document by id
pub async fn semantic_search_delete_document(configuration: &configuration::Configuration, document_id: &str, index: &str) -> Result<(), Error<SemanticSearchDeleteDocumentError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/{documentId}", local_var_configuration.base_path, documentId=crate::apis::urlencode(document_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::DELETE, local_var_uri_str.as_str());

    local_var_req_builder = local_var_req_builder.query(&[("index", &index.to_string())]);
    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<SemanticSearchDeleteDocumentError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Delete specific index by name
pub async fn semantic_search_delete_index(configuration: &configuration::Configuration, name: &str) -> Result<(), Error<SemanticSearchDeleteIndexError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/index", local_var_configuration.base_path, name=crate::apis::urlencode(name));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::DELETE, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<SemanticSearchDeleteIndexError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Import file document into semantic search
pub async fn semantic_search_file_ingestion(configuration: &configuration::Configuration, files: Vec<std::path::PathBuf>, document_id: Option<&str>, index: Option<&str>, pipeline: Option<Vec<String>>, web_hook_url: Option<&str>, embedding_model: Option<&str>, args: Option<std::collections::HashMap<String, serde_json::Value>>, tags: Option<std::collections::HashMap<String, serde_json::Value>>) -> Result<models::IngestDocumentResponse, Error<SemanticSearchFileIngestionError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/ingest/file", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_str) = document_id {
        local_var_req_builder = local_var_req_builder.query(&[("documentId", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = index {
        local_var_req_builder = local_var_req_builder.query(&[("index", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = pipeline {
        local_var_req_builder = match "multi" {
            "multi" => local_var_req_builder.query(&local_var_str.into_iter().map(|p| ("pipeline".to_owned(), p.to_string())).collect::<Vec<(std::string::String, std::string::String)>>()),
            _ => local_var_req_builder.query(&[("pipeline", &local_var_str.into_iter().map(|p| p.to_string()).collect::<Vec<String>>().join(",").to_string())]),
        };
    }
    if let Some(ref local_var_str) = web_hook_url {
        local_var_req_builder = local_var_req_builder.query(&[("webHookUrl", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_str) = embedding_model {
        local_var_req_builder = local_var_req_builder.query(&[("embeddingModel", &local_var_str.to_string())]);
    }
    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    let mut local_var_form = reqwest::multipart::Form::new();
    // TODO: support file upload for 'files' parameter
    if let Some(local_var_param_value) = args {
        local_var_form = local_var_form.text("args", local_var_param_value.to_string());
    }
    if let Some(local_var_param_value) = tags {
        local_var_form = local_var_form.text("tags", local_var_param_value.to_string());
    }
    local_var_req_builder = local_var_req_builder.multipart(local_var_form);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchFileIngestionError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Get queue status for ingestion job
pub async fn semantic_search_ingestion_status(configuration: &configuration::Configuration, id: &str) -> Result<models::DataPipelineStatus, Error<SemanticSearchIngestionStatusError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/ingest/status", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    local_var_req_builder = local_var_req_builder.query(&[("id", &id.to_string())]);
    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchIngestionStatusError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// List - and filter - for ingested documents
pub async fn semantic_search_list(configuration: &configuration::Configuration, list_document_parameters: models::ListDocumentParameters) -> Result<models::ListDocumentResponse, Error<SemanticSearchListError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/list", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&list_document_parameters);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchListError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Query ingested documents using semantic search
pub async fn semantic_search_query(configuration: &configuration::Configuration, query_document_request: models::QueryDocumentRequest) -> Result<models::QueryDocumentResponse, Error<SemanticSearchQueryError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/query", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&query_document_request);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchQueryError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Perform k-means clustering over semantic search log entries
pub async fn semantic_search_query_results_clustering(configuration: &configuration::Configuration, semantic_search_query_results_clustering_request: models::SemanticSearchQueryResultsClusteringRequest) -> Result<models::KMeansCluster, Error<SemanticSearchQueryResultsClusteringError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/query-results-clustering", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&semantic_search_query_results_clustering_request);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchQueryResultsClusteringError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Rerank documents
pub async fn semantic_search_rerank(configuration: &configuration::Configuration, re_rank_documents_request: models::ReRankDocumentsRequest) -> Result<models::ReRankDocumentsResponse, Error<SemanticSearchRerankError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/semantic/rerank", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&re_rank_documents_request);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchRerankError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Import plain text into semantic search
pub async fn semantic_search_text_ingestion(configuration: &configuration::Configuration, ingest_text_document_request: models::IngestTextDocumentRequest) -> Result<models::IngestDocumentResponse, Error<SemanticSearchTextIngestionError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/ingest/text", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&ingest_text_document_request);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchTextIngestionError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Import web page text into semantic search
pub async fn semantic_search_webpage_ingestion(configuration: &configuration::Configuration, ingest_web_page_document_request: models::IngestWebPageDocumentRequest) -> Result<models::IngestDocumentResponse, Error<SemanticSearchWebpageIngestionError>> {
    let local_var_configuration = configuration;

    let local_var_client = &local_var_configuration.client;

    let local_var_uri_str = format!("{}/api/ingest/webpage", local_var_configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = local_var_configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    local_var_req_builder = local_var_req_builder.json(&ingest_web_page_document_request);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SemanticSearchWebpageIngestionError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}
