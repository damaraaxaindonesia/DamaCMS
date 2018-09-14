

using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccMenuItemRepository : BaseRepository<NccMenuItem, long>
    {
        public NccMenuItemRepository(NccDbContext context) : base(context)
        {
        }
    }
}
