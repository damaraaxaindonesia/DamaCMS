

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Routing;
using DamaCoreCMS.Framework.Setup;
using DamaCoreCMS.Framework.Utility;
using System.Linq;

namespace DamaCoreCMS.Framework.i18n
{
    public class NccLanguageDetector
    {  
        private readonly HttpContext _httpContext;
        
        public NccLanguageDetector(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext; 
        }

        public string GetCurrentLanguage()
        {
            if (GlobalContext.WebSite != null && GlobalContext.WebSite.IsMultiLangual)
            {
                var lang = (string) _httpContext.GetRouteValue("lang");
                if (string.IsNullOrEmpty(lang))
                {
                    lang = GetLanguageFromCookie();
                }

                if (string.IsNullOrEmpty(lang))
                {
                    lang = GlobalContext.WebSite.Language;
                }

                if (string.IsNullOrEmpty(lang))
                {
                    lang = SetupHelper.Language;
                }

                return lang;
            }
            else
            {
                return SetupHelper.Language;
            }
        }

        private string GetLanguageFromCookie()
        {
            if (_httpContext.Request.Cookies.ContainsKey(CookieRequestCultureProvider.DefaultCookieName))
            {
                var cultures = (string) _httpContext.Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];
                if (string.IsNullOrEmpty(cultures) == false)
                {
                    var parsedValue = CookieRequestCultureProvider.ParseCookieValue(cultures);
                    var culture = parsedValue.Cultures.FirstOrDefault();
                    if (culture != null)
                    {
                        return culture.Value;
                    }
                }
            }
            return string.Empty;
        }
    }
}
