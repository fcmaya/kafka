# kafka

Exemplo de utilização do Kafka através de um producer e um consumer

## Instruções

- Para instalar o WSL2 basta executar este comando no powershell

```powershell
wsl --install -d Ubuntu
```

- Após a instalação, inicie a máquina Ubuntu no WSL2

- Obtenha a imagem Docker

```ubun
docker pull apache/kafka:4.0.0
```

- Inicie o contêiner Docker do Kafka

```ubuntu
docker run -d --name kafka -p 9092:9092 apache/kafka:4.0.0
```

- Abra esse projeto no Visual Studio Code e abra dois terminais. Em um terminal, entre na pasta KafkaProducer e execute o producer

```terminal
dotnet build
dotnet run
```

- No outro terminal, entre na pasta KafkaConsumer e execute o consumer

```terminal
dotnet build
dotnet run
```

```terminal
- No terminal do producer, você pode enviar mensagens para o tópico especificado. No terminal do consumer, você verá as mensagens recebidas

- Para parar o contêiner do Kafka, execute

```terminal
docker stop kafka
docker rm kafka
```
