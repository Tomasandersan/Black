using System;
using DeviceEmulation.Infrastructure;
using DeviceEmulation.Interfaces;
using DeviceEmulation.Models;

namespace DeviceEmulation.Devices
{
    internal class ThermalDevice : DeviceEntity, IThermal
    {
        private ThermDevice _thermDevice;

        public override string DeviceRegistrarion(string deviceName)
        {
            _thermDevice = new ThermDevice
            {
                Id = Guid.NewGuid(),
                Name = deviceName,
                MinTemperatureLavel = RandomValue.GetRandom(5, 10),
                MaxTemperatureLavel = RandomValue.GetRandom(28, 32),
                IsDeviceSwitchOn = false,
                EstablishedTemperature = RandomValue.GetRandom(5, 32)
            };

            return $"Light control device with {deviceName} name is created";
        }

        public override string GetDeviceState()
        {
            if (_thermDevice.IsDeviceSwitchOn)
            {
                return "Device switch on";
            }

            return "Device switch off";
        }

        public int GetThermal()
        {
            return _thermDevice.EstablishedTemperature;
        }

        public string SetCommonThermal(int temp)
        {
            _thermDevice.EstablishedTemperature = temp;

            return $"Temperature is set ({temp})";
        }

        public string SwitchOffThermal()
        {
            _thermDevice.IsDeviceSwitchOn = false;

            return "Thermal device is switched off";
        }

        public string SwitchOnThermal()
        {
            _thermDevice.IsDeviceSwitchOn = true;

            return "Thermal device is switched off";
        }

        public string LowerThemperature()
        {
            if (_thermDevice.EstablishedTemperature == _thermDevice.MinTemperatureLavel) return "Temperature is min";
            _thermDevice.EstablishedTemperature--;

            return $"Themperature esteblished in {_thermDevice.EstablishedTemperature}";

        }

        public string RaiseThemperature()
        {
            if (_thermDevice.EstablishedTemperature == _thermDevice.MaxTemperatureLavel) return "Temperature is max";
            _thermDevice.EstablishedTemperature++;

            return $"Themperature esteblished in {_thermDevice.EstablishedTemperature}";

        }
    }
}