

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using DamaCoreCMS.Framework.Core.Data;
using System.Collections.Generic;
using System.Linq;

namespace DamaCoreCMS.Framework.Core.Mvc.Repository
{
    public interface IBaseRepository<EntityT, IdT>
    {
        List<string> DefaultIncludedRelationalProperties { get; set; }
        IQueryable<EntityT> Query(bool? isActive = null, bool includeDefaultRelationProperties = true, List<string> extraIncludeRelationalProperties = null, bool isAsNoTracking = false, bool withDeleted = false);
        EntityEntry GetEntityEntry(EntityT T);
        EntityT Add(EntityT entity);
        EntityT Edit(EntityT entity);        
        EntityT Get(IdT id, bool isAsNoTracking = false, List<string> includeChilds = null, bool withDeleted = false);
        EntityT Get(string name, bool isAsNoTracking = false, List<string> includeRelationalProperties = null, bool withDeleted = false);
        List<EntityT> Load(string name, List<string> includeRelationalProperties = null, bool withDeleted = false);
        List<EntityT> LoadAll(bool isActive = true, int status = -1, string name = "", bool isLikeSearch = false, List<string> includeRelationalProperties = null, bool withDeleted = false);        
        IDbContextTransaction BeginTransaction();
        void Remove(EntityT entity);
        void DeletePermanently(EntityT entity);
        void SaveChange();
        int ExecuteSqlCommand(NccDbQueryText query);
    }
}