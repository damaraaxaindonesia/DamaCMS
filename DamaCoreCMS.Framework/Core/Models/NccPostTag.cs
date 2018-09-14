

using System;

namespace DamaCoreCMS.Framework.Core.Models
{
    [Serializable]
    public class NccPostTag
    {
        public long PostId { get; set; }
        public long TagId { get; set; }

        public NccPost Post { get; set; }

        public NccTag Tag { get; set; }
    }
}
