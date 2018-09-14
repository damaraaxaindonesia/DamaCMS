
 
using MediatR;

namespace DamaCoreCMS.Framework.Core.Events.Post
{
    public class OnCommentActivity : IRequest<CommentActivity>
    {
        public CommentActivity Data { get; set; }
        public OnCommentActivity(CommentActivity data)
        {
            Data = Data;
        }
    }
}
