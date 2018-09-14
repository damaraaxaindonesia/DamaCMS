

using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Repository;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.Framework.Core.Services
{
    /// <summary>
    /// Service for user permission details. 
    /// </summary>
    public class NccPermissionDetailsService : BaseService<NccPermissionDetails>
    {
        private readonly NccPermissionDetailsRepository _entityRepository;

        public NccPermissionDetailsService(NccPermissionDetailsRepository entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;
        }
    }
}