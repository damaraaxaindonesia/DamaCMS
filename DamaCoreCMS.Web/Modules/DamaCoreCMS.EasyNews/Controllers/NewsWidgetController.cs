

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;

namespace DamaCoreCMS.EasyNews.Controllers
{
    [AllowAnonymous]
    public class NewsWidgetController : NccController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
