using AutoMapper;
using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.CreateCustomer.Out;
using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Interfaces.Services;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.Out;
using Domain.Models.CreateSavingsAccount.Out;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[Route("api/v1/ms/[controller]")]
[ApiController]
public class CustomerController(ICreateCustomerService createCustomerService, IMapper mapper) : ControllerBase
{
    private readonly ICreateCustomerService createCustomerService = createCustomerService;
    private readonly IMapper mapper = mapper;

    [HttpPost]
    [Route("CreateCustomer")]
    public async Task<ActionResult> CreateCustomer(CustomerCreateInModel createCustomerIn)
    {
        CustomerCreateInDto createCustomerInDto = mapper.Map<CustomerCreateInDto>(createCustomerIn);

        string? id = await createCustomerService.SendCreateCustomerToIbm(createCustomerInDto);

        return StatusCode(StatusCodes.Status202Accepted, new
        {
            id,
            mensaje = "Creación del cliente está en proceso",
            estado = "Pendiente"
        });
    }

    [HttpGet]
    [Route("CreatedCustomerList")]
    public async Task<ActionResult> GetCustomerList()
    {
        List<CustomerCreateOutDto> customers = await createCustomerService.GetCustomerList();
        List<CustomerCreateOutModel> response = mapper.Map<List<CustomerCreateOutModel>>(customers);

        return StatusCode(StatusCodes.Status200OK, response);
    }

    [HttpGet]
    [Route("CreatedCustomerById/{id}")]
    public async Task<ActionResult> GetCustomerById(string id)
    {
        CustomerCreateOutDto? customer = await createCustomerService.GetCustomerById(id);

        if (customer is null)
        {
            return StatusCode(StatusCodes.Status404NotFound, new
            {
                id,
                mensaje = "Creación del cliente está en proceso",
                estado = "Pendiente"
            });
        }

        CustomerCreateOutModel response = mapper.Map<CustomerCreateOutModel>(customer);
        return StatusCode(StatusCodes.Status200OK, response);
    }
}
