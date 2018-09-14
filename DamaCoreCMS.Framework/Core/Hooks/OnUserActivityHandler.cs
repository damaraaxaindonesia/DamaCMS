

using MediatR;
using DamaCoreCMS.Framework.Core.Events.App;
using DamaCoreCMS.Framework.Core.Messages;

namespace DamaCoreCMS.Framework.Core.Hooks
{
    public class OnUserActivityHandler : IRequestHandler<OnUserActivity, UserActivity>
    {    
        public UserActivity Handle(OnUserActivity message)
        {
            return message.Data;
        }     
    }
}
