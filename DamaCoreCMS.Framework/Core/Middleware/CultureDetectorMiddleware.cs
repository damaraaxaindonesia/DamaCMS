

using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.i18n;

namespace DamaCoreCMS.Framework.Core.Middleware
{
    public class CultureDetectorMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;
        string _currentLanguage = "";
        public CultureDetectorMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            this.next = next;
            logger = loggerFactory.CreateLogger<CultureDetectorMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
             
            var feature = context.Features.Get<IRequestCultureFeature>();
            _currentLanguage = feature.RequestCulture.Culture.Name.ToLower();
            context.Session.SetString(SupportedCultures.LanguageSessionKey, _currentLanguage);
            context.Response.Cookies.Append(SupportedCultures.LanguageCookieKey, _currentLanguage);
             
            await next.Invoke(context); 
        }
    }
     
    public static class CultureDetactorMiddlewareExtensions
    {
        //public static IServiceCollection AddCultureDetactor(this IServiceCollection services)
        //{
        //    return services;
        //}
        
        public static IApplicationBuilder UseCultureDetactor(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureDetectorMiddleware>();
        }
    }
}
