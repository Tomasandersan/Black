using System;
using DeviceEmulation.Infrastructure;
using DeviceEmulation.Interfaces;
using DeviceEmulation.Models;

namespace DeviceEmulation.Devices
{
    internal class HumidifierDevice : DeviceEntity, IHumidifier
    {
        private HumidityDevice _humidDevice;

        public override string DeviceRegistrarion(string deviceName)
        {
            _humidDevice = new HumidityDevice
            {
                Id = Guid.NewGuid(),
                Name = deviceName,
                HumidifityAreaPercent = RandomValue.GetRandom(10, 90),
                IsDeviceSwitchOn = false
            };

            return $"Humidity control device with `{deviceName}` name is created";
        }

        public override string GetDeviceState()
        {
            return _humidDevice.IsDeviceSwitchOn ? $"`{_humidDevice.Name}` state: switch on" : $"`{_humidDevice.Name}` state: switch off";
        }

        public string SwitchOn()
        {
            _humidDevice.IsDeviceSwitchOn = true;

            return $"`{_humidDevice.Name}` is switched on";
        }

        public string SwitchOff()
        {
            _humidDevice.IsDeviceSwitchOn = false;

            return $"`{_humidDevice.Name}` is switched off";
        }

        public string GetHumidity()
        {
            return $"Now {_humidDevice.HumidifityAreaPercent} percent";
        }

        public string SetHumidity(int humidityPercent)
        {
            _humidDevice.HumidifityAreaPercent = humidityPercent;

            return $"`{_humidDevice.Name}` sets on {humidityPercent} percent";
        }
    }
}
