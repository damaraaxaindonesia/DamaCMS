

using System.Collections.Generic;

namespace DamaCoreCMS.Framework.Core.Models.ViewModels
{
    public class Menu
    {
        public string ModuleName { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string DisplayName { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public string IconCls { get; set; }
        public int Order { get; set; }
        public MenuType Type { get; set; }

        public enum MenuType
        {
            WebSite,
            Admin
        }
    }
}
