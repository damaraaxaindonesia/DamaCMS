

using System;

namespace DamaCoreCMS.Framework.Core.Exceptions
{
    public class InvalidRequestException : Exception
    {
        public InvalidRequestException(string message):base(message)
        {            
        }
    }
}
