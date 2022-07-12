using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQ.Consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory { Uri = new Uri("amqp://guest:13579630@localhost:5672") };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            DirectExchangeConsumer.Consume(channel);

        }
    }
}
