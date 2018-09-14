

using DamaCoreCMS.EasyNews.Models.Entities;
using System.Collections.Generic;

namespace DamaCoreCMS.EasyNews.Models.ViewModels
{
    public class NewsViewModel
    {
        public string HeaderTitle { get; set; }
        public string HeaderColor { get; set; }
        public string HeaderBgColor { get; set; }

        public string ColumnClass { get; set; }
        public string ColumnColor { get; set; }
        public string ColumnBgColor { get; set; }
        public string Scrollamount { get; set; }
        public string Height { get; set; }

        public string FooterTitle { get; set; }
        public string FooterColor { get; set; }
        public string FooterBgColor { get; set; }
        public List<News> NewsList { get; set; }
    }
}