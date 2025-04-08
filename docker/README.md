# AI Empowerlabs Studio Docker Compose Setup

This repository contains two Docker Compose files for running the **AI Studio** application with support for **telemetry and observability**.

- [`compose.base.yaml`](#composebaseyaml): Launches core AI Studio services (application, databases, embedding, and LLMs).
- [`compose.telemetry.yaml`](#composetelemetryyaml): Adds support for tracing, logging, metrics, and dashboards for observability and debugging.

> **⚠️ First Startup Warning:**  
> The first time you start these services, especially `llama3` and `embedding`, it may take a long time as they **download large AI models**. Please be patient during this process.

---

## 📦 Services Overview

### 🔹 compose.base.yaml

This file sets up all essential services for AI Studio.

| Service     | Description |
|-------------|-------------|
| **aistudio** | Main application server exposed at `http://localhost:8080`. Depends on Redis, Postgres, Embedding, and LLM. |
| **redis**    | In-memory key-value store using ValKey (drop-in Redis replacement) for fast caching. |
| **postgres** | PostgreSQL database with pgvector support for vector operations. |
| **llama3**   | LLM runtime via [Ollama](https://ollama.com/). Downloads and runs `llama3.1`. |
| **embedding**| Embedding and reranking service using `mixedbread-ai` models via `infinity`. |

> Models are stored persistently in the `models` volume. Postgres data is stored in the `pgdata` volume.

---

### 🔹 compose.telemetry.yaml

This file **extends `compose.base.yaml`** and adds telemetry and observability tools for debugging and performance monitoring.

| Service    | Description |
|------------|-------------|
| **collector** | OpenTelemetry Collector. Central hub that receives OTLP traces, logs, and metrics and forwards them to exporters. |
| **seq**       | Log aggregation and visualization. Web UI at [http://localhost:8090](http://localhost:8090). |
| **jaeger**    | Distributed tracing system. UI at [http://localhost:16686](http://localhost:16686). |
| **zipkin**    | Alternative tracing backend. UI at [http://localhost:9411](http://localhost:9411). |
| **prometheus**| Metrics scraping service. Scrapes `collector` and displays data. |
| **grafana**   | Metrics dashboards. Web UI at [http://localhost:3000](http://localhost:3000). Anonymous access is enabled. |
| **aspire**    | Microsoft Aspire Dashboard for .NET observability at [http://localhost:18888](http://localhost:18888). |

> All telemetry services are connected to the internal network (`ai_internal`) and exposed publicly for access.

---

## 🚀 How to Use

### Step 1: Start Base Services

Start essential AI Studio services:

```bash
docker compose -f compose.base.yaml up -d
```

Wait until:
- `aistudio` reports healthy (`http://localhost:8080/liveness`)
- LLM models are downloaded
- Embedding service finishes initializing

> Check logs using `docker compose logs -f` to monitor progress.

---

### Step 2: (Optional) Start Telemetry Services

To enable observability tools, run:

```bash
docker compose -f compose.telemetry.yaml up -d
```

Ensure `compose.base.yaml` is already running before this.

---

## 🧠 Application Configuration

The application uses `appsettings.json` for runtime configuration, including:

- **Database & Cache**: Connections to Postgres and Redis
- **LLMs**: Uses `llama3.1` served by Ollama
- **Embeddings**: Provided by `mxbai-embed-large-v1` and reranker
- **Text Ingestion Pipeline**: Token limits, steps, etc.
- **Logging**: Uses Serilog with debug level for the app

These values are mounted via Docker configs for easier management.

---

## 🧰 Developer Tips

- Use `docker compose ps` to check container status
- Use `docker compose logs <service>` to view service logs
- Healthchecks help ensure dependent services are ready
- `ollama pull llama3.1` runs on first container boot and might take **minutes** based on your network

---

## 📁 Volumes

| Volume     | Purpose |
|------------|---------|
| `models`   | Stores downloaded models (LLMs and embedding caches) |
| `pgdata`   | PostgreSQL persistent data |

---

## 📡 Network

Two networks are defined:
- `ai_internal`: Used for internal communication between containers
- `ai_public`: Used for exposing UI dashboards and app endpoints

---

## 📋 Telemetry Exports

Traces, logs, and metrics are exported from the app using OTLP to the OpenTelemetry Collector, which then forwards them to:
- Jaeger, Zipkin (traces)
- Seq (logs)
- Prometheus, Grafana, Aspire (metrics and dashboarding)

---

## 📊 Dashboards and Interfaces

| Tool     | URL                          |
|----------|------------------------------|
| App      | [http://localhost:8080](http://localhost:8080) |
| Grafana  | [http://localhost:3000](http://localhost:3000) |
| Seq      | [http://localhost:8090](http://localhost:8090) |
| Jaeger   | [http://localhost:16686](http://localhost:16686) |
| Zipkin   | [http://localhost:9411](http://localhost:9411) |
| Aspire   | [http://localhost:18888](http://localhost:18888) |

---

## 📎 Requirements

- Docker Engine 20.10+
- Docker Compose v2.5+
- At least 16GB RAM recommended
- Fast internet for initial model downloads

---

## 📄 License

MIT © AI Empower Labs
