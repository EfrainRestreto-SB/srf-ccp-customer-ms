using AutoMapper;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using SrfCcpCustomerMs.Domain.Entities;

namespace Application.Services;

public class CreateCustomerService(ICustomerRepository repository, IMapper mapper) : ICreateCustomerService
{
    public async Task<CustomerOutDto> CreateCustomerAsync(CreateCustomerInDto customerInDto)
    {
        var entity = mapper.Map<Customer>(customerInDto);
        var created = await repository.AddAsync(entity);
        return mapper.Map<CustomerOutDto>(created);
    }

    public async Task<CustomerOutDto?> GetCustomerById(int id)
    {
        var entity = await repository.GetByIdAsync(id);
        return entity == null ? null : mapper.Map<CustomerOutDto>(entity);
    }
}
