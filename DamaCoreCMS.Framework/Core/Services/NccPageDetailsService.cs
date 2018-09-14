

using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Repository;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.Framework.Core.Services
{
    public class NccPageDetailsService : BaseService<NccPageDetails>
    {
        private readonly NccPageDetailsRepository _entityRepository;

        public NccPageDetailsService(NccPageDetailsRepository entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;
        }

        #region New Method
        public NccPageDetails Get(string slug, string language)
        {
            return _entityRepository.Get(slug, language);
        }

        public List<NccPageDetails> LoadRecentPageDetails(int limit, string language = "")
        {
            return _entityRepository.LoadRecentPageDetails(limit, language);
        }

        public List<NccPageDetails> LoadAllByStatus(NccPage.NccPageStatus status)
        {
            return _entityRepository.LoadAllByStatus(status);
        }

        public List<NccPageDetails> Search(string name, string language = "")
        {
            return _entityRepository.Search(name, language);
        } 
        #endregion
    }
}
