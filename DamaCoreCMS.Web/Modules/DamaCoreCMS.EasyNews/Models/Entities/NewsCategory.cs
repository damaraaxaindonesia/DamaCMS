

namespace DamaCoreCMS.EasyNews.Models.Entities
{
    public class NewsCategory
    {
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public long NewsId { get; set; }
        public News News { get; set; }
    }
}