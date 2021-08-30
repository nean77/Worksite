using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class ServicesControlHelpers : BaseUserControlHelpers
    {
        private AllService _services;
        private long _serviceId;

        public AllService AllServices { get => _services; set => _services = value; }
        public long ServiceId { get => _serviceId; set => _serviceId = value; }

        public static async Task<ICollection<ServiceOrder>> GetServicesAsync()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetServices();
        }

        public static ServiceOrder GetServiceById(long Id)
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return entityHelpers.GetServiceById(Id);
        }

        public static ICollection<ServiceType> GetServiceTypes()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return entityHelpers.GetServiceTypes();
        }
        public static ICollection<ServiceStatus> GetServiceStatuses()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return entityHelpers.GetServiceStatuses();
        }
    }
}
