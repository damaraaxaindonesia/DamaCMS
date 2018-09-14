
 
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.IoC;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccWebSiteWidgetRepository : BaseRepository<NccWebSiteWidget, long>
    {
        public NccWebSiteWidgetRepository(NccDbContext context) : base(context)
        {
        }
    }
}
