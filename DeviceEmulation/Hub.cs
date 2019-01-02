using DeviceEmulation.Interfaces;
using DeviceEmulation.RabbitMQ;

namespace DeviceEmulation
{
    internal class Hub : IDeviceControl
    {
        private readonly DeviceBroker _rabbitMqBroker = new DeviceBroker();

        public void DeviceHubRegistrartion(IDeviceEntity device, string name)
        {
            var message = device.DeviceRegistrarion(name);
            _rabbitMqBroker.SendMessage(message);
            _rabbitMqBroker.Finish();
        }

        public void GetState(IDeviceEntity device)
        {
            var message = device.GetDeviceState();
            _rabbitMqBroker.SendMessage(message);
            _rabbitMqBroker.Finish();
        }

        public void UpdateDevice(IDeviceEntity device)
        {
            var message = device.UpdateDeviceProperty();
            _rabbitMqBroker.SendMessage(message);
            _rabbitMqBroker.Finish();
        }
    }
}
