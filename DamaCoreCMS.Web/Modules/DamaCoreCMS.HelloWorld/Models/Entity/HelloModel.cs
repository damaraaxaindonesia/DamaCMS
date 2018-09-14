

using DamaCoreCMS.Framework.Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.HelloWorld.Models.Entity
{
    public class HelloModel : BaseModel<long>
    {
        public string Hello { get; set; }
    }
}
