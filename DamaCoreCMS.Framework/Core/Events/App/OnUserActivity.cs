
 
using MediatR;

namespace DamaCoreCMS.Framework.Core.Events.App
{
    public class OnUserActivity : IRequest<UserActivity>
    {
        public UserActivity Data { get; set; }
        public OnUserActivity(UserActivity data)
        {
            Data = data;
        }
    }
}
