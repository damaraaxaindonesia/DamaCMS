
 
using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    /// <summary>
    /// Assigned user's permissions
    /// </summary>
    [Serializable]
    public class NccUserPermission
    {
        public long UserId { get; set; }
        public long PermissionId { get; set; }

        public NccUser User { get; set; }
        public NccPermission Permission { get; set; }
    }
}
