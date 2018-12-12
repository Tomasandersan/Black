using System;
using DeviceEmulation.Interfaces;

namespace DeviceEmulation
{
    internal class Hub
    {
        private readonly IHumidifier _humidifier;
        private readonly ILighter _lighter;
        private readonly IThermal _thermal;

        internal Hub(IHumidifier humidifier,ILighter lighter,IThermal thermal)
        {
            _humidifier = humidifier;
            _thermal = thermal;
            _lighter = lighter;
        }

        internal void HubControl()
        {
            Console.WriteLine(_humidifier.DeviceRegistrarion("Humidity device"));
            Console.WriteLine(_humidifier.GetDeviceState());
            Console.WriteLine(_humidifier.GetHumidity());
            Console.WriteLine(_humidifier.SetHumidity(50));
            Console.WriteLine(_humidifier.SwitchOn());
            Console.WriteLine(_humidifier.SwitchOff());
            Console.WriteLine(_humidifier.SetHumidity(80));
            Console.WriteLine(_humidifier.DeviseReboot());
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine(_lighter.DeviceRegistrarion("Light device"));
            Console.WriteLine(_lighter.GetDeviceState());
            Console.WriteLine(_lighter.SwitchOn());
            Console.WriteLine(_lighter.GetDeviceState());
            Console.WriteLine(_lighter.GetIllumination());
            Console.WriteLine(_lighter.LowerIllumonation());
            Console.WriteLine(_lighter.RaiseIllumination());
            Console.WriteLine(_lighter.UpdateDeviceProperty());
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine(_thermal.DeviceRegistrarion("Thermal device"));
            Console.WriteLine(_thermal.GetDeviceState());
            Console.WriteLine(_thermal.SwitchOnThermal());
            Console.WriteLine(_thermal.RaiseThemperature());
            Console.WriteLine(_thermal.RaiseThemperature());
            Console.WriteLine(_thermal.LowerThemperature());
            Console.WriteLine(_thermal.SetCommonThermal(25));
            Console.WriteLine(_thermal.SwitchOffThermal());
        }
    }
}
