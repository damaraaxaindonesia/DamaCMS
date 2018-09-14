

using System;
using System.ComponentModel.DataAnnotations;
using DamaCoreCMS.Framework.Utility;

namespace DamaCoreCMS.Framework.Core.Mvc.Models
{
    [Serializable]
    public class BaseModel<IdT> : ValidateableModel, IBaseModel<IdT>
    {
        public BaseModel()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
            CreateBy = ModifyBy = GlobalContext.GetCurrentUserId();
            Status = EntityStatus.Active;
            VersionNumber = 1;
            Metadata = "";
            Name = "";
        }

        [Key]
        public IdT Id { get; set; }
        public int VersionNumber { get; set; }
        public string Metadata { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public long CreateBy { get; set; }
        public long ModifyBy { get; set; }        
        public int Status { get; set; }       
    }
}