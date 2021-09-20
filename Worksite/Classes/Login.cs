using System;
using System.Linq;
using Worksite.Classes.EntityHelpers;
using Worksite.Exceptions;

namespace Worksite.Classes
{
    public class Login
    {
        private string _passedLogin;
        private byte[] _passedPassword;
        WriteAdministrationEntityHelpers write = new WriteAdministrationEntityHelpers();
        public Login(string PassedLogin, string PassedPassword)
        {
            _passedLogin = PassedLogin;
            if (String.IsNullOrEmpty(PassedPassword))
            {
                _passedPassword = null;
            }
            else
            {
                _passedPassword = write.CalculateSHA256Password(PassedPassword);
            }
        }

        public User LoginUser()
        {
            if (_passedPassword == null)
            {
                CheckIsFirstOrChangePasswdLogin();
            }
            return GetUser();
        }

        private User GetUser()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                var list = ctx.Users.ToList();
                User user = (User)list.FirstOrDefault(u => u.Login == _passedLogin
                    && u.Password.SequenceEqual(_passedPassword));

                if (user == null)
                    throw new NonRecognizedUserException();

                return user;
            }
        }
        private void CheckIsFirstOrChangePasswdLogin()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                var list = ctx.Users.ToList();
                User user = (User)list.FirstOrDefault(u => u.Login == _passedLogin
                    && u.Active == true
                    && u.ChangePassword == true);

                if (user != null)
                    throw new FirstLoginUserException(user);

                throw new NonRecognizedUserException();

            }
        }
    }
}
