﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OrderService.Model.Services.RegisterOrderServices;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderService.MessagingBus.RecievedMessages
{
    public class RecievedOrderCreatedMessage : BackgroundService
    {
        private IModel _channel;
        private IConnection _connection;

        private readonly string _hostname;
        private readonly string _queueName;
        private readonly string _username;
        private readonly string _password;
        private readonly IRegisterOrderService registerOrderService;

        public RecievedOrderCreatedMessage(IOptions<RabbitMqConfiguration> rabbitMqOptions,
            IRegisterOrderService registerOrderService)
        {
            _hostname = rabbitMqOptions.Value.Hostname;
            _queueName = rabbitMqOptions.Value.QueueName_BasketCheckout;
            _username = rabbitMqOptions.Value.UserName;
            _password = rabbitMqOptions.Value.Password;

            var factory = new ConnectionFactory
            {
                HostName = _hostname,
                UserName = _username,
                Password = _password
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: _queueName, durable: true,
                exclusive: false, autoDelete: false, arguments: null);
            this.registerOrderService = registerOrderService;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += (sender, eventArg) =>
             {
                 var body = Encoding.UTF8.GetString(eventArg.Body.ToArray());
                 var basket = JsonConvert.DeserializeObject<BasketDto>(body);


                 //ثبت سفارش
                var resultHandle=  HandleMessage(basket);

                 if(resultHandle)
                 _channel.BasicAck(eventArg.DeliveryTag, false);
             };
            _channel.BasicConsume(queue: _queueName, false, consumer);


            return Task.CompletedTask;
        }


        private bool HandleMessage(BasketDto basket)
        {
           return registerOrderService.Execute(basket);
        }


    }



    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
}
