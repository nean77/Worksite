using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers.Interfaces;

namespace Worksite.Classes.EntityHelpers
{
    public class WriteDevicesEntityHelpers : IWriteDevicesEntityHelpers
    {
        CurrentUser currentUser = CurrentUser.GetInstance();

        public async Task<bool> Save(Device device)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    ctx.Devices.Add(device);
                    await ctx.SaveChangesAsync();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Update(Device device)
        {
            try
            {
                using (WorksiteEntities ctx = new WorksiteEntities())
                {
                    Device dev = await ctx.Devices.Where(d => d.DeviceId == device.DeviceId).FirstAsync();
                    dev.Name = device.Name;
                    dev.DeviceTypeId = device.DeviceTypeId;
                    dev.CustomerId = device.CustomerId;
                    dev.InventNo = device.InventNo;
                    dev.SerialNumber = device.SerialNumber;


                    ctx.Entry(dev).State = EntityState.Modified;
                    await ctx.SaveChangesAsync();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }
    }
}
