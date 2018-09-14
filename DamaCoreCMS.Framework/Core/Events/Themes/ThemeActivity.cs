
 
using DamaCoreCMS.Framework.Themes;

namespace DamaCoreCMS.Framework.Core.Events.Themes
{
    public class ThemeActivity
    {
        public Theme Theme { get; set; }
        public Type ActivityType { get; set; }

        public enum Type
        {
            Download,
            Install,
            Activated,
            Deactivated,
            Uninstall            
        }
    }
}
