
 
using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.Collections.Generic;
using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    /// <summary>
    /// Permission Template for permission management. This one ore more permission will assign to the user.
    /// </summary>
    [Serializable]
    public class NccPermission : BaseModel<long>
    {
        public string Group { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public virtual List<NccUserPermission> Users { get; set; }
        public virtual List<NccPermissionDetails> PermissionDetails { get; set; }

        public NccPermission()
        {
            Users = new List<NccUserPermission>();
            PermissionDetails = new List<NccPermissionDetails>();
        }
    }
}
