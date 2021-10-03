using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers.Interfaces;

namespace Worksite.Classes.EntityHelpers
{
    public interface IReadEntityHelpers : IReadServicesEntityHepers<int>, IReadCustomersEntityHelpers, IReadDevicesEntityHelpers, IReadStatsEntityHelpers
    {
        ICollection<ServiceStatus> GetServiceStatuses();
        ICollection<User> GetActiveEmployees();
        Task<ICollection<User>> GetAllEmployees();
        ICollection<ServiceType> GetServiceTypes();

    }
}
