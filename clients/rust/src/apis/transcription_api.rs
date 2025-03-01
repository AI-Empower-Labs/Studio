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
use serde::{Deserialize, Serialize, de::Error as _};
use crate::{apis::ResponseContent, models};
use super::{Error, configuration, ContentType};


/// struct for typed errors of method [`transcription_asynchronous`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum TranscriptionAsynchronousError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method [`transcription_get_by_id`]
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum TranscriptionGetByIdError {
    Status400(models::HttpValidationProblemDetails),
    Status429(models::ProblemDetails),
    Status500(models::ProblemDetails),
    UnknownValue(serde_json::Value),
}


/// This service is designed to convert spoken words from audio or video files into written text, utilizing sophisticated speech recognition algorithms for accurate transcription. It offers a range of features that cater to various needs and use cases, making it particularly valuable for journalists, researchers, podcasters, and professionals dealing with meetings, interviews, lectures, or presentations.  ### Key features and capabilities include:  * Support for Various File Formats: Accepts a wide range of audio and video file formats, ensuring flexibility in file uploads. * Advanced Processing Steps: Incorporates noise reduction, speaker diarization, and speech-to-text conversion for clear and differentiated transcriptions. * Asynchronous Background Processing: Allows for non-blocking, efficient handling of transcription tasks, suitable for large files or batches of files. * Webhook Callback URL: Offers real-time updates on the transcription process via a provided webhook, enabling immediate reaction to task completion or failure. * /api/transcribe GET Endpoint: Provides an alternative for users to manually check the status of their transcription requests, allowing flexibility in monitoring. * Automatic Text Translation Feature: An optional service that translates the transcribed text into a specified target language, enhancing the utility for multi-lingual contexts. * Multi-File and Multi-Channel Support: Supports concurrent file uploads and accurate transcription of multi-channel recordings, ideal for complex audio environments. * The transcription output is meticulously formatted to clearly distinguish between channels and speakers, including timestamps and labels for easy navigation and reference. This structured approach ensures that even in challenging audio environments with multiple speakers or channels, the transcription service can provide clear, accurate, and useful text representations of the spoken content.  This service integrates into applications via API calls, offering developers a powerful tool to enhance their applications with audio-to-text conversion capabilities. The inclusion of features like language detection, support for multiple languages, and customization options for specific vocabulary or industry terms further extends its applicability across various domains and industries.
pub async fn transcription_asynchronous(configuration: &configuration::Configuration, files: Vec<std::path::PathBuf>, model: Option<&str>, language: Option<&str>, prompt: Option<&str>, temperature: Option<f64>, web_hook_url: Option<&str>, translate_to: Option<&str>, split_on_word: Option<bool>, language_detection: Option<bool>, enable_noise_reduction: Option<bool>) -> Result<models::TranscriptionAudioUploadResult, Error<TranscriptionAsynchronousError>> {
    // add a prefix to parameters to efficiently prevent name collisions
    let p_files = files;
    let p_model = model;
    let p_language = language;
    let p_prompt = prompt;
    let p_temperature = temperature;
    let p_web_hook_url = web_hook_url;
    let p_translate_to = translate_to;
    let p_split_on_word = split_on_word;
    let p_language_detection = language_detection;
    let p_enable_noise_reduction = enable_noise_reduction;

    let uri_str = format!("{}/api/transcribe/upload", configuration.base_path);
    let mut req_builder = configuration.client.request(reqwest::Method::POST, &uri_str);

    if let Some(ref param_value) = p_model {
        req_builder = req_builder.query(&[("model", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_language {
        req_builder = req_builder.query(&[("language", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_prompt {
        req_builder = req_builder.query(&[("prompt", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_temperature {
        req_builder = req_builder.query(&[("temperature", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_web_hook_url {
        req_builder = req_builder.query(&[("webHookUrl", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_translate_to {
        req_builder = req_builder.query(&[("translateTo", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_split_on_word {
        req_builder = req_builder.query(&[("splitOnWord", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_language_detection {
        req_builder = req_builder.query(&[("languageDetection", &param_value.to_string())]);
    }
    if let Some(ref param_value) = p_enable_noise_reduction {
        req_builder = req_builder.query(&[("enableNoiseReduction", &param_value.to_string())]);
    }
    if let Some(ref user_agent) = configuration.user_agent {
        req_builder = req_builder.header(reqwest::header::USER_AGENT, user_agent.clone());
    }
    let mut multipart_form = reqwest::multipart::Form::new();
    // TODO: support file upload for 'files' parameter
    req_builder = req_builder.multipart(multipart_form);

    let req = req_builder.build()?;
    let resp = configuration.client.execute(req).await?;

    let status = resp.status();
    let content_type = resp
        .headers()
        .get("content-type")
        .and_then(|v| v.to_str().ok())
        .unwrap_or("application/octet-stream");
    let content_type = super::ContentType::from(content_type);

    if !status.is_client_error() && !status.is_server_error() {
        let content = resp.text().await?;
        match content_type {
            ContentType::Json => serde_json::from_str(&content).map_err(Error::from),
            ContentType::Text => return Err(Error::from(serde_json::Error::custom("Received `text/plain` content type response that cannot be converted to `models::TranscriptionAudioUploadResult`"))),
            ContentType::Unsupported(unknown_type) => return Err(Error::from(serde_json::Error::custom(format!("Received `{unknown_type}` content type response that cannot be converted to `models::TranscriptionAudioUploadResult`")))),
        }
    } else {
        let content = resp.text().await?;
        let entity: Option<TranscriptionAsynchronousError> = serde_json::from_str(&content).ok();
        Err(Error::ResponseError(ResponseContent { status, content, entity }))
    }
}

/// The /api/transcribe GET endpoint is a crucial component of the audio transcription service, designed to offer users a way to check the status of their transcription requests. This endpoint caters to the needs of users who prefer polling to monitor their requests over relying on webhook callbacks for real-time updates. Here's a detailed description of its functionality and how it integrates within the service:  ### Purpose and Functionality The primary purpose of the /api/transcribe GET endpoint is to provide users with the ability to manually inquire about the current status of their audio or video file transcription tasks. This endpoint supports a polling mechanism, where users can send a GET request at their convenience to receive the latest update on their transcription process.  ### How It Works Request: To utilize this endpoint, users initiate a GET request, including a unique identifier for the transcription task as a parameter. This identifier is provided by the service when the transcription request is first submitted. Response: In response to the GET request, the endpoint returns data about the transcription task's status. The response indicate that the transcription is still processing, has been completed, or has failed.  ### Response Details The response from the /api/transcribe GET endpoint includes several pieces of information that are crucial for users to understand the status and outcome of their transcription requests:  Status: Indicates the current state of the transcription task (e.g., Queued, Completed, Failed). Completion Details: If the transcription is completed, the response include details the resulting transcript.  ### Use Cases This endpoint is particularly useful for scenarios where users need or prefer to periodically check the status of their requests rather than implement real-time update mechanisms via webhooks. It provides flexibility in handling transcription tasks, allowing users to:  ### Advantages The /api/transcribe GET endpoint offers several advantages, including simplicity in implementation, flexibility in usage, and the ability to integrate easily into various application workflows. It provides a straightforward method for users to remain informed about their transcription tasks without the need for complex callback systems, making it an essential feature for many applications and services requiring transcription capabilities.
pub async fn transcription_get_by_id(configuration: &configuration::Configuration, id: &str) -> Result<(), Error<TranscriptionGetByIdError>> {
    // add a prefix to parameters to efficiently prevent name collisions
    let p_id = id;

    let uri_str = format!("{}/api/transcribe", configuration.base_path);
    let mut req_builder = configuration.client.request(reqwest::Method::GET, &uri_str);

    req_builder = req_builder.query(&[("id", &p_id.to_string())]);
    if let Some(ref user_agent) = configuration.user_agent {
        req_builder = req_builder.header(reqwest::header::USER_AGENT, user_agent.clone());
    }

    let req = req_builder.build()?;
    let resp = configuration.client.execute(req).await?;

    let status = resp.status();

    if !status.is_client_error() && !status.is_server_error() {
        Ok(())
    } else {
        let content = resp.text().await?;
        let entity: Option<TranscriptionGetByIdError> = serde_json::from_str(&content).ok();
        Err(Error::ResponseError(ResponseContent { status, content, entity }))
    }
}

