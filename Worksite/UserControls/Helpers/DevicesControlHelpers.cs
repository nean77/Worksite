using System.Collections.Generic;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class DevicesControlHelpers : BaseUserControlHelpers
    {
        private Device _devices;
        private long? _devId;
        
        public Device Device { get => _devices; set => _devices = value; }
        public long? DevId { get => _devId; set => _devId = value; }

        public static async Task<ICollection<Device>> GetDevicesAsync()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetDevices();
        }
        public static async Task<ICollection<Device>> GetCustomerDevicesAsync(Customer cust)
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetCustomerDevices(cust);
        }
        public static ICollection<User> GetEmployees()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return entityHelpers.GetActiveEmployees();
        }
        public static Device GetDeviceById(long? Id)
        {
            long id;
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            if (Id == null)
            {
                id = 0;
            }
            else
            {
                id = (long)Id;
            }
            return entityHelpers.GetDeviceById(id);
        }
        public async Task<bool> HasChanges()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.HasDeviceChanges(Device);
        }
        public async Task<bool> SaveAsync()
        {
            WriteDevicesEntityHelpers writeHelpers = new WriteDevicesEntityHelpers();

            return await writeHelpers.Save(Device);
        }
        public async Task<bool> UpdateAsync()
        {
            WriteDevicesEntityHelpers writeHelpers = new WriteDevicesEntityHelpers();

            return await writeHelpers.Update(Device);
        }
    }
}
