

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccTag : BaseModel<long>
    { 
        public NccTag()
        {
            Posts = new List<NccPostTag>();
        }

        public List<NccPostTag> Posts { get; set; }
    }
}
