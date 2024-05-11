# AirByte / RabbitMQ and AI Empower Labs Integration sample

This sample explains how to integrate AirByte with RabbitMQ and leverage the NASA Astronomy Picture of the Day (APOD) API as a data source. The data will then be ingested into AI Empower Labs Studio for consumption.

## Prerequisites

### AirByte Installation
- Install AirByte from the official documentation: [Deploy AirByte](https://docs.airbyte.com/category/deploy-airbyte)

### NASA APOD Source Setup
- Setup the built-in NASA APOD source using `DEMO_KEY`, `start_date`, and `end_date` as configuration options.
  - Official Documentation: [NASA Integration](https://docs.airbyte.com/integrations/sources/nasa)
  - NASA APOD API GitHub Repository: [nasa/apod-api](https://github.com/nasa/apod-api)

### RabbitMQ Setup
- Run RabbitMQ using Docker:
  ```bash
  docker run -p 5672:5672 -d --hostname rabbit --name rabbit rabbitmq:3
  ```
- Setup the built-in RabbitMQ destination in AirByte:
  - [RabbitMQ Destination](https://docs.airbyte.com/integrations/destinations/rabbitmq)
  - Connection Details: Use port `5672`, no username/password required

## Running the Integration

### AI Empower Labs Configuration
- Ensure AI Empower Labs is running on `localhost` at port `8080`. See minimal example.

### Start Forwarder Script
- **Python Implementation**: 
  - Navigate to the `./python` directory and ensure dependencies in `requirements.txt` are installed.
  - Execute the script:
    ```bash
    python rabbit_forwarder.py
    ```

- **Dotnet Implementation**:
  - Ensure Dotnet 8 is installed.
  - Run the Dotnet C# project located in `./dotnet`:
    ```bash
    dotnet run --project rabbit_forwarder.csproj
    ```

## Execute Sync
- Start the data synchronization in AirByte and observe the NASA APOD explanations being ingested into AI Empower Labs Studio for analysis and use.
