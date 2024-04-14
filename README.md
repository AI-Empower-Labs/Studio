# Ai Empowerlabs Studio Open Source

## Prerequisites

- Docker: [Install Docker](https://docs.docker.com/get-docker/)
- Docker Compose: [Install Docker Compose](https://docs.docker.com/compose/install/)

## Installation

Clone the repository:

```bash
git clone https://github.com/AI-Empower-Labs/Studio
cd ./docker/minimum

```

#### Using Docker Compose

This section is key and should provide detailed instructions on how to use Docker Compose to start the system.

## Starting the System with Docker Compose

### Run the Services
To start all services defined in the docker-compose.yml file:
```bash
docker-compose up
```

Start Studio UI on http://localhost:8080

To run in detached mode, use the -d flag:
```bash
docker-compose logs
```

To follow logs for a specific service:
```bash
docker-compose logs -f service_name
```

To stop all services:
```bash
docker-compose down
```

### Docker Image List
* registry.aiempowerlabs.com/aistudio
* registry.aiempowerlabs.com/phi2
* registry.aiempowerlabs.com/translation
* registry.aiempowerlabs.com/transcription
* registry.aiempowerlabs.com/multilingual-e5-large
