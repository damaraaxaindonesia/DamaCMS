

using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;

using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using Microsoft.EntityFrameworkCore;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccUserRepository : BaseRepository<NccUser, long>
    {
        public NccUserRepository(NccDbContext context) : base(context)
        {

        }

        public List<NccUser> Search(string searchKey)
        {
            return Query()
                .Include("Permissions")
                .Include("ExtraPermissions")
                .Include("ExtraDenies")
                .Include("Permissions.Permission")
                .Include("Permissions.User")
                .Where(
                        x => x.Email.Contains(searchKey) 
                        || x.FullName.Contains(searchKey) 
                        || x.Mobile.Contains(searchKey) 
                        || x.Name.Contains(searchKey)
                        || x.NormalizedUserName.Contains(searchKey)
                        || x.PhoneNumber.Contains(searchKey)
                        || x.UserName.Contains(searchKey)
                    )
                .ToList();
        }

        public void RemoveUserPermission(List<NccUserPermission> items)
        {
            Context.RemoveRange(items);
        }
    }
}
