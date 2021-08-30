using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers
{
    public interface IReadDevicesEntityHelpers
    {
        Task<ICollection<Device>> GetDevices();
        Device GetDeviceById(long id);
        Device GetByInventNo(long inventNo);

    }
}
