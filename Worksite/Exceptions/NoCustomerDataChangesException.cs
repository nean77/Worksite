using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Exceptions
{
    public class NoCustomerDataChangesException : Exception
    {
        public NoCustomerDataChangesException()
        {
        }

        public NoCustomerDataChangesException(string message) : base(message)
        {
        }

        public NoCustomerDataChangesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
