using Application.Interfaces;
using AutoMapper;
using Domain.Dto.In;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [Route("api/v1/ms/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("natura")]
        public async Task<ActionResult> CreateCustomer([FromBody] CustomerCreateInModel customerIn)
        {
            CustomerCreateInDto customerDto = _mapper.Map<CustomerCreateInDto>(customerIn);

            await _customerService.CreateCustomerAsync(customerDto);

            return StatusCode(StatusCodes.Status202Accepted, new
            {
                mensaje = "Creación de cliente en proceso",
                estado = "Pendiente"
            });
        }

        [HttpGet]
        [Route("customerList")]
        public async Task<ActionResult> GetCustomerList()
        {
            List<CustomerModel> customers = await _customerService.GetAllCustomers();
            List<CustomerOutModel> response = _mapper.Map<List<CustomerOutModel>>(customers);

            return Ok(response);
        }

        [HttpGet]
        [Route("customerById/{id}")]
        public async Task<ActionResult> GetCustomerById(string id)
        {
            CustomerModel? customer = await _customerService.GetCustomerById(id);

            if (customer == null)
            {
                return NotFound(new
                {
                    id,
                    mensaje = "Cliente no encontrado",
                    estado = "No existe"
                });
            }

            CustomerOutModel response = _mapper.Map<CustomerOutModel>(customer);
            return Ok(response);
        }
    }
}
