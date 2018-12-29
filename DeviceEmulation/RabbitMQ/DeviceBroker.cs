using System;
using System.Text;
using System.Threading;
using RabbitMQ.Client;
using RabbitMQ.Client.MessagePatterns;

namespace DeviceEmulation.RabbitMQ
{
  public class DeviceBroker
  {
        private Thread _thread;
        private IConnection _conn;
        private IModel _model;

        public IConnection GetRabbitConnection()
        {
            ConnectionFactory factory = new ConnectionFactory
            {
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/",
                HostName = "localhost",
                RequestedHeartbeat = 60
            };
            _conn = factory.CreateConnection();

            return _conn;
        }

        public IModel GetRabbitChannel(string exchangeName, string queueName, string routingKey)//settings
        {
            _model = GetRabbitConnection().CreateModel();
            _model.ExchangeDeclare(exchangeName, ExchangeType.Direct);
            _model.QueueDeclare(queueName, true, false, false, null);
            _model.QueueBind(queueName, exchangeName, routingKey, null);

            return _model;
        }

        public void SendMessage(string message)
        {
            _model = GetRabbitChannel(ConnectionR.ExchangeName, ConnectionR.QueueName, ConnectionR.RoutingKey);
            var messageBodyBytes = Encoding.UTF8.GetBytes(message);
            _model.BasicPublish(ConnectionR.ExchangeName, ConnectionR.RoutingKey, null, messageBodyBytes);
        }

        private void RabbitListener()
        {
            _model = GetRabbitChannel(ConnectionR.ExchangeName, ConnectionR.QueueName, ConnectionR.RoutingKey);
            var subscription = new Subscription(_model, ConnectionR.QueueName, false);
            while (true)
            {
                var basicDeliveryEventArgs = subscription.Next();
                var messageContent = Encoding.UTF8.GetString(basicDeliveryEventArgs.Body);
                Console.WriteLine(messageContent);
                subscription.Ack(basicDeliveryEventArgs);
            }
        }

        public void Start()
        {
            _thread = new Thread(RabbitListener);
            _thread.Start();
        }

        public void Finish()
        {
            _thread?.Abort();

            _model?.Close();

            _conn?.Close();
        }
    }
}
