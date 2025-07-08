using AutoMapper;
using Core.Interfaces.Repositories;
using Domain.Dto.In;
using Domain.Models.Customer;

namespace SrfCcpCustomerMs.Application.Services
{
    public class CustomerService
    {
        private readonly IMapper _mapper;
        private readonly IAwsDynamoRepository<CustomerModel> _repository;

        public CustomerService(IMapper mapper, IAwsDynamoRepository<CustomerModel> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<CustomerModel> CreateCustomerAsync(CustomerCreateInDto customerDto)
        {
            // Map DTO to domain model
            var customerModel = _mapper.Map<CustomerModel>(customerDto);

            // Save to DynamoDB
            await _repository.SaveAsync(customerModel);

            return customerModel;
        }
    }
}
