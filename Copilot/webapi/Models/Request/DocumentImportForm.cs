// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace CopilotChat.WebApi.Models.Request;

/// <summary>
///     Form for importing a document from a POST Http request.
/// </summary>
public sealed record DocumentImportForm
{
    /// <summary>
    ///     The file to import.
    /// </summary>
    public IEnumerable<IFormFile> FormFiles { get; set; } = [];
}
