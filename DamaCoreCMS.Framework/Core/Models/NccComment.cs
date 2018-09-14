

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccComment : BaseModel<long>
    { 
        public string Title { get; set; }
        public string Content { get; set; }

        public NccPost Post { get; set; }
        public NccUser Author { get; set; }

        public string AuthorName { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public NccCommentStatus CommentStatus { get; set; }

        public enum NccCommentStatus
        {
            Pending,
            Approved,
            Rejected,
            Spam
        }
    } 
}
