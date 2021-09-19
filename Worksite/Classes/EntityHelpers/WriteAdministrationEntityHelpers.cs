using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers.Interfaces;

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
    }
}
