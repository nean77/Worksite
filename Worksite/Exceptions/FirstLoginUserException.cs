using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Exceptions
{
    public class FirstLoginUserException : Exception
    {
        User _user;
        public User User { get => _user;}
        public FirstLoginUserException()
        {
        }
        public FirstLoginUserException(User user)
        {
            _user = user;
        }

        public FirstLoginUserException(string message) : base(message)
        {
        }

        public FirstLoginUserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
