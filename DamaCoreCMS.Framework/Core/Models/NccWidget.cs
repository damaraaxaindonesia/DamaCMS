

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccWidget : BaseModel<long>
    { 
        public string Title { get; set; }
        public string DamaCoreCMSVersion { get; set; }
        public string Description { get; set; }
        public string Dependencies { get; set; }
        public string SortName { get; set; }
        public byte[] Content { get; set; }
    }
}
