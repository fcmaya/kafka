using System;
using Confluent.Kafka;

class KafkaProducer
{
    public static void Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092", // Altere para o endereço do seu broker
            // Segurança: configure SASL/SSL se necessário
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        try
        {
            var result = producer.ProduceAsync("meu-topico", new Message<Null, string> { Value = "Olá Kafka!" }).GetAwaiter().GetResult();
            Console.WriteLine($"Mensagem enviada para {result.TopicPartitionOffset}");
        }
        catch (ProduceException<Null, string> e)
        {
            Console.WriteLine($"Erro ao enviar: {e.Error.Reason}");
        }
    }
}