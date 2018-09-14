using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Auth
{
    public class ControllerActionCache
    {
        public static List<ControllerAction> ControllerActions { get; set; } = new List<ControllerAction>();
    }
}
