using System;

namespace DeviceEmulation.Models
{
   public class LightDevice
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int LighterCount { get; set; }

        public int LightLavel { get; set; }

        public bool IsDeviceSwitchOn { get; set; }

    }
}
