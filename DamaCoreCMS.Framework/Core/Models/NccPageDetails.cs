

using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccPageDetails : BaseModel<long>
    { 
        public string Title { get; set; }      
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        [MaxLength(int.MaxValue)]
        public string Content { get; set; }
        public string Language { get; set; }

        public NccPage Page { get; set; }
    }
}
