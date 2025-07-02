using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.CreateCustomer.Out;
using Domain.Interfaces.Services;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.Out;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;
using CustomerCreateInModel = Domain.Models.CreateCustomer.In.CustomerCreateInModel;

namespace Core.Controllers
{
    [ApiController]
    [Route("api/v1/customers")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class CustomerController : ControllerBase
    {
        private readonly ICreateCustomerService _createCustomerService;
        private readonly IMapper _mapper;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(
            ICreateCustomerService createCustomerService,
            IMapper mapper,
            ILogger<CustomerController> logger)
        {
            _createCustomerService = createCustomerService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Crea un nuevo cliente de forma asíncrona
        /// </summary>
        /// <param name="model">Datos del cliente a crear</param>
        /// <returns>Resultado de la operación con el ID de seguimiento</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CustomerCreationResponse>> CreateCustomer(
            [FromBody] CustomerCreateInModel model)
        {
            _logger.LogInformation("Iniciando creación de cliente");

            try
            {
                // Validación del modelo
                if (!ModelState.IsValid)
                {
                    _logger.LogWarning("Modelo de cliente inválido. Errores: {Errors}",
                        ModelState.Values.SelectMany(v => v.Errors));
                    return BadRequest(ModelState);
                }

                var dto = _mapper.Map<CustomerCreateInDto>(model);
                var result = await _createCustomerService.SendCreateCustomerToIbm(dto);

                if (string.IsNullOrEmpty(result))
                {
                    _logger.LogError("No se pudo iniciar el proceso de creación del cliente");
                    return StatusCode(StatusCodes.Status500InternalServerError, new
                    {
                        Message = "Error al iniciar el proceso de creación del cliente"
                    });
                }

                _logger.LogInformation("Cliente {CustomerId} creado exitosamente", result);

                var response = new CustomerCreationResponse
                {
                    Id = result,
                    Message = "Creación del cliente está en proceso",
                    Status = "Pendiente",
                    StatusUrl = Url.Action(nameof(GetCustomerStatus), new { id = result }) ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                return Accepted(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear el cliente");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error interno al procesar la solicitud"
                });
            }
        }

        /// <summary>
        /// Obtiene el estado de un cliente en proceso de creación
        /// </summary>
        /// <param name="id">ID del cliente</param>
        /// <returns>Información del estado actual</returns>
        [HttpGet("status/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerStatusResponse>> GetCustomerStatus(
            [FromRoute] string id)
        {
            _logger.LogInformation("Consultando estado del cliente {CustomerId}", id);

            try
            {
                var dto = await _createCustomerService.GetCustomerById(id);

                if (dto is null)
                {
                    _logger.LogWarning("Cliente {CustomerId} no encontrado", id);
                    return NotFound(new CustomerStatusResponse
                    {
                        Id = id,
                        Message = "El cliente aún no ha sido creado o está en proceso.",
                        Status = "Pendiente",
                        LastUpdated = DateTime.UtcNow
                    });
                }

                var response = _mapper.Map<CustomerStatusResponse>(dto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al consultar estado del cliente {CustomerId}", id);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error interno al consultar el estado"
                });
            }
        }

        /// <summary>
        /// Obtiene la lista de clientes creados
        /// </summary>
        /// <returns>Lista de clientes</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CustomerCreateOutModel>>> GetCustomerList()
        {
            _logger.LogInformation("Obteniendo lista de clientes");

            try
            {
                var dtos = await _createCustomerService.GetCustomerList();
                var response = _mapper.Map<List<CustomerCreateOutModel>>(dtos);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la lista de clientes");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error interno al obtener la lista"
                });
            }
        }

        /// <summary>
        /// Obtiene un cliente por su ID
        /// </summary>
        /// <param name="id">ID del cliente</param>
        /// <returns>Información completa del cliente</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CustomerCreateOutModel>> GetCustomerById(
            [FromRoute] string id)
        {
            _logger.LogInformation("Consultando cliente por ID: {CustomerId}", id);

            try
            {
                var dto = await _createCustomerService.GetCustomerById(id);

                if (dto is null)
                {
                    _logger.LogWarning("Cliente {CustomerId} no encontrado", id);
                    return NotFound(new
                    {
                        Id = id,
                        Message = "Cliente no encontrado",
                        Status = "No existe"
                    });
                }

                var response = _mapper.Map<CustomerCreateOutModel>(dto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al consultar cliente {CustomerId}", id);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "Ocurrió un error interno al consultar el cliente"
                });
            }
        }

        public class CustomerCreateOutModel
        {
        }
    }

    public class CustomerCreationResponse
    {
        public string Id { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string StatusUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }

    public class CustomerStatusResponse
    {
        public string Id { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
    }
}