

using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Modules.Widgets;
using Core.Blog.Models;
using System;
using Core.Blog.Controllers;

namespace Core.Blog.Widgets
{
    public class CategoryWidget : Widget
    {
        NccCategoryService _nccCategoryService;
        
        bool ShowCategoryHasPost = false;
        bool ShowPostCount = false;
        bool ShowHierarchy = false;
        bool DisplayAsDropdown = false;

        public CategoryWidget(        
            NccCategoryService nccCategoryService) : base(
                typeof(BlogController),
                "Category",
                "This is a widget to display category.",
                "",
                "Widgets/Category",
                "Widgets/CategoryConfig",
                true
            )
        {
            _nccCategoryService = nccCategoryService;
        }

        public override void InitConfig(dynamic config)
        {
            try
            {
                string temp = config.showCategoryHasPost;
                ShowCategoryHasPost = (temp == "on") ? true : false;

                temp = config.showPostCount;
                ShowPostCount = (temp == "on") ? true : false;

                temp = config.showHierarchy;
                ShowHierarchy = (temp == "on") ? true : false;

                temp = config.displayAsDropdown;
                DisplayAsDropdown = (temp == "on") ? true : false;
            }
            catch (Exception) { }
        }
        
        public override object PrepareViewModel()
        {
            var categoryList = _nccCategoryService.LoadAllWithPost();
            CategoryViewModel model = new CategoryViewModel();
            model.ShowCategoryHasPost = ShowCategoryHasPost;
            model.ShowPostCount = ShowPostCount;
            model.ShowHierarchy = ShowHierarchy;
            model.DisplayAsDropdown = DisplayAsDropdown;
            model.CategoryList = categoryList;
            return model;
        }
    }
}