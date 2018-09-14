

using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccWebSiteInfoRepository : BaseRepository<NccWebSiteInfo, long>
    {
        public NccWebSiteInfoRepository(NccDbContext context) : base(context)
        {
        }
    }
}
