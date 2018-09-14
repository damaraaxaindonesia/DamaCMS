

using MediatR;
using DamaCoreCMS.Framework.Core.Events.App;
using DamaCoreCMS.Framework.Core.Messages;

namespace DamaCoreCMS.Framework.Core.Hooks
{
    public class OnAppActivityHandler : IRequestHandler<OnAppActivity, AppActivity>
    {    
        public AppActivity Handle(OnAppActivity message)
        {
            return message.Data;
        }     
    }
}
