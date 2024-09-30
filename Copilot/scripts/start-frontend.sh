#!/usr/bin/env bash

# Builds and runs the Chat Copilot frontend.

set -e

export REACT_APP_BACKEND_URI=https://localhost:40443
SCRIPT_DIRECTORY="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIRECTORY/../webapp"

# Build and run the frontend application
yarn install && yarn start
