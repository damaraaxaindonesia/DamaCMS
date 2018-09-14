

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using System.Linq;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccSettingsRepository : BaseRepository<NccSettings, long>
    {
        public NccSettingsRepository(NccDbContext context) : base(context)
        {
        }

        public NccSettings GetByKey(string key)
        {
            return DbSet.FirstOrDefault(x => x.Key.Equals(key));
        }
    }
}
