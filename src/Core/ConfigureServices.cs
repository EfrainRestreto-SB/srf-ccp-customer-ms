using Core.Config.AwsKafka;
using Core.Config.Dynamo;
using Core.Config.SettingFiles.AwsKafka;
using Core.Config.SettingFiles.Dynamo;
using Core.Tasks;
using Core.Validators.Customer;
using Domain.Interfaces.AwsKafka.Config;
using Domain.Interfaces.Dynamo.Config;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Core;

public static class ConfigureServices
{
    public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
    {
        // Settings
        services.Configure<KafkaCreateCustomerCmdJson>(configuration.GetSection("KafkaCreateCustomerCmd"));
        services.Configure<KafkaCreateCustomerEvtJson>(configuration.GetSection("KafkaCreateCustomerEvt"));

        // Create Customer
        services.AddKeyedSingleton<IKafkaProducerConfig, KafkaProducerCreateCustomerCmdConfig>("KafkaProducerCreateCustomerCmdConfig");
        services.AddKeyedSingleton<IKafkaProducerConfig, KafkaConsumerCreateCustomerEvtConfig>("KafkaConsumerCreateCustomerEvtConfig");

        // Create Customer socket
        services.AddKeyedSingleton<IKafkaProducerConfig, KafkaProducerCreateCustomerCmdConfig>("KafkaProducerCreateCustomerSocketCmdConfig");
        services.AddKeyedSingleton<IKafkaConsumerConfig, KafkaConsumerCreateCustomerEvtConfig>("KafkaConsumerCreateCustomerSocketEvtConfig");

        services.Configure<DynamoJson>(configuration.GetSection("Dynamo"));
        services.AddSingleton<IDynamoConnectionConfig, DynamoConnectionConfig>();


        // Add Mappers
        services.AddAutoMapper(cfg =>
        {
            cfg.AllowNullCollections = true;
            cfg.AllowNullDestinationValues = true;
        }, Assembly.GetExecutingAssembly());

        // Add Input Validators
        services.AddFluentValidationAutoValidation(config => config.DisableDataAnnotationsValidation = true)
            .AddFluentValidationClientsideAdapters();
        // Add these to your service registration
        services.AddValidatorsFromAssemblyContaining<BasicInformationInValidator>();
        services.AddValidatorsFromAssemblyContaining<IdentificationInValidator>();
        services.AddValidatorsFromAssemblyContaining<BirthInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<ContactInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<AddressInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<FinancialInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<EmploymentInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<ForeignCurrencyInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<BankingInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<InterviewInfoInValidator>();
        services.AddValidatorsFromAssemblyContaining<ReferencesInValidator>();
        services.AddValidatorsFromAssemblyContaining<DescriptionsInValidator>();
        // Tasks
        services.AddHostedService<KafkaCreateCustomerConsumerTasks>();

        // Endpoints
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        // Add Redis
        RedisJson redisConfig = configuration.GetSection("Redis").Get<RedisJson>()!;
        services.AddSingleton<IConnectionMultiplexer>(sp => ConnectionMultiplexer
            .ConnectAsync(new ConfigurationOptions()
            {
                EndPoints = { $"{redisConfig.Host}:{redisConfig.Port}" },
                Password = redisConfig.Password,
                User = redisConfig.User,
                Ssl = bool.Parse(redisConfig.Ssl!),
                SslHost = redisConfig.SslHost,
                AbortOnConnectFail = false
            })
            .GetAwaiter()
            .GetResult());

        // Add sockets
        services.AddSignalR(o =>
        {
            o.EnableDetailedErrors = true;
            o.MaximumReceiveMessageSize = 1_000_000; // 1 MB
            o.ClientTimeoutInterval = TimeSpan.FromSeconds(30);
            o.KeepAliveInterval = TimeSpan.FromSeconds(15);
            o.HandshakeTimeout = TimeSpan.FromSeconds(15);
            o.StatefulReconnectBufferSize = 100_000; // 100KB buffer
        });
        //.AddStackExchangeRedis(options =>
        //{
        //    // Obtiene la instancia de IConnectionMultiplexer que ya registraste
        //    options.ConnectionFactory = async (writer) =>
        //    {
        //        IConnectionMultiplexer multiplexer = services.BuildServiceProvider().GetRequiredService<IConnectionMultiplexer>();
        //        return await Task.FromResult(multiplexer);
        //    };
        //    // Replace the line causing the warning
        //    options.Configuration.ChannelPrefix = RedisChannel.Literal("MyApp_SignalR_"); // Opcional: prefijo para aislamiento
        //});

        return services;
    }
}
