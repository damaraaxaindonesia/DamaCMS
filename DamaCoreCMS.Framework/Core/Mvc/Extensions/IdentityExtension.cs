﻿

using System.Security.Claims;

namespace DamaCoreCMS.Framework.Core.Mvc.Extensions
{
    public static class IdentityExtension
    {
        public static long GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
                return 0;
            var iDs = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            long.TryParse(iDs, out long userId);
            return userId;
        }
    }
 }
