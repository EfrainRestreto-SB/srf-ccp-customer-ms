using Core.Config.SettingFiles.AwsKafka;
using Domain.Dtos;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Options;

namespace Core.Tasks;

public class KafkaCreateCdtConsumerTasks(IKafkaConsumerAgent<string, CreateCustomerOutDto> kafkaConsumerAgent,
                                         IOptions<KafkaCreateCdtEvtJson> kafkaCreateCdtEvt,
                                         IServiceProvider serviceProvider,
                                         ILogger<KafkaCreateCdtConsumerTasks> logger)
: IHostedService
{
    private readonly IKafkaConsumerAgent<string, CreateCustomerOutDto> kafkaConsumerAgent = kafkaConsumerAgent;
    private readonly IServiceProvider serviceProvider = serviceProvider;
    private readonly ILogger<KafkaCreateCdtConsumerTasks> logger = logger;
    private readonly int parallelKafkaConsumers = kafkaCreateCdtEvt.Value.ParallelKafkaConsumers;

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

                    ICreateCdtService createCdtService = scope.ServiceProvider.GetRequiredService<ICreateCdtService>();

                    kafkaConsumerAgent.ConsumeMessages((ushort)number, createCdtService.NotifyToClient, cancellationToken);
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
