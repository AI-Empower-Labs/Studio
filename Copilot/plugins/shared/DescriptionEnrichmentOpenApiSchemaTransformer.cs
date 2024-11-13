// Copyright (c) Microsoft.All rights reserved.

using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi.Models;

namespace Plugins.PluginShared;

/// <summary>
/// Needed for Semantic Kernel to generate correct tool description
/// </summary>
public sealed class DescriptionEnrichmentOpenApiSchemaTransformer : IOpenApiOperationTransformer
{
	public Task TransformAsync(OpenApiOperation operation, OpenApiOperationTransformerContext context, CancellationToken cancellationToken)
	{
		foreach (OpenApiParameter parameter in operation.Parameters)
		{
			parameter.Schema.Description = parameter.Description;
		}

		return Task.CompletedTask;
	}
}

