﻿

using DamaCoreCMS.Framework.Core.Mvc.Models;
using DamaCoreCMS.Framework.Core.Mvc.Views;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Modules.Widgets;
using DamaCoreCMS.EasyNews.Controllers;
using DamaCoreCMS.EasyNews.Models.ViewModels;
using DamaCoreCMS.EasyNews.Services;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace DamaCoreCMS.EasyNews.Widgets
{
    public class NewsHorizontalWidget : Widget
    {
        NewsService _neNewsService;        
        int newsCount = 10;

        string headerTitle = "";
        string headerColor = "";
        string headerBgColor = "";

        string category = "";
        string columnClass = "";
        string columnColor = "";
        string columnBgColor = "";
        string scrollamount = "5";
        string height = "30";

        string footerTitle = "";
        string footerColor = "";
        string footerBgColor = "";

        public NewsHorizontalWidget(NewsService neNewsService) : base(
                typeof(EasyNewsController),
                "Horizontal News",
                "This is a widget to scroll news horizontally.",
                "",
                "Widgets/NewsHorizontal",
                "Widgets/NewsConfig",
                false
            )
        {   
            _neNewsService = neNewsService;
        }

        public override void InitConfig(dynamic config)
        {
            category = config.category;
            try
            {
                newsCount = Convert.ToInt32(config.newsCount);
            }
            catch (Exception) { newsCount = 10; }

            headerTitle = config.headerTitle;
            headerColor = config.headerColor;
            headerBgColor = config.headerBgColor;
            columnClass = config.columnClass;
            columnColor = config.columnColor;
            columnBgColor = config.columnBgColor;
            scrollamount = config.scrollamount;
            height = config.height;

            footerTitle = config.footerTitle;
            footerColor = config.footerColor;
            footerBgColor = config.footerBgColor;
        }

        public override object PrepareViewModel()
        {
            var itemList = _neNewsService.LoadAllByCategory(category);
            if (category.Trim() == "")
            {
                itemList = _neNewsService.LoadAll()
                    .Where(x => x.Status >= EntityStatus.Active && (x.HasDateRange == false || (x.PublishDate >= DateTime.Now && x.ExpireDate <= DateTime.Now)))
                    .OrderByDescending(x => x.Id)
                    .Take(newsCount)
                    .OrderBy(x => x.Order)
                    .ToList();
            }
            var item = new NewsViewModel()
            {
                HeaderTitle = headerTitle,
                HeaderColor = headerColor,
                HeaderBgColor = headerBgColor,

                ColumnClass = columnClass.Trim() == "" ? "" : columnClass,
                ColumnColor = columnColor,
                ColumnBgColor = columnBgColor,
                Scrollamount = scrollamount,
                Height = height.Trim() == "" ? "30" : height,

                FooterTitle = footerTitle,
                FooterColor = footerColor,
                FooterBgColor = footerBgColor,
                NewsList = itemList
            };
           
            return item;
        }
    }
}