using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers.Interfaces
{
    public interface IWriteAdministrationEntityHelpers
    {
        Task<bool> SaveNewUser(User user);

    }
}
