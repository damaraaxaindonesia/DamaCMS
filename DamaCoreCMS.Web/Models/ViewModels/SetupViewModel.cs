

using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Setup;
using System.ComponentModel.DataAnnotations;

namespace DamaCoreCMS.Core.Modules.Setup.Models.ViewModels
{
    public class SetupViewModel : DatabaseInfo
    { 
        public SupportedDatabases Database { get; set; }
        
    }
}
