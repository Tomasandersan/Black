using Microsoft.Azure.WebJobs;
using WebJobs.Extensions.RabbitMQ.Config;

namespace DeviceEmulation.WebJobs.ConnectionHost
{
   public static class DefaultHostConnection
    {
        public static void Connection()
        {
            var config = new JobHostConfiguration();
            if (config.IsDevelopment)
            {
                config.UseDevelopmentSettings();
            }

            config.UseRabbitMq("amqp://localhost:5672",false);

            var host = new JobHost(config);
            host.Start();
        }
    }
}
