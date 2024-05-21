# AI Empower Labs Embedding Models

AI Empower Labs delivers two embedding models:

## Models

### 1. multilingual-e5-large
- **Hugging Face Link**: [multilingual-e5-large](https://huggingface.co/intfloat/multilingual-e5-large)
- **Docker Image**: `registry.aiempowerlabs.com/multilingual-e5-large:1.0.0`

### 2. mxbai-embed-large-v1
- **Hugging Face Link**: [mxbai-embed-large-v1](https://huggingface.co/mixedbread-ai/mxbai-embed-large-v1)
- **Docker Image**: `registry.aiempowerlabs.com/mxbai-embed-large-v1:1.0.0`

## Features

Both models are multilingual and support GPU acceleration using NVIDIA CUDA. GPU usage is optional but highly recommended for significant performance improvements. Each embedding instance supports only one GPU at a time. 

## Usage

### Specifying GPU
To specify which GPU to use, set the `CudaDevice` environment variable. For example, to use the first installed GPU device, use the following Docker parameter:
```
-e CudaDevice=0
```

### Enabling GPU Support

Ensure GPU support is enabled in your container provider (Docker/Podman).

### Checking GPU Presence

To check for GPU presence, use the following CLI command:
```
nvidia-smi
```

For more information on installing the NVIDIA Container Toolkit, visit the [NVIDIA installation guide](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html#installing-the-nvidia-container-toolkit).

