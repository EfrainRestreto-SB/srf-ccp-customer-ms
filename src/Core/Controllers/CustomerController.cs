using Domain.Interfaces.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[ApiController]
[Route("api/Customer")]
public class CustomerController(ICreateCustomerService createCustomerService, IMapper mapper) : ControllerBase
{
    // GET /api/Customer/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<CustomerOutModel>> GetById(int id)
    {
        var customer = await createCustomerService.GetCustomerById(id.ToString());
        if (customer == null)
            return NotFound();

        return Ok(mapper.Map<CustomerOutModel>(customer));
    }

    // GET /api/Customer/by-ident/{numeroIdentificacion}
    [HttpGet("by-ident/{numeroIdentificacion}")]
    public async Task<ActionResult<CustomerOutModel>> GetByIdentificacion(string numeroIdentificacion)
    {
        var customer = await createCustomerService.GetCustomerById(numeroIdentificacion);
        if (customer == null)
            return NotFound();

        return Ok(mapper.Map<CustomerOutModel>(customer));
    }

    // POST /api/Customer
    [HttpPost]
    public async Task<ActionResult<CustomerOutModel>> CreateCustomer([FromBody] CustomerInModel customerInModel)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var dto = mapper.Map<CustomerInDto>(customerInModel);
        var created = await createCustomerService.CreateCustomerAsync(dto);
        var response = mapper.Map<CustomerOutModel>(created);

        return CreatedAtAction(nameof(GetByIdentificacion), new { numeroIdentificacion = response.NumeroIdentificacion }, response);
    }
}

