
 
using MediatR;
using DamaCoreCMS.Framework.Core.Models;

namespace DamaCoreCMS.Framework.Core.Events.Page
{
    public class OnPageShow : IRequest<NccPage>
    {
        public NccPage Page { get; set; }
        public OnPageShow(NccPage page)
        {
            Page = page;
        }
    }
}
