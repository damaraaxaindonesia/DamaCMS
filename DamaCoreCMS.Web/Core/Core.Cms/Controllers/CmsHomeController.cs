

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DamaCoreCMS.Framework.Core.Messages;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Controllers;
using DamaCoreCMS.Framework.Core.Network;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Setup;
using DamaCoreCMS.Framework.Utility;
using Core.Cms.Models.ViewModels;
using System;
using System.Linq;

namespace Core.Cms.Controllers
{
    [AllowAnonymous]
    public class CmsHomeController : NccController
    {
        private NccPageService _pageService;
        private NccPostService _postService;

        public CmsHomeController(NccPageService pageService, NccPostService nccPostService, ILoggerFactory factory)
        {
            _pageService = pageService;
            _postService = nccPostService;
            _logger = factory.CreateLogger<CmsHomeController>();
        }

        [AllowAnonymous]        
        public ActionResult Index(int pageNumber = 0)
        {
            if (SetupHelper.IsDbCreateComplete && SetupHelper.IsAdminCreateComplete)
            {
                var postPerPage = GlobalContext.WebSite.WebSitePageSize;
                var totalPost = _postService.Count(true, true, true, false);
                var stickyPosts = _postService.LoadSpecialPosts(true, false);
                var featuredPosts = _postService.LoadSpecialPosts(false,true);
                var allPost = _postService.Load(pageNumber, postPerPage, true, true, false, false);

                return View(new HomePageViewModel() {
                    AllPosts = allPost,
                    CurrentLanguage = CurrentLanguage,
                    FeaturedPosts = featuredPosts,
                    StickyPosts = stickyPosts,
                    PageNumber = pageNumber,
                    PostPerPage = postPerPage,
                    TotalPost = totalPost,
                    PreviousPage = pageNumber - 1,
                    NextPage = pageNumber + 1,
                    TotalPage = (int) Math.Ceiling(totalPost/(decimal)postPerPage),
                });
            }
            return Redirect("/SetupHome/Index");
        }

        [AllowAnonymous]
        public JsonResult RemoveGlobalMessage(string id)
        {
            GlobalMessageRegistry.UnRegisterMessage(id);
            return Json(new ApiResponse() { IsSuccess = true, Message = "Success" });
        }

        [AllowAnonymous]
        public IActionResult ResourceNotFound()
        {
            return View();
        } 
    }
}
