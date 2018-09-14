﻿

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using DamaCoreCMS.Framework.Core.Mvc.Models;
using System.Collections.Generic;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccRole : IdentityRole<long>, IBaseModel<long>
    {
        public NccRole()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }
        public int VersionNumber { get; set; }
        public string Metadata { get; set; }
        public string Slug { get; set; }        
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public long CreateBy { get; set; }
        public long ModifyBy { get; set; }
        public int Status { get; set; }

        public virtual ICollection<NccUserRole> Users { get; } = new List<NccUserRole>();
    }
}
