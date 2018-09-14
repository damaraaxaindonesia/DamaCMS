

using Core.Cms.Controllers;
using DamaCoreCMS.Framework.Modules.Widgets;

namespace Core.Cms.Widgets
{
    public class CmsSearchWidget : Widget
    { 
        public CmsSearchWidget() : base(typeof(CmsHomeController), "Search Widget", "Search form show", "", "Widgets/CmsSearch")
        {
            
        }
    }
}
