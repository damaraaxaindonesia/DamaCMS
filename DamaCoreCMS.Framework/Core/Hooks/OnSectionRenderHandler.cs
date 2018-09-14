
 
using MediatR;
using DamaCoreCMS.Framework.Core.Events.Themes;

namespace DamaCoreCMS.Framework.Core.Hooks
{
    public class OnSectionRenderHandler : IRequestHandler<OnThemeSectionRender, ThemeSection>
    {    
        public ThemeSection Handle(OnThemeSectionRender message)
        { 
            return message.Data;
        }     
    }
}
