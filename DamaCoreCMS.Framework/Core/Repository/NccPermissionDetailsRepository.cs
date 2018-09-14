

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using System.Linq;

using DamaCoreCMS.Framework.Core.IoC;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccPermissionDetailsRepository : BaseRepository<NccPermissionDetails, long>
    {
        public NccPermissionDetailsRepository(NccDbContext context) : base(context)
        {
        }

        public void RemoveByIds(List<long> removePermissionDetailsIdList)
        {
            var entities = DbSet.Where(x => removePermissionDetailsIdList.Contains(x.Id)).ToList();
            if (entities.Count > 0)
            {
                DbSet.RemoveRange(entities);
            }
        }
    }
}