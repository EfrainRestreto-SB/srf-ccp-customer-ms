using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Models.Customer.In;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[Route("api/v1/ms/[controller]")]
[ApiController]
public class CustomerController(ICreateCustomerService createCustomerService, IMapper mapper) : ControllerBase
{
    private readonly ICreateCustomerService createCustomerService = createCustomerService;
    private readonly IMapper mapper = mapper;

    [HttpPost]
    [Route("Natural")]
    public async Task<ActionResult> CreateCustomer(CreateCustomerInModel createCustomerIn)
    {
        CreateCustomerInDto createCustomerInDto = mapper.Map<CreateCustomerInDto>(createCustomerIn);

        string? id = await createCustomerService.SendCreateCustomerToIbm(createCustomerInDto);

        return StatusCode(StatusCodes.Status202Accepted, new
        {
            id,
            mensaje = "Creación de la cuenta customer esta en proceso",
            estado = "Pendiente"
        });
    }

    [HttpGet]
    [Route("CreatedCustomerList")]
    public async Task<ActionResult> GetCustomerList()
    {
        List<CreateCustomerOutDto> Customers = await createCustomerService.GetCustomerList();
        List<CreateCustomerOutModel> response = mapper.Map<List<CreateCustomerOutModel>>(Customers);

        return StatusCode(StatusCodes.Status200OK, response);
    }

    [HttpGet]
    [Route("CreatedCustomerById/{id}")]
    public async Task<ActionResult> GetCustomerById(string id)
    {
        CreateCustomerOutDto? customer = await createCustomerService.GetCustomerById(id);

        if (customer is null)
        {
            return StatusCode(StatusCodes.Status404NotFound, new
            {
                id,
                mensaje = "Creación de la cuenta Customer esta en proceso",
                estado = "Pendiente"
            });
        }

        CreateCustomerOutModel response = mapper.Map<CreateCustomerOutModel>(customer);
        return StatusCode(StatusCodes.Status200OK, response);
    }
}
