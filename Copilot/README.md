******NOTE**: This is a **sample** application to help you understand how Semantic Kernel and AI can work in Web Applications. This sample is **NOT FOR PRODUCTION** deployments.

# Chat Copilot Sample Application

This sample allows you to build your own integrated large language model (LLM) chat copilot. The sample is built on Microsoft [Semantic Kernel](https://github.com/microsoft/semantic-kernel) and has three components:

1. A frontend application [React web app](./webapp/)
2. A backend REST API [.NET web API service](./webapi/)
3. A [.NET worker service](./memorypipeline/) for processing semantic memory.

These quick-start instructions run the sample locally. They can also be found on the official Chat Copilot Microsoft Learn documentation page for [getting started](https://learn.microsoft.com/semantic-kernel/chat-copilot/getting-started).

To deploy the sample to Azure, please view [Deploying Chat Copilot](./scripts/deploy/README.md) after meeting the [requirements](#requirements) described below.

> **IMPORTANT:** This sample is for educational purposes only and is not recommended for production deployments.

> **IMPORTANT:** Each chat interaction will call Azure OpenAI/OpenAI which will use tokens that you may be billed for.

![Chat Copilot answering a question](https://learn.microsoft.com/en-us/semantic-kernel/media/chat-copilot-in-action.gif)

# Requirements

You will need the following items to run the sample:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) _(via Setup install.\* script)_
- [Node.js](https://nodejs.org/en/download) _(via Setup install.\* script)_
- [Yarn](https://classic.yarnpkg.com/docs/install) _(via Setup install.\* script)_
- [Git](https://www.git-scm.com/downloads)
- AI Service (one of the following is required)

| AI Service   | Requirement                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| ------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Azure OpenAI | - [Access](https://aka.ms/oai/access)<br>- [Resource](https://learn.microsoft.com/azure/ai-services/openai/how-to/create-resource?pivots=web-portal#create-a-resource)<br>- [Deployed models](https://learn.microsoft.com/azure/ai-services/openai/how-to/create-resource?pivots=web-portal#deploy-a-model) (`gpt-35-turbo` and `text-embedding-ada-002`) <br>- [Endpoint](https://learn.microsoft.com/azure/ai-services/openai/tutorials/embeddings?tabs=command-line#retrieve-key-and-endpoint)<br>- [API key](https://learn.microsoft.com/azure/ai-services/openai/tutorials/embeddings?tabs=command-line#retrieve-key-and-endpoint) |
| OpenAI       | - [Account](https://platform.openai.com/docs/overview)<br>- [API key](https://platform.openai.com/api-keys)                                                                                                                                                                                                                                                                                   
## License

Copyright (c) Microsoft Corporation. All rights reserved.

Licensed under the [MIT](LICENSE) license.
