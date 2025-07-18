using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;
using Domain.Dtos;
using Domain.Interfaces.Dynamo.Config;
using Microsoft.Extensions.Logging;
using System.Globalization;
using Domain.Dtos.CreateCdt.Out;
using Domain.Interfaces.Repositories;

namespace Persistence.Repositories;

public class AwsDynamoRepository(IAmazonDynamoDB amazonDynamoDB, 
                                 IDynamoConnectionConfig dynamoConnectionConfig,
                                 ILogger<AwsDynamoRepository> logger)
: IAwsDynamoRepository
{
    private readonly IAmazonDynamoDB amazonDynamoDB = amazonDynamoDB;
    private readonly IDynamoConnectionConfig dynamoConnectionConfig = dynamoConnectionConfig;
    private readonly ILogger<AwsDynamoRepository> logger = logger;
    
    private const string TiempoKey = "tiempo";
    private const string UnidadKey = "unidad";

    public async Task InsertCreateCdtAsync(CreateCdtOutDto createCdt)
    {
        try
        {
            Dictionary<string, AttributeValue> fechaApertura = new()
            {
                { "dia", new AttributeValue { N = createCdt.FechaApertura!.Dia.ToString() } },
                { "mes", new AttributeValue { N = createCdt.FechaApertura!.Mes.ToString() } },
                { "anio", new AttributeValue { N = createCdt.FechaApertura!.Anio.ToString() } }
            };

            Dictionary<string, AttributeValue> fechaVencimiento = new()
            {
                { "dia", new AttributeValue { N = createCdt.FechaVencimiento!.Dia.ToString() } },
                { "mes", new AttributeValue { N = createCdt.FechaVencimiento!.Mes.ToString() } },
                { "anio", new AttributeValue { N = createCdt.FechaVencimiento!.Anio.ToString() } }
            };

            Dictionary<string, AttributeValue> duracion = new()
            {
                { TiempoKey, new AttributeValue { N = createCdt.Duracion!.Tiempo.ToString() } },
                { UnidadKey, new AttributeValue { S = createCdt.Duracion.Unidad!.ToString() } }
            };

            Dictionary<string, AttributeValue> frecuenciaPagoInteres = new()
            {
                { TiempoKey, new AttributeValue { N = createCdt.Duracion!.Tiempo.ToString() } },
                { UnidadKey, new AttributeValue { S = createCdt.Duracion.Unidad!.ToString() } }
            };

            Dictionary<string, AttributeValue> item = new() {
                { "id", new AttributeValue { S = createCdt.Id }},
                { "numeroCliente", new AttributeValue { N = createCdt.NumeroCliente }},
                { "numeroProducto", new AttributeValue { N = createCdt.NumeroProducto }},
                { "primerNombre", new AttributeValue { S = createCdt.PrimerNombre?.ToString() }},
                { "segundoNombre", new AttributeValue { S = (!string.IsNullOrEmpty(createCdt.SegundoNombre)) ? createCdt.SegundoNombre : string.Empty }},
                { "primerApellido", new AttributeValue { S = createCdt.PrimerApellido?.ToString() }},
                { "segundoApellido", new AttributeValue { S = (!string.IsNullOrEmpty(createCdt.SegundoApellido)) ? createCdt.SegundoApellido : string.Empty }},
                { "montoAperturaCdt", new AttributeValue { N = createCdt.MontoAperturaCdt.ToString() }},
                { "fechaApertura", new AttributeValue { M = fechaApertura }},
                { "fechaVencimiento", new AttributeValue { M = fechaVencimiento }},
                { "duracion", new AttributeValue { M = duracion }},
                { "frecuenciaPagoInteres", new AttributeValue { M = frecuenciaPagoInteres }},
                { "tasaEfectiva", new AttributeValue { N = string.Format(CultureInfo.InvariantCulture, "{0}", createCdt.TasaEfectiva) }},
                { "tasaNominal", new AttributeValue { N = string.Format(CultureInfo.InvariantCulture, "{0}", createCdt.TasaNominal) }},
                { "interesCalculado", new AttributeValue { N = string.Format(CultureInfo.InvariantCulture, "{0}", createCdt.InteresCalculado) }},
                { "interesNeto", new AttributeValue { N = string.Format(CultureInfo.InvariantCulture, "{0}", createCdt.InteresNeto) }},
                { "retencionFuente", new AttributeValue { N = string.Format(CultureInfo.InvariantCulture, "{0}", createCdt.RetencionFuente) }},

                { "errorCode", new AttributeValue { N = string.Format(CultureInfo.InvariantCulture, "{0}", createCdt.ErrorCode is null ? 0 : createCdt.ErrorCode) }},
                { "errorField", new AttributeValue { S = string.Format(CultureInfo.InvariantCulture, "{0}", string.IsNullOrEmpty(createCdt.ErrorField) ? null : createCdt.ErrorField) }},
                { "errorDescription", new AttributeValue { S = string.Format(CultureInfo.InvariantCulture, "{0}", string.IsNullOrEmpty(createCdt.ErrorDescription) ? null : createCdt.ErrorDescription) }},
                { "approvalStatus", new AttributeValue { S = string.Format(CultureInfo.InvariantCulture, "{0}", string.IsNullOrEmpty(createCdt.ApprovalStatus) ? null : createCdt.ApprovalStatus) }}
            };

            // Crear la solicitud de inserción
            PutItemRequest request = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                Item = item
            };

            // Ejecutar la solicitud de inserción
            _ = await amazonDynamoDB.PutItemAsync(request);
            logger.LogInformation("Cdt Insertado correctamente.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error inserting item into DynamoDB:  {Inner}, {StackTrace}", ex.InnerException, ex.StackTrace);
            return;
        }
    }

    private static int GetIntValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && int.TryParse(value?.N, out int result) ? result : 0;
    }

    private static long? GetLongValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && long.TryParse(value?.N, out long result) ? result : null;
    }

    private static decimal GetDecimalValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && decimal.TryParse(value?.N, out decimal result) ? result : 0m;
    }

    private static double GetDoubleValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) && double.TryParse(value?.N, out double result) ? result : 0;
    }

    private static string? GetStringValue(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? value) ? value?.S : null;
    }

    private static FechaAperturaOutDto? GetFechaApertura(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? fecha) && fecha.M != null
            ? new FechaAperturaOutDto
            {
                Dia = GetIntValue(fecha.M, "dia"),
                Mes = GetIntValue(fecha.M, "mes"),
                Anio = GetIntValue(fecha.M, "anio")
            }
            : null;
    }

    private static DuracionOutDto? GetDuracion(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? duracion) && duracion.M != null
            ? new DuracionOutDto
            {
                Tiempo = GetIntValue(duracion.M, TiempoKey),
                Unidad = GetStringValue(duracion.M, UnidadKey)
            }
            : null;
    }

    private static FechaVencimientoOutDto? GetFechaVencimiento(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? fecha) && fecha.M != null
            ? new FechaVencimientoOutDto
            {
                Dia = GetIntValue(fecha.M, "dia"),
                Mes = GetIntValue(fecha.M, "mes"),
                Anio = GetIntValue(fecha.M, "anio")
            }
            : null;
    }

    private static FrecuenciaPagoInteresOutDto? GetFrecuenciaPagoInteres(Dictionary<string, AttributeValue> attributes, string key)
    {
        return attributes.TryGetValue(key, out AttributeValue? frecuencia) && frecuencia.M != null
            ? new FrecuenciaPagoInteresOutDto
            {
                Tiempo = GetIntValue(frecuencia.M, TiempoKey),
                Unidad = GetStringValue(frecuencia.M, UnidadKey)
            }
            : null;
    }

    public async Task<List<CreateCdtOutDto>> GetCdtList()
    {
        try
        {
            ScanRequest scanRequest = CreateScanRequest(dynamoConnectionConfig);
            ScanResponse response = await amazonDynamoDB.ScanAsync(scanRequest);

            return [.. response.Items.Select(ConvertToCdtDto)];
        }
        catch (Exception ex)
        {
            HandleException(ex);
            throw;
        }
    }

    public async Task<CreateCdtOutDto?> GetCdtListByIdAsync(string id)
    {
        try
        {
            // Crear la solicitud de Query para filtrar por el campo 'id'
            QueryRequest queryRequest = new()
            {
                TableName = dynamoConnectionConfig.TableName(),
                KeyConditionExpression = "id = :id", // Condición para filtrar por 'id'
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":id", new AttributeValue { S = id } } // Valor que estamos buscando para el 'id'
                }
            };

            // Ejecutar la solicitud de Query
            QueryResponse response = await amazonDynamoDB.QueryAsync(queryRequest);

            // Verificar si encontramos resultados
            if (response.Items.Count == 0)
            {
                logger.LogInformation("No se encontraron registros para el id: {Id}", id);
                return null; // Retorna null si no hay coincidencias
            }

            // Convertir el primer elemento encontrado en un objeto CreateCdtOutDto
            Dictionary<string, AttributeValue>? firstItem = response.Items.FirstOrDefault();
            return firstItem is not null ? ConvertToCdtDto(firstItem) : null;
        }
        catch (Exception ex)
        {
            // Manejar y registrar la excepción
            HandleException(ex);
            throw;
        }
    }

    private static ScanRequest CreateScanRequest(IDynamoConnectionConfig config)
    {
        return new ScanRequest { TableName = config.TableName() };
    }

    private CreateCdtOutDto ConvertToCdtDto(Dictionary<string, AttributeValue> item)
    {
        return new CreateCdtOutDto
        {
            Id = GetStringValue(item, "id"),
            NumeroCliente = GetLongValue(item, "numeroCliente").ToString(),
            NumeroProducto = GetLongValue(item, "numeroProducto").ToString(),
            PrimerNombre = GetStringValue(item, "primerNombre"),
            SegundoNombre = GetStringValue(item, "segundoNombre"),
            PrimerApellido = GetStringValue(item, "primerApellido"),
            SegundoApellido = GetStringValue(item, "segundoApellido"),
            MontoAperturaCdt = GetDecimalValue(item, "montoAperturaCdt"),
            FechaApertura = GetFechaApertura(item, "fechaApertura"),
            FechaVencimiento = GetFechaVencimiento(item, "fechaVencimiento"),
            Duracion = GetDuracion(item, "duracion"),
            FrecuenciaPagoInteres = GetFrecuenciaPagoInteres(item, "frecuenciaPagoInteres"),
            TasaEfectiva = GetDoubleValue(item, "tasaEfectiva"),
            TasaNominal = GetDoubleValue(item, "tasaNominal"),
            InteresCalculado = GetDoubleValue(item, "interesCalculado"),
            InteresNeto = GetDoubleValue(item, "interesNeto"),
            RetencionFuente = GetDoubleValue(item, "retencionFuente"),
            ErrorCode = GetIntValue(item, "errorCode"),
            ErrorField = GetStringValue(item, "errorField"),
            ErrorDescription = GetStringValue(item, "errorDescription"),
            ApprovalStatus = GetStringValue(item, "approvalStatus")
        };
    }

    private void HandleException(Exception ex)
    {
        if (!ex.Data.Contains("Logged"))
        {
            logger.LogError(ex, "Error al obtener la lista de CDT");
            ex.Data["Logged"] = true;
        }
    }
}
