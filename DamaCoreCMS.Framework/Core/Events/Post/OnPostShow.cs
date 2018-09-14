
 
using MediatR;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Events.Post
{
    public class OnPostShow : IRequest<NccPost>
    {
        public NccPost Post { get; set; }
        public OnPostShow(NccPost post)
        {
            Post = post;
        }
    }

    public enum PostEvent
    {
        Create,
        StatusChange,        
        Show,
        Edit,
        Delete        
    }
}
