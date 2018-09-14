
 
using MediatR;

namespace DamaCoreCMS.Framework.Core.Events.Themes
{
    public class OnThemeActivity : IRequest<ThemeActivity>
    {
        public ThemeActivity Data { get; set; }
        public OnThemeActivity(ThemeActivity data)
        {
            Data = data;
        }
    }
}
