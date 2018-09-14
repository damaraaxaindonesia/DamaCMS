﻿

using Microsoft.AspNetCore.Mvc.Rendering;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Themes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Models.ViewModels
{
    public class StartupViewModel
    {
        public string Url { get; set; }
        public string StartupType { get; set; }
        public string RoleStartupType { get; set; }
        public string StartupFor { get; set; }
        public string PageId { get; set; }
        public SelectList Pages { get; set; }
        public string CategoryId { get; set; }
        public SelectList Categories { get; set; }
        public string PostId { get; set; }
        public SelectList Posts { get; set; }
        public string ModuleSiteMenuUrl { get; set; }
        public SelectList ModuleSiteMenus { get; set; }
        public SelectList Roles { get; set; }
    }
}
