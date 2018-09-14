

using Microsoft.AspNetCore.Mvc;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.i18n;
using DamaCoreCMS.Framework.Core.Mvc.Attributes;
using PaulMiami.AspNetCore.Mvc.Recaptcha;
using Microsoft.AspNetCore.Authorization;
using DamaCoreCMS.Framework.Core.Services;

namespace DamaCoreCMS.HelloWorld.Controllers
{
    [AdminMenu(Name = "Hello Module", Order = 100)]
    [SiteMenu(Name = "Hello Module Site Menu", Url = "/HelloHome/Index", Order = 100)]
    public class HelloHomeController : NccController
    {
        public HelloHomeController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HelloHomeController>();
        }

        [AdminMenuItem(Name = "Index", Order = 1)]
        [SiteMenuItem(Name = "Hello world Home", Order = 1)]
        public ActionResult Index()
        {
            var nccTranslator = new NccTranslator(CurrentLanguage);
            return View();
        }

        [SiteMenuItem(Name = "Role Home", Order = 2)]
        [AllowAuthenticated]
        public ActionResult RoleHome()
        {
            return View();
        }

        public ActionResult SubAction()
        {
            return View();
        }
        
        [AllowAnonymous]
        [SiteMenuItem(Name ="Recaptcha", Order = 3)]
        public ActionResult Recaptcha()
        {
            return View();
        }

        [ValidateRecaptcha]
        [AllowAnonymous]
        [HttpPost]
        public ActionResult RecaptchaPost()
        {
            if (ModelState.IsValid)
            {
                ShowMessage("You were not a robot :)", Framework.Core.Mvc.Views.MessageType.Success, false, true);
            }
            else
            {
                ShowMessage("Are you human ??? :x", Framework.Core.Mvc.Views.MessageType.Error, false, true);
            }
            return RedirectToAction("Recaptcha");
        }
    }
}
