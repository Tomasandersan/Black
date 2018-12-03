using DeviceEmulation.Devices;
using DeviceEmulation.Interfaces;
using Unity;
using Unity.Lifetime;

namespace DeviceEmulation.Util
{
 public static class BindMolule
    {
        public static IUnityContainer BindLoad()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IHumidifier, HumidifierDevice>(new ContainerControlledLifetimeManager());
            container.RegisterType<ILighter, LighterDevice>(new ContainerControlledLifetimeManager());
            container.RegisterType<IThermal, ThermalDevice>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDeviceEntity, DeviceEntity>(new ContainerControlledLifetimeManager());

            return container;
        }
    }
}
