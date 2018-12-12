using System;
using DeviceEmulation.Infrastructure;
using DeviceEmulation.Interfaces;
using DeviceEmulation.Models;

namespace DeviceEmulation.Devices
{
    internal class LighterDevice : DeviceEntity, ILighter
    {
        private LightDevice _lightDevice;

        public override string DeviceRegistrarion(string deviceName)
        {
            _lightDevice = new LightDevice
            {
                Id = Guid.NewGuid(),
                Name = deviceName,
                LightLavel = RandomValue.GetRandom(4, 10),
                LighterCount = RandomValue.GetRandom(2, 20),
                IsDeviceSwitchOn = false
            };

            return $"Light control device with `{deviceName}` name is created";
        }

        public override string GetDeviceState()
        {
            if (_lightDevice.IsDeviceSwitchOn)
            {
                return $"{_lightDevice.Name} switches on";
            }

            return $"{_lightDevice.Name} switches off";
        }

        public string LowerIllumonation()
        {
            if (_lightDevice.LightLavel != 1)
            {
                _lightDevice.LightLavel -= 1;

                return $"Light lavel = {_lightDevice.LightLavel}";
            }

            return "Light lavel is min";
        }

        public string RaiseIllumination()
        {
            if (_lightDevice.LightLavel != 10)
            {
                _lightDevice.LightLavel += 1;

                return $"Light lavel = {_lightDevice.LightLavel}";
            }

            return "Light lavel is max";
        }

        public string SwitchOn()
        {
            _lightDevice.IsDeviceSwitchOn = true;

            return $"{_lightDevice.Name} is switched on";
        }

        public string SwitchOff()
        {
            _lightDevice.IsDeviceSwitchOn = false;

            return $"{_lightDevice.Name} is switched off";
        }

        public string GetIllumination()
        {
            return $"Lighter count = {_lightDevice.LighterCount}, light lavel = {_lightDevice.LightLavel}";
        }
    }
}