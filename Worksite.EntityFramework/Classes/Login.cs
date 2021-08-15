using System.Linq;
using Worksite.EntityFramework.Exceptions;

namespace Worksite.EntityFramework.Classes
{
    public class Login
    {
        private string _passedLogin;
        private string _passedPassword;
        public Login(string PassedLogin, string PassedPassword)
        {
            _passedLogin = PassedLogin;
            _passedPassword = PassedPassword;
        }

        public User LoginUser()
        {
            return GetUser();
        }

        private User GetUser()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                var list = ctx.Users.ToList();
                User user = list.FirstOrDefault(u => u.Login == _passedLogin
                    && u.Password == _passedPassword);

                if (user == null)
                    throw new NonRecognizedUserException();

                return user;
            }

        }
    }
}
