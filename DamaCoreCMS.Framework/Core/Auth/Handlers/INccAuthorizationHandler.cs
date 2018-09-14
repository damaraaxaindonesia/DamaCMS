

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DamaCoreCMS.Framework.Core.Auth.Handlers
{
    public interface INccAuthorizationHandler
    {
        Dictionary<string, string> GetRequirementValues(string requirementName);
        Task<AuthorizationResult> HandleRequirement(ActionExecutingContext context, NccAuthRequirement requirement, object model);
    }
}
