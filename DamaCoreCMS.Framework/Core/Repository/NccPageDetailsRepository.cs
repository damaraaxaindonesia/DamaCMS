﻿

using System;
using System.Linq;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Mvc.Repository;
using Microsoft.EntityFrameworkCore;

namespace DamaCoreCMS.Framework.Core.Repository
{
    public class NccPageDetailsRepository : BaseRepository<NccPageDetails, long>
    {
        public NccPageDetailsRepository(NccDbContext context) : base(context)
        {
        }

        public NccPageDetails Get(string slug, string language = "")
        {
            var query = Query().Include("Page").Include("Page.PageDetails").Where(x => x.Slug == slug);
            if (!string.IsNullOrEmpty(language))
            {
                query = query.Where(x => x.Language == language);
            }
            return query.FirstOrDefault();
        }

        public List<NccPageDetails> Search(string name, string language = "", int count = 20)
        {
            var query = Query().Include("Page").Include("Page.PageDetails").Where(x => x.Name.Contains(name) || x.Title.Contains(name) || x.Slug.Contains(name) || x.Page.Name.Contains(name));
            if (!string.IsNullOrEmpty(language))
            {
                query = query.Where(x => x.Language == language);
            }
            return query.Take(count).ToList();
        }

        public List<NccPageDetails> LoadAllByStatus(NccPage.NccPageStatus status)
        {
            var query = Query().Include("Page").Include("Page.PageDetails").Where(x => x.Page.PageStatus == status);
            return query.ToList();
        }

        public List<NccPageDetails> LoadRecentPageDetails(int limit, string language = "")
        {
            var query = Query().Include("Page").Where(x => x.Page.PageStatus == NccPage.NccPageStatus.Published);
            if (!string.IsNullOrEmpty(language))
            {
                query = query.Where(x => x.Language == language);
            }
            return query.OrderByDescending(x => x.Page.PublishDate).Take(limit).ToList();
        }
    }
}
