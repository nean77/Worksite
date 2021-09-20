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
        private ICollection<Customer> _customers = new List<Customer>();

        public CustomersControlHelpers()
        {
            fillList();
        }

        private async void fillList()
        {
            Customers = await GetCustomersAsync();
        }

        public Customer Customer { get => _cust; set => _cust = value; }
        public ICollection<Customer> Customers { get => _customers; set => _customers = value; }

        public static async Task<ICollection<Customer>> GetCustomersAsync()
        {
            ReadEntityHelpers entityHelpers = new ReadEntityHelpers();

            return await entityHelpers.GetCustomers();
        }

        public async Task<bool> HasChanges()
        {
            ReadEntityHelpers entityHelpers = new ReadEntityHelpers();

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
