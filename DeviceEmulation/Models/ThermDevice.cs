using System;

namespace DeviceEmulation.Models
{
   public class ThermDevice
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int MinTemperatureLavel { get; set; }

        public int MaxTemperatureLavel { get; set; }

        public int EstablishedTemperature { get; set; }

        public bool IsDeviceSwitchOn { get; set; }
    }
}
