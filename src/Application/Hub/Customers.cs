using Application.Services;
using Application.Utils;
using AutoMapper;
using Domain;
using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Models.CreateCustomer.In;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Application.Hubs;

public class CustomerHub(ICreateCustomerService createCustomercket,
                    IMapper mapper,
                    IValidator<CreateCustomerInModel> validator,
                    ILogger<CustomerHub> logger)
: Hub
{
    private readonly ICreateCustomerService createCdtService = createCDTSocket;
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

        logger.LogInformation("{SocketName} Conectado con ConnectionId {ConnectionId}", nameof(CdtHub), GetConnectionId()!);
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

    public async Task CreateCdt(CreateCustomerInModel createCdtInModel)
    {
        try
        {
            clientId = CommonUtil.GenerateNewClientId();

            while (clientConnections.TryGetValue(clientId!, out string? _))
                clientId = CommonUtil.GenerateNewClientId();

            clientConnections[clientId] = GetConnectionId()!;

            ValidationResult validationResult = validator.Validate(createCdtInModel);
            if (!validationResult.IsValid)
            {
                var errores = validationResult.Errors
                    .Select(e => new { Campo = e.PropertyName, Mensaje = e.ErrorMessage })
                    .ToList();

                logger.LogWarning("Errores de validación: {Errores}", JsonSerializer.Serialize(errores));
                await Clients.Caller.SendAsync(ReceiveMessageEvent, errores);

                return;
            }

            CreateCustomerInDto createCdtInDto = mapper.Map<CreateCustomerInDto>(createCdtInModel);
            await createCdtService.SendCreateCustomerToIbm(clientId, createCdtInDto);

            await Clients.Caller.SendAsync(
                ReceiveClientId, JsonSerializer.Serialize(new { requestId = clientId, connectionId = GetConnectionId() }));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error al enviar el mensaje a IBM. Cliente {ClientId}", clientId);
            throw new HubException($"Error al enviar el mensaje a IBM. Cliente {clientId}", ex);
        }
    }

    public async Task GetCreatedCdtById(RequestModel request)
    {
        CreateCdtOutDto? cdts = await createCdtService.GetCdtById(request.RequestId);

        if (cdts is null)
        {
            await Clients.Caller.SendAsync(
                ReceiveMessageEvent, JsonSerializer.Serialize(new
                {
                    request.RequestId,
                    mensaje = "Creación de la cuenta cdt esta en proceso",
                    estado = "Pendiente"
                }));

            return;
        }

        await Clients.Caller.SendAsync(ReceiveMessageEvent, JsonSerializer.Serialize(cdts));
    }
}
