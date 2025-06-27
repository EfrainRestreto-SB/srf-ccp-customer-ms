using Domain.Dtos.CreateSavingsAccount.In;
using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Interfaces.Repositories;
using Domain.Models;
using Domain.Models.CreateSavingsAccount.In;
using Domain.Models.CreateSavingsAccount.Out;

namespace Application.Mappers;

public class CreateCustomerMappingsProfile : Profile
{
    public CreateCustomerMappingsProfile() => CreateMapping();

    private void CreateMapping()
    {
        // Map In
        CreateMap<CustomerInDto, CustomerInModel>();
        CreateMap<CustomerCreateInModel, CustomerCreateInDto>();
        CreateMap<DatosGeneralesInModel, DatosGeneralesInDto>();
        CreateMap<DatosUbicacionInModel, DatosUbicacionInDto>();
        CreateMap<FechaInModel, FechaInDto>();
        CreateMap<InformacionExpedicionIdentificacionInModel, InformacionExpedicionIdentificacionInDto>();

        // Map Out
        CreateMap<CustomerOutDto, CustomerOutModel>();
        CreateMap<CustomerCreateOutDto, CustomerCreateOutModel>();
        CreateMap<DatosGeneralesOutDto, DatosGeneralesOutModel>();
        CreateMap<DatosUbicacionOutDto, DatosUbicacionOutModel>();
        CreateMap<FechaOutDto, FechaOutModel>();
        CreateMap<InformacionExpedicionIdentificacionOutDto, InformacionExpedicionIdentificacionOutModel>();
    }

    private void CreateMap<T1, T2>()
    {
        throw new NotImplementedException();
    }
}
