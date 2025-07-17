using System;
using Confluent.Kafka;

class KafkaConsumer
{
    public static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092", // Altere para o endereço do seu broker
            GroupId = "meu-grupo",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = true
            // Segurança: configure SASL/SSL se necessário
        };

        using var consumer = new ConsumerBuilder<Null, string>(config).Build();
        consumer.Subscribe("meu-topico");

        try
        {
            while (true)
            {
                var cr = consumer.Consume();
                Console.WriteLine($"Recebido: {cr.Message.Value} em {cr.TopicPartitionOffset}");
            }
        }
        catch (ConsumeException e)
        {
            Console.WriteLine($"Erro ao consumir: {e.Error.Reason}");
        }
        finally
        {
            consumer.Close();
        }
    }
}