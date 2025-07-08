using AutoMapper;
using Domain.Models.Customer;

namespace SrfCcpCustomerMs.Application.Services
{
    public class CustomerService
    {
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<CustomerModel> CreateCustomerAsync(Domain.Dtos.In.CustomerCreateOutDto dto)
        {
            var customer = _mapper.Map<CustomerModel>(dto);
            // Simulación de persistencia (puedes enviar a Dynamo, Kafka, etc.)
            await Task.Delay(10);
            return customer;
        }

    }
}
