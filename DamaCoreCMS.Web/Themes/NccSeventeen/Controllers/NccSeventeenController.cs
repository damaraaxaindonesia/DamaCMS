﻿
 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;
using DamaCoreCMS.Framework.Themes;
using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Mvc.Attributes;

namespace NccSeventeen.Controllers
{
    public class NccSeventeenController : NccController
    {
        Dictionary<string, string> style = new Dictionary<string, string>() { { "blue-skin.css", "Blue" }, { "green-skin.css", "Green" }, { "orange-skin.css", "Orange" }, { "red-skin.css", "Red" }, { "white-skin.css", "White" } };

        public NccSeventeenController()
        {

        }

        [SubActionOf(Controller = "CmsTheme", Action = "Settings")]
        public ActionResult Index()
        {
            ViewBag.style = new SelectList(style, "Key", "Value", ThemeHelper.ActiveTheme.Settings["style"]);
            return View();
        }
        [HttpPost]
        [SubActionOf(Controller = "CmsTheme", Action = "Settings")]
        public ActionResult Index(string[] key, string[] value)
        {
            foreach (var item in style)
            {
                ThemeHelper.UnRegisterResource(NccResource.ResourceType.CssFile, string.Concat("/Themes/NccSeventeen/css/", item.Key));
            }
            double version = 1.0;
            try
            {
                version = (double)ThemeHelper.ActiveTheme.Settings["version"];
                version += 0.1;
                ThemeHelper.ActiveTheme.Settings.Remove("version");
            }
            catch (Exception ex) { }
            ThemeHelper.ActiveTheme.Settings.Add("version", version);

            for (int i = 0; i < key.Length; i++)
            {
                ThemeHelper.ActiveTheme.Settings.Remove(key[i]);
                ThemeHelper.ActiveTheme.Settings.Add(key[i], value[i]);
            }
            ThemeHelper.ActiveTheme.Save();
            ShowMessage("Settings Updated Successfully", DamaCoreCMS.Framework.Core.Mvc.Views.MessageType.Success, false, true);
            return RedirectToAction("Index");
        }
    }
}
