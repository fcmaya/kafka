# kafka

Exemplo de utilização do Kafka através de um producer e um consumer

## Instruções

- Para instalar o WSL2 basta executar este comando no powershell

```powershell
wsl --install -d Ubuntu
```

- Após a instalação, inicie a máquina Ubuntu no WSL2

- Obtenha a imagem Docker

```ubuntu
docker pull apache/kafka:4.0.0
```

- Inicie o contêiner Docker do Kafka expondo a porta padrão do Kafka 9092 para o host windows na mesma porta 9092

```ubuntu
docker run -d --name kafka -p 9092:9092 apache/kafka:4.0.0
```

- Abra esse projeto no Visual Studio Code no host windows, executando dois terminais. Em um terminal, entre na pasta KafkaProducer

- O Confluent.Kafka é o cliente oficial .NET para Apache Kafka desenvolvido pela Confluent, que fornece APIs de alto nível para produtores e consumidores Kafka, além de suporte para recursos avançados como serialização, configuração de segurança, e integração com Schema Registry.

```terminal
dotnet add package Confluent.Kafka
```

- Execute o producer

```terminal
dotnet build
dotnet run
```

- No outro terminal, entre na pasta KafkaConsumer

```terminal
dotnet add package Confluent.Kafka
```

- Execute o consumer

```terminal
dotnet build
dotnet run
```

- No terminal do producer, você pode enviar mensagens para o tópico especificado. No terminal do consumer, você verá as mensagens recebidas

- Parando e removendo o contêiner do Kafka no WSL2, execute

```ubuntu
docker stop kafka
docker rm kafka
```
