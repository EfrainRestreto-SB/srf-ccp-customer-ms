using AutoMapper;
using Controllers;
using Core.Interfaces.Services;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Entities;
using static SrfCcpCustomerMs.Domain.Dto;

namespace SrfCcpCustomerMs.Application.Services
{
    public class CustomerService : ICreateCustomerService
    {
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task CreateCustomer(CreateCustomerInDto dto)
        {
            var entity = _mapper.Map<Customer>(dto);
            entity.Id = Guid.NewGuid();

            // Simulación de persistencia (ej. guardar en base de datos o enviar a Kafka)
            await Task.CompletedTask;
        }

        public async Task<List<CreateCustomerOutDto>> GetCustomerList()
        {
            return await Task.FromResult(new List<CreateCustomerOutDto>
            {
                new CreateCustomerOutDto
                {
                    FirstName = "Thais",
                    SecondName = "Ilianis",
                    FirstLastName = "Durán",
                    SecondLastName = "Pérez",
                    LegalName = "Thais Pérez",
                    Gender = "Femenino",
                    ClientType = "Natural",
                    MaritalStatus = "Soltera",
                    Language = "Español",
                    ConsultationLevel = "1",
                    RiskLevelCode = "Bajo",
                    EconomicSector = "Tecnología",
                    EconomicActivity = "Desarrollo de software",
                    Stratum = "3",
                    EducationLevel = "Universitario",
                    NichoCode = "001",
                    IsPEP = "No",
                    ManagesPublicMoney = "No",
                    HasPublicRecognition = "No",
                    StatusCustomer = "Activo",
                    HasTaxExemptions = "No",
                    IsTaxWithHolder = "No",
                    IsBigTaxpayer = "No",
                    TaxpayerType = "Ordinario",
                    SpecialTaxConditions = "Ninguna"
                }
            });
        }

        public async Task<CreateCustomerOutDto?> GetCustomerById(string id)
        {
            if (id == "notfound")
                return null;

            var customer = new CreateCustomerOutDto
            {
                FirstName = "Nombre",
                SecondName = "Ejemplo",
                FirstLastName = "Apellido",
                SecondLastName = "Ejemplo",
                LegalName = "Nombre Completo",
                Gender = "Femenino",
                ClientType = "Natural",
                MaritalStatus = "Soltera",
                Language = "Español",
                ConsultationLevel = "1",
                RiskLevelCode = "Bajo",
                EconomicSector = "Tecnología",
                EconomicActivity = "Desarrollo de software",
                Stratum = "3",
                EducationLevel = "Universitario",
                NichoCode = "001",
                IsPEP = "No",
                ManagesPublicMoney = "No",
                HasPublicRecognition = "No",
                StatusCustomer = "Activo",
                HasTaxExemptions = "No",
                IsTaxWithHolder = "No",
                IsBigTaxpayer = "No",
                TaxpayerType = "Ordinario",
                SpecialTaxConditions = "Ninguna"
            };

            return await Task.FromResult(customer);
        }

        public Task<Guid> CreateCustomerAsync(CustomerCreateInDto customerDto)
        {
            throw new NotImplementedException();
        }

        Task<List<CustomerController.CreateCustomerOutDto>> ICreateCustomerService.CustomerList => throw new NotImplementedException();

        //Task<CustomerController.CreateCustomerOutDto?> ICreateCustomerService.GetCustomerById(string id) => throw new NotImplementedException();

        public Task CreateCustomer(Core.CreateCustomerInDto dto)
        {
            throw new NotImplementedException();
        }

        Task ICreateCustomerService.CreateCustomerAsync(CustomerCreateInDto customerCreateInDto)
        {
            return CreateCustomerAsync(customerCreateInDto);
        }
    }
}
