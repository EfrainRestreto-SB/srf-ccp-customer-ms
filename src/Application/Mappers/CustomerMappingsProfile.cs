using AutoMapper;
using Domain.Dto.In;
using Domain.Dto.Out;
using Domain.Models.Customer.In;
using Domain.Models.Customer.Out;
using static Controllers.CustomerController;
using BasicInformationOutDto = Application.Mappers.BasicInformationOutDto;
using IdentificationOutDto = Application.Mappers.IdentificationOutDto;

namespace Application.Mappings
{
    public class CustomerMappingsProfile : Profile
    {
        public CustomerMappingsProfile()
        {
            CreateMap<CreateCustomerInModel, CustomerCreateOutDto>();
            CreateMap<BasicInformationInModel, BasicInformationOutDto>();
            CreateMap<IdentificationInModel, IdentificationOutDto>();
            CreateMap<CreateCustomerOutDto, CreateCustomerOutModel>(); 
            CreateMap<CreateCustomerOutModel, CreateCustomerOutModel>();

            CreateMap<ContactInfoInModel, ContactInfoOutDto>();
            CreateMap<AddressInfoInModel, AddressInfoOutDto>();
            CreateMap<FinancialInfoModel, FinancialInfoOutDto>();
            CreateMap<EmploymentInfoInModel, EmploymentInfoOutDto>();
            CreateMap<foreignCurrencyInfoModel, ForeignCurrencyAccountOutDto>();
            CreateMap<InterviewInfoInModel, InterviewInfoOutDto>();
            CreateMap<ReferenceInModel, Domain.Dto.Out.ReferenceOutDto>();
            CreateMap<DescriptionInfoInModel, DescriptionInfoOutDto>();
        }
    }
}
