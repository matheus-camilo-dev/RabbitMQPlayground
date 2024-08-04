﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

// Create Queue
channel
    .QueueDeclare(queue: "hello",
                  durable: false,
                  exclusive: false,
                  autoDelete: false,
                  arguments: null);

Console.WriteLine(" [*] Aguardando mensagens. ");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);

    Console.WriteLine($" [x] Recebido: {message}");
};

// Configure Consumer
channel
    .BasicConsume(queue: "hello",
                  autoAck: true,
                  consumer: consumer);

Console.WriteLine($" Aperte [enter] para sair.");
Console.ReadLine();
