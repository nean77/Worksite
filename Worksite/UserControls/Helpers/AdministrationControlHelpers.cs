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
        public async Task<bool> UpdateUserAsync()
        {
            WriteAdministrationEntityHelpers write = new WriteAdministrationEntityHelpers();
            return await write.UpdateUser(_user);
        }
        public void PassUserDetails(string FirstName, string LastName, string Login, string Email, bool IsActive, bool IsAdmin, bool ChangePassword = true, long Id = 0)
        {
            _user = new User();
            _user.UserId = Id;
            _user.FirstName = FirstName;
            _user.LastName = LastName;
            _user.Login = Login;
            _user.Password = null;
            _user.Email = Email;
            _user.Active = IsActive;
            _user.Administrator = IsAdmin;
            _user.ChangePassword = ChangePassword;
            _user.CreatedDateTime = DateTime.Now;
        }
        public async Task<ICollection<User>> GetUsersAsync()
        {
            ReadEntityHelpers helpers = new ReadEntityHelpers();

            return await helpers.GetAllEmployees();
        }
    }
}
