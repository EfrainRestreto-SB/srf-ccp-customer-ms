using Amazon.Extensions.NETCore.Setup;
using Confluent.Kafka;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.AwsKafka.Config;
using Microsoft.Extensions.Logging;
using Persistence.Serializers;

namespace Persistence.Agents.AwsKafka;

public class KafkaCdtProducerAgent<TKey, TValue> : IKafkaProducerAgent<TKey, TValue>, IDisposable
{
    private readonly ILogger<KafkaCdtProducerAgent<TKey, TValue>> logger;
    private readonly AWSOptions awsOptions;
    private readonly IKafkaProducerConfig kafkaProducerConfig;
    private readonly IProducer<TKey, TValue>? producer;

    private bool disposed = false;

    public KafkaCdtProducerAgent(IKafkaProducerConfig kafkaProducerConfig, AWSOptions awsOptions, ILogger<KafkaCdtProducerAgent<TKey, TValue>> logger)
    {
        this.kafkaProducerConfig = kafkaProducerConfig;
        this.awsOptions = awsOptions;
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

        producer ??= new ProducerBuilder<TKey, TValue>(kafkaProducerConfig.GetProducerConfig())
            .SetValueSerializer(new JsonKafkaSerializer<TValue>())
            .SetOAuthBearerTokenRefreshHandler(OauthCallback)
            .Build();
    }

    private async void OauthCallback(IClient client, string cfg)
    {
        try
        {
            if (awsOptions.Credentials is null)
                throw new InvalidOperationException("Credenciales de AWS no disponibles.");

            (string, long) values = await new AWSMSKAuthTokenGenerator().GenerateAuthTokenFromCredentialsProvider(
                () => awsOptions.Credentials, awsOptions.Region, useAsync: true
            );

            client.OAuthBearerSetToken(values.Item1, values.Item2, kafkaProducerConfig?.GetTopicName());
        }
        catch (Exception e) { client.OAuthBearerSetTokenFailure(e.ToString()); }
    }

    public async Task ProduceMessage(TKey key, TValue body)
    {
        bool hasError = false;
        for (int i = 0; i < kafkaProducerConfig.MaxRetries(); i++)
        {
            try
            {
                logger.LogInformation("{ProducerName} producing on Topic: {TopicName}.", producer!.Name, kafkaProducerConfig.GetTopicName());

                Message<TKey, TValue> message = new() { Key = key, Value = body };
                DeliveryResult<TKey, TValue> deliveryResult = await producer.ProduceAsync(kafkaProducerConfig.GetTopicName(), message);

                logger.LogInformation("Produced message - {ProducerName} - Topic {TopicName} - Partition: {Partition} - Offset: {Offset}",
                    producer!.Name, kafkaProducerConfig.GetTopicName(), deliveryResult.Partition, deliveryResult.Offset
                );

                producer.Flush();

                hasError = false;
                break;
            }
            catch (ProduceException<TKey, TValue> ex)
            {
                // Maneja errores específicos de la producción en Kafka
                logger.LogError(ex, "Error de producción en Kafka: {Message}. {InnerException}. {StackTrace}.", ex.Message, ex.InnerException, ex.StackTrace);
                hasError = true;
            }
            catch (TimeoutException ex)
            {
                // Maneja errores de tiempo de espera, como cuando el productor no puede producir en el tiempo especificado
                logger.LogError(ex, "Timeout al producir el mensaje: {Message}. {StackTrace}", ex.Message, ex.StackTrace);
                hasError = true;
            }
            catch (KafkaException ex)
            {
                // Captura errores generales de Kafka que no son específicos de la producción
                logger.LogError(ex, "Error general de Kafka: {Message}. {StackTrace}", ex.Message, ex.StackTrace);
                hasError = true;
            }
            catch (InvalidOperationException ex)
            {
                // Captura errores de estado inválido u otros errores operacionales
                logger.LogError(ex, "Operación inválida durante la producción: {Message}. {StackTrace}", ex.Message, ex.StackTrace);
                hasError = true;
            }
            catch (Exception ex)
            {
                // Captura cualquier otro tipo de error inesperado
                logger.LogError(ex, "Error inesperado durante la producción del mensaje: {Message}. {StackTrace}", ex.Message, ex.StackTrace);
                hasError = true;
            }
        }

        if (hasError) throw new InvalidOperationException("Error al producir mensaje en kafka");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Liberamos el productor de Kafka si estamos en el contexto de un dispose explícito
                producer?.Dispose();
            }

            disposed = true; // Marcamos que los recursos ya han sido liberados
        }
    }
}
