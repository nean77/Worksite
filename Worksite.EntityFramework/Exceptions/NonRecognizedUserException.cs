using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.EntityFramework.Exceptions
{
    public class NonRecognizedUserException : Exception
    {
        public NonRecognizedUserException()
        {
        }

        public NonRecognizedUserException(string message) : base(message)
        {
        }

        public NonRecognizedUserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
