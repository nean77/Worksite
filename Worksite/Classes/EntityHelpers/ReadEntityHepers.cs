using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Worksite.Exceptions;

namespace Worksite.Classes.EntityHelpers
{
    public class ReadEntityHelpers : IReadEntityHelpers
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
        public async Task<ICollection<User>> GetAllEmployees()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.Users.Select(x => x).ToListAsync();
            }
        }
        public async Task<ICollection<ServiceOrder>> GetServices()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                await ctx.ServiceTypes.Select(x => x).ToListAsync();
                await ctx.ServiceStatuses.Select(x => x).ToListAsync();
                var list = await ctx.ServiceOrders.Select(x => x)
                    .Include(so => so.Customer)
                    .Include(so => so.Device)
                    .Include(so => so.User)
                    .Include(so => so.ServiceOrders_ServiceStatuses)                    
                    .Include(so => so.ServiceOrders_ServiceTypes)                    
                    .ToListAsync();

                return list;
            }
        }
        public async Task<ICollection<ServiceOrder>> GetUserServices(long userId)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                await ctx.ServiceTypes.Select(x => x).ToListAsync();
                await ctx.ServiceStatuses.Select(x => x).ToListAsync();
                var list = await ctx.ServiceOrders.Select(x => x)
                    .Where(x => x.UserId == userId)
                    .Include(so => so.Customer)
                    .Include(so => so.Device)
                    .Include(so => so.User)
                    .Include(so => so.ServiceOrders_ServiceStatuses)
                    .Include(so => so.ServiceOrders_ServiceTypes)
                    .ToListAsync();

                return list;
            }
        }
        public async Task<ServiceOrder> GetServiceById(long Id)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                await ctx.ServiceTypes.Select(x => x).ToListAsync();
                await ctx.ServiceStatuses.Select(x => x).ToListAsync();

                var order = await ctx.ServiceOrders
                        .Include(so => so.ServiceOrders_ServiceStatuses)
                        .Include(so => so.ServiceOrders_ServiceTypes)
                        .Include(so => so.Customer)
                        .Include(so => so.Device)
                        .Include(so => so.User)
                        .FirstOrDefaultAsync(x => x.ServiceOrderId == Id);

                return order;
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
        public async Task<ICollection<Device>> GetDevices()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.Devices.Select(x => x)
                    .Include(c => c.Customer)
                    .Include(d => d.DeviceType)
                    .ToListAsync();
            }
        }
        public async Task<ICollection<Device>> GetCustomerDevices(Customer customer)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.Devices.Select(x => x)
                    .Where(c => c.CustomerId == customer.CustomerId)
                    .ToListAsync();
            }
        }
        public async Task<int> GetUserExpiredServices()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.AllExpiredServices.CountAsync(os => os.UserId == currentUser.UserId);
            }
        }
        public async Task<int> GetUserOpenServices()
        {            
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.AllOpenServices.CountAsync(os => os.UserId == currentUser.UserId);
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
        public async Task<bool> HasServiceChanges(ServiceOrder serviceOrder)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                ServiceOrder so = await ctx.ServiceOrders
                    .Include(x=> x.ServiceOrders_ServiceStatuses)
                    .FirstOrDefaultAsync(s => s.ServiceOrderId == serviceOrder.ServiceOrderId);

                if (so.Equals(serviceOrder))
                {
                    throw new NoServiceDataChangesException();
                }
                return true;
            }
        }
        public decimal GetOtherWorkHours(long serviceId)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return (decimal) ctx.ServiceOrders_ServiceTypes
                    .Where(x => x.ServiceOrderId == serviceId && x.ServiceTypeId == 8)
                    .Sum(x => x.Hours); 
            }
        }
        public async Task<int> GetServicesCount()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.ServiceOrders.CountAsync();
            }
        }
        public async Task<int> GetOpenServicesCount()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.AllOpenServices.CountAsync();
            }
        }
        public async Task<int> GetExpiresServicesCount()
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                return await ctx.AllExpiredServices.CountAsync();
            }
        }
        public async Task<decimal> GetTotalServicesPrice()
        {
            decimal defaultServicesPrice, hoursSum, otherServicePrice = 0, result=0;
            List<ServiceOrder> list = new List<ServiceOrder>();
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                await ctx.ServiceTypes.Select(x => x).ToListAsync();
                await ctx.ServiceStatuses.Select(x => x).ToListAsync();
                list = await ctx.ServiceOrders.Select(x => x)
                    .Include(so => so.Customer)
                    .Include(so => so.Device)
                    .Include(so => so.User)
                    .Include(so => so.ServiceOrders_ServiceStatuses)
                    .Include(so => so.ServiceOrders_ServiceTypes)
                    .ToListAsync();

                foreach (var l in list)
                {
                    defaultServicesPrice = l.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId < 8).Sum(x => x.ServiceType.Price);
                    hoursSum = (decimal)l.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId == 8).Sum(x => x.Hours);
                    try
                    {
                        otherServicePrice = l.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId == 8).FirstOrDefault().ServiceType.Price * hoursSum;
                    }
                    catch (Exception)
                    {
                        otherServicePrice = 0;
                    }
                    result += Math.Round(defaultServicesPrice + otherServicePrice, 2);
                }
            }
            return result;
        }
        public async Task<List<string[]>> GetUsersStats()
        {
            List<string[]> userStats = new List<string[]>();
            var allUsersList = await GetAllEmployees();
            foreach (var u in allUsersList)
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    string[] oneUserStats = new string[3];
                    var userServicesCount = await ctx.ServiceOrders.CountAsync(x => x.UserId == u.UserId);
                    var usersServicesList = await GetUserServices(u.UserId);
                    decimal defaultServicesPrice, hoursSum, otherServicePrice = 0, result = 0;
                    foreach (var l in usersServicesList)
                    {
                        defaultServicesPrice = l.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId < 8).Sum(x => x.ServiceType.Price);
                        hoursSum = (decimal)l.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId == 8).Sum(x => x.Hours);
                        try
                        {
                            otherServicePrice = l.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId == 8).FirstOrDefault().ServiceType.Price * hoursSum;
                        }
                        catch (Exception)
                        {
                            otherServicePrice = 0;
                        }
                        result += Math.Round(defaultServicesPrice + otherServicePrice, 2);
                    }

                    oneUserStats[0] = u.LastName;
                    oneUserStats[1] = userServicesCount.ToString();
                    oneUserStats[2] = result.ToString();

                    userStats.Add(oneUserStats);
                }
            }
            return userStats;
        }
    }
}
