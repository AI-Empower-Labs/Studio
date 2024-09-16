# AEL Studio Monitoring Guide

This document provides an overview of how monitoring works within AEL Studio, including the endpoints used for health checks, readiness, and liveness. It also covers how monitoring endpoints are configured and additional features like OpenTelemetry support for enterprise systems.

## Table of Contents
- [Health Check Endpoint](#health-check-endpoint)
- [Readiness Endpoint](#readiness-endpoint)
- [Liveness Endpoint](#liveness-endpoint)
- [Configuration of Monitoring Endpoints](#configuration-of-monitoring-endpoints)
- [Health Checks UI](#health-checks-ui)
- [OpenTelemetry Export Support](#opentelemetry-export-support)

## Health Check Endpoint

The main endpoint for extracting monitoring data is:

```
http://localhost:8080/healthz
```

This endpoint returns a JSON object that provides the health status of various services within AEL Studio. Here is an example response:

```json
{
    "status": "Healthy",
    "totalDuration": "00:00:00.0157338",
    "entries": {
        "Database": {
            "data": {},
            "duration": "00:00:00.0013644",
            "status": "Healthy",
            "tags": []
        },
        "Embedding DNS - localhost": {
            "data": {},
            "duration": "00:00:00.0000097",
            "status": "Healthy",
            "tags": ["ready"]
        },
        "Embedding TCP - localhost - Port: 8080": {
            "data": {},
            "duration": "00:00:00.0013968",
            "status": "Healthy",
            "tags": ["ready"]
        },
        "LLM DNS - <inference endpoint>": {
            "data": {},
            "duration": "00:00:00.0000103",
            "status": "Healthy",
            "tags": ["ready"]
        },
        "LLM TCP - <inference endpoint> - Port: 443": {
            "data": {},
            "duration": "00:00:00.0156274",
            "status": "Healthy",
            "tags": ["ready"]
        }
    }
}
```

This output provides:
- Overall health status.
- Total time taken to perform health checks.
- Health status of individual components, including databases, embedding services, and LLMs.

## Readiness Endpoint

The readiness endpoint is used to check if the application is ready to accept traffic. Readiness checks are often performed before routing traffic to a service, especially during startup or deployments.

```
http://localhost:8080/readiness
```

A service is "ready" when all its dependencies (databases, external services, etc.) are in a healthy state and the service itself is fully initialized. Readiness checks help prevent routing requests to a service that isn't fully operational yet.

## Liveness Endpoint

The liveness endpoint is used to check if the application is running and able to respond. Unlike readiness checks, liveness checks do not depend on the health of external services. They are used to determine if a service instance needs to be restarted.

```
http://localhost:8080/readiness
```

A service is considered "live" if it can respond to this endpoint, indicating that the application is not in a failed state. This check is crucial for self-healing in container orchestration systems like Kubernetes.

## Configuration of Monitoring Endpoints

Monitoring endpoints for Language Model (LLM) and Embedding services are configured via the `HealthCheckAddress` property in the configuration file. Here is an example configuration:

```json
"AiStudioOptions": {
    "Llm": {
        "llama3": {
            "Default": "true",
            "Address": "https://<inference_endpoint>/v1/chat/completions",
            "HealthCheckAddress": "https://<inference_endpoint>"
        },
        ...
    },
    "Embedding": {
        "intfloat/multilingual-e5-large-instruct": {
            "Default": "true",
            "Address": "http://<embedding_service>:8080/embeddings",
            "HealthCheckAddress": "http://<embedding_service>:8080"
        }
    }
}
```

The `HealthCheckAddress` is the endpoint used by AEL Studio to perform health checks on external services like LLMs and Embedding services. Each service has its own configuration block, where you specify the health check address.

## Health Checks UI

AEL Studio provides a UI for visualizing health check data at:

```
http://localhost:8080/healthchecks-ui
```

This endpoint offers a graphical representation of the data returned by the `/healthz` endpoint. Additionally, it provides a historical record of the service availability, helping with long-term monitoring and diagnostics.

## OpenTelemetry Export Support

AEL Studio supports OpenTelemetry for exporting monitoring data to enterprise systems. This is facilitated via the well-known environment variable:

```
OTEL_EXPORTER_OTLP_ENDPOINT
```

To see an example configuration, visit the [telemetry example in the repository](https://github.com/AI-Empower-Labs/Studio/tree/main/docker/telemetry).

---

By using these monitoring features, you can effectively track the health and status of various services within AEL Studio, ensuring smooth and reliable operation.