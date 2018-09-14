
 
using MediatR;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Events.Post
{
    public class OnPostEdited : IRequest<NccPost>
    {
        public NccPost OldPost { get; set; }
        public NccPost NewPost { get; set; }
        public OnPostEdited(NccPost oldPost, NccPost newPost)
        {
            OldPost = oldPost;
            NewPost = newPost;
        }
    }
}
