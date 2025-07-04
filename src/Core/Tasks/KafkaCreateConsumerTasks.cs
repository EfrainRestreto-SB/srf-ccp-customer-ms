using System.Text.Json;
using Core.Exceptions;
using Domain.Entities.Customer;
using Domain.Models.Customer.In;
using Microsoft.Extensions.Logging;
using Persistence.Cache.Interfaces;
using Persistence.Messaging.Agents;
using Persistence.Messaging.Kafka.Interfaces;

namespace Application.Tasks;

public class KafkaCreateCustomerConsumerTasks
{
    private readonly ILogger<KafkaCreateCustomerConsumerTasks> _logger;
    private readonly IRedisService _redisService;
    private readonly AS400MqAgent _mqAgent;
    private readonly IKafkaProducerCustomerEvt _evtProducer;

    public KafkaCreateCustomerConsumerTasks(
        ILogger<KafkaCreateCustomerConsumerTasks> logger,
        IRedisService redisService,
        AS400MqAgent mqAgent,
        IKafkaProducerCustomerEvt evtProducer)
    {
        _logger = logger;
        _redisService = redisService;
        _mqAgent = mqAgent;
        _evtProducer = evtProducer;
    }

    public async Task HandleAsync(string key, string json)
    {
        _logger.LogInformation($"Procesando mensaje de Kafka con key: {key}");

        CustomerCreateInModel? model = JsonSerializer.Deserialize<CustomerCreateInModel>(json);

        if (model == null)
        {
            _logger.LogError($"Error al deserializar mensaje de Kafka para key {key}");
            throw new BusinessException("Formato inválido del mensaje");
        }

        try
        {
            // 1. Enviar al agente MQ
            await _mqAgent.SendCustomerToAS400Async(key, model);

            // 2. (Opcional) Guardar en BD o actualizar Redis
            await _redisService.MarkAsProcessedAsync(key);

            // 3. Enviar evento de éxito
            await _evtProducer.SendSuccessAsync(key, model);

            _logger.LogInformation($"Cliente procesado correctamente: {key}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error procesando cliente key {key}");

            // 4. Enviar evento de fallo
            await _evtProducer.SendFailureAsync(key, ex.Message);

            throw;
        }
    }
}
