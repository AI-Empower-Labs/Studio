// Copyright (c) Microsoft. All rights reserved.

using System.Threading;
using CopilotChat.WebApi.Models.Response;
using CopilotChat.WebApi.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CopilotChat.WebApi.Controllers;

/// <summary>
///     Controller for reporting the status of chat migration.
/// </summary>
[ApiController]
public sealed class MaintenanceController(IOptions<ServiceOptions> serviceOptions) : ControllerBase
{
    internal const string GlobalSiteMaintenance = "GlobalSiteMaintenance";

    /// <summary>
    ///     Route for reporting the status of site maintenance.
    /// </summary>
    [Route("maintenanceStatus")]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<MaintenanceResult?> GetMaintenanceStatusAsync(
        CancellationToken cancellationToken = default)
    {
        MaintenanceResult? result = null;

        if (serviceOptions.Value.InMaintenance)
        {
            result = new MaintenanceResult(); // Default maintenance message
        }

        if (result is not null)
        {
            return Ok(result);
        }

        return Ok();
    }
}
