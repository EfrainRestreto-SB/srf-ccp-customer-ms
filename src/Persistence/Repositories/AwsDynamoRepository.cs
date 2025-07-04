using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Domain.Dtos.CreateCdt.Out;
using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Dtos.Customer.Out;
using Domain.Interfaces.Dynamo.Config;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Persistence.Repositories;

public class AwsDynamoRepository(IAmazonDynamoDB amazonDynamoDB,
                                 IAwsDynamoRepository dynamoConnectionConfig,
                                 ILogger<AwsDynamoRepository> logger)
: IAwsDynamoRepository
{
    private readonly IAmazonDynamoDB amazonDynamoDB = amazonDynamoDB;
    private readonly IAwsDynamoRepository dynamoConnectionConfig = dynamoConnectionConfig;
    private readonly ILogger<AwsDynamoRepository> logger = logger;

    private const string TiempoKey = "tiempo";
    private const string UnidadKey = "unidad";

    public async Task InsertCustomerAsync(CustomerCreateOutDto customer)
    {
        try
        {
            Dictionary<string, AttributeValue> item = new()
            {
                { "id", new AttributeValue { S = customer.CustomerId } },
                { "status", new AttributeValue { S = customer.Status } },
                { "message", new AttributeValue { S = customer.Message ?? string.Empty } },
                { "createdAt", new AttributeValue { S = customer.CreatedAt.ToString("o", CultureInfo.InvariantCulture) } }
            };

            PutItemRequest request = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                Item = item
            };

            _ = await amazonDynamoDB.PutItemAsync(request);
            logger.LogInformation("Cliente insertado en DynamoDB correctamente.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al insertar cliente en DynamoDB");
        }
    }

    public async Task<CustomerCreateOutDto?> GetCustomerByIdAsync(string id)
    {
        try
        {
            QueryRequest queryRequest = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                KeyConditionExpression = "id = :id",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":id", new AttributeValue { S = id } }
                }
            };

            QueryResponse response = await amazonDynamoDB.QueryAsync(queryRequest);

            if (response.Items.Count == 0)
            {
                logger.LogInformation("No se encontró cliente con id: {Id}", id);
                return null;
            }

            Dictionary<string, AttributeValue>? item = response.Items.FirstOrDefault();
            return item is not null ? ConvertToCustomerDto(item) : null;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al consultar cliente en DynamoDB");
            throw;
        }
    }

    private CustomerCreateOutDto ConvertToCustomerDto(Dictionary<string, AttributeValue> item)
    {
        return new CustomerCreateOutDto
        {
            CustomerId = GetStringValue(item, "id"),
            Status = GetStringValue(item, "status"),
            Message = GetStringValue(item, "message"),
            CreatedAt = DateTime.TryParse(GetStringValue(item, "createdAt"), null, DateTimeStyles.RoundtripKind, out var date)
                            ? date
                            : default
        };
    }

    private static string? GetStringValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out var value) ? value?.S : null;
    }
}
