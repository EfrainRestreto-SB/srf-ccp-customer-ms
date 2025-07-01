using Application.Services;
using Core.Config.SettingFile.AwsKafka;
using Domain.Dtos;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Options;

namespace Core.Tasks;

public class KafkaCreateCustomerConsumerTasks : IHostedService
{
    private readonly IKafkaConsumerAgent<string, CustomerOutDto> kafkaConsumerAgent;
    private readonly IServiceProvider serviceProvider;
    private readonly ILogger<KafkaCreateCustomerConsumerTasks> logger;
    private readonly int parallelKafkaConsumers;

    public KafkaCreateCustomerConsumerTasks(
        IKafkaConsumerAgent<string, CustomerOutDto> kafkaConsumerAgent,
        IOptions<KafkaCreateCustomerEvtJson> kafkaCreateCustomerEvt,
        IServiceProvider serviceProvider,
        ILogger<KafkaCreateCustomerConsumerTasks> logger
)
    {
        this.kafkaConsumerAgent = kafkaConsumerAgent;
        this.serviceProvider = serviceProvider;
        this.logger = logger;
        parallelKafkaConsumers = kafkaCreateCustomerEvt.Value.ParallelKafkaConsumers;
    }

    public KafkaCreateCustomerConsumerTasks(IKafkaConsumerAgent<string, CustomerOutDto> kafkaConsumerAgent, IServiceProvider serviceProvider, ILogger<KafkaCreateCustomerConsumerTasks> logger, int parallelKafkaConsumers)
    {
        this.kafkaConsumerAgent = kafkaConsumerAgent;
        this.serviceProvider = serviceProvider;
        this.logger = logger;
        this.parallelKafkaConsumers = parallelKafkaConsumers;
    }

    public override bool Equals(object? obj)
    {
        return obj is KafkaCreateCustomerConsumerTasks tasks &&
               EqualityComparer<IKafkaConsumerAgent<string, CustomerOutDto>>.Default.Equals(kafkaConsumerAgent, tasks.kafkaConsumerAgent) &&
               EqualityComparer<IServiceProvider>.Default.Equals(serviceProvider, tasks.serviceProvider) &&
               EqualityComparer<ILogger<KafkaCreateCustomerConsumerTasks>>.Default.Equals(logger, tasks.logger) &&
               parallelKafkaConsumers == tasks.parallelKafkaConsumers;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        for (ushort i = 0; i < parallelKafkaConsumers; i++)
        {
            int number = i + 1;
            Task.Run(() =>
            {
                try
                {
                    using IServiceScope scope = serviceProvider.CreateScope();

                    Application.Services.ICreateCustomerService createCustomerService = (Application.Services.ICreateCustomerService)scope.ServiceProvider.GetRequiredService<ICreateCustomerService>();

                    kafkaConsumerAgent.ConsumeMessages((ushort)number, createCustomerService.NotifyToClient, cancellationToken);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error al consumir mensajes en el consumidor #{Number}", number);
                    throw;
                }
            }, cancellationToken);
        }

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Deteniendo consumidores Kafka...");
        return Task.CompletedTask;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}

namespace Application.Services
{
    class ICreateCustomerService
    {
        internal async Task NotifyToClient(string arg1, CustomerOutDto dto)
        {
            throw new NotImplementedException();
        }
    }
}