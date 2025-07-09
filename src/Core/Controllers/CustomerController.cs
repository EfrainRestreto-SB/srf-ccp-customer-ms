using AutoMapper;
using Core.Interfaces.Services;
using Domain.Models.Customer.In;
using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// Crea un nuevo cliente y lo envía al flujo de procesamiento.
        /// </summary>
        [HttpPost("natural")]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerInModel createCustomerIn)
        {
            var dto = _mapper.Map<global::Domain.Dto.In.CreateCustomerOutDto>(createCustomerIn);
            return StatusCode(StatusCodes.Status202Accepted, new
            {
                id,
                mensaje = "Creación de la cuenta Customer está en proceso",
                estado = "Pendiente"
            });
        }

        /// <summary>
        /// Obtiene la lista de clientes ya creados.
        /// </summary>
        [HttpGet("list")]
        public async Task<IActionResult> GetCustomerList()
        {
            var customers = await _createCustomerService.GetCustomerList();
            var response = _mapper.Map<List<CreateCustomerOutModel>>(customers);

            return Ok(response);
        }

        /// <summary>
        /// Consulta un cliente creado por ID.
        /// </summary>
        [HttpGet("{id}")]
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

        private class CreateCustomerOutModel
        {
        }
    }
}
