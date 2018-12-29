using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceEmulation.Interfaces
{
    public interface IDeviceControl
    {
        void DeviceHubRegistrartion(IDeviceEntity device, string name);

        void GetState(IDeviceEntity device);

        void UpdateDevice(IDeviceEntity device);
    }
}
