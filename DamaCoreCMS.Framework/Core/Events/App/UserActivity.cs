
 
using DamaCoreCMS.Framework.Core.Models;
using System.Collections.Generic;

namespace DamaCoreCMS.Framework.Core.Events.App
{
    public class UserActivity
    {
        public UserActivity()
        {
            NewRoles = new List<string>();
        }

        public NccUser User{ get; set; }
        public string Email { get; set; }
        public IList<string> NewRoles { get; set; }
        public string Ip { get; set; }
        public string ReturnUrl { get; set; }
        public Type ActivityType { get; set; }

        public enum Type
        {
            Registered,
            Logedin,
            Logedout,
            RoleChanged,
            InActivated,
            EmailConfirmed,
            Activated            
        }
    }
}
