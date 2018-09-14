

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using System.Linq;

using DamaCoreCMS.Framework.Core.IoC;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccPermissionRepository : BaseRepository<NccPermission, long>
    {
        public NccPermissionRepository(NccDbContext context) : base(context)
        {
        }

        public int RemoveById(List<long> removePermissionDetailsIdList)
        {
            var idList = string.Join(",", removePermissionDetailsIdList);
            var count = ExecuteSqlCommand(new NccDbQueryText() {
                MySql_QueryText = $"delete from Ncc_Permission_Details where Id in ({idList})"
            });
            return count;
        }
    }
}