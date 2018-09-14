

using DamaCoreCMS.Framework.Core.IoC;
using DamaCoreCMS.HelloWorld.Models.Entity;
using DamaCoreCMS.Framework.Core.Mvc.Service;
using DamaCoreCMS.HelloWorld.Repositories;

namespace DamaCoreCMS.HelloWorld.Services
{
    public class HelloService : BaseService<HelloModel>, ISingleton
    {
        public HelloService(HelloRepository entityRepository) : base(entityRepository)
        {

        }
    }
}
