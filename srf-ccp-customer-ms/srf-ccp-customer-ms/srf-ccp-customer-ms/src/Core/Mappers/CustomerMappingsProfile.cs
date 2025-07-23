using Application.Dtos.Customer.Create.Out;
using AutoMapper;
using Domain.Dto.In;
using Domain.Dto.Out;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer.Out;
using Domain.Models;

namespace Application.Mappers;

public class CustomerMappingsProfile : Profile
{
    public CustomerMappingsProfile() => CreateMapping();

    private void CreateMapping()
    {
        // IN
        CreateMap<CreateCustomerInModel, CreateCustomerInDto>();
        CreateMap<BasicInformationInDto, BasicInformationInModel>();
        CreateMap<IdentificationInModel, IdentificationInDto>();
        CreateMap<BirthInfoInModel, BirthInfoInDto>();
        CreateMap<ContactInfoInModel, ContactInfoInDto>();
        CreateMap<AddressInfoInModel, AddressInfoInDto>();
        CreateMap<FinancialInfoInModel, FinancialInfoInDto>();
        CreateMap<EmploymentInfoInModel, EmploymentInfoInDto>();
        CreateMap<ForeignCurrencyInfoInModel, ForeignCurrencyInfoInDto>();
        CreateMap<BankingInfoInModel, BankingInfoInDto>();
        CreateMap<InterviewInfoInModel, InterviewInfoInDto>();
        CreateMap<ReferenceInModel, ReferenceInfoInDto>();
        CreateMap<DescriptionInfoInModel, DescriptionInfoInDto>();

        // OUT
        CreateMap<CreateCustomerOutDto, CreateCustomerOutModel>();
        CreateMap<BasicInformationOutDto, BasicInformationOutModel>();
        CreateMap<IdentificationOutDto, IdentificationOutModel>();
        CreateMap<BirthInfoOutDto, BirthInfoOutModel>();
        CreateMap<ContactInfoOutDto, ContactInfoOutModel>();
        CreateMap<AddressInfoOutDto, AddressInfoOutModel>();
        CreateMap<FinancialInfoOutDto, FinancialInfoOutModel>();
        CreateMap<EmploymentInfoOutDto, EmploymentInfoOutModel>();
        CreateMap<ForeignCurrencyInfoOutDto, ForeignCurrencyInfoOutModel>();
        CreateMap<BankingInfoOutDto, BankingInfoOutModel>();
        CreateMap<InterviewInfoOutDto, InterviewInfoOutModel>();
        CreateMap<ReferencesOutDto, ReferenceOutModel>();
        CreateMap<DescriptionInfoOutDto, DescriptionInfoOutModel>();
    }

}
