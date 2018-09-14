using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Modules;
using DamaCoreCMS.Framework.Setup;
using DamaCoreCMS.Framework.Themes;
using DamaCoreCMS.Framework.Utility;
using System;
using System.Collections.Generic;

namespace UnitTests.Lib
{
    public class FakeGlobalContext
    {
        public static void EnableMultiLanguage()
        {
            GlobalContext.WebSite = FakeNccWebSite.GetNccWebsite();
            GlobalContext.WebSite.IsMultiLangual = true;
        }

        public static void SetGlobalContextProperties()
        {
            GlobalContext.WebSite = FakeNccWebSite.GetNccWebsite();
            GlobalContext.App = null;
            GlobalContext.ContentRootPath = "C:\\initpub\\wwwroot\\DamaCoreCMS\\wwwroot";
            GlobalContext.IsRestartRequired = false;
            GlobalContext.Menus = new List<NccMenu>();
            GlobalContext.Modules = new List<IModule>();
            GlobalContext.ServiceProvider = null;
            GlobalContext.Services = null;
            GlobalContext.SetupConfig = new SetupConfig();
            GlobalContext.ShortCodes = new System.Collections.Hashtable();
            GlobalContext.Themes = new List<Theme>();
            GlobalContext.WebRootPath = "C:\\initpub\\wwwroot\\DamaCoreCMS";
            GlobalContext.WebSiteWidgets = new List<NccWebSiteWidget>();
            GlobalContext.Widgets = new List<DamaCoreCMS.Framework.Modules.Widgets.Widget>();
        }

        public static void DisableMultiLanguage()
        {
            GlobalContext.WebSite = FakeNccWebSite.GetNccWebsite();
            GlobalContext.WebSite.IsMultiLangual = false;
        }

    }
}
