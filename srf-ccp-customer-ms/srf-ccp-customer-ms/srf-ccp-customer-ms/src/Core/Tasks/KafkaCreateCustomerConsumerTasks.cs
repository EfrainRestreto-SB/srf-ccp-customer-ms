using Core.Config.SettingFiles.AwsKafka;
using Domain.Dtos;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Options;

namespace Core.Tasks;

public class KafkaCreateCustomerConsumerTasks(IKafkaConsumerAgent<string, CreateCustomerOutDto> kafkaConsumerAgent,
                                         IOptions<KafkaCreateCustomerEvtJson> kafkaCreateCustomerEvt,
                                         IServiceProvider serviceProvider,
                                         ILogger<KafkaCreateCustomerConsumerTasks> logger)
: IHostedService
{
    private readonly IKafkaConsumerAgent<string, CreateCustomerOutDto> kafkaConsumerAgent = kafkaConsumerAgent;
    private readonly IServiceProvider serviceProvider = serviceProvider;
    private readonly ILogger<KafkaCreateCustomerConsumerTasks> logger = logger;
    private readonly int parallelKafkaConsumers = kafkaCreateCustomerEvt.Value.ParallelKafkaConsumers;

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

                    ICreateCustomerService createCustomerService = scope.ServiceProvider.GetRequiredService<ICreateCustomerService>();

                    kafkaConsumerAgent.ConsumeMessages((ushort)number, createCustomerService.NotifyToClient, cancellationToken);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    throw;
                }
            }, cancellationToken);
        }

        return Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Stopping Kafka consumers...");

        // Cancela todas las tareas activas
        cancellationToken.ThrowIfCancellationRequested();

        await Task.CompletedTask;
    }
}
