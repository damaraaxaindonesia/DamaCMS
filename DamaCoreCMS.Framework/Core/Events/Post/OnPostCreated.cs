
 
using MediatR;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Events.Post
{
    public class OnPostCreated : IRequest<NccPost>
    {
        public NccPost Post { get; set; }
        public OnPostCreated(NccPost post)
        {
            Post = post;
        }
    }
}
