

namespace DamaCoreCMS.Framework.Core.Models.ViewModels
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string IconCls { get; set; }
        public int Order { get; set; }
        public string SubActions { get; set; }
        public string Requirements { get; set; }
        public bool HasAllowAnonymous { get; set; }
        public bool HasAllowAuthenticated { get; set; }
    }
}
