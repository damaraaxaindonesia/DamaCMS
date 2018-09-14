

using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Exceptions
{
    public class DuplicateRecordException : Exception
    {
        public DuplicateRecordException(string message):base(message)
        {            
        }
    }
}
