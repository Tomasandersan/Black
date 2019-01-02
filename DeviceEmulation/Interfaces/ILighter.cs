namespace DeviceEmulation.Interfaces
{
    public interface ILighter : IDeviceEntity //Система освещения
    {
        string GetIllumination();

        string LowerIllumonation();

        string RaiseIllumination();

        string SwitchOn();

        string SwitchOff();
    }
}
