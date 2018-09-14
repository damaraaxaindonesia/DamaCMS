

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccModuleDependency : BaseModel<long>
    {
        public string ModuleName { get; set; }
        public string ModuleVersion { get; set; }

        public NccModule NccModule { get; set; }
    }
}
