

using System.Collections.Generic;
using System.Linq;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using DamaCoreCMS.Framework.Core.Mvc.Services;
using DamaCoreCMS.Framework.Core.Repository;
using System;
using Microsoft.EntityFrameworkCore;
using DamaCoreCMS.Framework.Utility;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.Framework.Core.Services
{
    public class NccPostDetailsService : BaseService<NccPostDetails>
    {
        private readonly NccPostDetailsRepository _entityRepository;

        public NccPostDetailsService(NccPostDetailsRepository entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;
        }

        #region New Method
        public List<NccPostDetails> LoadRecentPages(int count)
        {
            var pages = _entityRepository.LoadRecentPosts(count);
            return pages;
        }

        public List<NccPostDetails> LoadAllByPostStatusAndDate(NccPost.NccPostStatus status, DateTime dateTime)
        {
            return _entityRepository
                .Query()
                .Include("Post")
                .Include("Post.PostDetails")
                .Where(x => x.Post.PostStatus == status && x.Post.PublishDate <= dateTime).ToList();
        }

        public List<NccPostDetails> LoadRecentPostDetails(int count, string language = "")
        {
            return _entityRepository.LoadRecentPostDetails(count, language);
        }

        public NccPostDetails Get(string slug, string language)
        {
            return _entityRepository.Get(slug, language);
        }

        public int TotalPublishedPostCount()
        {
            return _entityRepository
                .Query()
                .Include("Post")
                .Where(x => x.Post.PostStatus == NccPost.NccPostStatus.Published && x.Post.PublishDate <= DateTime.Now)
                .Count();
        }

        public List<NccPostDetails> Search(string name, string language = "")
        {
            return _entityRepository.Search(name, language);
        } 
        #endregion
    }
}