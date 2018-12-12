namespace DeviceEmulation.Interfaces
{
   public interface IDeviceEntity
    {
        string DeviceRegistrarion(string deviceName);

        string GetDeviceState();

        string DeviseReboot();

        string UpdateDeviceProperty();
    }
}
