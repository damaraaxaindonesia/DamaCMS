
 
using MediatR;
using DamaCoreCMS.Framework.Core.Events.Post;
using DamaCoreCMS.Framework.Core.Models;
 

namespace DamaCoreCMS.Framework.Core.Hooks
{
    public class OnPostShowHandler : IRequestHandler<OnPostShow, NccPost>
    {
        public NccPost Handle(OnPostShow message)
        {
            var post = message.Post; 
            return post;
        }
    }
}
