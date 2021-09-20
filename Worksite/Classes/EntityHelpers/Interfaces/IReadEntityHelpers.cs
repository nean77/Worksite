using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers
{
    public interface IReadEntityHelpers : IReadServicesEntityHepers<int>, IReadCustomersEntityHelpers, IReadDevicesEntityHelpers
    {
        ICollection<ServiceStatus> GetServiceStatuses();
        ICollection<User> GetActiveEmployees();
        Task<ICollection<User>> GetAllEmployees();
        ICollection<ServiceType> GetServiceTypes();

    }
}
