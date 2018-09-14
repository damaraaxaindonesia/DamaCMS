

using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccMenuRepository : BaseRepository<NccMenu, long>
    {
        public NccMenuRepository(NccDbContext context) : base(context)
        {
        }
    }
}
