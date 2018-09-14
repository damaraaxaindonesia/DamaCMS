

using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Service;
using DamaCoreCMS.Framework.Core.Repository;

namespace DamaCoreCMS.Framework.Core.Services
{
    public class NccScheduleTaskHistoryService : BaseService<NccScheduleTaskHistory>
    {
        private readonly NccScheduleTaskHistoryRepository _entityRepository;
         
        public NccScheduleTaskHistoryService(NccScheduleTaskHistoryRepository entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;
        }

    }
}
