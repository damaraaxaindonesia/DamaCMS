

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccCategoryDetails : BaseModel<long>
    {          
        public string Title { get; set; }
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string Language { get; set; }

        public NccCategory Category { get; set; }
    }
}
