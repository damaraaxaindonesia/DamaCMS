

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Utility;
using System;
using DamaCoreCMS.Framework.Core.Mvc.Extensions;
using System.Linq;
using DamaCoreCMS.Framework.Core.Network;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using DamaCoreCMS.Framework.Themes;
using DamaCoreCMS.Framework.Core.Mvc.Attributes;

namespace Core.Blog.Controllers
{
    [SiteMenu(IconCls = "fa-newspaper-o", Name = "Blog", Order = 100)]
    [AdminMenu(IconCls = "fa-newspaper-o", Name = "Blog", Order = 1)]
    public class BlogController : NccController
    {
        NccPostService _nccPostService;
        INccUserService _nccUserService;
        ILoggerFactory _loggerFactory;

        public BlogController(NccPostService nccPostService, INccUserService nccUserService, ILoggerFactory loggerFactory)
        {
            _nccPostService = nccPostService;
            _loggerFactory = loggerFactory;
            _nccUserService = nccUserService;
            _logger = _loggerFactory.CreateLogger<BlogController>();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Post");
        }

        [AllowAnonymous]
        public ActionResult Details(string slug)
        {
            return RedirectToAction("Index", "Post", new { slug = slug });            
        }        
    }
}