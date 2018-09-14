

using System;
using System.Collections.Generic;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using static DamaCoreCMS.Framework.Core.Models.NccPage;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccPageHistory : BaseModel<long>
    { 
        public NccPageHistory()
        {
            PageDetailsHistory = new List<NccPageDetailsHistory>();
        }
        
        public string Layout { get; set; }
        public DateTime PublishDate { get; set; }
        public int PageOrder { get; set; }

        public NccPageStatus PageStatus { get; set; }
        public NccPageType PageType { get; set; }

        public NccPage Parent { get; set; }
        public long PageId { get; set; }
        public List<NccPageDetailsHistory> PageDetailsHistory { get; set; }
    }
}
