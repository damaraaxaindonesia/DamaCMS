

using DamaCoreCMS.Framework.Modules.Widgets;
using DamaCoreCMS.HelloWorld.Controllers;

namespace DamaCoreCMS.HelloWorld.Widgets
{
    public class TopBarWidget : Widget
    {
        public TopBarWidget():base(typeof(HelloHomeController), "TopBar", "TopBar Widget", "", "Widgets/TopBar")
        {
            
        }        
    }
}
