

using DamaCoreCMS.Framework.Modules.Widgets;
using DamaCoreCMS.HelloWorld.Controllers;

namespace DamaCoreCMS.HelloWorld.Widgets
{
    public class FooterMenuWidget : Widget
    { 
        public FooterMenuWidget():base(typeof(HelloHomeController), "Footer Menu", "Footer nevigation menu", "", "Widgets/FooterMenu")
        {
           
        }
    }
}
