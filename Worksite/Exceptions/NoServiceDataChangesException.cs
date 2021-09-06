using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Exceptions
{
    public class NoServiceDataChangesException : Exception
    {
        public NoServiceDataChangesException()
        {
        }

        public NoServiceDataChangesException(string message) : base(message)
        {
        }

        public NoServiceDataChangesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
