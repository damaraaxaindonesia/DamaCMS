

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.Resources;
using DamaCoreCMS.Framework.Themes;
using DamaCoreCMS.Framework.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DamaCoreCMS.Framework.Core.Middleware
{
    public static class ThemeActivatorMiddleware
    {
        public static IApplicationBuilder UseThemeActivator(this IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            return app.Use((context, next) =>
            {
                var _themeManager = new ThemeManager();
                var themeFolder = Path.Combine(env.ContentRootPath, NccInfo.ThemeFolder);
                GlobalContext.Themes = _themeManager.ScanThemeDirectory(themeFolder);

                ResourcePathExpendar.RegisterStaticFiles(env, app, GlobalContext.Modules, GlobalContext.Themes);
                
                return next();
            });            
        }
    }
}
