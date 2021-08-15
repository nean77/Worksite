using System.Collections.Generic;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class DevicesControlHelpers : BaseUserControlHelpers
    {
        private AllDevice _devices;
        private long _devId;

        public AllDevice Device { get => _devices; set => _devices = value; }
        public long DevId { get => _devId; set => _devId = value; }

        public static async Task<ICollection<AllDevice>> GetDevicesAsync()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetDevices();
        }
        public static Device GetDeviceById(long Id)
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return entityHelpers.GetDeviceById(Id);
        }
    }
}
