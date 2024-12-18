# AI Empowerlabs Studio Open Source

## Prerequisites

- Docker: [Install Docker](https://docs.docker.com/get-docker/)
- Docker Compose: [Install Docker Compose](https://docs.docker.com/compose/install/)
- Windows or linux, will not work on OSX

## Installation

Clone the repository:

```bash
git clone https://github.com/AI-Empower-Labs/Studio
cd ./Studio/docker/minimum
```

#### Using Docker Compose

This section is key and should provide detailed instructions on how to use Docker Compose to start the system.

## Starting the System with Docker Compose

### Run the Services
Notice, this example run on CPU only, so LLM inference may be slow. See [GPU](#GPU) section on how to run with GPU if available.
To start all services defined in the docker-compose.yml file:
```bash
docker compose pull
docker compose up
```

Start Studio UI on http://localhost:8080

To run in detached mode, use the -d flag:
```bash
docker compose logs
```

To follow logs for a specific service:
```bash
docker compose logs -f service_name
```

To stop all services:
```bash
docker compose down
```

### Docker Image List
* registry.aiempowerlabs.com/aistudio
* registry.aiempowerlabs.com/llama3
* registry.aiempowerlabs.com/translation
* registry.aiempowerlabs.com/transcription
* registry.aiempowerlabs.com/multilingual-e5-large

## GPU

### Technical Documentation: AI Empowerlabs Local Hosting

#### Overview

AI Empowerlabs offers flexible hosting solutions for Large Language Models (LLMs) using Docker images based on ollama specifications. This document provides guidelines for local hosting and configuring GPU support when using custom models.

#### Local Hosting Using Docker Images Based on ollama

- **Service Provider**: ollama Specifications
- **Resource**: Docker images based on ollama
- **Usage**: For deployment of LLMs, AI Empowerlabs uses Docker images developed based on ollama specifications. These images facilitate quick setup and reliable performance tailored to ollama's standards.

#### Configuring GPU Support for LLM Hosting

- **Reference Guide**: [ollama GPU Acceleration](https://docs.docker.com/desktop/gpu/) & NVidia - https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/docker-specialized.html
- **Details**: To optimize the performance of LLM hosting, particularly with custom models, configuring GPU support is recommended. Detailed instructions and configurations can be accessed on the ollama GPU acceleration page linked above.

#### Compatibility and Custom Model Integration

- **Compatibility**: AI Empowerlabs supports any OpenAI compatible endpoints.
- **Custom Model Creation**: Users can create their own custom models that adhere to OpenAI specifications. For instance, models based on ollama can be integrated seamlessly.

For additional information on custom model integration and other advanced configurations, users are encouraged to refer to the specific documentation provided by ollama or contact AI Empowerlabs support.


# AI Empowerlabs Studio configuration - appsettings.json

### Customizing the `appsettings.json` for AI Application Configuration

The `appsettings.json` file serves as a central configuration file for settings in an AI Empowerlabs Studio. Here are guidelines on how to create a new configuration or customize the existing settings specifically for an AI application.

#### Sections in `appsettings.json`

1. **ConnectionStrings**
2. **AiStudioOptions**
3. **KernelMemory**
4. **Serilog**
5. **Columns**

### 1. ConnectionStrings

- **Purpose**: Manages database and external service connections.
- **Includes**: PostgreSQL database and an external API.

**To customize**:
- **Postgres**: Update credentials and host details.
- **libraTranslate**: Change the URL if using a different service.

```json
"ConnectionStrings": {
    "postgres": "Host=myhost;Port=5432;User Id=myuser;Database=mydb;Password=mypassword",
    "libraTranslate": "http://api.example.com"
}
```

### 2. AiStudioOptions

This section configures and manages the integration of various AI models and services. Each subsection here represents a specific AI capability or service, and adjusting these settings allows you to tailor the AI functionalities to meet specific needs.

#### LicenceKey
- **Purpose**: This key is used to validate your license for using specific AI services or models.
- **Customization**: Replace the existing key with your new license key if it has been updated or changed.

```json
"AiStudioOptions": {
    "LicenceKey": "Your_New_License_Key_Here"
}
```

#### Llm (Large Language Models)
This subsection configures the settings for various large language models used in your application.

- **Models**: Configuration options for multiple models like `phi-2`, `llama2-70b-4096`, `mixtral-8x7b-32768`, etc.
- **Attributes**:
  - **Default**: Specifies if the model is the default choice for operations.
  - **Address**: API endpoint for the model.
  - **AuthorizationToken**: Security token for accessing the model API.
  - **ContextSize**: Defines the maximum context size (in tokens) that the model can handle.
  - **DisplayName**: A friendly name for the model used for identification in logs or user interfaces.
  - **SupportsChatCompletionsResponseFormat**: Indicates if the model supports a specific response format for chat completions.

**To customize**:
Select the model and update its attributes according to your operational requirements or credentials update.

```json
"AiStudioOptions": {
    "Llm": {
        "llama3": {
            "Default": "false",
            "Address": "https://<dns>/v1/chat/completions",
            "AuthorizationToken": "<authToken>",
            "ContextSize": "32768",
            "DisplayName": "llama3.1 8b",
            "ModelName": "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo",
            "EmulateFunctionCalling": true,
            "Tokenizer": "llama"
        }
    }
}
```

#### Tokenizer Options
The Tokenizer value in the configuration can be set to one of the following supported tokenizer types, depending on the specific model or service you intend to use:

```
XlmRobertaBase
llama
mistral
mxbai-embed-large-v1
gpt-4o
gpt-4
gpt-3.5-turbo
gpt-3.5-turbo-16k
gpt-35
gpt-35-turbo
gpt-35-turbo-16k
text-davinci-003
text-davinci-002
text-davinci-001
text-curie-001
text-babbage-001
text-ada-001
davinci
curie
babbage
ada
code-davinci-002
code-davinci-001
code-cushman-002
code-cushman-001
davinci-codex
cushman-codex
text-davinci-edit-001
code-davinci-edit-001
text-embedding-ada-002
text-embedding-3-small
text-embedding-3-large
text-similarity-davinci-001
text-similarity-curie-001
text-similarity-babbage-001
text-similarity-ada-001
text-search-davinci-doc-001
text-search-curie-doc-001
text-search-babbage-doc-001
text-search-ada-doc-001
code-search-babbage-code-001
code-search-ada-code-001
gpt2
```

#### Embedding
Manages the embedding models for transforming text into numerical vectors, which are useful in various machine learning and AI tasks.

- **Models** such as `multilingual-e5-large`, `mxbai-embed-large-v1`, etc.
- **Attributes**:
  - **Default**: Indicates if this is the default embedding model.
  - **Type**: The type or source of the embedding model.
  - **Address**: API endpoint for accessing the model.
  - **MaxTokens**: Maximum number of tokens that the model can process in one request.
  - **Dimensions**: The dimensionality of the embeddings generated.

**To customize**:
Modify properties such as `MaxTokens` or `Dimensions` to tune the model's performance according to your requirements.

```json
"AiStudioOptions": {
    "Embedding": {
        "multilingual-e5-large": {
            "Default": true,
            "Address": "http://127.0.0.1:3000",
            "MaxTokens": "512",
            "Dimensions": "1024",
            "DisplayName": "multilingual-e5-large",
            "Tokenizer": "XlmRobertaBase"
        }
    }
}
```

#### Transcription
Configures transcription services that convert speech to text.

- **Default**: Whether this service is selected by default.
- **Address**: API endpoint for the transcription service.

**To customize**:
Update the `Address` to point to a new transcription service if changed.

```json
"AiStudioOptions": {
    "Transcription": {
        "AiEmpowerLabs": {
            "Default": "true",
            "Address": "http://new_transcription_service.example.com"
        }
    }
}
```

### SemanticSearchLogDbRetentionTime
The SemanticSearchLogDbRetentionTime property configures the retention period for the Semantic Search query logs. This setting determines how long the query logs are stored before being automatically deleted.

Type: Duration, optional
Accepted Values:
A duration of time, such as 10 days, 10.00:00:00, or 365 days. If not specified, the system will not remove logs.
```json
"AiStudioOptions": {
    "SemanticSearchLogDbRetentionTime": "31 days"
}
```



### Saving and Applying Changes

After editing the `appsettings.json` with the new configurations, save the file and ensure to restart your ASP.NET application to apply the changes. It's crucial to validate the settings for correctness to prevent any disruptions in the functionality of your application.

### 3. [KernelMemory](https://github.com/microsoft/kernel-memory)

### Customizing the `appsettings.json` for AI Application Configuration

The `KernelMemory` section of the `appsettings.json` file is essential for defining and managing the data processing, ingestion, retrieval, and storage strategies of your AI application. This section controls how data is handled throughout its lifecycle in the application, from initial ingestion to retrieval for AI processes.

#### Detailed Guide to Customizing `KernelMemory`

### 3. KernelMemory

The `KernelMemory` subsections allow for detailed control over various stages of data management. Here’s how you can tailor each to better fit the operational needs of your AI systems.

#### DataIngestion

- **Purpose**: Configures the steps and parameters for initial data processing workflows.
- **DefaultSteps**: Lists the sequential operations applied to data as it is ingested.
- **TextPartitioning**: Controls how text data is segmented into manageable parts.

**To customize**:

1. **DefaultSteps**: Modify this array to include or exclude steps such as 'extract', 'sanitize', etc., depending on your data processing requirements.

2. **TextPartitioning**: Adjust settings like `MaxTokensPerParagraph`, `MaxTokensPerLine`, and `OverlappingTokens` to optimize how text data is broken down.

```json
"KernelMemory": {
    "DataIngestion": {
        "DefaultSteps": ["extract", "sanitize", "transform", "save_records"],
        "TextPartitioning": {
            "MaxTokensPerParagraph": 1000,
            "MaxTokensPerLine": 250,
            "OverlappingTokens": 100
        }
    }
}
```

#### Retrieval

- **Purpose**: Defines how data is retrieved for use in AI tasks, specifically in generating responses from large language models.
- **SearchClient**: Customizes the behavior of the retrieval system in terms of prompt size, matches count, and the tokens reserved for answers.

**To customize**:

- **MaxAskPromptSize**: Set the maximum number of tokens for the query prompts.
- **MaxMatchesCount**: Define the upper limit of data points to consider for generating a response.
- **AnswerTokens**: Specify how many tokens should be reserved for the answers, influencing the length and detail of responses.
- **EmptyAnswer**: Customize the response when no suitable answer can be generated.

```json
"KernelMemory": {
    "Retrieval": {
        "SearchClient": {
            "MaxAskPromptSize": 5000,
            "MaxMatchesCount": 50,
            "AnswerTokens": 400,
            "EmptyAnswer": "No relevant information available."
        }
    }
}
```

### 3. [Serilog](https://github.com/serilog/serilog)

Configures logging via Serilog.

**To customize**:
- **MinimumLevel**: Adjust log levels.
- **WriteTo**: Modify outputs (e.g., Console, PostgreSQL).

```json
"Serilog": {
    "MinimumLevel": {
        "Default": "Warning"
    },
    "WriteTo": [
        {
            "Name": "Console",
            "Args": {
                "restrictedToMinimumLevel": "Error"
            }
        }
    ]
}
```

### Saving and Applying Changes

After making changes to the `appsettings.json`, save the file and restart your ASP.NET application to apply these adjustments. It is essential to validate the settings to prevent configuration errors that could disrupt the operation of your application.
