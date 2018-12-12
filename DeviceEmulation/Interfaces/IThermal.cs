namespace DeviceEmulation.Interfaces
{
    internal interface IThermal : IDeviceEntity //система термоконтроля
    {
        int GetThermal();

        string  SetCommonThermal(int temp);

        string SwitchOffThermal();

        string SwitchOnThermal();

        string LowerThemperature();

        string RaiseThemperature();
    }
}