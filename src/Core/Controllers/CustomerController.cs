using AutoMapper;
using Core.Interfaces.Services;
using Domain.Models.Customer.In;
using Domain.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using Domain.Models.Customer.Out;
using Core;
using Swashbuckle.AspNetCore.Annotations;

namespace SrfCcpCustomerMs.Presentation.Controllers
{
    [ApiController]
    [Route("v1/ms/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICreateCustomerService _createCustomerService;
        private readonly IMapper _mapper;
        private object id;

        public CustomerController(ICreateCustomerService createCustomerService, IMapper mapper)
        {
            _createCustomerService = createCustomerService;
            _mapper = mapper;
        }


        [HttpPost("Natural")]
        public async Task<IActionResult> CreateCustomer([FromBody]CreateCustomerInModel createCustomerIn)
        {
            var dto = _mapper.Map<CreateCustomerInDto>(createCustomerIn);
            await _createCustomerService.CreateCustomer(dto); 

            return StatusCode(StatusCodes.Status202Accepted, new
            {
                id = Guid.NewGuid().ToString(),
                mensaje = "Creación de la cuenta Customer está en proceso",
                estado = "Pendiente"
            });
        }

        [HttpGet("lists")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<CreateCustomerOutModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerList()
        {
            var customers = await _createCustomerService.GetCustomerList();
            var response = _mapper.Map<List<CreateCustomerOutModel>>(customers);

            return Ok(response); 
        }


        [HttpGet("{id}")]
        [Produces("application/json")]
        [SwaggerResponse(StatusCodes.Status200OK, "Cliente encontrado", typeof(CreateCustomerOutModel))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Cliente no encontrado")]
        public async Task<IActionResult> GetCustomerById(string id)
        {
            var customer = await _createCustomerService.GetCustomerById(id);

            if (customer is null)
            {
                return NotFound(new
                {
                    id,
                    mensaje = "El cliente aún no ha sido creado o no existe.",
                    estado = "Pendiente"
                });
            }

            var response = _mapper.Map<CreateCustomerOutModel>(customer);
            return Ok(response);
        }

    }



}
