using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.DataModels
{
    public class CustomerModel
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public CustomerModel(long Id, string FirstName, string LastName, string CompanyName, string PhoneNo, string Email, string Description)
        {
            this.CustomerId = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CompanyName = CompanyName;
            this.PhoneNo = PhoneNo;
            this.Email = Email;
            this.Description = Description;
        }

        public object[] ToObjTbl()
        {
            return new object[] { CustomerId, FirstName, LastName, CompanyName, PhoneNo, Email, Description };
        }

        public static List<CustomerModel> customersList = new List<CustomerModel>();
    }
}
