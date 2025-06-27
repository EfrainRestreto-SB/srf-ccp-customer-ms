using Amazon.Extensions.NETCore.Setup;
using Domain.Dtos;
using Domain.Dtos.Customer.Out;
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
        // === CONSUMERS ===

        // SavingsAccount
        services.AddSingleton<IKafkaConsumerAgent<string, CreateSavingsAccountOutDto>>(sp =>
        {
            var logger = sp.GetRequiredService<ILogger<KafkaSavingsAccountConsumerAgent<string, CreateSavingsAccountOutDto>>>();
            var kafkaConsumerConfig = sp.GetRequiredKeyedService<IKafkaConsumerConfig>("KafkaConsumerCreateSavingsAccountEvtConfig");
            var awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaSavingsAccountConsumerAgent<string, CreateSavingsAccountOutDto>(
                kafkaConsumerConfig, awsOptions, logger
            );
        });

        // Customer
        services.AddSingleton<IKafkaConsumerAgent<string, CreateCustomerOutDto>>(sp =>
        {
            var logger = sp.GetRequiredService<ILogger<KafkaSavingsAccountConsumerAgent<string, CreateCustomerOutDto>>>();
            var kafkaConsumerConfig = sp.GetRequiredKeyedService<IKafkaConsumerConfig>("KafkaConsumerCreateCustomerEvtConfig");
            var awsOptions = sp.GetRequiredService<AWSOptions>();

            return new KafkaSavingsAccountConsumerAgent<string, CreateCustomerOutDto>(
                kafkaConsumerConfig, awsOptions, logger
            );
        });

        // === REPOSITORIES ===

        // SavingsAccount
        services.AddSingleton<IAwsDynamoRepository, AwsDynamoRepository>();

        // Customer
        services.AddSingleton<IAwsDynamoCustomerRepository, AwsDynamoCustomerRepository>();

        return services;
    }
}
