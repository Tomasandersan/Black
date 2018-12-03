using System;

namespace DeviceEmulation.Models
{
   public class HumidityDevice
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int HumidifityAreaPercent { get; set; }

        public bool IsDeviceSwitchOn { get; set; }
    }
}
