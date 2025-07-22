using Application.Hubs;
using Domain.Dtos;
using Domain.Dtos.Customer.In;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Application.Services;

public class CreateCustomerService(IHubContext<CustomerHub> hubContext,
                              IKafkaProducerAgent<string, CreateCustomerInDto> kafkaProducerAgent,
                              IAwsDynamoRepository awsDynamoRepository,
                              ILogger<CreateCustomerService> logger)
: ICreateCustomerService
{
    private readonly IKafkaProducerAgent<string,CreateCustomerInDto> kafkaProducerAgent = kafkaProducerAgent;
    private readonly IAwsDynamoRepository awsDynamoRepository = awsDynamoRepository;
    private readonly IHubContext<CustomerHub> hubContext = hubContext;
    private readonly ILogger<CreateCustomerService> logger = logger;

    // Socket entry
    public async Task SendCreateCustomerToIbm(string? key,CreateCustomerInDto CustomerClienteInDto)
    {
        CustomerClienteInDto.Id = key;
        await kafkaProducerAgent.ProduceMessage(key!, CustomerClienteInDto);
    }

    // Endpoint entry
    public async Task<string?> SendCreateCustomerToIbm(CreateCustomerInDto createCustomerDto)
    {
        DateTime now = DateTime.Now;
        string id = now.ToString("yyMMddHHmmss") + new Random().Next(1111, 10000);
        createCustomerDto.Id = id;

        await kafkaProducerAgent.ProduceMessage(id!, createCustomerDto);

        return id;
    }

    public async Task NotifyToClient(string clientId, CreateCustomerOutDto createCustomerDto)
    {
        try
        {
            // Validaciones mínimas del DTO
            if (string.IsNullOrWhiteSpace(clientId))
            {
                logger.LogWarning("El clientId es nulo o vacío.");
                return;
            }

            if (createCustomerDto == null)
            {
                logger.LogWarning("El DTO createCustomerDto es nulo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(createCustomerDto.firstName) ||
                string.IsNullOrWhiteSpace(createCustomerDto.secondName) ||
                createCustomerDto.firstLastName == null)
            {
                logger.LogWarning("El DTO contiene información incompleta. Datos recibidos: {@Dto}", createCustomerDto);
                return;
            }

            // Reemplazar campos de nombres/apellidos nulos o vacíos por "vacio"
            createCustomerDto.BasicInformation = string.IsNullOrWhiteSpace(createCustomerDto.BasicInformation) ? "" : createCustomerDto.BasicInformation;
            createCustomerDto.Identification = string.IsNullOrWhiteSpace(createCustomerDto.Identification) ? "" : createCustomerDto.Identification;
            createCustomerDto.ContactInfo = string.IsNullOrWhiteSpace(createCustomerDto.ContactInfo) ? "" : createCustomerDto.ContactInfo;
            createCustomerDto.AddressInfo = string.IsNullOrWhiteSpace(createCustomerDto.AddressInfo) ? "" : createCustomerDto.AddressInfo;

            // Inserta en Dynamo
            await awsDynamoRepository.InsertCreateCustomerAsync(createCustomerDto);

            // Verifica si el cliente está conectado
            if (CustomerHub.clientConnections.TryGetValue(clientId!, out string? connectionId))
            {
                logger.LogInformation("Notificando al cliente {ClientId}", clientId);
                var json = JsonSerializer.Serialize(createCustomerDto);
                await hubContext.Clients.Client(connectionId).SendAsync("ReceiveMessage", json);
            }
            else
            {
                logger.LogWarning("No existe el cliente {ClientId} en la lista de conexiones establecidas.", clientId);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Ocurrió un error al intentar notificar al cliente {ClientId}.", clientId);
        }
    }



    // Endpoint entries
    public async Task<List<CreateCustomerOutDto>> GetCustomerList()
    {
        return await awsDynamoRepository.GetCustomerList();
    }

    public async Task<CreateCustomerOutDto?> GetCustomerById(string? id)
    {
        return await awsDynamoRepository.GetCustomerListByIdAsync(id!);
    }
}
