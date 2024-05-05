# AI Empower Labs Project

This Docker Compose configuration sets up a comprehensive infrastructure for AI Empower Labs, featuring multiple services integrated with OpenTelemetry for observability. The setup includes services for application hosting, databases, translation, transcription, embedding, and more, with extensive monitoring through tools like Prometheus, Grafana, Jaeger, and Zipkin.

## Prerequisites

Before deploying the services, ensure you have:
- Docker installed
- Docker Compose installed

## Services Overview

- **Application Host (`host`)**: Runs the main application using the latest AI Studio image, with configuration and logging settings.
- **PostgreSQL (`postgres`)**: Utilizes an image with pgvector extension for database operations.
- **Translation, Transcription, and Embedding Services**: These services handle specific AI tasks and are configured for high availability and monitoring.
- **Large Language Model (`llama3`)**: Manages GPU-accelerated tasks for large model processing.
- **OpenTelemetry Collector (`collector`)**: Aggregates and forwards telemetry data to various monitoring tools.
- **Monitoring Tools (`seq`, `jaeger`, `zipkin`, `prometheus`, `grafana`)**: Provides a suite of tools for logging, tracing, and monitoring the services.

## Configuration

### Logging

Logging configuration is centralized using Docker Compose file anchors, facilitating easy management of log rotation and file limits across all services.

### Environment Variables

Common environment variables are managed under the `x-defaults` section, including the endpoint for the OpenTelemetry collector.

### Networks

Services are connected to either internal or public networks, ensuring appropriate visibility and security.

## Running the Project

To deploy the services:

1. Clone the repository:
   ```bash
   git clone https://github.com/AI-Empower-Labs/Studio
   ```

2. Navigate to the directory containing `docker-compose.yml`.

3. Run the following command to start all services:
   ```bash
   docker-compose up -d
   ```

4. Monitor the services using the logs:
   ```bash
   docker-compose logs -f
   ```

## Stopping the Services

To stop all services, run:
```bash
docker-compose down
```

## Additional Information

For detailed service configuration and troubleshooting, refer to the respective documentation of each used Docker image and OpenTelemetry setup guidelines.

## Accessing and Testing Monitoring Services

This project includes comprehensive monitoring solutions that can be accessed through web interfaces. Below are the details on how to access each service and basic steps to verify that they are functioning correctly.

### Seq

Seq is a log management system that ingests structured log data and allows for powerful querying.

- **Access**: Navigate to `http://localhost:8090` in your web browser.
- **Test**: Check if the dashboard is loading and displaying logs. You can send a test log entry from any service configured to use Seq to see it appear in the Seq dashboard.

### Jaeger

Jaeger is used for tracing requests as they flow through the various services to discover performance bottlenecks.

- **Access**: Navigate to `http://localhost:16686` in your web browser.
- **Test**: Perform a few actions in your application that trigger service interactions and check if the traces appear in Jaeger's dashboard.

### Zipkin

Zipkin is another distributed tracing system that helps gather timing data needed to troubleshoot latency problems.

- **Access**: Navigate to `http://localhost:9411` in your web browser.
- **Test**: Similar to Jaeger, after generating some activity in your application, you should see the traces in Zipkin's dashboard.

### Prometheus

Prometheus is a monitoring system and time series database that is particularly good at collecting and processing metrics.

- **Access**: Navigate to `http://localhost:9090` in your web browser.
- **Test**: Check the Prometheus dashboard to see if metrics are being collected. You can execute a simple query (e.g., `up` or `process_cpu_seconds_total`) to see the metrics from different services.

### Grafana

Grafana allows you to query, visualize, alert on, and understand your metrics no matter where they are stored.

- **Access**: Navigate to `http://localhost:3000` in your web browser. Default login credentials are typically admin/admin unless configured otherwise.
- **Test**: Once logged in, navigate to the dashboard section to view the pre-configured dashboards. These should display metrics gathered from Prometheus and logs from Seq if configured correctly.

## Verifying the Setup

To ensure that all services are communicating correctly:
1. Generate some traffic or perform operations that trigger logging, metric collection, and tracing.
2. Verify that corresponding entries appear in Seq, metrics in Prometheus are updated, and traces are visible in both Jaeger and Zipkin.
3. Check Grafana to ensure that it can retrieve and display data from Prometheus and Seq.

By following these steps, you should be able to effectively monitor and troubleshoot your deployment using the tools provided in this Docker Compose setup.
