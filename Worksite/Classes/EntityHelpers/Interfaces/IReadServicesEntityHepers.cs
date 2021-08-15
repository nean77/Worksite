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
        Task<ICollection<AllService>> GetServices();
        ServiceOrder GetServiceById(long id);
    }
}
