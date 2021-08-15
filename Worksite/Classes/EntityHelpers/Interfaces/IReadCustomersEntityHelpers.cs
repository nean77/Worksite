using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers
{
    public interface IReadCustomersEntityHelpers
    {
        Task<ICollection<Customer>> GetCustomers();
        Customer GetCustomerById(long Id);
        Task<bool> HasCustomerChanges(Customer customer);
    }
}
