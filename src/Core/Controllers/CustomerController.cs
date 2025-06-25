using Microsoft.AspNetCore.Mvc;
using SrfCcpCustomerMs.Application.Services;
using SrfCcpCustomerMs.Domain.Entities;

namespace SrfCcpCustomerMs.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _service.GetCustomerById(id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }
    }
}
