using AutoMapper;
using Core.Interfaces.Repositories;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;
using Domain.Models.Customer;

public class CustomerService
{
    private readonly IMapper? _mapper; }
namespace SrfCcpCustomerMs.Application.Services
{
    public class CustomerService : CustomerServiceBase
    {

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
        public CustomerService(IMapper mapper) => mapper = mapper;
        // public CustomerService(IMapper mapper, IAwsDynamoRepository<CustomerModel> repository)
        //{
        // mapper = mapper;
        //  repository = repository;
    }
    }

    public class CustomerServiceBase
    {
    }
//}
