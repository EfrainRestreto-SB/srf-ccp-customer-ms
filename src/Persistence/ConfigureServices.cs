using Amazon.Extensions.NETCore.Setup;
using Domain.Dtos;
using Domain.Dtos.Customer.In;
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
        services.AddSingleton<IKafkaProducerAgent<string, CreateCustomerInDto>>(sp =>
        {
            ILogger<KafkaCdtProducerAgent<string, CreateCdtInDto>> logger = sp.GetRequiredService<ILogger<KafkaCdtProducerAgent<string, CreateCustomerInDto>>>();
            IKafkaProducerConfig kafkaProducerConfig = sp.GetRequiredKeyedService<IKafkaProducerConfig>("KafkaProducerCreateCdtCmdConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCdtProducerAgent<string, CreateCdtInDto>(kafkaProducerConfig, awsOptions, logger);
        });

     

        // Consumers
        services.AddSingleton<IKafkaConsumerAgent<string, CreateCustomerOutDto>>(sp =>
        {
            ILogger<KafkaCdtConsumerAgent<string, CreateCdtOutDto>> logger = sp.GetRequiredService<ILogger<KafkaCdtConsumerAgent<string, CreateCustomerOutDto>>>();
            IKafkaConsumerConfig kafkaConsumerConfig = sp.GetRequiredKeyedService<IKafkaConsumerConfig>("KafkaConsumerCreateCdtEvtConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCdtConsumerAgent<string, CreateCdtOutDto>(kafkaConsumerConfig, awsOptions, logger);
        });

     

        // Repositories              
        services.AddSingleton<IAwsDynamoRepository, AwsDynamoRepository>();
        services.AddSingleton<IRedisRepository, RedisRepository>();

        return services;
    }
}