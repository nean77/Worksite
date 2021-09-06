﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class ServicesControlHelpers : BaseUserControlHelpers
    {
        private ServiceOrder _serviceOrder;
        private long _serviceId;

        public ServiceOrder ServiceOrder { get => _serviceOrder; set => _serviceOrder = value; }
        public long ServiceId { get => _serviceId; set => _serviceId = value; }

        public static async Task<ICollection<ServiceOrder>> GetServicesAsync()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetServices();
        }
        public static Task<ServiceOrder> GetServiceById(long Id)
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
        public async Task<bool> HasChanges()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.HasServiceChanges(ServiceOrder);
        }
        public static decimal GetServicePrice(ServiceOrder s)
        {
            decimal defaultServicesPrice, hoursSum, otherServicePrice = 0;
            defaultServicesPrice = s.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId < 8).Sum(x => x.ServiceType.Price);
            hoursSum = (decimal)s.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId == 8).Sum(x => x.Hours);
            otherServicePrice = s.ServiceOrders_ServiceTypes.Where(x => x.ServiceTypeId == 8).FirstOrDefault().ServiceType.Price * hoursSum;

            return Math.Round(defaultServicesPrice + otherServicePrice, 2);
        }
        public async Task<bool> SaveAsync() { return true; }
        public async Task<bool> UpdateAsync(List<ServiceOrders_ServiceTypes> serviceOrders_ServiceTypes)
        {
            WriteServiceEntityHelpers writeHelpers = new WriteServiceEntityHelpers();

            return await writeHelpers.Update(ServiceOrder, serviceOrders_ServiceTypes);
        }
    }
}
