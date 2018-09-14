
 
using MediatR;
using DamaCoreCMS.Framework.Core.Events.Page;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Hooks
{
    public class OnPageShowHandler : IRequestHandler<OnPageShow, NccPage>
    {
        public NccPage Handle(OnPageShow message)
        {
            var post = message.Page;            
            return post;
        }
    }
}
