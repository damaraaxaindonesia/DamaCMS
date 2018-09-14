

using DamaCoreCMS.Framework.Modules.Widgets;
using DamaCoreCMS.HelloWorld.Controllers;

namespace DamaCoreCMS.HelloWorld.Widgets
{
    public class NavBarWidget : Widget
    { 
        public NavBarWidget():base(typeof(HelloHomeController), "NavBar", "NavBar Widget", "", "Widgets/NavBar")
        {
            
        } 
    }
}
