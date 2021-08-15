using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers
{
    public interface IWriteCustomersEntityHelpers
    {
        Task<bool> Save(Customer customer);
        Task<bool> Update(Customer customer);
    }
}
