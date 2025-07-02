using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Domain.Interfaces.Dynamo.Config;
using Microsoft.Extensions.Logging;
using AttributeValue = Amazon.DynamoDBv2.Model.AttributeValue;

namespace Persistence.Repositories;

public class AwsDynamoCustomerRepository(
    IAmazonDynamoDB amazonDynamoDB,
    IDynamoConnectionConfig dynamoConnectionConfig,
    ILogger<AwsDynamoCustomerRepository> logger
) : IAwsDynamoCustomerRepository
{
    private readonly IAmazonDynamoDB amazonDynamoDB = amazonDynamoDB;
    private readonly IDynamoConnectionConfig dynamoConnectionConfig = dynamoConnectionConfig;
    private readonly ILogger<AwsDynamoCustomerRepository> logger = logger;

    public async Task InsertCustomerAsync(CreateCustomerOutDto customer)
    {
        try
        {
            Dictionary<string, AttributeValue> item = new()
            {
                { "id", new AttributeValue { S = customer.Id } },
                { "tipoIdentificacion", new AttributeValue { S = customer.TipoIdentificacion } },
                { "numeroIdentificacion", new AttributeValue { S = customer.NumeroIdentificacion } },
                { "nombreCompleto", new AttributeValue { S = customer.NombreCompleto } },
                { "telefono", new AttributeValue { S = customer.Telefono } },
                { "correo", new AttributeValue { S = customer.Correo } },
                { "fechaRegistro", new AttributeValue { S = customer.FechaRegistro } }
                // Agrega más campos si tu DTO tiene más propiedades
            };

            PutItemRequest request = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                Item = item
            };

            _ = await amazonDynamoDB.PutItemAsync(request);
            logger.LogInformation("Cliente insertado correctamente.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al insertar el cliente en DynamoDB: {Inner}, {StackTrace}", ex.InnerException, ex.StackTrace);
        }
    }

    public async Task<CreateCustomerOutDto?> GetCustomerByNumeroIdentificacionAsync(string numeroIdentificacion)
    {
        try
        {
            QueryRequest queryRequest = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                KeyConditionExpression = "numeroIdentificacion = :numeroIdentificacion",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                {
                        ":numeroIdentificacion",
                        new AttributeValue { S = numeroIdentificacion }
                }
                }
            };

            QueryResponse response = await amazonDynamoDB.QueryAsync(queryRequest);

            if (response.Items.Count == 0)
            {
                logger.LogInformation("No se encontró cliente con la identificación: {numeroIdentificacion}", numeroIdentificacion);
                return null;
            }

            Dictionary<string, AttributeValue>? firstItem = response.Items.FirstOrDefault();
            return firstItem is not null ? ConvertToCustomerDto(firstItem) : null;
        }
        catch (Exception ex)
        {
            HandleException(ex);
            throw;
        }
    }

    private CreateCustomerOutDto ConvertToCustomerDto(Dictionary<string, AttributeValue> item)
    {
        return new CreateCustomerOutDto
        {
            Id = GetString(item, "id"),
            TipoIdentificacion = GetString(item, "tipoIdentificacion"),
            NumeroIdentificacion = GetString(item, "numeroIdentificacion"),
            NombreCompleto = GetString(item, "nombreCompleto"),
            Telefono = GetString(item, "telefono"),
            Correo = GetString(item, "correo"),
            FechaRegistro = GetString(item, "fechaRegistro")
        };
    }

    private static string? GetString(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out var value) ? value?.S : null;
    }

    private void HandleException(Exception ex)
    {
        if (!ex.Data.Contains("Logged"))
        {
            logger.LogError(ex, "Error al consultar cliente");
            ex.Data["Logged"] = true;
        }
    }
}

internal class CreateCustomerOutDto
{
    public string? TipoIdentificacion { get; internal set; }
    public string? NumeroIdentificacion { get; internal set; }
    public string? Id { get; internal set; }
    public string? NombreCompleto { get; internal set; }
    public string? Telefono { get; internal set; }
    public string? Correo { get; internal set; }
    public string? FechaRegistro { get; internal set; }
}