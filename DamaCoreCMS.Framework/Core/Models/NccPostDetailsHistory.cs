

using System;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.ComponentModel.DataAnnotations;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccPostDetailsHistory : BaseModel<long>
    { 
        public string Title { get; set; }
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        [MaxLength(int.MaxValue)]
        public string Content { get; set; }
        public string Language { get; set; }

        public long PostDetailsId { get; set; }

        public NccPostHistory PostHistory { get; set; }
    }
}
