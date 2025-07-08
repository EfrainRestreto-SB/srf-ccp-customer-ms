using Domain.Dto.In;
using Microsoft.AspNetCore.Mvc;
using SrfCcpCustomerMs.Application.Services;
using SrfCcpCustomerMs.Domain.Dtos.In;
using System.Threading.Tasks;

namespace SrfCcpCustomerMs.Presentation.Controllers
{
    [ApiController]
    [Route("v1/ms/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
        }

        [HttpPost("natura")]
        public async Task<IActionResult> CreateCustomer([FromBody] Domain.Dtos.In.CustomerCreateOutDto dto)
        {
            var result = await _service.CreateCustomerAsync(dto);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { Id = id });
        }
    }
}
