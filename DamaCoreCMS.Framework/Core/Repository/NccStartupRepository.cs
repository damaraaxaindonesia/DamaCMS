

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using System.Linq;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccStartupRepository : BaseRepository<NccStartup, long>
    {
        public NccStartupRepository(NccDbContext context) : base(context)
        {
        }        
    }
}
