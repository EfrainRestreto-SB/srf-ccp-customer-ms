using Application.DTOs.Customer;
using Application.Interfaces.Customer;
using Application.Mappers;
using Application.Services.Customer;
using Application.Validators.Customer;
using Core.Config;
using Core.Config.Aws;
using Core.Config.AwsKafka;
using Core.Config.SettingFiles.Aws;
using Core.Config.SettingFiles.AwsKafka;
using Core.Validators;
using Core.Validators.CreateCustomer;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using FluentValidation;
using Microsoft.OpenApi.Models;
using Persistence.Cache.Interfaces;
using Persistence.Cache.Services;
using Persistence.Messaging.Agents;
using Persistence.Messaging.Kafka.Consumers;
using Persistence.Messaging.Kafka.Interfaces;
using Persistence.Messaging.Kafka.Services;
using Presentation.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Customer API", Version = "v1" });
});

// Controllers & SignalR
builder.Services.AddControllers();
builder.Services.AddSignalR();

// AutoMapper
builder.Services.AddAutoMapper(typeof(CustomerMappingsProfile));

// FluentValidation
builder.Services.AddScoped<IValidator<CustomerCreateInDto>, CustomerCreateInDtoValidator>();
builder.Services.AddScoped<IValidator<AddressInfoInDto>, AddressInfoInDtoValidator>();
builder.Services.AddScoped<IValidator<DescriptionsInDto>, DescriptionsInDtoValidator>();
builder.Services.AddScoped<IValidator<FinancialInfoInDto>, FinancialInfoInDtoValidator>();
// (Agrega aquí todos los demás validadores)


// Redis
builder.Services.AddSingleton<IRedisService, RedisService>();

// Kafka Producer config
builder.Services.Configure<KafkaCreateCdtCustomerJson>(
    builder.Configuration.GetSection("KafkaCreateCdtCustomerJson"));

builder.Services.AddSingleton<IKafkaProducerCustomerCmdConfig, KafkaProducerCreateCustomerCmdConfig>();
builder.Services.AddSingleton<IKafkaProducerCreateCustomer, KafkaProducerCreateCustomer>();

// Kafka Consumer
builder.Services.AddHostedService<KafkaCreateCustomerConsumer>();

// AS400 MQ Agent
builder.Services.AddSingleton<AS400MqAgent>();

// Customer Services
builder.Services.AddScoped<ICreateCustomerService, CreateCustomerService>();

// DynamoDB
builder.Services.Configure<DynamoConnectionSettings>(
    builder.Configuration.GetSection("DynamoConnectionSettings"));

builder.Services.AddSingleton<DynamoConnectionConfig>();
builder.Services.AddSingleton(provider =>
{
    var config = provider.GetRequiredService<DynamoConnectionConfig>();
    return config.CreateClient();
});

builder.Services.AddScoped(typeof(IAwsDynamoRepository<>), typeof(AwsDynamoRepository<>));

// App
var app = builder.Build();

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.MapHub<CustomerHub>("/customerHub");

app.Run();
