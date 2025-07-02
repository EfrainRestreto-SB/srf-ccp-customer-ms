using Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using Application.Interfaces.Services; // Asegúrate de que este espacio de nombres contiene IKafkaCustomerProducerService

namespace Application.Services;

public class CreateCustomerService(
    IKafkaCustomerProducerService kafkaProducerService,
    ICustomerRepository customerRepository,
    ILogger<CreateCustomerService> logger)
    : ICreateCustomerService
{
    private readonly IKafkaCustomerProducerService _kafkaProducerService = kafkaProducerService;
    private readonly ICustomerRepository _customerRepository = customerRepository;
    private readonly ILogger<CreateCustomerService> _logger = logger;

    public async Task<string?> SendCreateCustomerToIbm(CustomerCreateInDto customerDto)
    {
        string customerId = customerDto.Id ?? Guid.NewGuid().ToString();

        try
        {
            await _kafkaProducerService.SendMessage(customerId, customerDto);
            _logger.LogInformation("Mensaje de creación de cliente enviado al topic Kafka.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al enviar el mensaje a Kafka.");
            return null;
        }

        return customerId;
    }

    public async Task<List<CustomerCreateOutDto>> GetCustomerList()
    {
        return await _customerRepository.GetAllAsync();
    }

    public async Task<CustomerCreateOutDto?> GetCustomerById(string id)
    {
        return await _customerRepository.GetByIdAsync(id);
    }
}