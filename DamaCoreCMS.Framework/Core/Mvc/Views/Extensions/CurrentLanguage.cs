

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using DamaCoreCMS.Framework.i18n;

namespace DamaCoreCMS.Framework.Core.Mvc.Views.Extensions
{
    public static class LanguageExtension
    {
        public static string CurrentLanguage(this IHtmlHelper helper)
        {
            var langDetector = new NccLanguageDetector(new HttpContextAccessor() { HttpContext = helper.ViewContext.HttpContext });
            return langDetector.GetCurrentLanguage();
        }
    }
}
