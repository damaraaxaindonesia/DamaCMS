

using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccPostCategory
    {
        public long PostId { get; set; }        
        public long CategoryId { get; set; }

        public NccPost Post { get; set; }
        public NccCategory Category { get; set; }
    }
}
