using Domain.Dtos;
using Domain.Interfaces.AwsKafka.Agents;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using static Application.Services.CreateCustomerService;

namespace Application.Services;

public class CreateCustomerService : ICreateCustomerService, ICreateCustomerService
{
    private readonly IAwsDynamoRepository awsDynamoRepository;
    private readonly ILogger<CreateCustomerService> logger;

    public CreateCustomerService(
        IAwsDynamoRepository awsDynamoRepository,
        ILogger<CreateCustomerService> logger)
    {
        this.awsDynamoRepository = awsDynamoRepository;
        this.logger = logger;
    }

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

        if (string.IsNullOrWhiteSpace(value: customerDto.NumeroIdentificacion)
return;
        if (!string.IsNullOrWhiteSpace
return;
        return;
    }

    internal interface ILogger<T>
    {
        void LogWarning(string v);
    }
}
