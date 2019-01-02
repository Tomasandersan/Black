using DeviceEmulation.CosmosDB;
using DeviceEmulation.Devices;
using DeviceEmulation.Util;
using DeviceEmulation.WebJobs.ConnectionHost;

namespace DeviceEmulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BindMolule.BindLoad();

            new Hub().DeviceHubRegistrartion(new LighterDevice(), "Light_device_1");

            new CreateDb().CreateDataBase();

            DefaultHostConnection.Connection();
        }
    }}
