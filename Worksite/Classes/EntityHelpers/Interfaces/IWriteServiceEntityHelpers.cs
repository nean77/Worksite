using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers.Interfaces
{
    public interface IWriteServiceEntityHelpers
    {
        Task<bool> Save(ServiceOrder serviceOrder);
        Task<bool> Update(ServiceOrder serviceOrder, List<ServiceOrders_ServiceTypes> list);
    }
}
