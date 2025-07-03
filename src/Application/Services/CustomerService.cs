using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Dtos.Customer.In;

namespace Application.Services;

public class CreateCustomerService : ICreateCustomerService
{
    private readonly IAwsDynamoRepository _awsDynamoRepository;
    private readonly ILogger<CreateCustomerService> _logger;

    public CreateCustomerService(IAwsDynamoRepository awsDynamoRepository, ILogger<CreateCustomerService> logger)
    {
        _awsDynamoRepository = awsDynamoRepository;
        _logger = logger;
    }

    // POST - Inserta cliente en DynamoDB (simulado)
    public async Task NotifyToClient(string clientId, Domain.Dtos.Customer.Out.CustomerOutDto customerDto)
    {
        if (string.IsNullOrWhiteSpace(clientId))
        {
            _logger.LogWarning("El clientId es nulo o vacío.");
            return;
        }

        if (customerDto == null)
        {
            _logger.LogWarning("El DTO customerDto es nulo.");
            return;
        }

        if (!string.IsNullOrWhiteSpace(customerDto.NumeroIdentificacion) &&
            string.IsNullOrWhiteSpace(customerDto.CorreoElectronico))
        {
            _logger.LogWarning("Se recibió identificación pero sin correo electrónico.");
            return;
        }

        // Simulación de inserción en DynamoDB
        await _awsDynamoRepository.SaveCustomerAsync(clientId, customerDto);
        _logger.LogInformation("Cliente {ClientId} notificado correctamente.", clientId);
    }

    Task<Domain.Dtos.Customer.Out.CustomerOutDto> ICreateCustomerService.CreateCustomerAsync(CreateCustomerInDto customerInDto)
    {
        throw new NotImplementedException();
    }

    Task<Domain.Dtos.Customer.Out.CustomerOutDto?> ICreateCustomerService.GetCustomerById(int id)
    {
        throw new NotImplementedException();
    }
}
