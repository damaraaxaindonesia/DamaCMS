

using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.Collections.Generic;

namespace DamaCoreCMS.EasyNews.Models.Entities
{
    public class Category : BaseModel<long>
    {
        public Category()
        {
            Details = new List<CategoryDetails>();
            NewsList = new List<NewsCategory>();
        }

        public List<CategoryDetails> Details { get; set; }
        public List<NewsCategory> NewsList { get; set; }
    }

    public class CategoryDetails : BaseModel<long>
    {
        public string Language { get; set; }
        public Category Category { get; set; }
    }
}