using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.DataModels;
using Worksite.UserControls.CustomersUC;

namespace Worksite.Helpers.UserUI_helpers
{
    public class CustomersPGHelpers
    {
        List<Customer> customers = new List<Customer>();
        public void initData()
        {
            using (WorksiteEntities context = new WorksiteEntities())
            {
                customers = context.Customers.Select(x => x).ToList();

                foreach(var c in customers)
                {
                    CustomerModel customerModel = new CustomerModel(
                            c.CustomerId,
                            c.FirstName,
                            c.LastName,
                            c.CompanyName,
                            c.PhoneNo,
                            c.Email,
                            c.Description
                        );
                    CustomerModel.customersList.Add(customerModel);
                }
            }
        }
    }
}
