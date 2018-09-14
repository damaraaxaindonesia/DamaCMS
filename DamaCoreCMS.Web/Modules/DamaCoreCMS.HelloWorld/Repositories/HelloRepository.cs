

using DamaCoreCMS.Framework.Core.Mvc.Repository;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.IoC;
using DamaCoreCMS.HelloWorld.Models.Entity;

namespace DamaCoreCMS.HelloWorld.Repositories
{
    public class HelloRepository : BaseRepository<HelloModel, long>, ISingleton
    {
        public HelloRepository(NccDbContext context) : base(context)
        {
        }
    }
}
