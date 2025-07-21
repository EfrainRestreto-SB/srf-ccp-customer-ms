using Amazon.Extensions.NETCore.Setup;
using Confluent.Kafka;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.AwsKafka.Config;
using Microsoft.Extensions.Logging;
using Persistence.Serializers;

namespace Persistence.Agents.AwsKafka;

public class KafkaCustomerConsumerAgent<TKey, TValue>(IKafkaConsumerConfig kafkaConsumerConfig,
                                                 AWSOptions awsOptions,
                                                 ILogger<KafkaCustomerConsumerAgent<TKey, TValue>> logger) 
: IKafkaConsumerAgent<TKey, TValue>
{
    private readonly IKafkaConsumerConfig kafkaConsumerConfig = kafkaConsumerConfig;
    private readonly AWSOptions awsOptions = awsOptions;
    private readonly ILogger<KafkaCustomerConsumerAgent<TKey, TValue>> logger = logger ?? throw new ArgumentNullException(nameof(logger));

    private async void OauthCallback(IClient client, string cfg)
    {
        try
        {
            if (awsOptions.Credentials is null)
                throw new InvalidOperationException("Credenciales de AWS no disponibles.");

            (string, long) values = await new AWSMSKAuthTokenGenerator().GenerateAuthTokenFromCredentialsProvider(
                () => awsOptions.Credentials, awsOptions.Region, useAsync: true
            );

            client.OAuthBearerSetToken(values.Item1, values.Item2, kafkaConsumerConfig?.GetTopicName());
        }
        catch (Exception e) { client.OAuthBearerSetTokenFailure(e.ToString()); }
    }

    public async Task ConsumeMessages(ushort consumerNumber, Func<TKey, TValue, Task> method, CancellationToken cancellationToken)
    {
        logger.LogInformation("Iniciando Thread #{Number} - Topic: {Topic}", consumerNumber, kafkaConsumerConfig.GetTopicName());

        try
        {
            using IConsumer<TKey, TValue> consumer = new ConsumerBuilder<TKey, TValue>(kafkaConsumerConfig.GetConsumerConfig())
                .SetValueDeserializer(new JsonKafkaDeserializer<TValue>())
                .SetOAuthBearerTokenRefreshHandler(OauthCallback)
                .Build();

            consumer.Subscribe(kafkaConsumerConfig.GetTopicName());
            logger.LogInformation(
                "Consumer incializado: {ConsumerName} - Thread #{Number} - Topic: {Topic}", consumer.Name, consumerNumber, kafkaConsumerConfig.GetTopicName()
            );

            await ConsumeLoop(consumer, method, cancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al conectarse al Kafka: {Message} {InnerException} {StackTrace}", ex.Message, ex.InnerException, ex.StackTrace);
            await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            await ConsumeMessages(consumerNumber, method, cancellationToken);
        }
    }

    private async Task ConsumeLoop(IConsumer<TKey, TValue> consumer, Func<TKey, TValue, Task> method, CancellationToken cancellationToken) 
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                ConsumeResult<TKey, TValue> cr = consumer.Consume(cancellationToken);

                // Verifica si hay un mensaje y que no sea nulo
                if (cr is not null && cr.Message is not null)
                {
                    await method(cr.Message.Key, cr.Message.Value);
                    consumer.Commit(cr);

                    logger.LogInformation(
                        "Mensaje Consumido: {Name} - Topic {Topic} - Partition {Partition} - Offset {Offset}.",
                        consumer.Name, cr.Topic, cr.Partition, cr.Offset
                    );

                    continue;
                }

                logger.LogError("Mensaje no válido: {Name} - Topic {Topic} - Partition {Partition} - Offset {Offset}.",
                    consumer.Name, cr!.Topic, cr.Partition, cr.Offset
                );
            }
            catch (ConsumeException e)
            {
                // Manejo de excepciones específicas al consumir mensajes en Kafka
                logger.LogError(e, "Error: Razon {Reason}", e.Error.Reason);
                await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            }
            catch (OperationCanceledException e)
            {
                // Captura de cancelación de la operación (cuando el consumidor es detenido)
                logger.LogError(e, "Consumo cancelado");
                break;
            }
            catch (TimeoutException e)
            {
                // Maneja errores de tiempo de espera, como cuando el consumidor no puede consumir en el tiempo especificado
                logger.LogError(e, "Timeout ocurrido mientras se consumia mensajes");
                await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            }
            catch (KafkaException e)
            {
                // Captura errores generales de Kafka
                logger.LogError(e, "Error general de Kafka: {Message}. {StackTrace}", e.Message, e.StackTrace);
                await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            }
            catch (Exception e)
            {
                // Captura cualquier otro tipo de error inesperado
                logger.LogError(e, "Error occurred: {Message}. {InnerException} {StackTrace}", e.Message, e.InnerException, e.StackTrace);
                await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            }
        }
    }
}
