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
            ILogger<KafkaCustomerProducerAgent<string, CreateCustomerInDto>> logger = sp.GetRequiredService<ILogger<KafkaCustomerProducerAgent<string, CreateCustomerInDto>>>();
            IKafkaProducerConfig kafkaProducerConfig = sp.GetRequiredKeyedService<IKafkaProducerConfig>("KafkaProducerCreateCustomerCmdConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCustomerProducerAgent<string, CreateCustomerInDto>(kafkaProducerConfig, awsOptions, logger);
        });

     

        // Consumers
        services.AddSingleton<IKafkaConsumerAgent<string, CreateCustomerOutDto>>(sp =>
        {
            ILogger<KafkaCustomerConsumerAgent<string, CreateCustomerOutDto>> logger = sp.GetRequiredService<ILogger<KafkaCustomerConsumerAgent<string, CreateCustomerOutDto>>>();
            IKafkaConsumerConfig kafkaConsumerConfig = sp.GetRequiredKeyedService<IKafkaConsumerConfig>("KafkaConsumerCreateCustomerEvtConfig");
            AWSOptions awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaCustomerConsumerAgent<string, CreateCustomerOutDto>(kafkaConsumerConfig, awsOptions, logger);
        });

     

        // Repositories              
        services.AddSingleton<IAwsDynamoRepository, AwsDynamoRepository>();
        services.AddSingleton<IRedisRepository, RedisRepository>();

        return services;
    }
}