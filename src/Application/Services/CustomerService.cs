using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Application.Services;

public class CreateCustomerService(
    IAwsDynamoRepository awsDynamoRepository,
#pragma warning disable CS0436 // El tipo entra en conflicto con un tipo importado
    ILogger<CreateCustomerService> logger) : ICreateCustomerService, ICreateCustomerService
#pragma warning restore CS0436 // El tipo entra en conflicto con un tipo importado
{
    private readonly IAwsDynamoRepository awsDynamoRepository = awsDynamoRepository;
    private readonly ILogger<CreateCustomerService> logger = logger;

    public CreateCustomerService()
    {
    }

    // Endpoint POST - Inserta cliente en DynamoDB
    public async Task NotifyToClient(string clientId, CustomerOutDto customerDto)
    {
        if (string.IsNullOrWhiteSpace(clientId))
        {
            logger.LogWarning("El clientId es nulo o vacío.");
            return;
        }

        if (customerDto == null)
        {
            logger.LogWarning("El DTO customerDto es nulo.");
            return;
        }

        if (string.IsNullOrWhiteSpace(customerDto.NumeroIdentificacion) ||
string.IsNullOrWhiteSpace
return; return;
    }

    internal interface ILogger<T>
    {
        void LogWarning(string v);
    }
}
