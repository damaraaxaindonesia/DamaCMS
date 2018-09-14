

using Core.Blog.Controllers;
using DamaCoreCMS.Framework.Core.Models;
using DamaCoreCMS.Framework.Core.Services;
using DamaCoreCMS.Framework.Modules.Widgets;
using System;
using System.Collections.Generic;

namespace Core.Blog.Widgets
{
    public class RecentCommentsWidget : Widget
    {
        NccCommentsService _nccCommentsService;        
        int CommentsCount = 5;

        public RecentCommentsWidget(            
            NccCommentsService nccCommentsService) : base(
                typeof(BlogController),
                "Recent Comments",
                "This is a widget to display recent blog Comments.",
                "",
                "Widgets/RecentComments",
                "Widgets/RecentCommentsConfig",
                true
            )
        {
            _nccCommentsService = nccCommentsService;
        }

        public override void InitConfig(dynamic config)
        {
            try
            {
                string cc = config.commentsCount;
                CommentsCount = string.IsNullOrEmpty(cc) ? 5 : Convert.ToInt32(cc);
            }
            catch (Exception) { CommentsCount = 5; }
        }

        public override object PrepareViewModel()
        {
            List<NccComment> commentsList = _nccCommentsService.LoadRecentComments(CommentsCount);            
            return commentsList;
        }
    }
}