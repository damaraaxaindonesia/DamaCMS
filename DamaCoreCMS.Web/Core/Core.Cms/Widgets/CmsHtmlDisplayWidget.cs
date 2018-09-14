﻿

using Core.Cms.Controllers;
using Core.Cms.Models.ViewModels;
using DamaCoreCMS.Framework.Modules.Widgets;

namespace Core.Cms.Widgets
{
    public class CmsHtmlDisplayWidget : Widget
    {
        private HtmlDisplayViewModel model;
        public CmsHtmlDisplayWidget():base(typeof(CmsHomeController), "Html Display", "Html or text Display Show", "", "Widgets/CmsHtmlDisplay", "Widgets/CmsHtmlDisplayConfig")
        {
            
        }

        public override void InitConfig(dynamic config)
        {
            model = new HtmlDisplayViewModel() { Content = config.bodyContent};            
        }
        
        public override object PrepareViewModel()
        {
            return model;
        }
    }
}
