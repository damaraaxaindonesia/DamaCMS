
 
using MediatR;
namespace DamaCoreCMS.Framework.Core.Events.Themes
{
    public class OnThemeSectionRender : IRequest<ThemeSection>
    {
        public ThemeSection Data { get; set; }
        public OnThemeSectionRender(ThemeSection data)
        {
            Data = data;
        }
    }
}
