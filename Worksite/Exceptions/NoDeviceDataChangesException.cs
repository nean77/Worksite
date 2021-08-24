using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Exceptions
{
    public class NoDeviceDataChangesException : Exception
    {
        public NoDeviceDataChangesException()
        {
        }

        public NoDeviceDataChangesException(string message) : base(message)
        {
        }

        public NoDeviceDataChangesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
