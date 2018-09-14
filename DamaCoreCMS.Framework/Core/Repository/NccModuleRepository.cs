

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using System.Linq;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccModuleRepository : BaseRepository<NccModule, long>
    {
        public NccModuleRepository(NccDbContext context) : base(context)
        {

        }

        internal List<NccModule> LoadByModuleStatus(NccModule.NccModuleStatus active)
        {
            return Query().Where(x => x.ModuleStatus == active).ToList();
        }
    }
}
