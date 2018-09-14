

using System;
using System.Collections.Generic;
using System.Linq;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using DamaCoreCMS.Framework.Core.Mvc.Services;
using DamaCoreCMS.EasyNews.Repositories;
using Microsoft.EntityFrameworkCore;
using DamaCoreCMS.EasyNews.Models.Entities;
using DamaCoreCMS.Framework.Core.Mvc.Service;

namespace DamaCoreCMS.EasyNews.Services
{
    public class CategoryService : BaseService<Category>
    {
        private readonly CategoryRepository _entityRepository;

        public CategoryService(CategoryRepository entityRepository) : base(entityRepository, new List<string>() { "Details" })
        {
            _entityRepository = entityRepository;
        }

        #region Method Override
        public override void AfterCopyData(Category entity, Category oldEntity)
        {
            var currentDateTime = DateTime.Now;
            foreach (var item in entity.Details)
            {
                var isNew = false;
                var temp = oldEntity.Details.Where(x => x.Language == item.Language).FirstOrDefault();
                if (temp == null)
                {
                    isNew = true;
                    temp = new CategoryDetails();
                    temp.Language = item.Language;
                }
                temp.Metadata = item.Metadata;
                temp.Name = item.Name;
                if (isNew)
                {
                    oldEntity.Details.Add(temp);
                }
            }
        }
        #endregion

        #region New Method
        public long Count(bool isActive, string keyword)
        {
            return _entityRepository.Count(isActive, keyword);
        }

        public List<Category> Load(int from, int total, bool isActive, string keyword, string orderBy, string orderDir)
        {
            return _entityRepository.Load(from, total, isActive, keyword, orderBy, orderDir);
        } 
        #endregion
    }
}