using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Models;
using System.Text.Json;
using Application.Utils;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using Domain.Models.Customer.In;
using Domain.Dtos.Customer.In;

namespace Application.Hubs;

public class CustomerHub(ICreateCustomerService createCustomerSocket,
                    IMapper mapper,
                    IValidator<CreateCustomerInModel> validator,
                    ILogger<CustomerHub> logger)
: Hub
{
    private readonly ICreateCustomerService createCustomerService = createCustomerSocket;
    private readonly IMapper mapper = mapper;
    private readonly IValidator<CreateCustomerInModel> validator = validator;
    private readonly ILogger<CustomerHub> logger = logger;

    private string? clientId;
    private const string ReceiveMessageEvent = "ReceiveMessage";
    private const string ReceiveClientId = "ReceiveClientId";
    public static readonly ConcurrentDictionary<string, string> clientConnections = [];

    public string? GetConnectionId() => Context.ConnectionId;

    public override async Task OnConnectedAsync()
    {
        await Clients.Caller.SendAsync("ReceiveConnectionId", JsonSerializer.Serialize(new { connectionId = GetConnectionId() }));

        logger.LogInformation("{SocketName} Conectado con ConnectionId {ConnectionId}", nameof(CustomerHub), GetConnectionId()!);
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        KeyValuePair<string, string> connectionId = clientConnections.FirstOrDefault(x => x.Value == GetConnectionId());

        try
        {
            if (string.IsNullOrEmpty(connectionId.Key))
            {
                logger.LogInformation("No existe el Cliente {ConnectionId} en la lista de conexion establecidas.", connectionId);
                return;
            }

            clientConnections.Remove(connectionId.Key!, out string? _);
            logger.LogInformation("Cliente {ConnectionId} desconectado.", GetConnectionId());
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al desconectar el cliente {ClientId}", clientId);
            throw new HubException($"Error al desconectar el cliente {clientId}", ex);
        }

        await base.OnDisconnectedAsync(exception);
    }

    public async Task CreateCustomer(CreateCustomerInModel createCustomerInModel)
    {
        try
        {
            clientId = CommonUtil.GenerateNewClientId();

            while (clientConnections.TryGetValue(clientId!, out string? _))
                clientId = CommonUtil.GenerateNewClientId();

            clientConnections[clientId] = GetConnectionId()!;

            ValidationResult validationResult = validator.Validate(createCustomerInModel);
            if (!validationResult.IsValid)
            {
                var errores = validationResult.Errors
                    .Select(e => new { Campo = e.PropertyName, Mensaje = e.ErrorMessage })
                    .ToList();

                logger.LogWarning("Errores de validación: {Errores}", JsonSerializer.Serialize(errores));
                await Clients.Caller.SendAsync(ReceiveMessageEvent, errores);

                return;
            }

            CreateCustomerInDto createCustomerInDto = mapper.Map<CreateCustomerInDto>(createCustomerInModel);
            await createCustomerService.SendCreateCustomerToIbm(clientId, createCustomerInDto);

            await Clients.Caller.SendAsync(
                ReceiveClientId, JsonSerializer.Serialize(new { requestId = clientId, connectionId = GetConnectionId() }));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al enviar el mensaje a IBM. Cliente {ClientId}", clientId);
            throw new HubException($"Error al enviar el mensaje a IBM. Cliente {clientId}", ex);
        }
    }

    public async Task GetCreatedCustomerById(RequestModel request)
    {
        CreateCustomerOutDto? Customers = await createCustomerService.GetCustomerById(request.RequestId);

        if (Customers is null)
        {
            await Clients.Caller.SendAsync(
                ReceiveMessageEvent, JsonSerializer.Serialize(new
                {
                    request.RequestId,
                    mensaje = "Creación de la cuenta Customer esta en proceso",
                    estado = "Pendiente"
                }));

            return;
        }

        await Clients.Caller.SendAsync(ReceiveMessageEvent, JsonSerializer.Serialize(Customers));
    }
}
