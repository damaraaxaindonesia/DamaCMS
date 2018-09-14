
 
using System;
using System.Collections.Generic;
using System.Text;

namespace DamaCoreCMS.Framework.Core.Exceptions
{
    public class KeyAlreadyExistsException : Exception
    {
        public KeyAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
