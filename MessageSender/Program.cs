using RabbitMQ.Client;
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

Console.WriteLine("Digite a sua mensagem e aperte <ENTER>");

while (true)
{
    string message = Console.ReadLine();

    if (message == "") break;

    var body = Encoding.UTF8.GetBytes(message);

    // Publish Message
    channel
        .BasicPublish(exchange: string.Empty,
                      routingKey: "hello",
                      basicProperties: null,
                      body: body);

    Console.WriteLine($" [x] Enviado {message}");
}
