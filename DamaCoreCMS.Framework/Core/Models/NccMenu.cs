

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccMenu : BaseModel<long>
    { 
        public NccMenu()
        {
            MenuItems = new List<NccMenuItem>();
        }

        public string Position { get; set; }
        public string MenuIconCls { get; set; }
        public int MenuOrder { get; set; }
        public string MenuLanguage { get; set; }
        public List<NccMenuItem> MenuItems { get; set; }        
        
    }   
}
