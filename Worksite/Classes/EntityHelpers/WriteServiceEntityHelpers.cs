using MetroFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers.Interfaces;
using Worksite.UserControls.Helpers;

namespace Worksite.Classes.EntityHelpers
{
    public class WriteServiceEntityHelpers : IWriteServiceEntityHelpers
    {
        private long _serviceOrderId;
        public async Task<bool> Save(ServiceOrder serviceOrder)
        {
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                using (DbContextTransaction transaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.ServiceOrders.Add(serviceOrder);
                        await ctx.SaveChangesAsync();
                        long idx = serviceOrder.ServiceOrderId;
                        ctx.ServiceOrders_ServiceStatuses.Add(new ServiceOrders_ServiceStatuses(idx, 1));
                        await ctx.SaveChangesAsync();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                return true;
            }
        }

        public async Task<bool> Update(ServiceOrder serviceOrder, List<ServiceOrders_ServiceTypes> list)
        {
            _serviceOrderId = serviceOrder.ServiceOrderId;
            using (WorksiteEntities ctx = new WorksiteEntities())
            {
                using (DbContextTransaction transaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        var so = await ServicesControlHelpers.GetServiceById(serviceOrder.ServiceOrderId);

                        so.CustomerId = serviceOrder.CustomerId;
                        so.DeviceId = serviceOrder.DeviceId;
                        so.OpenDate = serviceOrder.OpenDate;
                        so.CloseDate = serviceOrder.CloseDate;
                        so.UserId = serviceOrder.UserId;
                        so.Description = serviceOrder.Description;

                        using (WorksiteEntities contx = new WorksiteEntities())
                        {
                            var soss = await contx.ServiceOrders_ServiceStatuses.Where(x => x.ServiceOrderId == so.ServiceOrderId).SingleOrDefaultAsync();

                            soss.ServiceStatusId = serviceOrder.ServiceOrders_ServiceStatuses.FirstOrDefault().ServiceStatusId;
                            soss.UserId = serviceOrder.ServiceOrders_ServiceStatuses.FirstOrDefault().UserId;

                            await contx.SaveChangesAsync();
                        }

                        if (!await deleteServiceTypes())
                        {
                            throw new Exception();
                        }
                        if (!await insertNewServiceTypes(list))
                        {
                            throw new Exception();
                        }
                        ctx.Entry(so).State = EntityState.Modified;
                        await ctx.SaveChangesAsync();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                return true;
            }
        }

        private async Task<bool> insertNewServiceTypes(List<ServiceOrders_ServiceTypes> list)
        {
            foreach (var st in list)
            {
                try
                {
                    using (WorksiteEntities ctx = new WorksiteEntities())
                    {
                        ctx.ServiceOrders_ServiceTypes.Add(st);
                        await ctx.SaveChangesAsync();
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        private async Task<bool> deleteServiceTypes()
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    ctx.ServiceOrders_ServiceTypes.RemoveRange(ctx.ServiceOrders_ServiceTypes.Where(x => x.ServiceOrderId == _serviceOrderId));

                    await ctx.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
