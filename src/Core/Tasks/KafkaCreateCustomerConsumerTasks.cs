using Domain.Dtos.CreateCustomer.In;
using Domain.Interfaces.Services.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Tasks.Kafka
{
    public class KafkaCreateCustomerConsumerTasks(
        IKafkaCreateCustomerConsumerService consumerService,
        ILogger<KafkaCreateCustomerConsumerTasks> logger
    ) : BackgroundService
    {
        private readonly IKafkaCreateCustomerConsumerService _consumerService = consumerService;
        private readonly ILogger<KafkaCreateCustomerConsumerTasks> _logger = logger;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Kafka Customer Consumer Task iniciado.");

            try
            {
                await _consumerService.ConsumerAsync(async (key, value) =>
                {
                    _logger.LogInformation("Mensaje recibido de Kafka - Key: {Key}", key);
                    await _consumerService.ProcessMessageAsync(key, value);
                }, stoppingToken);
            }
            catch (TaskCanceledException)
            {
                _logger.LogWarning("Kafka Customer Consumer Task cancelado.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en Kafka Customer Consumer Task.");
            }
        }
    }
}
