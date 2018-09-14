

using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.Reflection;
using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccSettings : BaseModel<long>
    {   
        public NccSettings()
        {
            var assembly = Assembly.GetCallingAssembly();
            GroupId = assembly.FullName;
        }
        public string GroupId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; } 
    }
}
