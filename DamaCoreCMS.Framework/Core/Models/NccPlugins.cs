

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccPlugins : BaseModel<long>
    { 
        public NccPlugins()
        {
            Widgets = new List<NccWidget>();
        }

        public bool AntiForgery { get; set; }
        public string Author { get; set; }
        public string Website { get; set; }
        public string Version { get; set; }
        public string DamaCoreCMSVersion { get; set; }
        public string Description { get; set; }
        public string Dependencies { get; set; }
        public string Category { get; set; }
        public string SortName { get; set; }
        public string Path { get; set; }

        public NccPluginsStatus PluginsStatus { get; set; }
        public List<NccWidget> Widgets { get; set; }

        public enum NccPluginsStatus
        {
            Listed,
            Installed,
            Active,
            Inactive,
            Uninstalled
        }
    }
}
