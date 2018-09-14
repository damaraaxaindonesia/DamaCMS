

using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException(string message):base(message)
        {            
        }
    }
}
