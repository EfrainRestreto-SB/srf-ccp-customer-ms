using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.Customer.In;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Models.CreateCustomer.In;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;
[Route("api/v1/ms/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICreateCustomerService _createCustomerService;
    private readonly IMapper _mapper;

    public CustomerController(ICreateCustomerService createCustomerService, IMapper mapper)
    {
        _createCustomerService = createCustomerService;
        _mapper = mapper;
    }

    [HttpPost("CreateCustomer")]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerInModel createCustomerIn)
    {
        var dto = _mapper.Map<CreateCustomerInDto>(createCustomerIn);
        string? id = await _createCustomerService.SendCreateCustomerToIbm(dto);

        return Accepted(new
        {
            id,
            mensaje = "Creación de la cuenta Customer está en proceso",
            estado = "Pendiente"
        });
    }

    // otros métodos...
}
