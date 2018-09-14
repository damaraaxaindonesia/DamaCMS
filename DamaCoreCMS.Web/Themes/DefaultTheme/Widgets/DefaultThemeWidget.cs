

using DefaultTheme.Controllers;
using DamaCoreCMS.Framework.Modules.Widgets;

namespace DefaultTheme.Widgets
{
    public class DefaultThemeWidget : Widget
    { 
        public DefaultThemeWidget():base(typeof(DefaultThemeController), "Default Theme", "Default theme Hello Widget", "", "Widgets/Hello")
        {
            
        }
    }
}
