using DeviceEmulation.Interfaces;

namespace DeviceEmulation.Devices
{
    class DeviceEntity : IDeviceEntity
    {
        public virtual string DeviceRegistrarion(string deviceName)
        {
            return null;
        }

        public virtual string GetDeviceState()
        {
            return null;
        }

        public string DeviseReboot()
        {
            return "Device is rebooted";
        }

        public string UpdateDeviceProperty()
        {
            return "Device is updated";
        }
    }
}
