using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Worksite.Exceptions;

namespace Worksite.Classes.EntityHelpers
{
    public class ReadEntityHepers : IReadEntityHelpers
    {
        CurrentUser currentUser = CurrentUser.GetInstance();
                
        public ICollection<ServiceType> GetServiceTypes()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return ctx.ServiceTypes.Select(x => x).ToList();
            }
        }
        public ICollection<ServiceStatus> GetServiceStatuses()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return ctx.ServiceStatuses.Select(x => x).ToList();
            }
        }
        public ICollection<User> GetActiveEmployees()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return ctx.Users.Select(x => x).Where(x => x.Active == true).ToList();
            }
        } 
        public async Task<ICollection<AllService>> GetServices()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.AllServices.Select(x => x).ToListAsync();
            }
        }
        public ServiceOrder GetServiceById(long Id)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return (ServiceOrder)ctx.ServiceOrders.Select(x => x.ServiceOrderId == Id);
            }
        }
        public Device GetDeviceById(long Id)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return (Device)ctx.Devices
                    .Include(c => c.Customer)
                    .SingleOrDefault(x => x.DeviceId == Id);
            }
        }
        public Customer GetCustomerById(long Id)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return (Customer)ctx.Customers.Select(x => x.CustomerId == Id);
            }
        }
        public Device GetByInventNo(long InventNo)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return (Device)ctx.Devices.Select(x => x.InventNo == InventNo);
            }
        }
        public async Task<ICollection<Customer>> GetCustomers()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.Customers.Select(x => x).ToListAsync();
            }
        }
        public async Task<ICollection<AllDevice>> GetDevices()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.AllDevices.Select(x => x).ToListAsync();
            }
        }
        public async Task<int> GetUserExpiredServices()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                int count = await ctx.AllExpiredServices.CountAsync(os => os.UserId == currentUser.UserId);

                return count;
            }
        }
        public async Task<int> GetUserOpenServices()
        {            
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                int count = await ctx.AllOpenServices.CountAsync(os => os.UserId == currentUser.UserId);

                return count;
            }
        }
        public async Task<bool> HasCustomerChanges(Customer customer)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                Customer cust = await ctx.Customers.FirstOrDefaultAsync(c => c.CustomerId == customer.CustomerId);

                if (cust.Equals(customer))
                {
                    throw new NoCustomerDataChangesException();
                }
                return true;
            }
        }
        public async Task<bool> HasDeviceChanges(Device device)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                Device dev = await ctx.Devices.FirstOrDefaultAsync(d => d.DeviceId == device.DeviceId);

                if (dev.Equals(device))
                {
                    throw new NoDeviceDataChangesException();
                }
                return true;
            }
        }
    }
}
