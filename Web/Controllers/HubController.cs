using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using DeviceEmulation.Interfaces;
using DeviceEmulation.RabbitMQ;

namespace Web.Controllers
{
    public class HubController : ApiController
    {
        private readonly IHumidifier _humidifier;
        private readonly IThermal _thermal;
        private readonly ILighter _lighter;
        private readonly IDeviceControl _deviceControl;

        private DeviceBroker deviceBroker=new DeviceBroker();

        public HubController()
        {
        }

        public HubController(IHumidifier humidifier,IThermal thermal,ILighter lighter,IDeviceControl deviceControl)
        {
            _humidifier = humidifier;
            _thermal = thermal;
            _lighter = lighter;
            _deviceControl = deviceControl;

            deviceBroker.Start();
        }

        public void Get()
        {
            _deviceControl.GetState(_lighter);
        }

        public void Post([FromBody]string value)
        {
            _deviceControl.DeviceHubRegistrartion(_humidifier, value);
        }

        public void Put(int id, [FromBody]string value)
        {
            _deviceControl.UpdateDevice(_thermal);
        }
    }
}
