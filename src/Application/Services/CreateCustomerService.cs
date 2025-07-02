using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Application.Services
{

    public class CreateCustomerService : ICreateCustomerService
    {
        private readonly IKafkaCustomerProducerService _kafkaProducerService;
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger<CreateCustomerService> _logger;
        private readonly IMapper _mapper;
        private readonly IHubContext<CustomerHub> _hubContext;

        public CreateCustomerService(
            IKafkaCustomerProducerService kafkaProducerService,
            ICustomerRepository customerRepository,
            ILogger<CreateCustomerService> logger,
            IMapper mapper,
            IHubContext<CustomerHub> hubContext)
        {
            _kafkaProducerService = kafkaProducerService;
            _customerRepository = customerRepository;
            _logger = logger;
            _mapper = mapper;
            _hubContext = hubContext;
        }

        public async Task<CustomerCreationResult> SendCreateCustomerToIbm(CustomerCreateInDto customerDto)
        {
            var stopwatch = Stopwatch.StartNew();
            var customerId = customerDto.Id ?? Guid.NewGuid().ToString();
            customerDto.Id = customerId;

            try
            {
                // 1. Notificar inicio del proceso via WebSocket
                await NotifyCustomerCreationStatus(customerId, "PROCESSING",
                    "Customer creation process started");

                // 2. Validar datos antes de enviar
                if (!ValidateCustomerData(customerDto))
                {
                    _logger.LogWarning("Validation failed for customer {CustomerId}", customerId);
                    await NotifyCustomerCreationStatus(customerId, "FAILED",
                        "Customer data validation failed");
                    return new CustomerCreationResult(false, customerId, "Validation failed");
                }

                // 3. Guardar en base de datos como "en progreso"
                var customerModel = _mapper.Map<CustomerCreateInModel>(customerDto);
                customerModel.Status = "PROCESSING";
                await _customerRepository.AddAsync(customerModel);

                // 4. Enviar a Kafka
                var kafkaResult = await _kafkaProducerService.SendMessage(customerId, customerDto);

                if (!kafkaResult.IsSuccess)
                {
                    _logger.LogError("Failed to send message to Kafka for {CustomerId}", customerId);
                    await UpdateCustomerStatus(customerId, "FAILED",
                        "Failed to send to Kafka");
                    return new CustomerCreationResult(false, customerId,
                        "Failed to send to Kafka");
                }

                _logger.LogInformation("Successfully sent customer {CustomerId} to Kafka " +
                    "in {ElapsedMilliseconds}ms", customerId, stopwatch.ElapsedMilliseconds);

                // 5. Notificar éxito parcial (procesamiento en curso)
                await NotifyCustomerCreationStatus(customerId, "PROCESSING",
                    "Customer data received and being processed");

                return new CustomerCreationResult(true, customerId,
                    "Customer creation process started successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing customer {CustomerId}", customerId);
                await UpdateCustomerStatus(customerId, "FAILED",
                    $"Error: {ex.Message}");
                await NotifyCustomerCreationStatus(customerId, "FAILED",
                    "Error processing your request");

                return new CustomerCreationResult(false, customerId,
                    $"Error: {ex.Message}");
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        public async Task<List<CustomerCreateOutDto>> GetCustomerList()
        {
            try
            {
                var customers = await _customerRepository.GetAllAsync();
                return _mapper.Map<List<CustomerCreateOutDto>>(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving customer list");
                throw;
            }
        }

        public async Task<CustomerCreateOutDto?> GetCustomerById(string id)
        {
            try
            {
                var customer = await _customerRepository.GetByIdAsync(id);
                return customer != null ?
                    _mapper.Map<CustomerCreateOutDto>(customer) : null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving customer {CustomerId}", id);
                throw;
            }
        }

        public async Task UpdateCustomerStatus(string customerId, string status, string message)
        {
            try
            {
                await _customerRepository.UpdateStatusAsync(customerId, status, message);
                _logger.LogInformation("Updated status for {CustomerId} to {Status}",
                    customerId, status);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating status for {CustomerId}", customerId);
                throw;
            }
        }

        private async Task NotifyCustomerCreationStatus(string customerId,
            string status, string message)
        {
            try
            {
                await _hubContext.Clients.Group(customerId).SendAsync("CustomerStatusUpdate",
                    new { CustomerId = customerId, Status = status, Message = message });

                _logger.LogDebug("Notification sent for {CustomerId} with status {Status}",
                    customerId, status);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending notification for {CustomerId}", customerId);
            }
        }

        private bool ValidateCustomerData(CustomerCreateInDto customer)
        {
            // Implementar validaciones específicas según requisitos
            if (string.IsNullOrWhiteSpace(customer.BasicInformation?.FirstName))
                return false;

            if (string.IsNullOrWhiteSpace(customer.Identification?.IdNumber))
                return false;

            // Más validaciones según necesidades...

            return true;
        }
    }

    public record CustomerCreationResult(bool IsSuccess, string CustomerId, string Message);
}