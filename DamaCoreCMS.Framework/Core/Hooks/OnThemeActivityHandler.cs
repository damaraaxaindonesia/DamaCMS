

using MediatR;
using DamaCoreCMS.Framework.Core.Events.Themes;
using DamaCoreCMS.Framework.Core.Messages;

namespace DamaCoreCMS.Framework.Core.Hooks
{
    public class OnThemeActivityHandler : IRequestHandler<OnThemeActivity, ThemeActivity>
    {    
        public ThemeActivity Handle(OnThemeActivity message)
        {
            //GlobalMessageRegistry.RegisterMessage(new GlobalMessage()
            //{
            //    For = GlobalMessage.MessageFor.Both,
            //    Registrater = "CoreModule",
            //    Text = message.Data.ActivityType.ToString(),
            //    Type = GlobalMessage.MessageType.Info
            //}, new System.TimeSpan(0, 0, 10));
            return message.Data;
        }     
    }
}
