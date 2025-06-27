using Application.Services;
using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[Route("api/v1/ms/[controller]")]
[ApiController]
public class CustomerController(ICreateCustomerService createCustomerService, IMapper mapper) : ControllerBase
{
    private readonly ICreateCustomerService createCustomerService = createCustomerService;
    private readonly IMapper mapper = mapper;

    [HttpGet]
    [Route("clientes/{numeroIdentificacion}")]
    public async Task<ActionResult> GetCustomerById(string numeroIdentificacion)
    {
        CustomerOutDto? customer = await createCustomerService.GetCustomerById(numeroIdentificacion);

        if (customer is null)
        {
            return StatusCode(StatusCodes.Status404NotFound, new
            {
                numeroIdentificacion,
                mensaje = "El cliente aún no ha sido creado.",
                estado = "Pendiente"
            });
        }

        CustomerOutModel response = mapper.Map<CustomerOutModel>(customer);
        return StatusCode(StatusCodes.Status200OK, response);
    }
}
