using Application.Services;
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
    [Route("CreateCustomer")]
    public async Task<ActionResult> CreateCustomer(CreateCustomerInModel createCustomerIn)
    {
        CreateCustomerInDto createCustomerInDto = mapper.Map<CreateCustomerInDto>(createCustomerIn);

        string? id = await createCustomerService.SendCreateCustomerToIbm(createCustomerInDto);

        return StatusCode(StatusCodes.Status202Accepted, new
        {
            id,
            mensaje = "Creación de la cuenta Customer esta en proceso",
            estado = "Pendiente"
        });
    }

    [HttpGet]
    [Route("CreatedCustomerList")]
    public async Task<ActionResult> GetCustomerList()
    {
        List<CreateCustomerOutDto> Customers = await createCustomerService.GetCustomerList();
        List<CreateCustomerInModel> response = mapper.Map<List<CreateCustomerInModel>>(Customers);

        return StatusCode(StatusCodes.Status200OK, response);
    }

    [HttpGet]
    [Route("CreatedCustomerById/{id}")]
    public async Task<ActionResult> GetCustomerById(string id)
    {
        CreateCustomerOutDto? Customers = await createCustomerService.GetCustomerById(id);

        if (Customers is null)
        {
            return StatusCode(StatusCodes.Status404NotFound, new
            {
                id,
                mensaje = "Creación de la cuenta Customer esta en proceso",
                estado = "Pendiente"
            });
        }

        CreateCustomerInModel response = mapper.Map<CreateCustomerInModel>(Customers);
        return StatusCode(StatusCodes.Status200OK, response);
    }
}
