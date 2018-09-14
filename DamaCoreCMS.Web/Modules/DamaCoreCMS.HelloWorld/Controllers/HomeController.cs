using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;

namespace DamaCoreCMS.HelloWorld.Controllers
{
    public class HomeController : NccController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
