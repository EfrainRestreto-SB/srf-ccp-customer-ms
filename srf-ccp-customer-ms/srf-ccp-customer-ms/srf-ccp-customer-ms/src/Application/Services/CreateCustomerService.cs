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

            if (string.IsNullOrWhiteSpace(createCustomerDto.BasicInformation?.FirstName) ||
               string.IsNullOrWhiteSpace(createCustomerDto.BasicInformation?.SecondName) ||
              string.IsNullOrWhiteSpace(createCustomerDto.BasicInformation?.FirstLastName))
            {
                logger.LogWarning("El DTO contiene información incompleta. Datos recibidos: {@Dto}", createCustomerDto);
                return;
            }


            // Reemplazar campos de nombres/apellidos nulos o vacíos por "vacio"
            createCustomerDto.BasicInformation.FirstName = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.FirstName);
            createCustomerDto.BasicInformation.SecondName = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.SecondName);
            createCustomerDto.BasicInformation.FirstLastName = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.FirstLastName);
            createCustomerDto.BasicInformation.SecondLastName = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.SecondLastName);
            createCustomerDto.BasicInformation.LegalName = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.LegalName);
            createCustomerDto.BasicInformation.Gender = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.Gender);
            createCustomerDto.BasicInformation.ClientType = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.ClientType);
            createCustomerDto.BasicInformation.MaritalStatus = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.MaritalStatus);
            createCustomerDto.BasicInformation.Language = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.Language);
            createCustomerDto.BasicInformation.RiskLevelCode = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.RiskLevelCode);
            createCustomerDto.BasicInformation.EconomicSector = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.EconomicSector);
            createCustomerDto.BasicInformation.EconomicActivity = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.EconomicActivity);
            createCustomerDto.BasicInformation.Stratum = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.Stratum);
            createCustomerDto.BasicInformation.EducationLevel = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.EducationLevel);
            createCustomerDto.BasicInformation.NichoCode = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.NichoCode);
            createCustomerDto.BasicInformation.IsPEP = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.IsPEP);
            createCustomerDto.BasicInformation.ManagesPublicMoney = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.ManagesPublicMoney);
            createCustomerDto.BasicInformation.HasPublicRecognition = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.HasPublicRecognition);
            createCustomerDto.BasicInformation.Status = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.Status);
            createCustomerDto.BasicInformation.HasTaxExemptions = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.HasTaxExemptions);
            createCustomerDto.BasicInformation.IsTaxWithHolder = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.IsTaxWithHolder);
            createCustomerDto.BasicInformation.IsBigTaxpayer = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.IsBigTaxpayer);
            createCustomerDto.BasicInformation.TaxpayerType = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.TaxpayerType);
            createCustomerDto.BasicInformation.SpecialTaxConditions = ReplaceNullOrEmpty(createCustomerDto.BasicInformation.SpecialTaxConditions);

            createCustomerDto.Identification.IdNumber = ReplaceNullOrEmpty(createCustomerDto.Identification.IdNumber);
            createCustomerDto.Identification.IdType = ReplaceNullOrEmpty(createCustomerDto.Identification.IdType);
            createCustomerDto.Identification.IdCountry = ReplaceNullOrEmpty(createCustomerDto.Identification.IdCountry);
            createCustomerDto.Identification.IdIssuePlace = ReplaceNullOrEmpty(createCustomerDto.Identification.IdIssuePlace);
            createCustomerDto.Identification.NationalityCode = ReplaceNullOrEmpty(createCustomerDto.Identification.NationalityCode);
            createCustomerDto.Identification.FiscalEmployeeId = ReplaceNullOrEmpty(createCustomerDto.Identification.FiscalEmployeeId);


            createCustomerDto.birthInfo.BirthCountry = ReplaceNullOrEmpty(createCustomerDto.birthInfo.BirthCountry);
            createCustomerDto.birthInfo.BirthDepartment = ReplaceNullOrEmpty(createCustomerDto.birthInfo.BirthDepartment);
            createCustomerDto.birthInfo.BirthCity = ReplaceNullOrEmpty(createCustomerDto.birthInfo.BirthCity);

            createCustomerDto.ContactInfo.EmailType = ReplaceNullOrEmpty(createCustomerDto.ContactInfo.EmailType);
            createCustomerDto.ContactInfo.Email = ReplaceNullOrEmpty(createCustomerDto.ContactInfo.Email);
            createCustomerDto.ContactInfo.PhoneType = ReplaceNullOrEmpty(createCustomerDto.ContactInfo.PhoneType);
            createCustomerDto.ContactInfo.MainPhone = ReplaceNullOrEmpty(createCustomerDto.ContactInfo.MainPhone);
            createCustomerDto.ContactInfo.PhoneExtension = ReplaceNullOrEmpty(createCustomerDto.ContactInfo.PhoneExtension);


            createCustomerDto.AddressInfo.AddressLine1 = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.AddressLine1);
            createCustomerDto.AddressInfo.AddressLine2 = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.AddressLine2);
            createCustomerDto.AddressInfo.AddressLine3 = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.AddressLine3);
            createCustomerDto.AddressInfo.City = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.City);
            createCustomerDto.AddressInfo.CityCode = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.CityCode);
            createCustomerDto.AddressInfo.Country = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.Country);
            createCustomerDto.AddressInfo.PostalCode = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.PostalCode);
            createCustomerDto.AddressInfo.ResidenceCountry = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.ResidenceCountry);
            createCustomerDto.AddressInfo.HousingType = ReplaceNullOrEmpty(createCustomerDto.AddressInfo.HousingType);



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

    private string ReplaceNullOrEmpty(string firstName)
    {
        throw new NotImplementedException();
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
