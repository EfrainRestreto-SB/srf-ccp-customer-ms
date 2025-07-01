using Application.Hubs;
using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.CreateCustomer.Out;
using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Application.Services;

public class CreateCustomerService(IHubContext<CustomerHub> hubContext,
                                   IKafkaProducerAgent<string, CustomerCreateInDto> kafkaProducerAgent,
                                   IAwsDynamoRepository awsDynamoRepository,
                                   ILogger<CreateCustomerService> logger)
: ICreateCustomerService
{
    private readonly IKafkaProducerAgent<string, CustomerCreateInDto> kafkaProducerAgent = kafkaProducerAgent;
    private readonly IAwsDynamoRepository awsDynamoRepository = awsDynamoRepository;
    private readonly IHubContext<CustomerHub> hubContext = hubContext;
    private readonly ILogger<CreateCustomerService> logger = logger;

    public async Task SendCreateCustomerToIbm(string? key, CustomerCreateInDto dto)
    {
        dto.Id = key;
        await kafkaProducerAgent.ProduceMessage(key!, dto);
    }

    public async Task<string?> SendCreateCustomerToIbm(CustomerCreateInDto dto)
    {
        DateTime now = DateTime.Now;
        string id = now.ToString("yyMMddHHmmss") + new Random().Next(1111, 10000);
        dto.Id = id;

        await kafkaProducerAgent.ProduceMessage(id, dto);

        return id;
    }

    public async Task NotifyToClient(string clientId, CustomerCreateOutDto dto)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(clientId) || dto == null)
                return;

            dto.PrimerNombre = string.IsNullOrWhiteSpace(dto.PrimerNombre) ? "" : dto.PrimerNombre;
            dto.SegundoNombre = string.IsNullOrWhiteSpace(dto.SegundoNombre) ? "" : dto.SegundoNombre;
            dto.PrimerApellido = string.IsNullOrWhiteSpace(dto.PrimerApellido) ? "" : dto.PrimerApellido;
            dto.SegundoApellido = string.IsNullOrWhiteSpace(dto.SegundoApellido) ? "" : dto.SegundoApellido;

            await awsDynamoRepository.InsertCreateCustomerAsync(dto);

            if (CustomerHub.clientConnections.TryGetValue(clientId, out string? connectionId))
            {
                var json = JsonSerializer.Serialize(dto);
                await hubContext.Clients.Client(connectionId).SendAsync("ReceiveMessage", json);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al notificar al cliente {ClientId}.", clientId);
        }
    }

    public async Task<List<CustomerCreateOutDto>> GetCustomerList()
    {
        return await awsDynamoRepository.GetCustomerList();
    }

    public async Task<CustomerCreateOutDto?> GetCustomerById(string? id)
    {
        return await awsDynamoRepository.GetCustomerByIdAsync(id!);
    }
}
