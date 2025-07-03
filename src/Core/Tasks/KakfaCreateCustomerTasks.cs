using Confluent.Kafka;
using System.Text.Json;
using Core.Config.SettingFile.AwsKasfa;
using Core.Mapper;
using Domain.Validadores;
using Microsoft.Extensions.Hosting;

namespace Core.Tasks
{
    public class KakfaCreateCustomerTasks : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "cliente-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("crear-cliente");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var result = consumer.Consume(stoppingToken);
                    var json = result.Message.Value;

                    var kafkaDto = JsonSerializer.Deserialize<KafkaCreateCustomerEvtJson>(json);
                    var cliente = Mapper.CreateCustomerMappings.ToClienteEntity(kafkaDto);

                    var errores = ClienteValidator.Validar(cliente);

                    if (errores.Any())
                    {
                        Console.WriteLine("❌ Cliente inválido:");
                        errores.ForEach(e => Console.WriteLine($" - {e}"));
                    }
                    else
                    {
                        Console.WriteLine(" Cliente válido:");
                        Console.WriteLine($" - Nombre: {cliente.PrimerNombre} {cliente.PrimerApellido}");
                        Console.WriteLine($" - ID: {cliente.TipoIdentificacion} {cliente.NumeroIdentificacion}");
                        // Aquí puedes guardar el cliente usando un servicio
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Error al consumir mensaje Kafka: {ex.Message}");
                }
            }
        }
    }
}
