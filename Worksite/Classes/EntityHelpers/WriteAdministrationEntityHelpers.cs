using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers.Interfaces;
using System.Security.Cryptography;


namespace Worksite.Classes.EntityHelpers
{
    public class WriteAdministrationEntityHelpers : IWriteAdministrationEntityHelpers
    {
        public async Task<bool> SaveNewUser(User user)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    ctx.Users.Add(user);
                    await ctx.SaveChangesAsync();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdatePassword(User user)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    User usr = await ctx.Users.Where(u => u.UserId == user.UserId).FirstAsync();
                    usr.Password = user.Password;
                    usr.ChangePassword = user.ChangePassword;

                    ctx.Entry(usr).State = EntityState.Modified;
                    await ctx.SaveChangesAsync();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }

        public byte[] CalculateSHA256Password(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();
            hashValue = sha256.ComputeHash(objUtf8.GetBytes(str));

            return hashValue;
        }

        public async Task<bool> UpdateUser(User user)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    User usr = await ctx.Users.Where(u => u.UserId == user.UserId).FirstAsync();
                    usr.FirstName = user.FirstName;
                    usr.LastName = user.LastName;
                    usr.Login = user.Login;
                    usr.Email = user.Email;
                    usr.Administrator = user.Administrator;
                    usr.Active = user.Active;
                    usr.ChangePassword = user.ChangePassword;

                    ctx.Entry(usr).State = EntityState.Modified;
                    await ctx.SaveChangesAsync();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }
    }
}
