namespace DeviceEmulation.Interfaces
{
    public interface IHumidifier : IDeviceEntity //увлажнитель воздуза
    {
        string GetHumidity();

        string SetHumidity(int humidityPercent);

        string SwitchOn();

        string SwitchOff();
    }
}
