using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[Route("api/v1/ms/[controller]")]
[ApiController]
public class CustomerController(ICreateCdtService createCdtService, IMapper mapper) : ControllerBase
{
    private readonly ICreateCdtService createCdtService = createCdtService;
    private readonly IMapper mapper = mapper;

    [HttpPost]
    [Route("CreateCdt")]
    public async Task<ActionResult> CreateCdt(CreateCdtInModel createCdtIn)
    {
        CreateCdtInDto createCdtInDto = mapper.Map<CreateCdtInDto>(createCdtIn);

        string? id = await createCdtService.SendCreateCdtToIbm(createCdtInDto);

        return StatusCode(StatusCodes.Status202Accepted, new
        {
            id,
            mensaje = "Creación de la cuenta cdt esta en proceso",
            estado = "Pendiente"
        });
    }

    [HttpGet]
    [Route("CreatedCdtList")]
    public async Task<ActionResult> GetCdtList()
    {
        List<CreateCdtOutDto> cdts = await createCdtService.GetCdtList();
        List<CreateCdtOutModel> response = mapper.Map<List<CreateCdtOutModel>>(cdts);

        return StatusCode(StatusCodes.Status200OK, response);
    }

    [HttpGet]
    [Route("CreatedCdtById/{id}")]
    public async Task<ActionResult> GetCdtById(string id)
    {
        CreateCdtOutDto? cdts = await createCdtService.GetCdtById(id);

        if (cdts is null) 
        { 
            return StatusCode(StatusCodes.Status404NotFound, new
            {
                id,
                mensaje = "Creación de la cuenta cdt esta en proceso",
                estado = "Pendiente"
            });
        }

        CreateCdtOutModel response = mapper.Map<CreateCdtOutModel>(cdts);
        return StatusCode(StatusCodes.Status200OK, response);
    }
}
