using System.Net.Http.Json;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "airbyte", exclusive: false, autoDelete: false);

channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
var consumer = new EventingBasicConsumer(channel);
using var httpClient = new HttpClient();
consumer.Received += (_, ea) =>
{
    var jsonDocument = JsonSerializer.Deserialize<JsonDocument>(ea.Body.Span);
    if (jsonDocument.RootElement.TryGetProperty("explanation", out var jsonElement))
    {
        Console.WriteLine($"[x] Received {jsonElement.GetString()}");
        using var httpRequest =
            new HttpRequestMessage(HttpMethod.Post, "http://localhost:8080/api/semantic/ingest/text");

        using var content = JsonContent.Create(new
        {
            documentId = Guid.NewGuid().ToString(),
            index = "nasa",
            text = jsonElement.GetString()
        });
        httpRequest.Content = content;
        httpClient.Send(httpRequest);
    }

    channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
};
channel.BasicConsume(queue: "airbyte",
    autoAck: false,
    consumer: consumer);

Console.WriteLine("Press [enter] to exit.");
Console.ReadLine();