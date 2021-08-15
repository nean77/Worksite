using System;

namespace Worksite.Exceptions
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
