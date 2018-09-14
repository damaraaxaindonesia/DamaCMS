
 
using DamaCoreCMS.Framework.Modules;

namespace DamaCoreCMS.Framework.Core.Events.Modules
{
    public class ModuleActivity
    {
        public IModule Module{ get; set; }
        public Type ActivityType { get; set; }

        public enum Type
        {
            Downloaded,
            Installed,
            Activated,
            Deactivated,
            Uninstalled,
            Removed
        }
    }
}
