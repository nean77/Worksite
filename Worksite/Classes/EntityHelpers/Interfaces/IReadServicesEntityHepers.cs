using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers
{
    public interface IReadServicesEntityHepers<T>
    {
        Task<T> GetUserOpenServices();
        Task<T> GetUserExpiredServices();
        Task<ICollection<ServiceOrder>> GetServices();
        Task<bool> HasServiceChanges(ServiceOrder serviceOrder);
        Task<ServiceOrder> GetServiceById(long id);
        decimal GetOtherWorkHours(long serviceId);
    }
}
