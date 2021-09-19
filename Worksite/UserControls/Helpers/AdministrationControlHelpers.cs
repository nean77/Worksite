using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class AdministrationControlHelpers : BaseUserControlHelpers
    {
        private User _user;

        public async Task<bool> SaveUserAsync()
        {
            WriteAdministrationEntityHelpers write = new WriteAdministrationEntityHelpers();
            return await write.SaveNewUser(_user);
        }
        public void PassUserDetails(string FirstName, string LastName, string Login, string Email, bool IsActive, bool IsAdmin)
        {
            _user = new User();
            _user.FirstName = FirstName;
            _user.LastName = LastName;
            _user.Login = Login;
            _user.Password = String.Empty;
            _user.Email = Email;
            _user.Active = IsActive;
            _user.Administrator = IsAdmin;
            _user.ChangePassword = true;
            _user.CreatedDateTime = DateTime.Now;
        }
    }
}
