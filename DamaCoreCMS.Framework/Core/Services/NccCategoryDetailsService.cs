

using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Repository;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.Framework.Core.Services
{
    public class NccCategoryDetailsService : BaseService<NccCategoryDetails>
    {
        private readonly NccCategoryDetailsRepository _entityRepository;

        public NccCategoryDetailsService(NccCategoryDetailsRepository entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;
        }

        #region New Methods
        public NccCategoryDetails Get(string slug, string language)
        {
            return _entityRepository.Get(slug, language);
        }

        public List<NccCategoryDetails> LoadByParrentId(long parrentId, bool isActive = true)
        {
            return _entityRepository.LoadByParrentId(parrentId, isActive);
        }

        public List<NccCategoryDetails> LoadRecentCategoryDetails(int count, string language = "")
        {
            return _entityRepository.LoadRecentCategoryDetails(count, language);
        }

        public List<NccCategoryDetails> Search(string name, string language = "", int count = 20)
        {
            return _entityRepository.Search(name, language, count);
        } 
        #endregion
    }
}