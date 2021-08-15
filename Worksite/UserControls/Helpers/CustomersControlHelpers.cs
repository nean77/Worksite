using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class CustomersControlHelpers : BaseUserControlHelpers
    {
        private Customer _cust;
        public Customer Customer { get => _cust; set => _cust = value; }
        public static async Task<ICollection<Customer>> GetCustomersAsync()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetCustomers();
        }

        public async Task<bool> HasChanges()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.HasCustomerChanges(Customer);
        }

        public async Task<bool> SaveAsync()
        {
            WriteCustomersEntityHelpers writeHelpers = new WriteCustomersEntityHelpers();

            return await writeHelpers.Save(Customer);
        }
        public async Task<bool> UpdateAsync()
        {
            WriteCustomersEntityHelpers writeHelpers = new WriteCustomersEntityHelpers();

            return await writeHelpers.Update(Customer);
        }
    }
}
