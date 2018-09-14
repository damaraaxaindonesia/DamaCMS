

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccStartup : BaseModel<long>
    {  
        public long UserId { get; set; }
        //public NccUser User { get; set; }
        public long RoleId { get; set; }
        
        public StartupType StartupType { get; set; }
        public string StartupUrl { get; set; }
        public StartupFor StartupFor { get; set; }

        public NccPermission Permission { get; set; }
    }

    public enum StartupFor
    {
        Website,
        Admin,
        Role,
        User
    }

    public enum StartupType
    {
        Url,
        Page,
        Category,
        Post,
        Module,
        Tag
    }
}
