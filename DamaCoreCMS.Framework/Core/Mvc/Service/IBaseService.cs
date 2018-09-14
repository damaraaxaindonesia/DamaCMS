

using System.Collections.Generic;

namespace DamaCoreCMS.Framework.Core.Mvc.Services
{
    public interface IBaseService<EntityT> 
    {
        EntityT Get(long entityId, bool isAsNoTracking = false, bool withDeleted = false);
        List<EntityT> LoadAll(bool isActive = true, int status = 0, string name = "", bool isLikeSearch = false, bool withDeleted = false);
        EntityT Save(EntityT model);
        EntityT Update(EntityT model);
        void Remove(long entityId);
        void DeletePermanently(long entityId);        

    }
}
