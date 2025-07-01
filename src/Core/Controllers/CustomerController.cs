using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Models.CreateCustomer.Out;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[Route("api/v1/ms/[controller]")]
[ApiController]
public class CustomerController(ICreateCustomerService createCustomerService, IMapper mapper) : ControllerBase
{
    private readonly ICreateCustomerService createCustomerService = createCustomerService;
    private readonly IMapper mapper = mapper;

    [HttpPost("CreateCustomer")]
    public async Task<ActionResult> CreateCustomer(CustomerCreateInModel customerModel)
    {
        var customerDto = mapper.Map<CustomerCreateInDto>(customerModel);
        string? id = await createCustomerService.SendCreateCustomerToIbm(customerDto);

        return StatusCode(StatusCodes.Status202Accepted, new
        {
            id,
            mensaje = "Creación del cliente está en proceso",
            estado = "Pendiente"
        });
    }

    [HttpGet("CreatedCustomerList")]
    public async Task<ActionResult> GetCustomerList()
    {
        var response = mapper.Map<List<CustomerCreateOutModel>>(await createCustomerService.GetCustomerList());
        return Ok(response);
    }

    [HttpGet("CreatedCustomerById/{id}")]
    public async Task<ActionResult> GetCustomerById(string id)
    {
        var customer = await createCustomerService.GetCustomerById(id);

        if (customer is null)
        {
            return NotFound(new
            {
                id,
                mensaje = "Creación del cliente está en proceso",
                estado = "Pendiente"
            });
        }

        var response = mapper.Map<CustomerCreateOutModel>(customer);
        return Ok(response);
    }

    private class CustomerCreateOutModel
    {
    }
}
