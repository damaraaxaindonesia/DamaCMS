

using Microsoft.AspNetCore.Mvc;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;

namespace DamaCoreCMS.ImageSlider.Controllers
{
    public class ImageSliderWidgetController : NccController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
