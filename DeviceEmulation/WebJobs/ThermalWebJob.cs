using System;
using System.IO;
using DeviceEmulation.Models;
using WebJobs.Extensions.RabbitMQ;
using static DeviceEmulation.CosmosDB.CreateDocument;

namespace ThermalWebJob
{
    public class Functions
    {
        public static void ProcessQueueMessage([RabbitQueueBinder("queue", "queue")][RabbitQueueTrigger("queue")] string message, TextWriter log)
        {
            CreateCosmosDbDocument(new CosmosDbMessage { Id = Guid.NewGuid(), Message = message });

            Console.WriteLine(message);
        }
    }
}