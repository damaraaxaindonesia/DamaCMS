

using DamaCoreCMS.Framework.Modules.Widgets;
using DamaCoreCMS.HelloWorld.Controllers;

namespace DamaCoreCMS.HelloWorld.Widgets
{
    public class HelloWidget : Widget
    {
        public HelloWidget():base(typeof(HelloHomeController), "Hello", "Hello Widget", "", "Widgets/Hello")
        {
            
        }        
    }
}
