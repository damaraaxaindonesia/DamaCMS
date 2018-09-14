

using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Setup
{
    public class SetupTemplateModules
    {
        public List<string> Basic { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms"
        };

        public List<string> Blog { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms"
        };

        public List<string> CompanyWebiste { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms"
        };

        public List<string> PersonalProfile { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms"
        };

        public List<string> CRM { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms",
            "DamaCoreCMS.Modules.CRM",
        };

        public List<string> ShoppingCart { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms",
            "DamaCoreCMS.Modules.ShoppingCart",
        };

        public List<string> Accounting { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms",
            "DamaCoreCMS.Modules.Accounting",
        };
        
        public List<string> Inventory { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms",
            "DamaCoreCMS.Modules.Inventory",
        };

        public List<string> SchoolManagement { get; } = new List<string>()
        {
            "DamaCoreCMS.Modules.Cms",
            "DamaCoreCMS.Modules.SchoolManagement",
        };
    }
}
