using Application.Dtos.Customer.Create.Out;
using AutoMapper;
using Domain.Dto.In;
using Domain.Dto.Out;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using Domain.Models.Customer.Out;

namespace Application.Mappers;

public class CustomerMappingsProfile : Profile
{
    public CustomerMappingsProfile() => CreateMapping();

    private void CreateMapping()
    {
        // IN
        CreateMap<CreateCustomerInDto, CreateCustomerInModel>();
        CreateMap<BasicInformationInDto, BasicInformationInModel>();
        CreateMap<IdentificationInDto, IdentificationInModel>();
        CreateMap<BirthInfoInDto, BirthInfoInModel>();
        CreateMap<ContactInfoInDto, ContactInfoInModel>();
        CreateMap<AddressInfoInDto, AddressInfoInModel>();
        CreateMap<FinancialInfoInDto, FinancialInfoInModel>();
        CreateMap<EmploymentInfoInDto, EmploymentInfoInModel>();
        CreateMap<ForeignCurrencyInfoInDto, ForeignCurrencyInfoInModel>();
        CreateMap<BankingInfoInDto, BasicInformationInModel>();
        CreateMap<InterviewInfoInDto, InterviewInfoInModel>();
        CreateMap<ReferenceInModel, ReferenceInModel>();
        CreateMap<DescriptionInfoInDto, DescriptionInfoInModel>();

        // OUT
        CreateMap<CreateCustomerOutDto, CreateCustomerOutModel>();
        CreateMap<BasicInformationOutDto, BasicInformationOutModel>();
        CreateMap<IdentificationOutDto, IdentificationOutModel>();
        CreateMap<BirthInfoOutDto, BirthInfoOutModel>();
        CreateMap<ContactInfoOutDto, ContactInfoOutModel>();
        CreateMap<AddressInfoOutDto, AddressInfoOutModel>();
        CreateMap<FinancialInfoOutDto, FinancialInfoOutModel>();
        CreateMap<EmploymentInfoOutDto, EmploymentInfoOutModel>();
        CreateMap<ForeignCurrencyInfoOutDto,ForeignCurrencyInfoOutModel>();
        CreateMap<BankingInfoOutDto, BankingInfoOutModel>();
        CreateMap<InterviewInfoOutDto, InterviewInfoOutModel>();
        CreateMap<ReferenceOutDto, ReferenceOutModel>();
        CreateMap<DescriptionInfoOutDto,DescriptionInfoOutModel>();
    }
}
