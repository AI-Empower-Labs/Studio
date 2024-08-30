# LLM Cache Integration Guide

This README file explains how to utilize the caching mechanism for LLM (Large Language Model) API calls, focusing on two types of caches: **Key-Value Cache** and **Semantic Cache**. Each type of cache offers different trade-offs in terms of speed, cost, and efficiency, and can be configured to optimize performance based on your application's needs.

## Cache Types

### 1. Key-Value Cache
- **Description:** This cache type is simple, fast, and cost-effective. It stores and retrieves exact matches based on the input key, resulting in minimal overhead.
- **Use Case:** Best suited for scenarios where exact input-output mappings are frequent and predictable.

### 2. Semantic Cache
- **Description:** The Semantic Cache is more advanced and slightly more expensive. It uses embedding models to determine the similarity between requests, allowing for intelligent matching even when the input is not identical.
- **Use Case:** Ideal for applications where requests might be semantically similar but not identical, reducing redundant LLM calls and improving response times.

## Configuration Options

Caching behavior can be configured globally in the `application.json` or overridden per request using the `extra_body` in the API call.

### Global Configuration (`application.json`)

- **CacheType:** 
  - *Optional*
  - Specifies the cache type: `KeyValue`, `Semantic`, or `NoCache`.
  - Example: `"CacheType": "KeyValue"`
  
- **CacheTimeToLive:** 
  - *Optional* Default is 5 minutes.
  - Defines the default duration for which the cache entry is valid. Accepts natural language input, e.g., `"5 minutes"`, `"1 hour"`.
  - Example: `"CacheTimeToLive": "1 minute"`

- **SemanticCacheMinimumRelevanceThreshold:** 
  - *Optional* Default is 0.95
  - Sets the minimum similarity threshold for semantic cache matching. The default value is `0.95`.
  - Example: `"SemanticCacheMinimumRelevanceThreshold": "0.95"`

- **CacheEmbeddingModelName:** 
  - *Optional*
  - Specifies the embedding model to use for semantic matching. If not provided, the system's default embedding model is used.
  - Example: `"CacheEmbeddingModelName": "E5"`

Here is an example configuration
```json
"AiStudioOptions": {
    "Llm": {
        "llama3": {
            ...,
            "CacheType": "Semantic",
            "CacheTimeToLive": "1 minute",
            "SemanticCacheMinimumRelevanceThreshold": "0.95",
            "CacheEmbeddingModelName": "E5"
        }
    }
}
```

### Per-Request Configuration (`extra_body` in API call)

These configurations can override the global settings for a specific request:

- **cache-type:** Corresponds to `CacheType`.
- **cache-ttl:** Corresponds to `CacheTimeToLive`.
- **cache-similarity-minimum-threshold:** Corresponds to `SemanticCacheMinimumRelevanceThreshold`.
- **cache-similarity-embedding-model:** Corresponds to `CacheEmbeddingModelName`.

**If both server configuration and request configurations are present, request configuration values will override server configuration values.**

### Example API Call with Cache Configuration

```bash
POST http://localhost:8080/api/openai/v1/chat/completions
Content-Type: application/json

{
    "model": "llama3",
    "messages": [
        {
            "role": "user",
            "content": "Write a limerick about the wonders of GPU computing."
        }
    ],
    "extra_body": {
        "cache-type": "semantic",
        "cache-ttl": "10 seconds",
        "cache-similarity-minimum-threshold": "0.9",
        "cache-similarity-embedding-model": "someModelName"
    }
}
```

### Response with Cache Hit

If the request hits the cache, the response includes the following headers:

- **`x-ael-cache-key`**: Specifies the cache key for the response.
- **`x-ael-cache-expires`**: Indicates the expiration date and time of the cache content in ISO8601 format.
- **`x-ael-cache-relevance`**: (Semantic Cache only) Shows the relevance score of the cached response, where `0` is the lowest and `1` is the highest.

```json
Content-Type: application/json; charset=utf-8
x-ael-cache-key: 2B9794715B05AF95033AEBE0546D1229D9E83298B3D57E69DCF2C7D3BEBEDD6A
x-ael-cache-expires: 2024-08-20T10:06:44.7623541+00:00
x-ael-cache-relevance: 1

{
  "id": "8b61924aa9de82dc-ARN",
  "object": "chat.completion",
  "created": 1724148395,
  "model": "meta-llama/meta-llama-3.1-8b-instruct-turbo",
  "prompt": [],
  "choices": [
    {
      "finish_reason": "eos",
      "seed": 1273641686262356000,
      "logprobs": null,
      "index": 0,
      "message": {
        "role": "assistant",
        "content": "Here is a limerick about GPUs:\n\nThere once was a GPU so fine,\nIt computed with speed and design.\nIt handled with ease,\nMassive data with expertise,\nAnd solved problems in no time divine."
      }
    }
  ],
  "usage": {
    "prompt_tokens": 22,
    "completion_tokens": 44,
    "total_tokens": 66
  }
}
```

### Cache Sessions
Notice that to enable "session" based caching, use the OpenAI compatible "user" property, and set the value to the current "session" / user. This will ensure cache uniqueness cross "session" / user.

Example:

```bash
POST http://localhost:8080/api/openai/v1/chat/completions
Content-Type: application/json

{
    "model": "llama3",
    "messages": [
        {
            "role": "user",
            "content": "Write a limerick about the wonders of GPU computing."
        },
        "user": "<sessionId> / <userId>"
    ],
    "extra_body": {
        "cache-type": "semantic"
    }
}
```

## Response Headers

For both cache types, specific headers are included in the response:

- **`x-ael-cache-key`:** The key used for the cached response, which can be used to manually invalidate the cache if necessary.
- **`x-ael-cache-expires`:** The expiration date and time of the cache entry.
- **`x-ael-cache-relevance`:** (For Semantic Cache only) Indicates how closely the cached response matches the request.

### Configuring Response Header Names

You can define the names of these headers in the `appsettings.json` using the following keys:

- **CacheResponseHeaderKey**: Default is `"x-ael-cache-key"`.
- **CacheResponseHeaderExpiresKey**: Default is `"x-ael-cache-expires"`.
- **CacheResponseHeaderRelevancyKey**: Default is `"x-ael-cache-relevance"`.

## Conclusion

Leveraging the caching mechanism for LLM calls can significantly enhance performance and reduce costs. Depending on your application's requirements, you can choose between the fast and inexpensive Key-Value Cache or the more intelligent and efficient Semantic Cache. By fine-tuning the cache settings both globally and per request, you can optimize your application's responsiveness and resource usage.
