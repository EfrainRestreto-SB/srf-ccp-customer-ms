using Application.Mappers;
using AutoMapper;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Entities;
using Domain.Models;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerInDto, Customer>();

        CreateMap<Customer, CustomerOutDto>()
            .ForMember(dest => dest.NombreCompleto,
                opt => opt.MapFrom(src => $"{src.PrimerNombre} {src.SegundoNombre} {src.PrimerApellido} {src.SegundoApellido}".Trim()))
            .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico));

        CreateMap<CustomerOutDto, CustomerOutModel>()
            .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.NombreCompleto))
            .ForMember(dest => dest.Correo, opt => opt.MapFrom(src => src.CorreoElectronico));
    }
}
using AutoMapper;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Entities;
using Domain.Models;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerInDto, Customer>();

        CreateMap<Customer, CustomerOutDto>()
            .ForMember(dest => dest.NombreCompleto,
                opt => opt.MapFrom(src => $"{src.PrimerNombre} {src.SegundoNombre} {src.PrimerApellido} {src.SegundoApellido}".Trim()))
            .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico));

        CreateMap<CustomerOutDto, CustomerOutModel>()
            .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.NombreCompleto))
            .ForMember(dest => dest.Correo, opt => opt.MapFrom(src => src.CorreoElectronico));
    }
}
