using System;
using DeviceEmulation.Interfaces;
using DeviceEmulation.Util;
using Unity;

namespace DeviceEmulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BindMolule.BindLoad();
            var humidifier = container.Resolve<IHumidifier>();
            var lighter = container.Resolve<ILighter>();
            var thermal = container.Resolve<IThermal>();
            new Hub(humidifier,lighter,thermal).HubControl();
            Console.ReadKey();
        }
    }
}
