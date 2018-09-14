

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccCategory : BaseModel<long>
    { 
        public NccCategory()
        {
            CategoryDetails = new List<NccCategoryDetails>();
            Posts = new List<NccPostCategory>();
        }

        public string CategoryImage { get; set; }

        public NccCategory Parent { get; set; }
        public List<NccCategoryDetails> CategoryDetails { get; set; }
        public List<NccPostCategory> Posts { get; set; }
    }
}
