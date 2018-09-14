

using Microsoft.AspNetCore.Mvc;
using DamaCoreCMS.Framework.Core.Mvc.Attributes;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;
using DamaCoreCMS.Framework.Core.Network;
using System.Linq;
using DamaCoreCMS.Framework.i18n;

namespace Core.Admin.Controllers
{
    [AdminMenu(Name ="Settings", Order = 7)]
    public class LanguageController : NccController
    {
        public ActionResult RedirectToDefaultLanguage()
        {
            var lang = CurrentLanguage;
            var redirectUrl = Request.Path.Value;
            if (Request.Path.Value.StartsWith("/en") || Request.Path.Value.StartsWith("/bn"))
            {
                return Redirect("~" + redirectUrl);
            }
            return Redirect("~/" + lang + Request.Path.Value);
        }

        [AdminMenuItem(Name ="Translation", Order = 6, IconCls ="fa fa-language", SubActions = new[] { "EditTranslationFile"})]
        public ActionResult TranslationFiles()
        {
            var translator = new NccTranslator(CurrentLanguage);
            translator.SaveTranslations();

            var resourceFileList = TranslationFile.GetTranslationFiles();
            return View(resourceFileList);
        }
          
        public ActionResult EditTranslationFile(string id)
        {
            var translationFiles = TranslationFile.GetTranslationFiles();
            var selectedTranslationFile = translationFiles.Where(x => x.Id == id).FirstOrDefault();

            if(selectedTranslationFile == null)
            {
                ViewBag.ErrorMessage = "File not found";
                return View(new TranslationFile());
            }

            ViewBag.TranslationFile = selectedTranslationFile;

            return View(selectedTranslationFile);
        }

        [HttpPost]
        public JsonResult EditTranslationFile(string id, string contentJson)
        {
            var translationFiles = TranslationFile.GetTranslationFiles();
            var selectedTranslationFile = translationFiles.Where(x => x.Id == id).FirstOrDefault();

            if (selectedTranslationFile == null)
            {
                ViewBag.ErrorMessage = "File not found";
                return Json(new ApiResponse() {
                     IsSuccess = false,
                     Message = "Translation file not found"
                });
            }
            else
            {
                selectedTranslationFile.Content = contentJson;
                selectedTranslationFile.Save();
                NccTranslator.LoadTranslations();

                return Json(new ApiResponse()
                {
                    IsSuccess = true,
                    Message = "Update successful"
                });
            }
        }   
    }
}
