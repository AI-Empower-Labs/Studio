# Running AI Empower Labs with Langfuse

See the minimal ./docker/minimal/README.md for reference

This guide provides instructions to run AI Empower Labs with Langfuse.

## Getting Started

### Prerequisites

Make sure you have Docker installed on your machine.

### Running the Application

To start the application, use the following command:

```sh
docker compose up -d
```

To stop the application, use:

```sh
docker compose stop
```

To remove the application, use:

```sh
docker compose down
```

### Setting Up Langfuse

1. Open your browser and navigate to [http://localhost:3100](http://localhost:3100).
2. Create a new user account and log in.
3. Create new project
4. Go to the Settings Menu and click on "Create new API keys".
5. Copy the generated API keys.

### Configuring the Application

1. Open the `.env` file in your project directory. If the file doesn't exist, create a new one or copy the included `.env.example` file.
2. Paste the copied API keys into the `.env` file.

### Restarting the Application

After updating the `.env` file, restart the application using:

```sh
docker compose up -d
```

You are now ready to use AI Empower Labs with Langfuse. Enjoy!

