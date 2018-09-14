

using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccWebSiteRepository : BaseRepository<NccWebSite, long>
    {
        public NccWebSiteRepository(NccDbContext context) : base(context)
        {
        }
    }
}
