# Copilot Installation Guide

This guide provides instructions for running Copilot in Docker on Linux or macOS.

## Requirements

To set up and run Copilot, the following tools are required:

- [Git](https://git-scm.com/)
- [Docker and docker compose](https://www.docker.com/)

## Installation Steps

*. Clone the repository:
   ```sh
   git clone https://github.com/AI-Empower-Labs/Studio
   ```
*. Navigate to the Copilot docker directory (ensure you are in the correct repository folder):
   ```sh
   cd ./Studio/Copilot/docker
   ```
*. Copy the `.env` example file and modify it as needed:
   ```sh
   cp .env.example .env
   ```
*. Copy the `env.example` file for the web API and modify it as needed:
   ```sh
   cp ./webapi/.env.example ./webapi/.env
   ```
*. Edit the `env.example` file for the web API and modify it as needed. For example
   ```sh
   nano ./webapi/.env
   ```
   For example modify the Studio server endpoint by adding this line and changind the url to a predefined known endpoint:
   ```
   AIEmpowerLabs__Url=https://<url>
   ```

*. Build the Docker containers(Ensure Docker is running before building the containers):
   ```sh
   docker compose build
   ```
*. Start the containers:
   ```sh
   docker compose up
   ```

Now, your Copilot should be up and running!
Allow for some time to get the applications started up depending of the speed opf your system, then navigate to http://localhost:3000 .

![Copilot](./CoPilot.png)

## Troubleshooting

If you encounter issues, here are some common troubleshooting steps:

- **Connectivity Problems**: Ensure all required ports are open and that Docker has internet access.
- **Missing Environment Variables**: Double-check that all required environment variables are properly set in the `.env` files.
- **Container Failing to Start**: Review the logs using `docker compose logs` to identify any issues during startup.


