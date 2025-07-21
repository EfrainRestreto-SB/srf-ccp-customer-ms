using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Application.Hubs;
using Core;
using Domain.Dtos;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Dynamo.Config;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Persistence.Repositories;

public class CreateCustomerService : IAwsDynamoRepository
{
    private readonly IKafkaProducerAgent<string, CreateCustomerInDto> _kafkaProducerAgent;
    private readonly IHubContext<CustomerHub> _hubContext;
    private readonly ILogger<CreateCustomerService> _logger;
    private readonly IAmazonDynamoDB _amazonDynamoDB;
    private readonly IDynamoConnectionConfig _dynamoConnectionConfig;

    public CreateCustomerService(
        IHubContext<CustomerHub> hubContext,
        IKafkaProducerAgent<string, CreateCustomerInDto> kafkaProducerAgent,
        IAmazonDynamoDB amazonDynamoDB,
        IDynamoConnectionConfig dynamoConnectionConfig,
        ILogger<CreateCustomerService> logger)
    {
        _hubContext = hubContext;
        _kafkaProducerAgent = kafkaProducerAgent;
        _amazonDynamoDB = amazonDynamoDB;
        _dynamoConnectionConfig = dynamoConnectionConfig;
        _logger = logger;
    }

    public async Task SendCreateCustomerToIbm(string? key, CreateCustomerInDto createCustomerInDto)
    {
        createCustomerInDto.Id = key;
        await _kafkaProducerAgent.ProduceMessage(key!, createCustomerInDto);
    }

    public async Task InsertCreateCustomerAsync(CreateCustomerOutDto createCustomer)
    {
        try
        {
            if (createCustomer == null || string.IsNullOrWhiteSpace(createCustomer.Id))
                throw new ArgumentException("CreateCustomer data is invalid");

            var basicInformation = new Dictionary<string, AttributeValue>
            {
                { "firstName", new AttributeValue { S = createCustomer.BasicInformation.FirstName } },
                { "secondName", new AttributeValue { S = createCustomer.BasicInformation.SecondName ?? string.Empty } },
                { "firstLastName", new AttributeValue { S = createCustomer.BasicInformation.FirstLastName } },
                { "secondLastName", new AttributeValue { S = createCustomer.BasicInformation.SecondLastName ?? string.Empty } },
                { "documentType", new AttributeValue { S = createCustomer.BasicInformation.documentType } },
                { "expeditionPlace", new AttributeValue { S = createCustomer.BasicInformation.ExpeditionPlace } },
                { "expeditionDate", new AttributeValue { S = createCustomer.BasicInformation.ExpeditionDate } },
                { "countryCode", new AttributeValue { S = createCustomer.BasicInformation.CountryCode } },
                { "stateCode", new AttributeValue { S = createCustomer.BasicInformation.StateCode } },
                { "cityCode", new AttributeValue { S = createCustomer.BasicInformation.CityCode } },
                { "gender", new AttributeValue { S = createCustomer.BasicInformation.Gender } },
                { "maritalStatus", new AttributeValue { S = createCustomer.BasicInformation.MaritalStatus } },
                { "educationLevel", new AttributeValue { S = createCustomer.BasicInformation.EducationLevel } },
                { "profession", new AttributeValue { S = createCustomer.BasicInformation.Profession } },
                { "economicActivity", new AttributeValue { S = createCustomer.BasicInformation.EconomicActivity } },
                { "riskLevel", new AttributeValue { S = createCustomer.BasicInformation.RiskLevel } }
            };

            var contactInfo = new Dictionary<string, AttributeValue>
            {
                { "emailType", new AttributeValue { S = createCustomer.ContactInfo.EmailType } },
                { "email", new AttributeValue { S = createCustomer.ContactInfo.Email } },
                { "phoneType", new AttributeValue { S = createCustomer.ContactInfo.PhoneType } },
                { "mainPhone", new AttributeValue { S = createCustomer.ContactInfo.MainPhone } },
                { "phoneExtension", new AttributeValue { S = createCustomer.ContactInfo.PhoneExtension ?? string.Empty } },
                { "mobileNumber", new AttributeValue { S = createCustomer.ContactInfo.MobileNumber } },
                { "alternatePhoneNumber", new AttributeValue { S = createCustomer.ContactInfo.AlternatePhoneNumber ?? string.Empty } }
            };

            var item = new Dictionary<string, AttributeValue>
            {
                { "PK", new AttributeValue { S = createCustomer.Id } },
                { "SK", new AttributeValue { S = DateTime.UtcNow.ToString("o") } },
                { "BasicInformation", new AttributeValue { M = basicInformation } },
                { "ContactInfo", new AttributeValue { M = contactInfo } }
            };

            var request = new PutItemRequest
            {
                TableName = _dynamoConnectionConfig.TableName(),
                Item = item
            };

            await _amazonDynamoDB.PutItemAsync(request);
            _logger.LogInformation("Customer inserted successfully.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error inserting customer into DynamoDB.");
            throw;
        }
    }

    public Task<List<CreateCustomerOutDto>> GetCustomerList()
    {
        throw new NotImplementedException();
    }

    public Task<CreateCustomerOutDto?> GetCustomerListByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
}
