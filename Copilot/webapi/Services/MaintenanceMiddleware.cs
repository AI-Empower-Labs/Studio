// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Threading.Tasks;
using CopilotChat.WebApi.Controllers;
using CopilotChat.WebApi.Hubs;
using CopilotChat.WebApi.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;

namespace CopilotChat.WebApi.Services;

/// <summary>
///     Middleware for determining is site is undergoing maintenance.
/// </summary>
public class MaintenanceMiddleware(
    RequestDelegate next,
    IReadOnlyList<IMaintenanceAction> actions,
    IOptions<ServiceOptions> serviceOptions,
    IHubContext<MessageRelayHub> messageRelayHubContext)
{
    private bool? _isInMaintenance;

    public async Task Invoke(HttpContext ctx)
    {
        // Skip inspection if _isInMaintenance explicitly false.
        if (_isInMaintenance == null || _isInMaintenance.Value)
        {
            // Maintenance never false => true; always true => false or just false;
            _isInMaintenance = await InspectMaintenanceActionAsync();
        }

        // In maintenance if actions say so or explicitly configured.
        if (serviceOptions.Value.InMaintenance)
        {
            await messageRelayHubContext.Clients.All.SendAsync(MaintenanceController.GlobalSiteMaintenance,
                "Site undergoing maintenance...");
        }

        await next(ctx);
    }

    private async Task<bool> InspectMaintenanceActionAsync()
    {
        bool inMaintenance = false;

        foreach (IMaintenanceAction action in actions)
        {
            inMaintenance |= await action.InvokeAsync();
        }

        return inMaintenance;
    }
}
