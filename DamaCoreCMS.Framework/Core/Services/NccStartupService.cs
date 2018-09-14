﻿

using System;
using System.Collections.Generic;
using System.Linq;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Repository;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.Framework.Core.Services
{
    public class NccStartupService : BaseService<NccStartup>
    {
        private readonly NccStartupRepository _entityRepository;
        private readonly NccPermissionRepository _nccPermissionRepository;

        public NccStartupService(NccStartupRepository entityRepository, NccPermissionRepository nccPermissionRepository) : base(entityRepository, new List<string>() { "Permission" })
        {
            _entityRepository = entityRepository;
            _nccPermissionRepository = nccPermissionRepository;
        }

        #region New Method
        public void SaveOrUpdate(string startupUrl, string roleStartupType, long[] roles)
        {
            using (var txn = _entityRepository.BeginTransaction())
            {
                foreach (var item in roles)
                {
                    var startup = new NccStartup();
                    var startupType = (StartupType)Enum.Parse(typeof(StartupType), roleStartupType);
                    var existingStartup = Get(item, StartupFor.Role);
                    var permission = _nccPermissionRepository.Get(item);

                    if (existingStartup == null)
                    {
                        startup.Permission = permission;
                        startup.StartupFor = StartupFor.Role;
                        startup.StartupType = startupType;
                        startup.StartupUrl = startupUrl;
                        _entityRepository.Add(startup);
                    }
                    else
                    {
                        existingStartup.Permission = permission;
                        existingStartup.StartupFor = StartupFor.Role;
                        existingStartup.StartupType = startupType;
                        existingStartup.StartupUrl = startupUrl;
                        _entityRepository.Edit(existingStartup);
                    }
                }
                _entityRepository.SaveChange();
                txn.Commit();
            }
        }

        public NccStartup Get(long roleId, StartupFor startupFor)
        {
            var query = _entityRepository.Query().Where(x => x.RoleId == roleId && x.StartupFor == startupFor);
            return query.LastOrDefault();
        } 
        #endregion
    }
}
