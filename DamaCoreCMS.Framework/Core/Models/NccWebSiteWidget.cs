

using System;
using System.ComponentModel.DataAnnotations.Schema;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using DamaCoreCMS.Framework.Modules.Widgets;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccWebSiteWidget : BaseModel<long>
    {   
        public string ThemeId { get; set; }
        public string ModuleName { get; set; }
        public string LayoutName { get; set; }
        public string Zone { get; set; }
        public string WidgetId { get; set; }
        public int WidgetOrder { get; set; }
        public string WidgetConfigJson { get; set; }
        public string WidgetData { get; set; }
        [NotMapped]
        public Widget Widget { get; set; }
        public NccWebSite WebSite { get; set; }
    }

    public enum WebSiteWidgetStatus
    {
        Active,
        Inactive,
        Installed,
        Uninstalled
    }
}
