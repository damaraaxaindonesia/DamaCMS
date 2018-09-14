

using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    /// <summary>
    /// Permission details will contain in which menu of a module user will get permission.
    /// </summary>
    [Serializable]
    public class NccPermissionDetails : BaseModel<long>
    {
        public NccPermission Permission { get; set; }        
        public virtual NccUser DenyUser { get; set; }
        public virtual NccUser AllowUser { get; set; }

        public string ModuleName { get; set; }
        public string MenuType { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int Order { get; set; }
        public string Requirements { get; set; }

        public long? ExtraAllowUserId { get; set; }
        public long? ExtraDenyUserId { get; set; }
        public long? PermissionId { get; set; }
    }
}
