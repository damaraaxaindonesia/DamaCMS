

using Microsoft.EntityFrameworkCore;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models.ViewModels;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using DamaCoreCMS.EasyNews.Models;
using DamaCoreCMS.EasyNews.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DamaCoreCMS.EasyNews.Repositories
{
    public class NewsRepository : BaseRepository<News, long>
    {
        public NewsRepository(NccDbContext context) : base(context)
        {
        }

        public long Count(bool isActive, string keyword)
        {
            return GetBaseQuery(isActive, keyword).Count();
        }

        public List<News> Load(int from, int total, bool isActive, string keyword, string orderBy, string orderDir)
        {
            var query = GetBaseQuery(isActive, keyword);

            if (orderBy.ToLower() == "name")
            {
                if (orderDir.ToLower() == "asc")
                    query = query.OrderBy(x => x.Name);
                else
                    query = query.OrderByDescending(x => x.Name);
            }

            query = query.OrderByDescending(x => x.CreationDate);
            return query.Skip(from * total).Take(total).ToList();
        }

        #region Helper
        private IQueryable<News> GetBaseQuery(bool isActive, string keyword)
        {
            var baseQuery = Query().Include("Details").Include("CategoryList").Where(x => x.Status != EntityStatus.Deleted);

            if (isActive == true)
            {
                baseQuery = baseQuery.Where(x => x.Status == EntityStatus.Active);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                baseQuery = baseQuery.Where(x => x.Name.Contains(keyword) || x.Details.Any(y => y.Name.Contains(keyword)));
            }
            return baseQuery;
        } 
        #endregion
    }
}
