

using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Modules.Widgets;
using Core.Blog.Models;
using System;
using Core.Blog.Controllers;

namespace Core.Blog.Widgets
{
    public class ArchiveWidget : Widget
    {
        NccPostService _nccPostService;
        
        bool ShowPostCount = false;
        bool DisplayOrder = true;
        bool DisplayAsDropdown = false;

        public ArchiveWidget(NccPostService nccPostService) : base(
                typeof(BlogController),
                "Archive",
                "This is a widget to display archive.",
                "",
                "Widgets/Archive",
                "Widgets/ArchiveConfig",
                true
            )
        {            
            _nccPostService = nccPostService;
        }

        public override void InitConfig(dynamic config)
        {   
            try
            {
                string temp = config.showPostCount;
                ShowPostCount = (temp == "on") ? true : false;

                temp = config.displayOrder;
                DisplayOrder = (temp == "1") ? true : false;

                temp = config.displayAsDropdown;
                DisplayAsDropdown = (temp == "on") ? true : false;
            }
            catch (Exception) {}           
        }

        public override object PrepareViewModel()
        {
            var itemList = _nccPostService.LoadArchive(DisplayOrder);
            ArchiveViewModel model = new ArchiveViewModel();
            model.ShowPostCount = ShowPostCount;
            model.DisplayAsDropdown = DisplayAsDropdown;
            model.ItemList = itemList;            
            return model;
        }
    }
}