using Amazon.Extensions.NETCore.Setup;
using Domain.Dtos;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.AwsKafka.Config;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Persistence.Agents.AwsKafka;
using Persistence.Repositories;

namespace Persistence;

public static class ConfigureServices
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        // Producers
        services.AddSingleton<IKafkaProducerAgent<string, CreateCdtInDto>>(sp =>
        {
            ILogger<KafkaCdtProducerAgent<string, CreateCdtInDto>> logger = sp.GetRequiredService<ILogger<KafkaCdtProducerAgent<string, CreateCdtInDto>>>();
            IKafkaProducerConfig kafkaProducerConfig = sp.GetRequiredKeyedService<IKafkaProducerConfig>("KafkaProducerCreateCdtCmdConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCdtProducerAgent<string, CreateCdtInDto>(kafkaProducerConfig, awsOptions, logger);
        });

        services.AddSingleton<IKafkaProducerAgent<string, CdtSimulatorInDto>>(sp =>
        {
            ILogger<KafkaCdtProducerAgent<string, CdtSimulatorInDto>> logger = sp.GetRequiredService<ILogger<KafkaCdtProducerAgent<string, CdtSimulatorInDto>>>();
            IKafkaProducerConfig kafkaProducerConfig = sp.GetRequiredKeyedService<IKafkaProducerConfig>("KafkaProducerCdtSimulatorCmdConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCdtProducerAgent<string, CdtSimulatorInDto>(kafkaProducerConfig, awsOptions, logger);
        });

        // Consumers
        services.AddSingleton<IKafkaConsumerAgent<string, CreateCdtOutDto>>(sp =>
        {
            ILogger<KafkaCdtConsumerAgent<string, CreateCdtOutDto>> logger = sp.GetRequiredService<ILogger<KafkaCdtConsumerAgent<string, CreateCdtOutDto>>>();
            IKafkaConsumerConfig kafkaConsumerConfig = sp.GetRequiredKeyedService<IKafkaConsumerConfig>("KafkaConsumerCreateCdtEvtConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCdtConsumerAgent<string, CreateCdtOutDto>(kafkaConsumerConfig, awsOptions, logger);
        });

        services.AddSingleton<IKafkaConsumerAgent<string, CdtSimulatorOutDto>>(sp =>
        {
            ILogger<KafkaCdtConsumerAgent<string, CdtSimulatorOutDto>> logger = sp.GetRequiredService<ILogger<KafkaCdtConsumerAgent<string, CdtSimulatorOutDto>>>();
            IKafkaConsumerConfig kafkaConsumerConfig = sp.GetRequiredKeyedService<IKafkaConsumerConfig>("KafkaConsumerCdtSimulatorEvtConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCdtConsumerAgent<string, CdtSimulatorOutDto>(kafkaConsumerConfig, awsOptions, logger);
        });

        // Repositories              
        services.AddSingleton<IAwsDynamoRepository, AwsDynamoRepository>();
        services.AddSingleton<IRedisRepository, RedisRepository>();

        return services;
    }
}

public class IServiceCollection
{
}