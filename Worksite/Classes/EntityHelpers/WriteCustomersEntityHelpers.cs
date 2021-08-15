using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers
{
    public class WriteCustomersEntityHelpers : IWriteCustomersEntityHelpers
    {
        CurrentUser currentUser = CurrentUser.GetInstance();
        public async Task<bool> Save(Customer customer)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    ctx.Customers.Add(customer);
                    await ctx.SaveChangesAsync();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Update(Customer customer)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    Customer cust = await ctx.Customers.Where(c => c.CustomerId == customer.CustomerId).FirstAsync();
                    cust.FirstName = customer.FirstName;
                    cust.LastName = customer.LastName;
                    cust.CompanyName = customer.CompanyName;
                    cust.PhoneNo = customer.PhoneNo;
                    cust.Description = customer.Description;

                    ctx.Entry(cust).State = EntityState.Modified;
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
